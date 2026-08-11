# Test Plan

## 1. Document Information

| Field | Details |
|------|---------|
| Project | FieldForce Pro |
| Client | Australian BG Engineering Pty Ltd (ABG) |
| Document | Test Plan |
| Version | 1.0 |
| Author | Bhargavi Gorisetty |
| Role | Test Analyst |
| Status | Draft |
| Date | 11-Aug-2026 |

----------

## 2. Introduction

This Test Plan defines the testing approach for the FieldForce Pro application developed for Australian BG Engineering Pty Ltd (ABG).

The objective of testing is to verify that the application satisfies the documented business and functional requirements while delivering a reliable and user-friendly experience for office staff, supervisors, field engineers, payroll officers and operations managers.

This document describes the scope of testing, test approach, environments, test deliverables, entry and exit criteria, risks, and responsibilities that will be followed throughout the testing lifecycle.

-----------

## 3. Test Objectives

The primary objectives of testing for the FieldForce Pro application are to:

- Verify that all business and functional requirements are implemented correctly.
- Validate end-to-end business workflows across office staff, supervisors, field engineers, payroll officers and operations managers.
- Ensure role-based access control is enforced and users can perform only the actions permitted for their roles.
- Verify that job creation, assignment, execution, approval and completion processes function as expected.
- Validate attendance, timesheet and leave management workflows.
- Verify payroll-related information is generated accurately from attendance and timesheet data.
- Ensure reports and dashboards display accurate and consistent information.
- Identify and report defects before the application is released to production.
- Reduce the risk of production issues by performing functional, integration, regression and exploratory testing.

--------------

## 4. Scope

The scope of testing includes validating the functional and business workflows of the FieldForce Pro application across all supported user roles. Testing will ensure that each module functions independently and integrates correctly with related modules.

### 4.1 In Scope

The following features and business processes are included in this testing cycle:

#### User Authentication
- User login
- User logout
- Password validation
- Session timeout
- Role-based access control

#### User Management
- Create users
- Update user details
- Activate or deactivate users
- Assign user roles
- Permission validation

#### Customer Management
- Create customer records
- Edit customer information
- Search customers
- View customer history

#### Job Management
- Create jobs
- Edit jobs
- Assign jobs to field engineers
- Update job status
- Track job progress
- Complete jobs

#### Attendance Management
- Geofenced clock in
- Geofenced clock out
- Attendance history
- Attendance validation

#### Leave Management
- Apply leave
- Approve leave
- Reject leave
- Leave balance validation

#### Timesheet Management
- Create timesheets
- Edit submitted timesheets
- Approve timesheets
- Reject timesheets
- Validate working hours

#### Payroll
- Attendance validation
- Timesheet validation
- Payroll calculation verification
- Payroll report generation

#### Reports
- Attendance reports
- Payroll reports
- Job reports
- Employee reports

#### Notifications
- Job assignment notifications
- Leave approval notifications
- Status update notifications

#### File Uploads
- Upload site photos
- Upload documents
- Validate supported file types
- Validate maximum file size

#### Integration Testing
- Job Management with Attendance
- Attendance with Payroll
- Leave with Payroll
- Job Completion with Reports
- User Roles across all modules

### 4.2 Out of Scope

The following items are not included in this phase of testing:

- Performance testing
- Load testing
- Stress testing
- Security penetration testing
- Infrastructure testing
- Network configuration testing
- Third-party payment gateway testing
- Disaster recovery testing
- Production deployment validation

----------------

## 5. Test Strategy

Testing will follow a risk-based approach, focusing on validating critical business workflows before lower-priority functionality. The QA team will begin testing once the application build is deployed to the test environment and the required documentation is approved.

Testing activities will be performed throughout the Software Development Life Cycle (SDLC) within an Agile Scrum environment. Test scenarios and test cases will be derived from the approved Business Requirements Document (BRD) and Functional Requirements Specification (FRS).

The overall testing approach includes:

### Requirement Analysis
- Review business and functional requirements.
- Identify testable requirements.
- Clarify ambiguities with stakeholders before test design.

### Test Design
- Prepare test scenarios covering all business processes.
- Design detailed test cases for positive, negative and boundary conditions.
- Identify required test data.

### Test Execution
- Execute planned test cases.
- Record execution results.
- Capture evidence where required.
- Report any deviations from expected behaviour.

### Defect Management
- Log defects in Azure DevOps.
- Assign severity and priority.
- Retest resolved defects.
- Perform regression testing after fixes.

### Regression Testing
Regression testing will be performed after defect fixes and before every release to ensure that existing functionality continues to work without introducing new defects.

### Exploratory Testing
Exploratory testing will be conducted to identify usability issues, unexpected behaviour and defects that may not be covered by predefined test cases.

### Integration Testing
Testing will verify that related modules exchange data correctly and support complete business workflows, including:

- Job Assignment → Attendance
- Attendance → Timesheets
- Timesheets → Payroll
- Job Completion → Reports
- Leave Requests → Payroll

### SQL Validation
SQL queries will be executed where necessary to validate database records and confirm data consistency between the application and the database.

### API Validation
Where backend services are exposed through REST APIs, Postman will be used to validate request and response data, HTTP status codes and business rules.

-----------

## 6. Test Types

The following testing types will be performed during the project:

