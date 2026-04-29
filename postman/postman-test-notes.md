# Postman API Testing Notes

This folder contains a Postman collection and environment for API testing practice as part of the Junior QA Demo Project.

The API tests are based on ReqRes demo endpoints and cover basic API testing scenarios.

---

## Covered Areas

- Users API
- Authentication API
- Positive API scenarios
- Negative API scenarios
- Status code validation
- Response body validation
- Collection-level API key authorization
- Environment variables

---

## Requests Covered

### Users

- Get users list
- Get single user
- Get user not found
- Create user
- Update user
- Delete user

### Authentication

- Login successful
- Login unsuccessful - missing password
- Register successful
- Register unsuccessful - missing password

---

## Environment Variables

The environment uses the following variables:

| Variable | Purpose |
|---|---|
| `baseUrl` | Base URL for the ReqRes API |
| `apiKey` | API key used for the `x-api-key` header |
| `userId` | Existing user ID used in positive tests |
| `notFoundUserId` | Non-existing user ID used in negative tests |

---

## Important Security Note

The real API key is not included in this repository.

Before running the collection, replace the placeholder value:

```text
YOUR_API_KEY_HERE
```

with a valid ReqRes API key in your local Postman environment.

---

## What This Demonstrates

This Postman collection demonstrates basic API testing skills, including:

- Sending GET, POST, PUT, and DELETE requests
- Using environment variables
- Using collection-level authorization
- Validating status codes
- Validating response body structure
- Testing both successful and unsuccessful API scenarios