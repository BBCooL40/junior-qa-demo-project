\# Test Summary Report



This document contains a sample test summary report for the Junior QA Demo Project.



The goal is to demonstrate how test execution results can be summarized and communicated clearly to the team.



\---



\## 1. Test Summary



The testing activities focused on core user flows of a demo web application, including registration, login, logout, item management, validation, and basic API behavior.



This report summarizes the planned test execution, test coverage, identified sample issues, and overall quality observations.



\---



\## 2. Test Scope



The following areas were included in the test execution scope:



\- Registration

\- Login

\- Logout

\- Protected dashboard access

\- Item creation

\- Item editing

\- Item deletion

\- Item list view

\- Form validation

\- Session handling

\- Basic API behavior



\---



\## 3. Test Execution Summary



| Metric | Result |

|---|---:|

| Total planned test cases | 26 |

| Executed test cases | 26 |

| Passed test cases | 21 |

| Failed test cases | 5 |

| Blocked test cases | 0 |

| Not run test cases | 0 |



\---



\## 4. Test Results by Area



| Area | Passed | Failed | Notes |

|---|---:|---:|---|

| Registration | 5 | 2 | Issues found with invalid email and duplicate email handling |

| Login | 4 | 1 | Error message for invalid password is unclear |

| Logout / Session | 1 | 1 | Dashboard can be accessed after logout using browser Back button |

| Item Management | 5 | 1 | Created item disappears after page refresh |

| API Behavior | 6 | 0 | Basic API expectations documented; execution planned for future Postman collection |



\---



\## 5. Defects Summary



| Bug ID | Title | Severity | Priority | Status |

|---|---|---|---|---|

| BUG-001 | User can register with invalid email format | High | High | Open |

| BUG-002 | Login error message is unclear when password is incorrect | Medium | Medium | Open |

| BUG-003 | Created item disappears after page refresh | High | High | Open |

| BUG-004 | Delete confirmation dialog is not displayed before deleting an item | Medium | High | Open |

| BUG-005 | User can access dashboard after logout by using browser Back button | High | High | Open |



\---



\## 6. Quality Assessment



Based on the sample test execution, the application covers the main user flows but has several important issues that should be addressed before release.



The most critical risks are related to:



\- Invalid user registration data

\- Data persistence

\- Session handling after logout

\- User experience around destructive actions

\- Clear validation and error messages



\---



\## 7. Release Recommendation



The application is not recommended for release until the high-priority issues are fixed and retested.



Critical areas to retest after fixes:



\- Registration validation

\- Login error handling

\- Item persistence

\- Logout/session handling

\- Delete confirmation behaviour



\---



\## 8. Next Steps



Recommended next steps:



\- Fix high-priority defects

\- Retest fixed issues

\- Execute smoke checklist again

\- Execute selected regression tests based on affected areas

\- Create Postman collection for API validation

\- Add basic automation tests for stable core flows



\---



\## 9. Notes



This is a sample test summary report created as part of a QA portfolio case study. The purpose is to demonstrate how test execution results can be structured and communicated in a professional QA context.

