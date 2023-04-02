using System;
using System.Collections.Generic;

namespace ConsoleApp114
{
    public class Employees
    {
        public string employeeName;
        public double employeeSalary;

        public string employeePosition;
        public string employeeDepartment;

        public string employeeEmail = "n/a";

        public string employeeAge = "-1";
        public static void EmployeeList()
        {
            Console.WriteLine("Enter how many employees info you are going to write:");
            int n = Convert.ToInt32(Console.ReadLine());

            List<Employees> employeeList = new List<Employees>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter employee information for employee {i + 1}:");
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');

                Employees employee = new Employees();
                employee.employeeName = parts[0];
                employee.employeeSalary = double.Parse(parts[1]);
                employee.employeePosition = parts[2];
                employee.employeeDepartment = parts[3];
                if (employee.employeeEmail == "null"){
                    employee.employeeEmail = "null";
                }
                else{
                    employee.employeeEmail = parts[4];
                }
                if (employee.employeeAge == "null"){
                    employee.employeeAge = "null";
                }
                else {
                    employee.employeeAge = (parts[5]);
                }

                employeeList.Add(employee);
            }

            Console.WriteLine("Employee List:");
            
            foreach (Employees employee in employeeList)
            {
                
                string employeeInfo = $"{employee.employeeName} {employee.employeeSalary} {employee.employeePosition} {employee.employeeDepartment} {employee.employeeEmail} {employee.employeeAge}";
                Console.WriteLine(employeeInfo);
            }

            System.Console.WriteLine();
            
            double maxSalary = double.MinValue;
            string departmentSalary = "";

            foreach (Employees employee in employeeList){
                if (employee.employeeSalary > maxSalary)
                {
                    maxSalary = employee.employeeSalary;
                    departmentSalary = employee.employeeDepartment;
                }
            }

            System.Console.WriteLine($"Highest Average Salary: {maxSalary} in the {departmentSalary}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employees.EmployeeList();
        }
    }
}
