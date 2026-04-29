\# Regression Test Checklist



This checklist contains regression test scenarios for a simple web application with authentication and item management functionality.



The goal of regression testing is to verify that existing functionality still works correctly after code changes, bug fixes, or new feature releases.



\---



\## Regression Test Scope



Regression testing covers:



\- Registration

\- Login

\- Logout

\- Form validation

\- Session handling

\- Item creation

\- Item editing

\- Item deletion

\- Data persistence

\- Error handling

\- Basic API behavior



\---



\## Authentication Regression Checklist



| ID | Scenario | Expected Result | Status |

|---|---|---|---|

| REG-AUTH-001 | Register with valid data | User account is created successfully | Not Run |

| REG-AUTH-002 | Register with empty required fields | Required field validation messages are displayed | Not Run |

| REG-AUTH-003 | Register with invalid email format | Email validation message is displayed | Not Run |

| REG-AUTH-004 | Register with short password | Password validation message is displayed | Not Run |

| REG-AUTH-005 | Register with mismatched password confirmation | Password mismatch validation message is displayed | Not Run |

| REG-AUTH-006 | Register with already existing email | Duplicate email error message is displayed | Not Run |

| REG-AUTH-007 | Login with valid credentials | User logs in successfully | Not Run |

| REG-AUTH-008 | Login with invalid password | User is not logged in and error message is displayed | Not Run |

| REG-AUTH-009 | Login with non-existing email | User is not logged in and error message is displayed | Not Run |

| REG-AUTH-010 | Login with empty fields | Required field validation messages are displayed | Not Run |

| REG-AUTH-011 | Logout from active session | User is logged out successfully | Not Run |

| REG-AUTH-012 | Access protected page after logout | User is redirected to login or access is denied | Not Run |



\---



\## Item Management Regression Checklist



| ID | Scenario | Expected Result | Status |

|---|---|---|---|

| REG-ITEM-001 | Create item with valid data | Item is created and displayed in the list | Not Run |

| REG-ITEM-002 | Create item with empty title | Validation message is displayed and item is not created | Not Run |

| REG-ITEM-003 | Create item with maximum allowed title length | Item is created or validation is handled correctly | Not Run |

| REG-ITEM-004 | Edit item title | Item title is updated successfully | Not Run |

| REG-ITEM-005 | Edit item description | Item description is updated successfully | Not Run |

| REG-ITEM-006 | Delete existing item | Item is removed from the list | Not Run |

| REG-ITEM-007 | Cancel item deletion | Item remains visible in the list | Not Run |

| REG-ITEM-008 | Refresh page after item creation | Created item remains visible | Not Run |

| REG-ITEM-009 | Refresh page after item edit | Updated item remains visible | Not Run |

| REG-ITEM-010 | Item list displays correct data | All created items are displayed with correct title and description | Not Run |



\---



\## UI and Validation Regression Checklist



| ID | Scenario | Expected Result | Status |

|---|---|---|---|

| REG-UI-001 | Required fields are visually indicated | Required fields are clear to the user | Not Run |

| REG-UI-002 | Validation messages are readable | Validation messages are clear and understandable | Not Run |

| REG-UI-003 | Buttons are enabled/disabled correctly | Buttons behave according to form state | Not Run |

| REG-UI-004 | Navigation links work correctly | User can navigate between main pages | Not Run |

| REG-UI-005 | Error messages do not expose sensitive information | Messages are useful but do not reveal internal details | Not Run |



\---



\## API Regression Checklist



| ID | Scenario | Expected Result | Status |

|---|---|---|---|

| REG-API-001 | Registration API accepts valid request | API returns success status code and creates user | Not Run |

| REG-API-002 | Registration API rejects invalid email | API returns validation error | Not Run |

| REG-API-003 | Login API accepts valid credentials | API returns success status and authentication token/session | Not Run |

| REG-API-004 | Login API rejects invalid credentials | API returns appropriate error status | Not Run |

| REG-API-005 | Create item API accepts valid request | API creates item successfully | Not Run |

| REG-API-006 | Create item API rejects invalid request | API returns validation error | Not Run |

| REG-API-007 | Update item API updates existing item | API returns success status and updated data | Not Run |

| REG-API-008 | Delete item API deletes existing item | API returns success status and item is removed | Not Run |



\---



\## Regression Testing Notes



Regression tests should be executed:



\- Before a release

\- After bug fixes

\- After changes in authentication

\- After changes in database or API logic

\- After UI changes that may affect user flows



A full regression cycle is not always required after every small change. The scope should be selected based on risk, affected areas, and business priority.

