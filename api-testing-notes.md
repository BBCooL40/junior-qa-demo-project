# API Testing Notes

This document describes the API testing approach for a simple web application with authentication and item management functionality.

The purpose is to demonstrate understanding of API testing basics, including endpoints, request/response validation, status codes, negative testing, and future automation readiness.

---

## 1. API Testing Objective

The objective of API testing is to verify that the backend correctly handles requests, returns expected responses, validates input data, and communicates errors clearly.

API testing helps identify issues that may not be visible through the UI, such as:

- Incorrect status codes
- Missing validation
- Invalid response structure
- Authentication problems
- Data persistence issues
- Incorrect error handling

---

## 2. Example API Endpoints

The following endpoints are examples for a demo application.

| Method | Endpoint | Purpose |
|---|---|---|
| POST | `/api/register` | Create a new user account |
| POST | `/api/login` | Authenticate an existing user |
| POST | `/api/logout` | End user session |
| GET | `/api/items` | Get all items for the logged-in user |
| POST | `/api/items` | Create a new item |
| GET | `/api/items/{id}` | Get item details |
| PUT | `/api/items/{id}` | Update an existing item |
| DELETE | `/api/items/{id}` | Delete an existing item |

---

## 3. Status Codes to Verify

| Status Code | Meaning | Example Usage |
|---|---|---|
| 200 OK | Request completed successfully | Login, get items, update item |
| 201 Created | Resource created successfully | Register user, create item |
| 400 Bad Request | Invalid request data | Missing required fields, invalid email |
| 401 Unauthorized | Authentication is missing or invalid | Access protected endpoint without token/session |
| 403 Forbidden | User is authenticated but not allowed | Accessing another user's resource |
| 404 Not Found | Resource does not exist | Get, update, or delete non-existing item |
| 409 Conflict | Resource conflict | Register with already existing email |
| 500 Internal Server Error | Unexpected server error | Should not happen in normal scenarios |

---

## 4. Registration API Test Ideas

| Test ID | Scenario | Request Data | Expected Result |
|---|---|---|---|
| API-REG-001 | Register with valid data | Valid name, email, password | User is created, status code 201 |
| API-REG-002 | Register with empty email | Missing email field | Validation error, status code 400 |
| API-REG-003 | Register with invalid email format | Email: `anton.test` | Validation error, status code 400 |
| API-REG-004 | Register with short password | Password: `123` | Validation error, status code 400 |
| API-REG-005 | Register with already existing email | Existing email address | Conflict error, status code 409 |

---

## 5. Login API Test Ideas

| Test ID | Scenario | Request Data | Expected Result |
|---|---|---|---|
| API-LOG-001 | Login with valid credentials | Valid email and password | Login succeeds, status code 200 |
| API-LOG-002 | Login with invalid password | Valid email, wrong password | Login fails, status code 401 |
| API-LOG-003 | Login with non-existing email | Unknown email | Login fails, status code 401 |
| API-LOG-004 | Login with empty fields | Missing email and password | Validation error, status code 400 |
| API-LOG-005 | Login with invalid email format | Invalid email format | Validation error, status code 400 |

---

## 6. Item API Test Ideas

| Test ID | Scenario | Request Data | Expected Result |
|---|---|---|---|
| API-ITEM-001 | Create item with valid data | Valid title and description | Item is created, status code 201 |
| API-ITEM-002 | Create item with empty title | Empty title | Validation error, status code 400 |
| API-ITEM-003 | Get all items | Authenticated request | List of items is returned, status code 200 |
| API-ITEM-004 | Get item by valid ID | Existing item ID | Item details are returned, status code 200 |
| API-ITEM-005 | Get item by invalid ID | Non-existing item ID | Not found error, status code 404 |
| API-ITEM-006 | Update item with valid data | Existing item ID and valid data | Item is updated, status code 200 |
| API-ITEM-007 | Delete existing item | Existing item ID | Item is deleted successfully |
| API-ITEM-008 | Delete non-existing item | Non-existing item ID | Not found error, status code 404 |

---

## 7. Authentication and Authorization Checks

Important API checks related to authentication:

| Scenario | Expected Result |
|---|---|
| Access protected endpoint without authentication | API returns 401 Unauthorized |
| Access protected endpoint with invalid token/session | API returns 401 Unauthorized |
| Access another user's item | API returns 403 Forbidden or 404 Not Found depending on product design |
| Logout and reuse old token/session | API rejects the request |
| Create item while unauthenticated | API returns 401 Unauthorized |

---

## 8. Response Body Validation

For API testing, it is not enough to check only the status code. The response body should also be validated.

Example checks:

- Response contains expected fields
- Response does not expose sensitive data
- Error messages are clear and consistent
- IDs are returned after resource creation
- Created/updated values match the request data
- Date/time fields use expected format
- Boolean fields return correct values

Example successful item response:

```json
{
  "id": 1,
  "title": "Test task",
  "description": "Created by QA test",
  "isCompleted": false
}
```

Example validation error response:

```json
{
  "error": "Title is required."
}
```

---

## 9. Negative API Testing

Negative API tests help verify that the backend handles invalid input safely and predictably.

Examples:

- Missing required fields
- Invalid data types
- Invalid email format
- Too short password
- Empty request body
- Malformed JSON
- Invalid item ID
- Unauthorized request
- Duplicate email registration
- Attempt to update/delete another user's data

---

## 10. Postman Collection Plan

A Postman collection can be created with the following folders:

```text
Authentication
├── Register user
├── Login user
└── Logout user

Items
├── Create item
├── Get all items
├── Get item by ID
├── Update item
└── Delete item

Negative Tests
├── Register with invalid email
├── Login with wrong password
├── Create item without title
├── Access items without authentication
└── Delete non-existing item
```

Postman tests can include:

- Status code validation
- Response time check
- Required field validation
- Saving authentication token/session as a collection variable
- Reusing item ID between requests
- Negative response validation

---

## 11. Example Postman Test Assertions

```javascript
pm.test("Status code is 201", function () {
    pm.response.to.have.status(201);
});

pm.test("Response contains item ID", function () {
    const jsonData = pm.response.json();
    pm.expect(jsonData).to.have.property("id");
});

pm.test("Title matches request data", function () {
    const jsonData = pm.response.json();
    pm.expect(jsonData.title).to.eql("Test task");
});
```

---

## 12. API Testing Notes for Interview

In an interview, I would explain API testing like this:

API testing verifies the behavior of the backend directly, without relying only on the user interface. I would check not only whether the API returns the correct status code, but also whether the response body, validation rules, authentication, authorization, and error handling are correct.

For example, for a login API, I would test valid credentials, invalid password, non-existing email, empty fields, invalid email format, and unauthenticated access to protected endpoints.

I would also check that error messages are consistent and that sensitive information is not exposed in responses.