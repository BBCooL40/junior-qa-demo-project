\# Test Cases



This document contains sample test cases for a simple web application with registration, login, logout, and basic item management functionality.



The purpose is to demonstrate structured test case design, including positive, negative, and edge case scenarios.



\---



\## Registration Test Cases



| Test Case ID | Title | Preconditions | Steps | Test Data | Expected Result | Priority |

|---|---|---|---|---|---|---|

| TC-REG-001 | Register with valid data | User is on the registration page | 1. Enter valid name<br>2. Enter valid email<br>3. Enter valid password<br>4. Confirm password<br>5. Click Register | Name: Anton<br>Email: anton.test@example.com<br>Password: Test123! | User account is created successfully and user is redirected to login or dashboard page | High |

| TC-REG-002 | Register with empty required fields | User is on the registration page | 1. Leave all fields empty<br>2. Click Register | Empty fields | Validation messages are displayed for all required fields | High |

| TC-REG-003 | Register with invalid email format | User is on the registration page | 1. Enter valid name<br>2. Enter invalid email<br>3. Enter valid password<br>4. Click Register | Email: anton.test | Email validation message is displayed and registration is not completed | High |

| TC-REG-004 | Register with password shorter than minimum length | User is on the registration page | 1. Enter valid name<br>2. Enter valid email<br>3. Enter short password<br>4. Click Register | Password: 123 | Password validation message is displayed and registration is not completed | High |

| TC-REG-005 | Register when password and confirm password do not match | User is on the registration page | 1. Enter valid registration data<br>2. Enter different values in Password and Confirm Password<br>3. Click Register | Password: Test123!<br>Confirm Password: Test456! | Validation message is displayed and registration is not completed | High |

| TC-REG-006 | Register with already existing email | A user with the same email already exists | 1. Enter valid name<br>2. Enter an already registered email<br>3. Enter valid password<br>4. Click Register | Email: existing.user@example.com | User is not registered and a clear error message is displayed | High |

| TC-REG-007 | Register with leading and trailing spaces in email | User is on the registration page | 1. Enter email with spaces before and after<br>2. Complete the remaining fields<br>3. Click Register | Email: " anton.test@example.com " | Spaces are trimmed or validation message is displayed clearly | Medium |



\---



\## Login Test Cases



| Test Case ID | Title | Preconditions | Steps | Test Data | Expected Result | Priority |

|---|---|---|---|---|---|---|

| TC-LOG-001 | Login with valid credentials | User has an existing account | 1. Open login page<br>2. Enter valid email<br>3. Enter valid password<br>4. Click Login | Email: anton.test@example.com<br>Password: Test123! | User logs in successfully and is redirected to dashboard page | High |

| TC-LOG-002 | Login with invalid password | User has an existing account | 1. Open login page<br>2. Enter valid email<br>3. Enter invalid password<br>4. Click Login | Password: Wrong123! | User is not logged in and an error message is displayed | High |

| TC-LOG-003 | Login with non-existing email | User is on the login page | 1. Enter non-existing email<br>2. Enter any password<br>3. Click Login | Email: notfound@example.com | User is not logged in and an error message is displayed | High |

| TC-LOG-004 | Login with empty email and password | User is on the login page | 1. Leave email and password empty<br>2. Click Login | Empty fields | Required field validation messages are displayed | High |

| TC-LOG-005 | Login with invalid email format | User is on the login page | 1. Enter invalid email format<br>2. Enter password<br>3. Click Login | Email: anton.test | Email validation message is displayed | Medium |

| TC-LOG-006 | Login with leading/trailing spaces in email | User has an existing account | 1. Enter valid email with spaces before and after<br>2. Enter valid password<br>3. Click Login | Email: " anton.test@example.com " | Application handles spaces consistently by trimming them or showing a clear validation message | Medium |



\---



\## Logout Test Cases



| Test Case ID | Title | Preconditions | Steps | Test Data | Expected Result | Priority |

|---|---|---|---|---|---|---|

| TC-OUT-001 | Logout from an active session | User is logged in | 1. Click Logout button | N/A | User is logged out and redirected to login or home page | High |

| TC-OUT-002 | Access protected page after logout | User has logged out | 1. Logout<br>2. Try to open dashboard page directly from URL | Dashboard URL | User is redirected to login page or access is denied | High |



\---



\## Item Management Test Cases



| Test Case ID | Title | Preconditions | Steps | Test Data | Expected Result | Priority |

|---|---|---|---|---|---|---|

| TC-ITEM-001 | Create item with valid data | User is logged in | 1. Open item creation page<br>2. Enter valid title<br>3. Enter valid description<br>4. Click Save | Title: Test task<br>Description: Created by QA test | Item is created and displayed in the item list | High |

| TC-ITEM-002 | Create item with empty title | User is logged in | 1. Open item creation page<br>2. Leave title empty<br>3. Enter description<br>4. Click Save | Empty title | Validation message is displayed and item is not created | High |

| TC-ITEM-003 | Edit existing item | User is logged in and has at least one item | 1. Open existing item<br>2. Change title or description<br>3. Click Save | Updated title: Updated test task | Item is updated successfully and changes are visible | High |

| TC-ITEM-004 | Delete existing item | User is logged in and has at least one item | 1. Click Delete on an item<br>2. Confirm deletion | N/A | Item is removed from the list | High |

| TC-ITEM-005 | Cancel item deletion | User is logged in and has at least one item | 1. Click Delete on an item<br>2. Cancel confirmation dialog | N/A | Item is not deleted and remains visible in the list | Medium |

| TC-ITEM-006 | Verify created item persists after page refresh | User is logged in and has created an item | 1. Create item<br>2. Refresh the page<br>3. Check item list | Title: Persistent task | Created item remains visible after refresh | High |



\---



\## Notes



These test cases can later be expanded with:



\- API-level validation

\- Database validation

\- Automation scenarios

\- Cross-browser checks

\- Accessibility checks

\- Security-related negative scenarios

