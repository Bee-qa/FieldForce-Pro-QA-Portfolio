using RestSharp;
using NUnit.Framework;
using System.Text.Json;


namespace RestfulBooker.ApiTests;

public class BookingTests
{
    private int bookingId;
    private string authToken = string.Empty;
    private const string BaseUrl = "https://restful-booker.herokuapp.com";

    [Test]
    public async Task GetBookings_ReturnsSuccessfulResponse()
    {
        var client = new RestClient(BaseUrl);

        var request = new RestRequest("/booking", Method.Get);

        var response = await client.ExecuteAsync(request);

        Assert.That((int)response.StatusCode, Is.EqualTo(200));
    }

    [Test] 
    [Order(1)]
    public async Task CreateBooking_ReturnsBookingId()
    {
        var client = new RestClient(BaseUrl);

        var request = new RestRequest("/booking", Method.Post);
        request.AddHeader("Accept", "application/json");

        request.AddJsonBody(new
        {
            firstname = "Bee",
            lastname = "Tester",
            totalprice = 250,
            depositpaid = true,
            bookingdates = new
            {
                checkin = "2026-08-20",
                checkout = "2026-08-25"
            },
            additionalneeds = "Breakfast"
        });

        var response = await client.ExecuteAsync(request);
TestContext.WriteLine($"Status Code: {(int)response.StatusCode}");
TestContext.WriteLine($"Response: {response.Content}");
        Assert.That((int)response.StatusCode, Is.EqualTo(200));
        using var jsonDocument = JsonDocument.Parse(response.Content!);

bookingId = jsonDocument.RootElement
    .GetProperty("bookingid")
    .GetInt32();

TestContext.WriteLine($"Booking ID: {bookingId}");

Assert.That(bookingId, Is.GreaterThan(0));
    }

   [Test]
[Order(2)]
public async Task GetBookingById_ReturnsSuccessfulResponse()
{
    var client = new RestClient(BaseUrl);

    var request = new RestRequest($"/booking/{bookingId}", Method.Get);

    request.AddHeader("Accept", "application/json");

    var response = await client.ExecuteAsync(request);

    TestContext.WriteLine($"Booking ID: {bookingId}");
    TestContext.WriteLine($"Status Code: {(int)response.StatusCode}");
    TestContext.WriteLine($"Response: {response.Content}");

    Assert.That((int)response.StatusCode, Is.EqualTo(200));
    Assert.That(response.Content, Is.Not.Empty);
}
[Test]
[Order(3)]
public async Task CreateAuthToken_ReturnsToken()
{
    var client = new RestClient(BaseUrl);

    var request = new RestRequest("/auth", Method.Post);

    request.AddHeader("Accept", "application/json");

    request.AddJsonBody(new
    {
        username = "admin",
        password = "password123"
    });

    var response = await client.ExecuteAsync(request);

    TestContext.WriteLine($"Status Code: {(int)response.StatusCode}");
    TestContext.WriteLine($"Response: {response.Content}");

    Assert.That((int)response.StatusCode, Is.EqualTo(200));
    using var jsonDocument = JsonDocument.Parse(response.Content!);

authToken = jsonDocument.RootElement
    .GetProperty("token")
    .GetString()!;

TestContext.WriteLine($"Auth Token: {authToken}");

Assert.That(authToken, Is.Not.Empty);
}
[Test]
[Order(4)]
public async Task UpdateBooking_ReturnsSuccessfulResponse()
{
    var client = new RestClient(BaseUrl);

    var request = new RestRequest($"/booking/{bookingId}", Method.Put);

    request.AddHeader("Accept", "application/json");
    request.AddHeader("Cookie", $"token={authToken}");

    request.AddJsonBody(new
    {
        firstname = "Bee",
        lastname = "UpdatedTester",
        totalprice = 300,
        depositpaid = true,
        bookingdates = new
        {
            checkin = "2026-08-21",
            checkout = "2026-08-26"
        },
        additionalneeds = "Dinner"
    });

    var response = await client.ExecuteAsync(request);

    TestContext.WriteLine($"Status Code: {(int)response.StatusCode}");
    TestContext.WriteLine($"Response: {response.Content}");

    Assert.That((int)response.StatusCode, Is.EqualTo(200));
    Assert.That(response.Content, Does.Contain("UpdatedTester"));
}
[Test]
[Order(5)]
public async Task PartialUpdateBooking_ReturnsSuccessfulResponse()
{
    var client = new RestClient(BaseUrl);

    var request = new RestRequest($"/booking/{bookingId}", Method.Patch);

    request.AddHeader("Accept", "application/json");
    request.AddHeader("Cookie", $"token={authToken}");

    request.AddJsonBody(new
    {
        firstname = "BeeUpdated",
        additionalneeds = "Late Checkout"
    });

    var response = await client.ExecuteAsync(request);

    TestContext.WriteLine($"Status Code: {(int)response.StatusCode}");
    TestContext.WriteLine($"Response: {response.Content}");

    Assert.That((int)response.StatusCode, Is.EqualTo(200));
    Assert.That(response.Content, Does.Contain("BeeUpdated"));
    Assert.That(response.Content, Does.Contain("Late Checkout"));
}
[Test]
[Order(6)]
public async Task DeleteBooking_ReturnsSuccessfulResponse()
{
    var client = new RestClient(BaseUrl);

    var request = new RestRequest($"/booking/{bookingId}", Method.Delete);

    request.AddHeader("Cookie", $"token={authToken}");

    var response = await client.ExecuteAsync(request);

    TestContext.WriteLine($"Status Code: {(int)response.StatusCode}");
    TestContext.WriteLine($"Response: {response.Content}");

    Assert.That((int)response.StatusCode, Is.EqualTo(201));
}
[Test]
[Order(7)]
public async Task GetDeletedBooking_Returns404()
{
    var client = new RestClient(BaseUrl);
    var request = new RestRequest($"/booking/{bookingId}", Method.Get);

    request.AddHeader("Accept", "application/json");

    var response = await client.ExecuteAsync(request);

    TestContext.WriteLine($"Status Code: {(int)response.StatusCode}");
    TestContext.WriteLine($"Response: {response.Content}");

    Assert.That((int)response.StatusCode, Is.EqualTo(404));
}
[Test]
[Order(8)]
public async Task GetInvalidBookingId_Returns404()
{
    var client = new RestClient(BaseUrl);

    var request = new RestRequest("/booking/99999999", Method.Get);

    request.AddHeader("Accept", "application/json");

    var response = await client.ExecuteAsync(request);

    TestContext.WriteLine($"Status Code: {(int)response.StatusCode}");
    TestContext.WriteLine($"Response: {response.Content}");

    Assert.That((int)response.StatusCode, Is.EqualTo(404));
}
[Test]
[Order(9)]
public async Task PartialUpdateWithoutAuthentication_Returns403()
{
    var client = new RestClient(BaseUrl);

    var request = new RestRequest($"/booking/{bookingId}", Method.Patch);

    request.AddHeader("Accept", "application/json");

    request.AddJsonBody(new
    {
        firstname = "UnauthorizedUpdate"
    });

    var response = await client.ExecuteAsync(request);

    TestContext.WriteLine($"Status Code: {(int)response.StatusCode}");
    TestContext.WriteLine($"Response: {response.Content}");

    Assert.That((int)response.StatusCode, Is.EqualTo(403));
}

}