| Test Type | Purpose |
|-----------|---------|
| Smoke Testing | Verify the stability of a new build before detailed testing begins. |
| Functional Testing | Validate that each feature works according to the documented requirements. |
| Integration Testing | Verify data flow and interactions between related modules. |
| Regression Testing | Ensure existing functionality remains unaffected after changes or defect fixes. |
| Exploratory Testing | Discover defects through unscripted testing based on tester knowledge and experience. |
| User Acceptance Testing (Support) | Support business users during UAT by resolving defects and clarifying issues. |
| Database Validation | Validate backend data using SQL queries. |
| API Testing | Validate REST API requests and responses using Postman. |


-------------

## 7. Test Environment

Testing will be conducted in a dedicated QA environment that closely mirrors the production environment to ensure accurate validation of application functionality.

| Component | Details |
|-----------|---------|
| Application | FieldForce Pro |
| Client | Australian BG Engineering Pty Ltd (ABG) |
| Environment | QA / Test |
| Operating System | Windows 11 |
| Browser | Google Chrome (Latest Stable Version) |
| Mobile Devices | Android (where applicable) |
| Database | Microsoft SQL Server |
| API Testing Tool | Postman |
| Test Management | Azure DevOps |
| Source Control | GitHub |
| IDE | Visual Studio Code |
| Documentation | Markdown (.md), Microsoft Excel |

------------

## 8. Test Data

The following test data will be prepared before execution:

### User Accounts
- Office Staff
- Supervisor
- Field Engineer
- Payroll Officer
- Operations Manager

### Customer Data
- Existing customers
- New customer records
- Inactive customers

### Job Data
- New jobs
- Assigned jobs
- In Progress jobs
- Completed jobs
- Cancelled jobs

### Attendance Data
- Valid geofenced locations
- Invalid locations
- Early clock-in
- Late clock-in
- Missing clock-out

### Leave Data
- Annual Leave
- Sick Leave
- Approved Leave
- Rejected Leave

### Payroll Data
- Standard working hours
- Overtime hours
- Public holidays
- Leave deductions

### File Upload Data
- Valid image files
- Invalid file types
- Large file sizes

--------------

## 9. Roles and Responsibilities

| Role | Responsibilities |
|------|------------------|
| Business Analyst | Prepare and maintain business and functional requirements. |
| Product Owner | Define business priorities and approve completed functionality. |
| Developers | Develop features, resolve defects and support testing activities. |
| Test Analyst | Review requirements, design test scenarios and test cases, execute testing, report defects and perform regression testing. |
| QA Lead | Review testing deliverables, monitor testing progress and provide quality oversight. |
| Business Users | Perform User Acceptance Testing (UAT) and validate business workflows. |

--------------

## 10. Entry Criteria

Testing can commence once the following conditions have been met:

- Business Requirements Document (BRD) has been approved.
- Functional Requirements Specification (FRS) has been reviewed and approved.
- Test Plan has been reviewed and approved.
- Test environment is available and accessible.
- Application build has been successfully deployed to the QA environment.
- Test data has been prepared.
- Required user accounts and permissions have been configured.
- Any critical blockers preventing testing have been resolved.

------------

## 11. Exit Criteria

Testing will be considered complete when:

- All planned test cases have been executed.
- All Critical and High severity defects have been resolved and successfully retested.
- Medium and Low severity defects have been reviewed and accepted by stakeholders or scheduled for future releases.
- Regression testing has been completed successfully.
- Test execution results have been documented.
- Test Summary Report has been prepared and shared with stakeholders.
- Product Owner and business stakeholders have approved the release for User Acceptance Testing (UAT) or Production deployment.

---------------

## 12. Defect Management

All defects identified during testing will be logged and tracked using Azure DevOps.

Each defect will include:

- Unique Defect ID
- Summary
- Description
- Module
- Steps to Reproduce
- Expected Result
- Actual Result
- Severity
- Priority
- Environment
- Build Version
- Supporting Evidence (Screenshots or Videos)
- Reporter
- Assignee
- Current Status

Defects will follow the standard defect lifecycle:

New → Assigned → In Progress → Fixed → Retest → Closed

If a reported issue cannot be reproduced or is determined not to be a defect, it may be marked as:

- Rejected
- Duplicate
- Deferred
- Cannot Reproduce

-------------

## 13. Risks and Mitigation

| Risk | Impact | Mitigation |
|------|--------|------------|
| Incomplete requirements | Incorrect test coverage | Clarify requirements with the Business Analyst before designing test cases. |
| Delayed application builds | Testing schedule delays | Re-prioritise test execution and perform smoke testing immediately after deployment. |
| Unstable QA environment | Blocked testing activities | Coordinate with the development team to resolve environment issues promptly. |
| Limited test data | Reduced validation coverage | Prepare comprehensive positive, negative and boundary test data before execution. |
| High number of defects | Release delays | Prioritise critical business workflows and perform regression testing after fixes. |


------------

## 14. Test Deliverables

The following deliverables will be produced during the testing lifecycle:

- Test Plan
- Test Scenarios
- Test Cases
- Test Data
- Defect Log
- Test Execution Report
- Requirement Traceability Matrix (RTM)
- API Test Cases
- SQL Validation Scripts
- Test Summary Report

-----------------

## 15. Assumptions and Dependencies

### Assumptions

- Requirements are complete and approved before testing begins.
- The QA environment reflects the production environment.
- Required user roles and permissions are available.
- Stakeholders are available to clarify requirements when needed.

### Dependencies

- Timely delivery of application builds by the development team.
- Availability of test environments.
- Availability of test data.
- Resolution of critical defects before regression testing.

---------------

