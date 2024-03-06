

using Practice_Interface_Services.Models;
using Practice_Interface_Services.Services;
using Practice_Interface_Services.Services.Interfaces;

namespace Practice_Interface_Services.Controllers
{
    public class EmployeeController
    {
        
         EmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public void GetAll()
        {
          var employees = _employeeService.GetAll();
            foreach (var employee in employees)
            {
                string result = $"{employee.Name} {employee.Surname} {employee.Address}" +
                    $"{employee.Email} {employee.Age} {employee.Brithday.ToString("MM-dd-yyyy")}";
                Console.WriteLine(result);

            }

        }
        //public void GetById()
        //{
        //    int? id = 4;
        //    var response = _employeeService.GetById(_employeeService.GetAll(), id);
        //    if (response.ErrorMessage is null)
        //    {
        //        string result = $"{response.Employee.Name} {response.Employee.Surname} {response.Employee.Address}" +
        //        $"{response.Employee.Email} {response.Employee.Age} {response.Employee.Brithday.ToString("MM-dd-yyyy")}";
        //        Console.WriteLine(result);
        //    }
        //    else
        //    {
        //        Console.WriteLine(response.ErrorMessage);

        //    }
        //}


        public void Search()
        {
            string name = "Rashad";
            

            var response = _employeeService.Search(_employeeService.GetAll(), name);
            if (response[0].ErrorMessage is null)
            {
                string result = $"{response.Employee.Name} {response.Employee.Surname} {response.Employee.Address}" +
                $"{response.employee.email} {response.employee.age} {response.employee.brithday.tostring("mm-dd-yyyy")}";
                console.writeline(result);
            }
            else
            {
                Console.WriteLine(response[0].ErrorMessage);

            }

        }


    }
}
