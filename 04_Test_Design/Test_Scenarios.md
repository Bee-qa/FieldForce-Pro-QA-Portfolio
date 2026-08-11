# Test Scenarios

---

## Authentication

Related User Story:
**US-001 – User Login**

| Scenario ID | Test Scenario | Priority |

| TS-001 | Verify user can log in with valid credentials. | High |
| TS-002 | Verify login fails with invalid credentials. | High |
| TS-003 | Verify mandatory validation for username and password. | High |
| TS-004 | Verify inactive users cannot log in. | High |
| TS-005 | Verify user can successfully log out. | Medium |

-----------------------------------------------------------------

## Customer Management

Related User Story:
**US-002 – Create Customer**

| Scenario ID | Test Scenario | Priority |

| TS-006 | Verify office staff can create a customer with valid details. | High |
| TS-007 | Verify mandatory field validation while creating a customer. | High |
| TS-008 | Verify duplicate customer code is not allowed. | High |

-----------------------------------------------------------------

## Project Management

Related User Story:
**US-003 – Create Project**

| Scenario ID | Test Scenario | Priority |

| TS-009 | Verify office staff can create a project for an existing customer. | High |
| TS-010 | Verify a customer must be selected before creating a project. | High |
| TS-011 | Verify project details can be updated successfully. | Medium |

-----------------------------------------------------------------

## Job Management

Related User Story:
**US-004 – Create Job**

| Scenario ID | Test Scenario | Priority |

| TS-012 | Verify office staff can create a new job. | High |
| TS-013 | Verify mandatory field validation while creating a job. | High |
| TS-014 | Verify job details can be edited before assignment. | Medium |

-----------------------------------------------------------------

## Job Assignment

Related User Story:
**US-005 – Assign Job**

| Scenario ID | Test Scenario | Priority |

| TS-015 | Verify supervisor can assign a field engineer to a job. | High |
| TS-016 | Verify only supervisors can assign jobs. | High |
| TS-017 | Verify assigned engineer can view the assigned job. | High |

-----------------------------------------------------------------

## Attendance Management

Related User Story:
**US-006 – Record Attendance**

| Scenario ID | Test Scenario | Priority |

| TS-018 | Verify field engineer can clock in within the permitted geofence. | High |
| TS-019 | Verify clock in is prevented outside the permitted geofence. | High |
| TS-020 | Verify GPS must be enabled before clocking in. | High |
| TS-021 | Verify field engineer can clock out after successful clock in. | High |

-----------------------------------------------------------------

## Job Completion

Related User Story:
**US-007 – Complete Field Job**

| Scenario ID | Test Scenario | Priority |

| TS-022 | Verify engineer can update job progress. | High |
| TS-023 | Verify required information must be completed before job submission. | High |
| TS-024 | Verify completed job is submitted successfully. | High |

-----------------------------------------------------------------

## Timesheet Management

Related User Story:
**US-008 – Submit Timesheet**

| Scenario ID | Test Scenario | Priority |

| TS-025 | Verify field engineer can create a timesheet. | High |
| TS-026 | Verify attendance is required before submitting a timesheet. | High |
| TS-027 | Verify completed timesheet can be submitted successfully. | High |

-----------------------------------------------------------------

## Timesheet Approval

Related User Story:
**US-009 – Approve Timesheet**

| Scenario ID | Test Scenario | Priority |

| TS-028 | Verify supervisor can approve a submitted timesheet. | High |
| TS-029 | Verify supervisor can reject a submitted timesheet. | High |
| TS-030 | Verify approved timesheet is available for payroll processing. | Medium |

-----------------------------------------------------------------

## Leave Management

Related User Story:
**US-010 – Apply Leave**

| Scenario ID | Test Scenario | Priority |

| TS-031 | Verify employee can submit a leave request. | High |
| TS-032 | Verify mandatory validation while applying for leave. | High |

-----------------------------------------------------------------

## Leave Approval

Related User Story:
**US-011 – Approve Leave**

| Scenario ID | Test Scenario | Priority |

| TS-033 | Verify supervisor can approve or reject leave requests. | High |
| TS-034 | Verify leave status is updated after approval or rejection. | Medium |

-----------------------------------------------------------------

## Reports

Related User Story:
**US-012 – View Reports**

| Scenario ID | Test Scenario | Priority |

| TS-035 | Verify authorised users can access reports. | High |
| TS-036 | Verify report data is displayed accurately. | High |

-----------------------------------------------------------------