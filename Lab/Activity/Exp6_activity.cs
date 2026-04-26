/* 1. Why MVC is used in companies
Reasons:
1.Separation of Concerns
-Model → Data
-View → UI
-Controller → Logic
2.Scalability = Easy to manage large applications
3.Maintainability = Code is organized and easy to update
4.Testability = Easy to write unit tests
5.Team Collaboration = Frontend & backend developers can work separately
-That’s why companies prefer MVC for:
1.Banking apps
2.E-commerce websites
3.Enterprise systems
*/

/* 2. MVC Folder Structure
Models → Business/data classes
Views → UI pages (.cshtml)
Controllers → Handle requests & responses
*/

/* 3. What is Routing in MVC
Routing = Mapping URL to Controller Action
*/

/*4. Difference between MVC and Razor Pages
Feature 	       MVC	                Razor Pages
Structure	   Controller + View   	    Page-based
Complexity	   More structured	        Simpler
Use Case	    Large apps	            Small/medium apps
Code Location	Separate files	        Same file (.cshtml + code)
Control           More control	        Less control
*/

/* 5.When we click on "Customer Menu" (Workflow in MVC)
1.User Action
-User clicks on the Customer menu link in the UI.
2.HTTP Request Generated
-Browser sends a request to the server with URL like:
-/Customer/Index
3.Routing Process
-MVC routing system matches the URL to:
-CustomerController
-Index() action method
4.Controller Execution
-The CustomerController receives the request.
-The Index() method is executed.
5.Model Interaction
-Controller interacts with the Model layer.
-It fetches data (from database/API/service).
6.Data Processing
-Retrieved data is processed or prepared for display.
7.Return View
-Controller returns a View along with model data.
8.View Rendering
-View (.cshtml file) generates HTML using the data.
9.Response to Browser
-Generated HTML is sent back to the user's browser.
10.Display Output
-Browser renders the page showing Customer details.
*/


