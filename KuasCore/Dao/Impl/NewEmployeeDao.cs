
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{


    public class NewEmployeeDao : IEmployeeDao
    {
        public IList<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employees1 = new Employee();
            employees1.Id = "LaLa";
            employees1.Name = "拉拉";
            employees1.Age = 1;
            employees.Add(employees1);

            Employee employees2 = new Employee();
            employees2.Id = "Bear";
            employees2.Name = "熊大";
            employees2.Age = 10;
            employees.Add(employees2);

            return employees;
        }

        public Employee GetEmployeeById(string id)
        {
            Employee employees2 = new Employee();
            employees2.Id = "Bear";
            employees2.Name = "熊大";
            employees2.Age = 10;


            return employees2;
        }


    }



}