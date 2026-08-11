# User Stories


## US-001 – Create Customer

### User Story

As an Office Staff member,
I want to create a new customer,
so that projects can be managed under that customer.

Epic: Authentication

Sprint: Sprint 1

Priority: High

Story Points: 5

Status: Done

Business Value: Allows authorised users to securely access the application.

### Acceptance Criteria

- Customer Name is mandatory.
- Customer Code must be unique.
- Contact details can be saved.
- Customer is available in the Customer List after saving.
- Success message is displayed after creation.

---------------------------------------------------------------

## US-002 – Create Project

### User Story

As an Office Staff member,
I want to create a project for an existing customer,
so that engineering work can be organised.

**Priority  -  High**

### Acceptance Criteria

- A customer must be selected.
- Project Name is mandatory.
- Project is linked to the selected customer.
- Project appears in the Project List.

-----------------------------------------------------------------

# US-003 – Create Project

### User Story

As an Office Staff member,
I want to create a project,
so that engineering work can be organised.

**Priority  -  High**

### Acceptance Criteria

- Customer must be selected.
- Project Name is mandatory.
- Project is linked to the selected customer.
- Project is displayed in the Project List.
- Success message is displayed after saving.

---------------------------------------------------------------

# US-004 – Create Job

### User Story

As an Office Staff member,
I want to create a job,
so that work can be assigned to field engineers.

**Priority  -  High**

### Acceptance Criteria

- Project must be selected.
- Job Title is mandatory.
- Required job details are captured.
- Job is created successfully.
- Job appears in the Job List.

----------------------------------------------------------------

# US-005 – Assign Job

### User Story

As a Supervisor,
I want to assign a field engineer to a job,
so that field work can begin.

**Priority  -  High**

### Acceptance Criteria

- Only supervisors can assign jobs.
- Only active field engineers are available for selection.
- Assigned engineer receives the job.
- Assignment is saved successfully.
- Assignment history is recorded.

---------------------------------------------------------------

# US-006 – Record Attendance

### User Story

As a Field Engineer,
I want to clock in and clock out,
so that my attendance is recorded accurately.

**Priority  -  High**

### Acceptance Criteria

- User must be inside the configured geofence.
- GPS must be enabled.
- Clock In records date and time.
- Clock Out is allowed only after Clock In.
- Attendance history is updated.

-----------------------------------------------------------------

# US-007 – Complete Field Job

### User Story

As a Field Engineer,
I want to complete my assigned job,
so that the supervisor can review my work.

**Priority  -  High**

### Acceptance Criteria

- Engineer can access assigned jobs only.
- Job progress can be updated.
- Site photos can be uploaded.
- Required job information is completed.
- Job status changes to Completed after submission.

-----------------------------------------------------------------

# US-008 – Submit Timesheet

### User Story

As a Field Engineer,
I want to submit my timesheet,
so that my working hours can be reviewed.

**Priority  -  Medium**

### Acceptance Criteria

- Timesheet records working hours.
- Attendance exists for the selected date.
- Timesheet can be submitted.
- Submitted timesheet cannot be edited unless returned.
- Supervisor receives the submission.

-----------------------------------------------------------------

# US-009 – Approve Timesheet

### User Story

As a Supervisor,
I want to approve submitted timesheets,
so that payroll can be processed correctly.

**Priority  -  Medium**

### Acceptance Criteria

- Supervisor can view submitted timesheets.
- Supervisor can approve a timesheet.
- Supervisor can reject a timesheet.
- Approved timesheets become available for payroll.
- Status is updated after approval.

-----------------------------------------------------------------

# US-010 – Apply Leave

### User Story

As a Field Engineer,
I want to apply for leave,
so that my absence can be approved by my supervisor.

**Priority  -  Medium**

### Acceptance Criteria

- Leave Type is mandatory.
- Start Date is mandatory.
- End Date is mandatory.
- Leave request is submitted successfully.
- Leave request status is displayed.

-----------------------------------------------------------------

# US-011 – Approve Leave

### User Story

As a Supervisor,
I want to approve or reject leave requests,
so that employee leave is managed appropriately.

**Priority  -  Medium**

### Acceptance Criteria

- Supervisor can view pending leave requests.
- Supervisor can approve leave.
- Supervisor can reject leave.
- Employee is notified of the decision.
- Leave status is updated.

----------------------------------------------------------------

# US-012 – View Reports

### User Story

As an authorised user,
I want to view operational reports,
so that I can monitor project and workforce activities.

**Priority  -  Low**

### Acceptance Criteria

- Authorised users can access reports.
- Reports display accurate information.
- Reports can be filtered.
- Reports can be searched.
- Users cannot access reports outside their permissions.

-----------------------------------------------------------------


