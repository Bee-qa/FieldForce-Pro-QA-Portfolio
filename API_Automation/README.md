# Restful Booker API Automation

This project demonstrates API test automation using C#, NUnit and RestSharp against the public Restful Booker API.

The automation covers core booking operations including retrieving, creating, updating and deleting bookings, along with authentication and negative test scenarios.

## Tools and Technologies

- C#
- .NET
- NUnit
- RestSharp
- Visual Studio Code
- Git and GitHub

## Automated Test Coverage

The current automation suite contains 10 tests covering:

- Retrieve all bookings
- Create a new booking
- Retrieve a booking by ID
- Generate an authentication token
- Update an existing booking
- Partially update an existing booking
- Delete an existing booking
- Verify a deleted booking cannot be retrieved
- Retrieve an invalid booking ID
- Attempt a partial update without authentication

## Test Flow

The automation creates a booking and captures the generated `bookingId`.

The captured ID is reused in subsequent tests to retrieve, update and delete the same booking.

For authenticated operations, an authentication token is generated and used in the relevant API requests.

## Test Validation

NUnit assertions are used to validate API responses, including:

- HTTP status codes
- Successful booking creation
- Generated booking ID
- Authentication behaviour
- Error responses for negative scenarios

## Running the Tests

From the project directory, run:

```powershell
dotnet test
```

For more detailed test output:

```powershell
dotnet test --logger "console;verbosity=detailed"
```