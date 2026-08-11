# Project Overview

## 1. Project Information

| Field | Details |
|------|---------|
| Project Name | FieldForce Pro |
| Client | Australian BG Engineering Pty Ltd (ABG) |
| Industry | Engineering & Construction |
| Application Type | Web-based Workforce Management System |
| Development Methodology | Agile Scrum |
| Test Management | Azure DevOps |
| Source Control | GitHub |
| Database | Microsoft SQL Server |
| API Testing | Postman |
| Test Type | Manual Testing with SQL and API Validation |

---

## 2. Business Overview

FieldForce Pro is a workforce management application designed for engineering and construction companies to manage field operations efficiently.

The application enables office staff to manage customers, projects and jobs, while allowing supervisors to assign work to field engineers. Field engineers can record attendance, complete assigned jobs, upload supporting documents and submit timesheets. The system also supports leave management, payroll processing and operational reporting.

The application improves visibility of field activities, reduces manual paperwork and ensures accurate payroll calculations based on attendance and approved timesheets.

---

## 3. Business Goals

The primary business goals of FieldForce Pro are to:

- Digitise field workforce operations.
- Improve job scheduling and resource allocation.
- Track employee attendance using geofencing.
- Simplify leave and timesheet management.
- Improve payroll accuracy.
- Provide real-time operational reporting.
- Reduce manual administrative effort.

-----

## 4. User Roles

### 4.1 Office Staff

Office staff are responsible for maintaining administrative and operational information within the application.

Key responsibilities include:

- Create and maintain customer records.
- Create and maintain project information.
- Create jobs under relevant projects.
- Update job and customer information where permitted.
- View job progress and operational information.
- Access relevant reports based on assigned permissions.

Office staff cannot assign field engineers to jobs unless they also hold the required supervisor permissions.

---

### 4.2 Supervisor

Supervisors are responsible for coordinating field work and reviewing work completed by field engineers.

Key responsibilities include:

- Review available jobs.
- Assign field engineers to jobs.
- Reassign jobs when required.
- Monitor job status and progress.
- Review completed field work.
- Approve or return completed jobs where applicable.
- Review timesheets where required.
- Access relevant operational reports.

Only supervisors are permitted to assign field engineers to jobs.

---

### 4.3 Field Engineer

Field engineers perform work assigned to them through the application.

Key responsibilities include:

- View assigned jobs.
- View project and worksite information.
- Clock in and clock out.
- Access job-related safety and work documents.
- Record measurements and work details.
- Upload job-related photographs or documents.
- Update job progress.
- Complete assigned field activities.
- Submit timesheets.
- Submit leave requests.
- View their own attendance and leave information.

Field engineers cannot create jobs, assign jobs to other employees, or approve their own work.

---

### 4.4 Payroll Officer

Payroll officers use approved workforce information for payroll-related processing.

Key responsibilities include:

- Review approved attendance information.
- Review approved timesheets.
- Review leave information relevant to payroll.
- Identify missing or inconsistent workforce records.
- Access payroll-related reports.
- Process payroll information based on approved records.

Payroll officers should not modify operational job information unless separately authorised.

---

### 4.5 Operations Manager

Operations managers have broader visibility across the system for monitoring and operational decision-making.

Key responsibilities include:

- View customers, projects and jobs.
- Monitor workforce activity.
- Review job progress.
- View attendance and timesheet information.
- Access operational and management reports.
- Monitor outstanding work and exceptions.

Access remains subject to the permissions configured for the user's role.

------

## 5. Module Overview

FieldForce Pro consists of multiple functional modules that work together to support day-to-day engineering field operations.

---

### 5.1 Authentication Module

**Purpose**

Provides secure access to the application based on user credentials and assigned roles.

**Key Features**

- User login
- User logout
- Forgot password
- Password reset
- Session timeout
- Role-based access control

---

### 5.2 Customer Management Module

**Purpose**

Allows office staff to maintain customer information for engineering projects.

**Key Features**

- Create customer
- Update customer
- Search customer
- View customer details
- Activate/Deactivate customer

---

### 5.3 Project Management Module

**Purpose**

Maintains engineering projects for each customer.

**Key Features**

- Create project
- Edit project
- Assign customer
- Track project status
- Archive completed projects

---

### 5.4 Job Management Module

**Purpose**

Allows office staff to create work orders and supervisors to assign field engineers.

**Key Features**

- Create job
- Edit job
- Assign engineer
- Update job status
- Track progress
- Close completed jobs

---

### 5.5 Attendance Management Module

**Purpose**

Records employee attendance at worksites using geofencing.

**Key Features**

- Clock In
- Clock Out
- GPS validation
- Geofence validation
- Attendance history

---

### 5.6 Timesheet Management Module

**Purpose**

Records working hours completed by field engineers.

**Key Features**

- Create timesheet
- Edit draft timesheet
- Submit timesheet
- Supervisor review
- Timesheet approval

---

### 5.7 Leave Management Module

**Purpose**

Allows employees to request leave while enabling supervisors to manage approvals.

**Key Features**

- Apply leave
- View leave balance
- Approve leave
- Reject leave
- Leave history

---

### 5.8 Payroll Module

**Purpose**

Supports payroll preparation using approved attendance and timesheet information.

**Key Features**

- Review attendance
- Review approved timesheets
- Calculate payable hours
- Payroll reports

---

### 5.9 Reports Module

**Purpose**

Provides operational and management reports.

**Key Features**

- Attendance reports
- Job reports
- Payroll reports
- Employee reports
- Project progress reports

---

### 5.10 Notification Module

**Purpose**

