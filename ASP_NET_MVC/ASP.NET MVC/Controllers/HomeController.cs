using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.NET_MVC.Models;
using MyApp.models;
using MyApp.db.DbOperations;
using Newtonsoft.Json;
using System.IO;

namespace ASP.NET_MVC.Controllers
{
    public class HomeController : Controller
    {
        //Part 1,2,3,4,5 - Basics and Controller
        /*
        // GET: Home - by default data comes by GET method, we can change it to POST
        public string Index()
        {
            return "This is index function";
        }
        //Index always execute first because in route.config , it is set as default method called in HomeController
        public string Name()
        {
            //we can call this method explicitly from browser by YOURDOMAIN/CONTROLLERNAME/METHODNAME
            return "My name is haider";
        }
        //parameters can also be passed from browser by
        //localhost:xxxx/HomeController/Profile?id=1
        public string MyProfile(int id)
        {
            if(id == 1)
            {
                return "User id 1";
            }
            else if(id == 2)
            {
                return "User id 2";
            }
            else
            {
                return "No record found";
            }
        }
        //we can two or more paramters as well 
        //localhost:xxxx/HomeController/MyAddress?id=1&code=2233
        //if we want to send code sometimes but not everytime then make it nullable so
        //if user dont pass code from paramter, it will get setted to null
        public string MyAddress(int id , int? code=null)
        {
            return "id = " + id + " and " + " code = " + code;
        }
        */

        //Part 6 - Views
        /*
        //ActionResult is more general and parent class so we can return files,views with that as well
        //whereas ViewResult is more specific return only views
        //If you want to return only View() then the name os View in Views folder must be same as ActionResult/ViewResult
        //If you have different ActionResult and View name (usually) then pass name or path of View in paramter of returning view as return View("ViewName/~ViewPath")
        //The views which need to be accessed by every controller should be in "Shared" folder(we need to make in Views folder)

        public ActionResult Index()
        {
            return View();
        }
        public ViewResult MyProfile()
        {
            //giving path because this action method name and its relevant view name is not same
            //Both ways working
            //return View("~/Views/Home/MyProfileView.cshtml");
            return View("MyProfileView");
        }
        */

        //Part 7 - Models
        /*
        public ActionResult Index()
        {
            var model = GetEmployee();
            return View(model);
        }
        //To use models, first we need to add them in above includes as "Using ApplicationName.Models"
        //Now we'll pass this Model to index view where it will be shown to user
        //To get model in view we do as "@model ApplicationName.Models.ModelName"
        public Employee GetEmployee()
        {
            return new Employee()
            {
                ID = 1,
                Name = "Haider"
            };
        }
        */

        /*
        //Part 8 - View Engine and Razor
        //Part 9 - loop,if else,directives in Razor
        //View Engine render View and programming languages code in it into pure html for webpages
        //It has many jobs including searching for views in different folders, embeding server side code into web page
        //Razor is view engine used these days
        //It is present in System.Web.Razor
        //It has easy syntax and give power to write C# code in views
        //It begins with @

        //@using , @model are 2 directives of razor used to add any model or namespace in view to use
        //@using ASP.NET_MVC.Models - how to use using
        public ActionResult Index()
        {
            return View();
        }
        */

        //Part 10 - HTML helpers
        //These are methods which return html string and we use them on views
        //In other words, these are C# methods which return html
        //We can render text area, image box etc with html helpers. MVC has some build-in but we can create custom as well
        //Types:
        //1. inline html helpers
        //2. Build-in (Standard,Strongly typed,Templated)
        //3. Custom html helpers

        //Inline helpers
        //Limitation: this can only be used for only single view. cannot be used in anyother view
        /*
        @helper HelperName(parameters)
        {
            //code
        }
        //To call
        @HelperName(paramters)

        public ActionResult Index()
        {
            return View();
        }
        */

        /*
        //Part 11 - Standard html helpers
        //some examples include @Html.ActionLink, @Html.TextBox, @Html.Password, @Html.CheckBox etc. They also have overriden methods
        //@Html.ActionLink(TextOnLink, ActionMethodName, ControllerName(when u need to redirect in different controller), AnyParameter(if u want to))
        //@Html.TextBox(Name,value,html attributes(whichever we want like class,id,style))
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult MyProfile()
        {
            //return View("~/Views/Home/MyProfileView.cshtml");
            return View("MyProfileView");
        }
        */

