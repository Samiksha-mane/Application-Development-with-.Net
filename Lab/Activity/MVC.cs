/*What is IActionResult
IActionResult is an interface in ASP.NET Core MVC used as 
a return type for controller actions.
It allows a controller method to return different types of responses like:
View (HTML page),JSON data,Redirect,Status codes (404, 200, etc.)
Used in ASP.NET Core MVC
*/

/*Why IActionResult is used?
Instead of fixing one return type, it gives flexibility:
Return View,Return JSON,Return File,Return Error
All from the same method type
*/

//Basic Example
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(); // returns HTML page
    }
}

/*Different Types of IActionResult
1. Return View
2. Return JSON
3. Redirect to another action
4. Return Status Code
5. Return Content
*/

/*Real-Time Use in Companies
1.Web Applications = Return views (UI pages)
2.Web APIs = Return JSON data to frontend (React, Angular)
3.Error Handling = Return proper HTTP status codes
4.Authentication = Redirect after login/logout
*/
