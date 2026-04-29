\# Bug Reports



This document contains sample bug reports for a simple web application with registration, login, and item management functionality.



The goal is to demonstrate clear defect reporting, including steps to reproduce, expected result, actual result, severity, priority, and business impact.



\---



\## Bug Report Template



| Field | Description |

|---|---|

| Bug ID | Unique identifier of the bug |

| Title | Short and clear summary of the issue |

| Environment | Browser, OS, device, app version if available |

| Preconditions | Required state before reproducing the issue |

| Steps to Reproduce | Clear numbered steps |

| Expected Result | What should happen |

| Actual Result | What actually happens |

| Severity | Technical/user impact |

| Priority | Business urgency |

| Attachment | Screenshot, video, logs if available |

| Notes | Additional context |



\---



\## BUG-001: User can register with invalid email format



| Field | Details |

|---|---|

| Bug ID | BUG-001 |

| Title | User can register with invalid email format |

| Environment | Windows 11, Chrome |

| Preconditions | User is on the registration page |

| Steps to Reproduce | 1. Open the registration page<br>2. Enter a valid name<br>3. Enter invalid email format: `anton.test`<br>4. Enter valid password: `Test123!`<br>5. Confirm the password<br>6. Click Register |

| Expected Result | Registration should not be completed. A clear validation message should be displayed, for example: `Please enter a valid email address.` |

| Actual Result | User account is created successfully with invalid email format. |

| Severity | High |

| Priority | High |

| Attachment | Not attached |

| Notes | This can lead to invalid user accounts and communication issues. Email validation should be enforced on both frontend and backend/API level. |



\---



\## BUG-002: Login error message is unclear when password is incorrect



| Field | Details |

|---|---|

| Bug ID | BUG-002 |

| Title | Login error message is unclear when password is incorrect |

| Environment | Windows 11, Chrome |

| Preconditions | User has an existing registered account |

| Steps to Reproduce | 1. Open the login page<br>2. Enter valid email: `anton.test@example.com`<br>3. Enter invalid password: `Wrong123!`<br>4. Click Login |

| Expected Result | User should not be logged in. A clear generic error message should be displayed, for example: `Invalid email or password.` |

| Actual Result | The application displays: `Something went wrong.` |

| Severity | Medium |

| Priority | Medium |

| Attachment | Not attached |

| Notes | The message does not help the user understand the issue. A generic authentication error is preferred to avoid exposing whether the email exists. |



\---



\## BUG-003: Created item disappears after page refresh



| Field | Details |

|---|---|

| Bug ID | BUG-003 |

| Title | Created item disappears after page refresh |

| Environment | Windows 11, Chrome |

| Preconditions | User is logged in |

| Steps to Reproduce | 1. Open the item creation page<br>2. Enter title: `Test task`<br>3. Enter description: `Created by QA test`<br>4. Click Save<br>5. Verify that the item appears in the list<br>6. Refresh the page |

| Expected Result | Created item should remain visible after page refresh. |

| Actual Result | Created item disappears from the item list after refreshing the page. |

| Severity | High |

| Priority | High |

| Attachment | Not attached |

| Notes | This suggests that the item may not be persisted correctly. The issue should be checked on API and database level. |



\---



\## BUG-004: Delete confirmation dialog is not displayed before deleting an item



| Field | Details |

|---|---|

| Bug ID | BUG-004 |

| Title | Delete confirmation dialog is not displayed before deleting an item |

| Environment | Windows 11, Chrome |

| Preconditions | User is logged in and has at least one created item |

| Steps to Reproduce | 1. Open the item list<br>2. Click Delete on an existing item |

| Expected Result | A confirmation dialog should be displayed before the item is deleted. |

| Actual Result | The item is deleted immediately without confirmation. |

| Severity | Medium |

| Priority | High |

| Attachment | Not attached |

| Notes | This can cause accidental data loss. A confirmation step is recommended for destructive actions. |



\---



\## BUG-005: User can access dashboard after logout by using browser Back button



| Field | Details |

|---|---|

| Bug ID | BUG-005 |

| Title | User can access dashboard after logout by using browser Back button |

| Environment | Windows 11, Chrome |

| Preconditions | User is logged in and currently on the dashboard page |

| Steps to Reproduce | 1. Click Logout<br>2. Verify that the user is redirected to the login page<br>3. Click the browser Back button |

| Expected Result | User should not be able to access the dashboard after logout. The application should redirect the user to login or show an access denied message. |

| Actual Result | Dashboard page is displayed after clicking the browser Back button. |

| Severity | High |

| Priority | High |

| Attachment | Not attached |

| Notes | This can indicate a session/cache handling issue. Protected pages should require valid authentication. |



\---



\## Severity and Priority Explanation



\### Severity



Severity describes how serious the bug is from a technical or user impact perspective.



| Severity | Meaning |

|---|---|

| Critical | Application crash, data loss, security issue, or core flow completely blocked |

| High | Major functionality is broken or produces incorrect results |

| Medium | Functionality works partially, but user experience or reliability is affected |

| Low | Minor UI issue, typo, cosmetic problem, or small inconvenience |



\### Priority



Priority describes how urgently the issue should be fixed from a business or product perspective.



| Priority | Meaning |

|---|---|

| High | Should be fixed as soon as possible |

| Medium | Should be fixed in a normal development cycle |

| Low | Can be fixed later if time allows |



\---



\## Notes



A good bug report should be:



\- Clear

\- Reproducible

\- Specific

\- Neutral in tone

\- Useful for developers

\- Focused on user and business impact