        /*
        //Part 12 - Strongly typed HTML helpers
        //some examples include @Html.TextBoxFor, @Html.CheckBoxFor
        //model(property) + view(html) = strongly typed views
        //They use lambda expression as @Html.TextBoxFor(model => model.property)
        public ActionResult Index()
        {
            Employee emp = new Employee() { ID = 1, Name = "haider" };
            return View(emp);
        }
        */

        /*
        //Part 13 - Template HTML helpers
        //Used for data display and input
        //one template helper can be used to display entire model, it will generate complete html for model automatically
        //examples
        //DISPLAY - @Html.Display, @Html.DisplayName, @Html.DisplayNameFor, @Html.Text, @Html.TextFor, @Html.DisplayForModel
        //EDIT/INPUT - @Html.Editor, @Html.EditorFor, @Html.EditorForModel

        //by default this is get to sent data from controller to view
        public ActionResult Index()
        {
            return View();
        }

        //we are making another one with post method to get data from view to controller
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            return View();
        }
        */

        /*
        //Part 14 - Custom HTML helpers
        //MVC does not provide helpers like @Html.image() to render image, @Html.AddressFormat to custom address format
        //So, we need our custom helpers according to our need
        //We can create by 2 methods
        //1. static class and static methods
        //2. using extension method
        public ActionResult Index()
        {
            return View();
        }
        */

        /*
        //Part 15 - ViewBag and ViewData
        //Both are used to send data from controller to view but not from view to controller
        //ViewBag.MyPropertyName = Value;  -dynamic property
        //ViewData["myKey"] = value; -as a dictionary
        public ActionResult Index()
        {
            ViewBag.MyName = "I am haider sending data with ViewBag";
            ViewData["KeyForName"] = "I am haider sending data via ViewData";
            return View();
        }
        */

        /*
        //Part 16 - TempData
        //It is used to pass store data for one http subsequent request
        //syntax same as ViewData
        //It stores only for one request cycle and not more than that
        public ActionResult Index()
        {
            TempData["myKey"] = "Temp data from indexx action method";
            return View();
        }
        public ActionResult Index2()
        {
            ViewBag.myKey = TempData["myKey"];
            return View();
        }
        //To save data for all TempData we use keep() method - now value hold for all next http requests
        //TempData.keep()
        //TempData.keep("key")
        //Peek() is used to get and save data for next call
        //Peek() = get data from TempData + Keep()

        //TempData internally uses session
        //If session is disabled then TempData will not work
        */


        //Part 17 - HTTP verbs
        //HTTP = Hypertext transfer protoccol
        //http provides methods(verbs) for the action performedon a resource
        //http main verbs are: Get, Post, Put, Delete
        //http verbs are used on action method

        //[HttpGet] - data transfer only on URL e.g domain.com/student/profile?studentId=1
        //[HttpPost] - used when we have to create new resource in database, data transfer both in URL,header,body
        //[HttpPut] - used when we have to update existing resource in database
        //[HttpDelete] - used when we have to delete existing resource in database

        //Part 18 - Routing
        //Routing is pattern matching system used to map incoming requests (from browser) to a particular resource (controller & action method)
        //We define route for each action method that are stored in route table, each incoming request is mapped to this route table
        //2 types of routing
        //1. Traditional way (using RouteConfig)
        //2. Attribute Routing (Available in MVC 5)

        /*
        //Part 19 - Conventional Routing
        //First, we register rounter in Global.asax
        //then we define in App_Start->RouteConfig.cs
        public ActionResult GetAllEmplyees()
        {
            var Employees = employees();
            return View(Employees); //the view is generated by template (List), all code in that view is self generated by MVC
        }
        public ActionResult GetEmplyee(int id)
        {
            var Employee = employees().FirstOrDefault(x=>x.ID == id);
            return View(Employee);
        }
        private List<Employee> employees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    ID = 1,
                    Name = "haider"
                },
                new Employee()
                {
                    ID = 2,
                    Name = "abbas"
                },
                new Employee()
                {
                    ID = 3,
                    Name = "ali"
                }
            };
        }
        */