Keeps users informed about important application events.

**Key Features**

- Job assignment notifications
- Leave approval notifications
- Timesheet reminders
- Job completion notifications

---

### 5.11 Document Management Module

**Purpose**

Stores documents and images related to engineering work.

**Key Features**

- Upload site photos
- Upload drawings
- Upload safety documents
- Download attachments
- View document history

--------


## 6. Business Workflows

The following business workflows describe the end-to-end processes supported by FieldForce Pro.


Customer
     ↓
Project
     ↓
Job
     ↓
Assign Engineer
     ↓
Clock In
     ↓
Complete Work
     ↓
Supervisor Approval
     ↓
Payroll
     ↓
Reports

---

### Workflow 1 – Customer to Job Assignment

**Objective**

Create a customer, create a project, create a job and assign a field engineer.

```
Office Staff
      │
      ▼
Create Customer
      │
      ▼
Create Project
      │
      ▼
Create Job
      │
      ▼
Supervisor Reviews Job
      │
      ▼
Assign Field Engineer
      │
      ▼
Job Available in Engineer Dashboard
```

**Business Rules**

- Every project must belong to a customer.
- Every job must belong to a project.
- A job cannot be assigned until it has been created.
- Only supervisors can assign field engineers.
- A field engineer can only view jobs assigned to them.

--------

---

### Workflow 2 – Attendance Recording

**Objective**

Allow field engineers to record attendance only at authorised worksites.

```
Engineer Arrives at Worksite
          │
          ▼
GPS Location Captured
          │
          ▼
Within Geofence?
     │           │
    Yes          No
     │           │
     ▼           ▼
Clock In     Display Error
```

The same process applies for Clock Out.

**Business Rules**

- Users must be inside the configured geofence.
- GPS must be enabled.
- Clock In is allowed only once per workday.
- Clock Out is allowed only after Clock In.
- Attendance time is recorded automatically.

---------

---

### Workflow 3 – Field Job Completion

**Objective**

Allow engineers to complete assigned work and submit supporting information.

```
Engineer Opens Assigned Job
          │
          ▼
Performs Work
          │
          ▼
Uploads Photos
          │
          ▼
Records Measurements
          │
          ▼
Completes Safety Checklist
          │
          ▼
Submits Job
          │
          ▼
Supervisor Reviews
          │
     ┌────┴────┐
     ▼         ▼
Approve     Return for Rework
```

**Business Rules**

- Engineers cannot complete jobs assigned to another user.
- At least one site photo must be uploaded before job completion.
- Mandatory measurements must be entered.
- Required safety checklist items must be completed.
- A supervisor must review completed jobs.

---------

---

### Workflow 4 – Timesheet and Payroll

**Objective**

Generate payroll using approved attendance and timesheets.

```
Clock In / Clock Out
          │
          ▼
Attendance Recorded
          │
          ▼
Engineer Submits Timesheet
          │
          ▼
Supervisor Approval
          │
          ▼
Payroll Officer Reviews
          │
          ▼
Payroll Generated
```

**Business Rules**

- Attendance must exist before a timesheet can be submitted.
- Timesheets require supervisor approval.
- Payroll uses approved attendance and approved timesheets.
- Unapproved timesheets are excluded from payroll.

-----

---

### Workflow 5 – Leave Request

**Objective**

Allow employees to request leave while enabling supervisors to approve or reject requests.

```
Employee Applies Leave
          │
          ▼
Supervisor Reviews
     ┌────┴────┐
     ▼         ▼
Approve     Reject
     │         │
     ▼         ▼
Leave Balance Updated
```

**Business Rules**

- Employees cannot approve their own leave.
- Leave balance must be validated before approval.
- Approved leave updates attendance records.
- Payroll reflects approved leave.

------------

## 7. Business Rules

The following business rules define the expected behaviour of the FieldForce Pro application. These rules are referenced throughout the requirements, test scenarios, test cases and defect reports.

| Rule ID | Business Rule |
|---------|---------------|
| BR-001 | Every customer must have a unique Customer ID. |
| BR-002 | A customer may have multiple projects. |
| BR-003 | Every project must belong to exactly one customer. |
| BR-004 | A project may contain multiple jobs. |
| BR-005 | Every job must belong to one project. |
| BR-006 | A job cannot be assigned until it has been created. |
| BR-007 | Only supervisors can assign field engineers to jobs. |
| BR-008 | A field engineer can only access jobs assigned to them. |
| BR-009 | A completed job cannot be edited by a field engineer. |
| BR-010 | A supervisor may return a completed job for rework before approval. |
| BR-011 | Clock In is permitted only within the configured geofence. |
| BR-012 | GPS services must be enabled before attendance can be recorded. |
| BR-013 | A user cannot Clock Out before completing a successful Clock In. |
| BR-014 | Attendance time is automatically captured by the system. |
| BR-015 | A timesheet cannot be submitted without recorded attendance. |
| BR-016 | Timesheets require supervisor approval before payroll processing. |
| BR-017 | Payroll calculations use only approved attendance and approved timesheets. |
| BR-018 | Employees may submit leave requests only when sufficient leave balance is available (where applicable). |
| BR-019 | Employees cannot approve or reject their own leave requests. |
| BR-020 | At least one site photograph is mandatory before completing a field job. |
| BR-021 | Mandatory measurements must be recorded before job completion. |
| BR-022 | Required safety checklist items must be completed before a job can be submitted. |
| BR-023 | Uploaded files must comply with the supported file types and maximum file size configured by the application. |
| BR-024 | Every significant system action must be recorded in the audit history. |

-----------


