# Defect Report

## Purpose

This document records defects identified during the execution of test cases for the FieldForce Pro application. Each defect includes severity, priority, reproduction steps, expected and actual results, and current status.

## Defect Summary

| Defect ID | Related Test Case | Defect Title | Module | Severity | Priority | Status |

| BUG-001 - TC-010 | Inactive user able to login | Authentication | High | High | Closed |
| BUG-002 - TC-045 | Field engineer able to clock in outside permitted geofence | Attendance | Critical | High | Closed |
| BUG-003 - TC-063 | Timesheet can be submitted for date without attendance | Timesheet | High | High | Open |
| BUG-004 - TC-069 | Non-supervisor user able to approve submitted timesheet | Timesheet Approval | Critical | High | Closed |
| BUG-005 - TC-081 | Employee able to approve own leave request | Leave Approval | High | High | Open |

----------------------------------------------------------------

## BUG-001 – Inactive user able to login

Module: Authentication  
Severity: High  
Priority: High  
Status: Closed  

### Preconditions
- User account exists in the system.
- User account status is set to inactive.

### Steps to Reproduce
1. Navigate to the FieldForce Pro login page.
2. Enter valid credentials belonging to an inactive user.
3. Click the Login button.

### Expected Result
The inactive user should not be allowed to login and an appropriate error message should be displayed.

### Actual Result
The inactive user is successfully authenticated and redirected to the application dashboard.

### Retest Result
Defect was retested after the fix. The inactive user is now prevented from logging in and the appropriate error message is displayed.

---------------------------------------------------------------

## BUG-002 – Field engineer able to clock in outside permitted geofence

Module: Attendance  
Severity: Critical  
Priority: High  
Status: Closed  

### Preconditions
- Field engineer is logged into the application.
- Field engineer is assigned to an active job.
- User device location services are enabled.
- User is located outside the permitted job-site geofence.

### Steps to Reproduce
1. Login as a field engineer.
2. Navigate to the assigned job.
3. Remain outside the permitted geofence.
4. Select Clock In.

### Expected Result
The system should prevent the field engineer from clocking in outside the permitted geofence and display an appropriate validation message.

### Actual Result
The system allows the field engineer to clock in successfully while outside the permitted geofence.

### Retest Result
Defect was retested after the fix. Clock-in is now blocked when the field engineer is outside the permitted geofence.

----------------------------------------------------------------

## BUG-003 – Job completion submitted without mandatory information

Module: Job Completion  
Severity: High  
Priority: High  
Status: Open  

### Preconditions
- Field engineer is logged into the application.
- An active job is assigned to the field engineer.
- The assigned job is ready for completion.

### Steps to Reproduce
1. Login as a field engineer.
2. Open the assigned job.
3. Navigate to the Job Completion section.
4. Leave mandatory completion information blank.
5. Select Submit.

### Expected Result
The system should prevent submission and display validation messages for all mandatory fields.

### Actual Result
The job completion is submitted successfully without the mandatory information.

---------------------------------------------------------------

## BUG-004 – Incorrect total hours calculated in timesheet

Module: Timesheet  
Severity: High  
Priority: High  
Status: Closed  

### Preconditions
- Field engineer is logged into the application.
- Attendance records exist for the selected workday.
- Valid clock-in and clock-out times are recorded.

### Steps to Reproduce
1. Login as a field engineer.
2. Navigate to Timesheet.
3. Open the timesheet for the relevant workday.
4. Review the recorded start and finish times.
5. Compare the displayed total hours with the actual hours worked.

### Expected Result
The system should calculate the total worked hours correctly based on the recorded attendance.

### Actual Result
The total hours displayed in the timesheet do not match the actual hours calculated from the attendance records.

### Retest Result
Defect was retested after the fix. The system now calculates and displays the correct total worked hours.

---------------------------------------------------------------

## BUG-005 – Leave balance not updated after approved leave

Module: Leave  
Severity: Medium  
Priority: Medium  
Status: Open  

### Preconditions
- Employee is logged into the application.
- Employee has sufficient available leave balance.
- A leave request has been submitted.

### Steps to Reproduce
1. Login as a supervisor.
2. Navigate to pending leave requests.
3. Open the employee's leave request.
4. Approve the leave request.
5. Login as the employee.
6. Navigate to the Leave section.
7. Review the available leave balance.

### Expected Result
The employee's available leave balance should be updated after the leave request is approved.

### Actual Result
The leave request shows as approved, but the employee's available leave balance remains unchanged.

----------------------------------------------------------------