        /*
        //Part 20 - Attribute routing (available in MVC 5)
        //All concepts are same as traditional routing just the way of mapping changes
        //First we'll call "routes.MapMvcAttributesRoute" in RouteConfig.cs
        //we have common part here in all routes "employees", if we dont want to write that 
        //then we have to define route prefx above controller as [RoutePrefix("employees")]
        [Route("employees")]
        public ActionResult GetAllEmplyees()
        {
            var Employees = employees();
            return View(Employees); //the view is generated by template (List), all code in that view is self generated by MVC
        }
        [Route("employees/{id}")] //we can also add constraint on this id as [Route("employees/{id}:int:min(5)")]
        public ActionResult GetEmplyee(int id)
        {
            var Employee = employees().FirstOrDefault(x => x.ID == id);
            return View(Employee);
        }
        //if we want to override RoutePrefix then use ~/ in route
        [Route("~/about-us")]
        public string AboutUs()
        {
            return "This is about us";
        }
        private List<Employee> employees()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    ID = 1,
                    Name = "haider"
                },
                new Employee()
                {
                    ID = 2,
                    Name = "abbas"
                },
                new Employee()
                {
                    ID = 3,
                    Name = "ali"
                }
            };
        }
        */

        /*
        //Part 21 - Pass data from view to controller
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string PostUsingParameters(string firstName,string lastName)
        {
            return "From PostUsingParameters " + firstName + " " + lastName;
        }
        [HttpPost]
        public string PostUsingRequest()
        {
            string firstName = Request["firstName"];
            string lastName = Request["lastName"];
            return "From PostUsingRequest " + firstName + " " + lastName;
        }
        public string PostUsingFormCollection(FormCollection form)
        {
            string firstName = form["firstName"];
            string lastName = form["lastName"];
            return "From PostUsingFormCollection " + firstName + " " + lastName;
        }
        //Another way is using models via strong binding
        //We can also pass data by JavaScript
        */

        /*
        //Part 22 - Validation in MVC in loosely binding
        //Validation is used to filter user input
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitData(Student s)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View("Index");
        }
        */

        //Part 23 - Validation in MVC in strongly binding
        //use For in all like @Html.TextBoxFor(x=>x.firstName)etc

        //Part 24 - @Html.ValidationSummary() in MVC
        //If we want to show Validation message all above we use @Html.ValidationSummary()

        /*
        //Part 25 - Custom Validation in MVC
        //We have to implement ValidationAttribute class which is present in System.ComponentModel.DataAnnotations namespace
        //Then, we have to override IsValid method
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitData(Student s)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                return View();
            }
            return View("Index");
        }
        */

        /*
        //Part 26 - Layout
        //If we want to make same view part like (Header,footer or navbar common in all pages), then we code these in shared _layout
        //Also we need to add layout above every cshtml in which we want common part, if it is null then shared part will not come
        //If we also want to avoid adding shared layout reference above every view then we can do that by adding that only one time in _ViewStart.cshtml
        public ActionResult Index()
        {
            return View();
        }
        */

        //Part 27 - Multiple Layout
        //We can add more than one common layouts for one or more pages
        //it has many methods like we can give path to new layout above each page

        /*
        //Part 28 - section in Layout
        //To create space on Layout File we use @RenderSection()
        //@RenderSection("sectionName",required:true)
        //To use that space from View we use @section
        //@section sectionName
        //{
        //      code here
        //}
        public ActionResult Index()
        {
            return View();
        }
        */

        //Part 29 - @RenderPage()
        //If we want to use another view into an another view , we can do it by @RenderPage("~/View/....complete path","params we want to pass")
        //How to get parameters from that view, by "var page = Page" -> Page[0] has first parameter and so on

        //Part 30 - Entity framework
        //First make more than one project in mvc, for the sake of simplicity that we want all our db logic outside the main frame of app so we made class library for db operations
        //class library(.NET framework) cannot execute on its own , it has to be in some mvc project
        //then we add reference of out class library into our main application
        //then we download entity framework latest version from "manage nuGet packages"
        //then we connect sql db with our project


        /*
        //Part 31 - Save data in database using entity framework
        //now we add another layer of models just like we added library class for db
        //we can add models in mvc Models folder but we'll go with layers approch because we can use them in any project in one solution just by adding references

        EmployeeRepository repository = null;
        public HomeController()
        {
            repository = new EmployeeRepository();

        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            if (ModelState.IsValid)
            {
                int id = repository.AddEmployee(emp);
                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.IsSuccess = "Data added";
                }
            }
            return View();
        }
        */

