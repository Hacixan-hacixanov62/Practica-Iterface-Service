

using Practice_Interface_Services.Helpers.Constans;
using Practice_Interface_Services.Helpers.Responses;
using Practice_Interface_Services.Models;
using Practice_Interface_Services.Services.Interfaces;

namespace Practice_Interface_Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        public Employee[] GetAll()
        {

            Employee employee1 = new()
            {
               
                Id = 1,
                Name="Rashad",
                Surname="Agayev",
                Age=21,
                Email="rashad@gmail.com",
                Address="Ordubad",
                Brithday = DateTime.Now.AddDays(-21),


            };

            Employee employee2 = new()
            {

                Id = 2,
                Name = "Rufat",
                Surname = "Ismayilov",
                Age = 22,
                Email = "rufat@gmail.com",
                Address = "Baki",
                Brithday = DateTime.Now.AddDays(-22),


            };

            Employee employee3 = new()
            {

                Id = 3,
                Name = "Cavid ",
                Surname = "Bashirov",
                Age = 30,
                Email = "cavid@gmail.com",
                Address = "Siyezen",
                Brithday = DateTime.Now.AddDays(-30),


            };

            Employee employee4 = new()
            {

                Id = 4,
                Name = "Amirastan",
                Surname = "Miriyev",
                Age = 33,
                Email = "Amirastan@gmail.com",
                Address = "Xezer",
                Brithday = DateTime.Now.AddDays(-33),


            };

            Employee employee5 = new()
            {

                Id = 5,
                Name = "Esgerxan",
                Surname = "Bayramov",
                Age = 27,
                Email = "esgerxan@gmail.com",
                Address = "Berde",
                Brithday = DateTime.Now.AddDays(-27),


            };

            Employee employee6 = new()
            {

                Id = 6,
                Name = "Behruz",
                Surname = "Aliyev",
                Age = 21,
                Email = "bahruz@gmail.com",
                Address = "Ordubad",
                Brithday = DateTime.Now.AddDays(-21),


            };

            Employee employee7 = new()
            {

                Id = 7,
                Name = "Rashad",
                Surname = "Agayev",
                Age = 21,
                Email = "rashad@gmail.com",
                Address = "Ordubad",
                Brithday = DateTime.Now.AddDays(-21),


            };

            Employee employee8 = new()
            {

                Id = 8,
                Name = "Ismayil",
                Surname = "Ceferli",
                Age = 24,
                Email = "ismayil@gmail.com",
                Address = "Ehmedli",
                Brithday = DateTime.Now.AddDays(-21),


            };
            return new Employee[] { employee1, employee2, employee3, employee4, employee5, employee6, employee7, employee8 };  

        }
        public EmployeeResponse GetById( Employee[] employees , int? id)
        {
            if (id == null)
            {
                return new EmployeeResponse { ErrorMessage = EmployeeResponseMessages.ArgumentNull};
            }

            Employee employee = employees.FirstOrDefault(m => m.Id == id);
            if (employee is null)
            {
                return new EmployeeResponse { ErrorMessage = EmployeeResponseMessages.NotFound };
            }

            return new EmployeeResponse { Employee = employee };
        }

        public EmployeeResponse[] Search(Employee[] employees, string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                return new EmployeeResponse[] { new EmployeeResponse { ErrorMessage = EmployeeResponseMessages.ArgumentNull, } };
            }
            Employee[] employee = employees.Where(m=>m.Name.Contains(str)||m.Surname.Contains(str)).ToArray();

            if (employee.Length==0)
            {
                return new EmployeeResponse[] { new EmployeeResponse { ErrorMessage = EmployeeResponseMessages.NotFound } };
            }

            EmployeeResponse[] employeeResponses = new EmployeeResponse[employee.Length];

            for (int i = 0; i < employeeResponses.Length; i++)d
            {
                employeeResponses[i]=new EmployeeResponse() { Employee = employee[i] };
            }
            return employeeResponses;
        }
    }
}
