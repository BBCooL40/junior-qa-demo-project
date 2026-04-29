# Junior QA Demo Project

[![.NET NUnit Tests](https://github.com/BBCooL40/junior-qa-demo-project/actions/workflows/dotnet-tests.yml/badge.svg)](https://github.com/BBCooL40/junior-qa-demo-project/actions/workflows/dotnet-tests.yml)

This is a practical QA portfolio case study created to demonstrate my testing approach for a junior QA / future SDET role.

The project focuses on a simple web application concept with common user flows such as registration, login, logout, and basic item management. The goal is to show structured test thinking, risk-based prioritization, clear documentation, API testing awareness, and basic automation readiness.

---

## Project Purpose

The purpose of this project is to demonstrate how I approach quality assurance work:

- Understanding requirements
- Identifying risks
- Designing structured test cases
- Covering positive, negative, and edge case scenarios
- Writing clear bug reports
- Planning smoke and regression testing
- Thinking about API behavior and validation
- Converting selected manual test scenarios into automated tests at the appropriate test level

This project is intentionally small and focused. It is not meant to represent a large production framework, but to show practical QA thinking, documentation quality, and first automation steps.

---

## Tested Application Concept

The tested application is a demo web application with the following functionality:

- User registration
- User login
- User logout
- Protected dashboard
- Item creation
- Item editing
- Item deletion
- Item list view
- Basic API behavior

---

## Project Structure

| File / Folder | Purpose |
|---|---|
| `test-plan.md` | Defines the testing scope, objective, risks, entry criteria, exit criteria, and deliverables |
| `test-cases.md` | Contains structured test cases for registration, login, logout, and item management |
| `bug-reports.md` | Contains sample bug reports demonstrating defect documentation structure |
| `smoke-checklist.md` | Contains high-priority smoke test scenarios |
| `regression-checklist.md` | Contains regression scenarios for authentication, item management, UI validation, and API behavior |
| `api-testing-notes.md` | Describes API testing approach, endpoints, status codes, negative testing, and Postman collection planning |
| `test-summary-report.md` | Contains a sample test execution summary and release recommendation |
| `automation/JuniorQaDemo.Tests` | Contains C# / NUnit unit tests for selected validation scenarios |
| `postman/` | Contains Postman API testing collection, environment, and notes for ReqRes API scenarios |
| `.github/workflows/dotnet-tests.yml` | GitHub Actions workflow that runs the NUnit tests automatically |

---

## Testing Types Covered

- Functional testing
- Positive testing
- Negative testing
- Boundary value testing
- Smoke testing
- Regression testing
- Exploratory testing
- API testing basics
- Unit test automation with C# and NUnit
- CI test execution with GitHub Actions

---

## Tools and Technologies

- Manual testing
- Test case design
- Bug reporting
- Markdown documentation
- Git and GitHub
- GitHub Actions
- Postman
- C#
- NUnit
- .NET
- Visual Studio / VS Code

---

## Key QA Focus Areas

### 1. Risk-Based Thinking

The project prioritizes critical business flows first:

- Registration
- Login
- Session handling
- CRUD operations
- Data persistence
- Error handling

### 2. Clear Test Documentation

The test cases and checklists are written in a structured way so they can be understood by QA engineers, developers, product owners, and other team members.

### 3. API Testing Awareness

The API testing notes and Postman collection include:

- Endpoint examples
- Status code expectations
- Positive and negative API scenarios
- Authentication and authorization checks
- Response body validation
- Environment variables
- Collection-level API key authorization

### 4. Automation at the Appropriate Test Level

Not every manual test case should become a unit test.

Some scenarios are better suited for UI, API, integration, or end-to-end testing. In this project, the first automation step focuses on validation logic because it is stable, isolated, and appropriate for unit testing.

Examples of automated validation areas:

- Registration input validation
- Login input validation
- Item title validation
- Item description validation

### 5. Continuous Integration Mindset

The project includes a basic CI pipeline with GitHub Actions. The goal is to demonstrate that automated tests should be easy to run locally and automatically in a shared repository.

---

## Automation

The project includes a small C# / NUnit unit test project under the `automation` folder.

The automation part currently focuses on validation logic for:

- Registration input validation
- Login input validation
- Item title validation
- Item description validation

These tests demonstrate how selected manual test scenarios can be converted into automated unit tests at the appropriate test level.

Current automated test result:

- Total tests: 14
- Passed: 14
- Failed: 0

To run the tests locally:

```bash
cd automation/JuniorQaDemo.Tests
dotnet test
```

---

## Continuous Integration

The project includes a GitHub Actions CI workflow that runs the C# / NUnit automated tests on every push and pull request to the `main` branch.

The workflow performs the following steps:

- Checks out the repository
- Sets up .NET
- Restores dependencies
- Builds the NUnit test project
- Runs the automated tests

Current CI status is displayed with the badge at the top of this README.

---

## Postman API Testing

The project includes a Postman collection and environment under the `postman` folder.

The collection covers:

### Users API

- Get users list
- Get single user
- Get user not found
- Create user
- Update user
- Delete user

### Authentication API

- Login successful
- Login unsuccessful - missing password
- Register successful
- Register unsuccessful - missing password

The collection uses an environment variable for the API key. The real API key is not included in this repository.

Before running the collection, replace:

```text
YOUR_API_KEY_HERE
```

with a valid ReqRes API key in your local Postman environment.

---

## Example Interview Explanation

If asked about this project in an interview, I would explain it like this:

> This is a small QA portfolio case study where I demonstrate how I approach testing a web application. I started with a test plan, then created structured test cases for core user flows such as registration, login, logout, and item management. I also prepared sample bug reports, smoke and regression checklists, API testing notes, and a test summary report.
>
> After that, I added a small C# / NUnit automation project for selected validation scenarios. I did not try to automate every manual test case as a unit test, because different scenarios belong to different test levels. For example, validation logic is suitable for unit testing, while login flow, logout behavior, API status codes, and page refresh behavior are better suited for API, integration, or UI automation.
>
> I also added a Postman collection for API testing using ReqRes demo endpoints. It covers positive and negative API scenarios, response body validation, status code checks, environment variables, and collection-level authorization.
>
> Finally, I added a GitHub Actions CI workflow so the NUnit tests run automatically on every push and pull request to the main branch.
>
> The goal of this project is to show structured QA thinking, attention to risk, clear documentation, API testing awareness, automation fundamentals, and basic CI understanding.

---

## Future Improvements

Planned future improvements:

- Add real demo web application or publicly available test application
- Add Newman CLI execution for the Postman collection
- Add API test execution report
- Add UI automation examples with Playwright or Selenium
- Add screenshots or test execution evidence
- Add simple test execution report from automated tests

---

## Author

Anton Tzonev

Junior QA / Future SDET candidate focused on structured testing, C# fundamentals, API testing, automation foundations, and continuous improvement.