        //Part 32 - save data using navigational property
        //Save data of composite object(Address) in only one hit with covering object(Employee)

        /*
        //Part 33 - Get data from database
        EmployeeRepository repository = null;
        public HomeController()
        {
            repository = new EmployeeRepository();

        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(EmployeeModel emp)
        {
            if (ModelState.IsValid)
            {
                int id = repository.AddEmployee(emp);
                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.IsSuccess = "Data added";
                }
            }
            return View();
        }

        public ActionResult GetAllRecords()
        {
            var result = repository.GetAllEmployee();
            return View(result);
        }
        */

        //Part 34 - Update data
        //Part 35 - Delete record

        //Part 36 - Managing EntityState (update and delete record with single hit)

        /*
        //Part 37 - Using jQuert in MVC
        //Not secure if we use that basically, all code is visible in browser inspect
        //Install jQuery using NuGet package
        public ActionResult Index()
        {
            return View();
        }
        */

        /*
        //Part 38 - Return JSON from MVC controller
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetEmployee()
        {
            Employee std = new Employee()
            {
                ID = 1,
                Name = "Haider"
            };
            var json = JsonConvert.SerializeObject(std);
            return Json(json, JsonRequestBehavior.AllowGet);

        }
        */

        /*
        //Part 39 - Get Data using Ajax (controller to view)
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetEmployee()
        {
            Employee std = new Employee()
            {
                ID = 1,
                Name = "Haider"
            };
            var json = JsonConvert.SerializeObject(std);
            return Json(json, JsonRequestBehavior.AllowGet);

        }
        */

        /*
        //Part 40 - Post data using Ajax (view to controller)
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AddEmployee(Employee emp)
        {
            return Json("true", JsonRequestBehavior.AllowGet);
        } 
        */

        //Part 41 - Ajax Helpers
        //@Ajax is used to access ajax helpers
        //Ajax helpers are used on views
        //provided in System.Web.Mvc.Ajax
        //If we use ajax helpers then we dont need to write ajax functions in script
        //Ajax options have properties like confirm,OnSuccess etc, explore AjaxOptions class for all properties

        //Setup for Ajax helpers
        //1. Jquery must be enabled on client side
        //2. Unobtrusive js must be enabled on client side
        //3. Must have jQuery reference
        //4. Must have jquery.unobtrusive.ajax.js reference

        /*
        //Part 42 - @Ajax.BeginForm()
        //Part 43 - Loader in Ajax Helpers
        //Part 44 - @Ajax.ActionLink()
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee model)
        {
            return View();
        }
        */

        /*
        //Part 45 - Partial view
        //A common piece of view code available for all views
        //They can have html and C# code, they are common for every view so we put them in shared folder
        //2 methods to render partial view
        //1. @Html.Partial("veiwName")
        //2. @Html.RenderPartial("viewName)

        //mistake: _card is partial view. it must be in shared folder
        public ActionResult Index()
        {
            return View();
        }
        */

        //Part 46 - @Html.Partial vs @Html.RenderPartial

        //Pat 47 - Filters
        //When we want to apple some logic Before,After,During the execution of ActionMethods we call them filters
        //Example  - Caching, Error Handling, Logging, Permission
        //5 types of filter
        //1. Authentication filter
        //2. Authorization filter
        //3. Action filter
        //4. Result filter
        //5. Exception filter
        //Places to use filter - Action method, Controller, Global

        /*
        //Part 48 - Output Cache Action filter
        //Every time request comes, it will execute this method, which will slow down process
        //If we use output cache then only one time it will execute and then hold request for given duration for all requests and do not execute this action method again and again

        //Part 49 - Location in Output Cache
        //When we cache data, it needs some location to store it
        //Location property is used to set that location
        //By defualt it is Any

         //If we want to have same thing for multiple clients then output cache on server
         //We use client output cache for links otherwise it wont work
        [OutputCache(Duration =20, Location =System.Web.UI.OutputCacheLocation.Server)]
        public ActionResult Index()
        {
            //time will not update for 20 seconds even though we request because of outputcache
            return View();
        }
        */

