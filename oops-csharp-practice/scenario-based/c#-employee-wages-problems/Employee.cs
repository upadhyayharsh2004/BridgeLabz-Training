using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Bridgelabz.Training_oops_scenario_based_Employee_Wages_Problems
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int TotalWage { get; private set; }
        public int TotalHours { get; private set; }
        public int TotalDays { get; private set; }
        public Employee(int empId, string empName)
        {
            EmpId = empId;
            EmpName = empName;
            TotalWage = 0;
            TotalHours = 0;
            TotalDays = 0;
        }
        public void AddHours(int hours)
        {
            TotalHours += hours;
        }
        public void AddWage(int wage)
        {
            TotalWage += wage;
        }
        public void AddDay()
        {
            TotalDays++;
        }
    }
}
