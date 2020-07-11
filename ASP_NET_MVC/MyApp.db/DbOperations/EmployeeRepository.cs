using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.models;

namespace MyApp.db.DbOperations
{
    public class EmployeeRepository
    {
        public int AddEmployee(EmployeeModel model)
        {
            using(var context = new EmployeeDBEntities())
            {
                Employee emp = new Employee()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Code = model.Code
                };
                context.Employee.Add(emp);
                context.SaveChanges();
                return emp.Id;
            }
        }

        //Part 33
        public List<EmployeeModel> GetAllEmployee()
        {
            using(var context = new EmployeeDBEntities())
            {
                var result = context.Employee.Select(x => new EmployeeModel()
                {
                    Id = x.Id,
                    Code = x.Code,
                    Email = x.Email,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                }).ToList();
                return result;
            }
            
        }
    }
}