        /*
        //Part 50 - Handle Errors -> Exception filter
        //used to avoid duplicacy of try catch block in all action methods
        //To use 3 things required
        //1. Enable custom error in web.config
        //2. Add Error.cshtml in shared folder
        //3. Use handle error ar Action/controller/global level
        [HandleError] //write this above controller to use it for all action methods of that controller
        //TO use global level - Add this "GlobalFilters.Filters.Add(new HandleErrorAttribute())" in Global.asax
        //If we make MVC template then we have all this in filter.config
        public ActionResult Index()
        {
            throw new Exception();
        }
        //Limitation: 
        //we cannot log error by handle error attribute
        //this does not support 404, 401
        */

        //Part 51 - @Html.Raw   
        //It is html helper returns IHtmlString
        //If we pass any html as sting in html.raw, it renders a valid html on browser

        //Part 52 - ValidateInput and AllowHTML (XSS attack , Filters)
        //XSS is security attack
        //Allow html to get html script from input as mvc avoid any script input
        //html.raw will make html tags effective

        //Part 53 - Authentication and Authorisation
        //Part 54 - FormsAuthentication (Login, Signup, Logout)
        //FormsAuthentication is available in System.Web.Security namespace
        //To implement
        //set mode in web.config
        //Use FormsAuthentication.SetAuthCookie for login
        //Use FormsAuthentication.SignOut for logout
        //Code in separate project

        //Part 55 - AllowAnonymous
        //If we set authorize globally then we wont be able to see first view also
        //thats where we need allow anonymous

        //Part 56 - Roles in MVC
        //Role based authorization
        //Roles are permission which are given to particular user to access some resource
        //Roles are used to provide security to system

        //Part 57 - Role based menu

        //Part 58 - Using Identity Framework

        //Part 59 - Custom Authentication Filter

        //Part 60 - Custom Action Filter

        //Part 61 - Custom Exception Filter

        //Part 62 - Area in MVC

        //Part 63 - Routing in area
        //Add namespace in routeconfig

        //Part 64 - Bundling and Minification
        //Bundling is the technique to improve performance by reducing number of requests to server
        //To add new bundle we use BundleConfig file
        //available in System.Web.Optimization namespace
        //Bundle need to be registered in Global.asax file
        //Minification is the process of removing unnecessary data(comments, extra spaces) without changing its functionality 

        /*
        //Part 65 - Model Binder
        //Binds model to action method parameter
        //Part 66 - Custom Model Binder
        [HttpPost]
        public ActionResult Index([ModelBinder(typeof(MyModelBinder))]Employee model)
        {
            return View();
        }
        */

        //Part 67 - MVC application life cycle

        //Part 68 - Unit testing
        //Recommended: Add Unit test project when creating project

        //Part 69 - Dependency injection ??

        //Part 70 - Web API
        //"Application Programming Interface" allow users to access particular resource uing HTTP protocol

        //Visual Studio has added the full set of dependencies for ASP.NET Web API 2 to project 'ASP.NET MVC'. 

        //The Global.asax.cs file in the project may require additional changes to enable ASP.NET Web API.

        //1. Add the following namespace references:

        //    using System.Web.Http;
        //    using System.Web.Routing;

        //2. If the code does not already define an Application_Start method, add the following method:

        //    protected void Application_Start()
        //    {
        //    }

        //3. Add the following lines to the beginning of the Application_Start method:

        //    GlobalConfiguration.Configure(WebApiConfig.Register);

        //Part 71 - Async controllers
        //Part 72 - Deploy MVC on IIS server
        //Part 73 - advance concepts
        //Part 74 - Drop down list
        //Part 75 - How to upload file
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase fileBase)
        {
            string path = Server.MapPath("~/App_Data/File");
            string filename = Path.GetFileName(fileBase.FileName);

            string fullpath = Path.Combine(path, filename);
            fileBase.SaveAs(fullpath);
            return View();
        }

        //Part 76 - How to download a file using FileResult
        //Part 77 - 3 ways to use multiple submit buttons on single form
        //Part 78 - 6 ways to return multiple models on a single view
        //# Return multiple models using ViewModels  03:54
        //# Return multiple models using Dynamic model (ExpandoObject) 13:39
        //# Return multiple models using Tuples 19:53
        //# Return multiple models using ViewBag 24:31
        //# Return multiple models using ViewData 26:43
        //# Return multiple models using PartialView 29:05
    }

}