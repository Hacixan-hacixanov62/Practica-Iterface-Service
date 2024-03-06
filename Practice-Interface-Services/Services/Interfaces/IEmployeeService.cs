

using Practice_Interface_Services.Helpers.Responses;
using Practice_Interface_Services.Models;

namespace Practice_Interface_Services.Services.Interfaces
{
    public interface IEmployeeService
    {
        Employee[] GetAll();
        EmployeeResponse GetById(Employee[] employees,int? id);

        EmployeeResponse[] Search(Employee[] employees ,string str);
    }
}
