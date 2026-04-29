\# Smoke Test Checklist



This checklist contains high-priority smoke test scenarios for a simple web application with registration, login, logout, and item management functionality.



The goal of smoke testing is to quickly verify that the most critical user flows are working before deeper testing begins.



\---



\## Smoke Test Scope



Smoke testing focuses only on the most important flows:



\- Application loads successfully

\- User can register

\- User can log in

\- User can log out

\- User can create an item

\- User can view created items

\- User can edit an item

\- User can delete an item



\---



\## Smoke Checklist



| ID | Scenario | Steps | Expected Result | Status |

|---|---|---|---|---|

| SMK-001 | Application loads successfully | Open the application URL | Application home page or login page is displayed without errors | Not Run |

| SMK-002 | Registration page opens | Open the registration page | Registration form is displayed | Not Run |

| SMK-003 | User can register with valid data | Fill all required fields with valid data and submit the form | User account is created successfully | Not Run |

| SMK-004 | Login page opens | Open the login page | Login form is displayed | Not Run |

| SMK-005 | User can log in with valid credentials | Enter valid email and password and click Login | User is logged in and redirected to dashboard | Not Run |

| SMK-006 | Dashboard is accessible after login | Log in and open the dashboard page | Dashboard page is displayed correctly | Not Run |

| SMK-007 | User can create an item | Create a new item with valid title and description | Item is created and displayed in the list | Not Run |

| SMK-008 | User can view item list | Open the item list page | Created items are displayed | Not Run |

| SMK-009 | User can edit an existing item | Edit item title or description and save changes | Item is updated successfully | Not Run |

| SMK-010 | User can delete an item | Delete an existing item | Item is removed from the list | Not Run |

| SMK-011 | User can log out | Click Logout | User is logged out and redirected to login or home page | Not Run |

| SMK-012 | Protected page is not accessible after logout | Logout and try to open dashboard directly | User is redirected to login page or access is denied | Not Run |



\---



\## Smoke Testing Notes



Smoke tests should be executed:



\- After a new build is deployed

\- Before starting detailed functional testing

\- Before running a full regression cycle

\- After critical environment changes



If a critical smoke test fails, deeper testing should be paused until the issue is fixed.

