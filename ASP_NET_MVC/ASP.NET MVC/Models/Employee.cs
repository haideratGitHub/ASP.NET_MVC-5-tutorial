using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASP.NET_MVC.Models
{
    public class Employee
    {
        //generally fields are private and properties are public
        public int ID { get; set; }
        public string Name { get; set; }

        /*
        [DataType(DataType.Date)] //without this, input for date of birth is not date but it is textinput, we'll use data annotation above DOB property to make input date type
        public DateTime DOB { get; set; }
        */
    }
}