using StorageApp.Entities;
using StorageApp.Repositories;
using System;

namespace StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var employeeRepository = new EmployeeRepository();
            employeeRepository.Add(new Employee { FirstName = "Julia" });
            employeeRepository.Add(new Employee { FirstName = "Anna" });
            employeeRepository.Add(new Employee { FirstName = "Thomas" });
            employeeRepository.Save();

            Console.ReadLine();
        }
    }
}
