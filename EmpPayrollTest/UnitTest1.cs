using EmpServiceADO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EmpPayrollTest
{
    
    public class UnitTest1
    {
        [Test]
        public void Given10Employee_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<EmpModel> employee = new List<EmpModel>();
            employee.Add(new EmpModel(Id: 1, Name: "Bruce", Age: 25, Salary: 1000, StartDate : DateTime.Now,Gender: "M", PhoneNumber: "9001234560", Department: "sales",Deductions: "100", Taxable_Pay: "100", Income_Tax: "1000", Net_Pay: "2000"));
            employee.Add(new EmpModel(Id: 2, Name: "Banner", Age: 24, Salary: 2000, StartDate: DateTime.Now, Gender: "M", PhoneNumber: "9001234562", Department: "IT", Deductions: "500", Taxable_Pay: "500", Income_Tax: "1000", Net_Pay: "5000"));
            employee.Add(new EmpModel(Id: 3, Name: "Peter", Age: 24, Salary: 2000, StartDate: DateTime.Now, Gender: "M", PhoneNumber: "9001234563", Department: "IT", Deductions: "500", Taxable_Pay: "500", Income_Tax: "1000", Net_Pay: "5000"));
            employee.Add(new EmpModel(Id: 4, Name: "Parker", Age:43, Salary: 3000, StartDate: DateTime.Now, Gender: "M", PhoneNumber: "9001234564", Department: "sales", Deductions: "600", Taxable_Pay: "600", Income_Tax: "1500", Net_Pay: "6000"));
            employee.Add(new EmpModel(Id: 5, Name: "Tony", Age: 44, Salary: 4000, StartDate: DateTime.Now, Gender: "M", PhoneNumber: "9001234565", Department: "IT", Deductions: "700", Taxable_Pay: "700", Income_Tax: "1800", Net_Pay: "4000"));
            employee.Add(new EmpModel(Id: 6, Name: "Stark", Age: 28, Salary: 5000, StartDate: DateTime.Now, Gender: "M", PhoneNumber: "9001234566", Department: "Banking", Deductions: "800", Taxable_Pay: "800", Income_Tax: "2000", Net_Pay: "8000"));
            employee.Add(new EmpModel(Id: 7, Name: "Rogers", Age: 12, Salary: 6000, StartDate: DateTime.Now, Gender: "M", PhoneNumber: "9001234567", Department: "sales", Deductions: "900", Taxable_Pay: "900", Income_Tax: "1200", Net_Pay: "2000"));
            employee.Add(new EmpModel(Id: 8, Name: "Natasha", Age: 53, Salary: 7000, StartDate: DateTime.Now, Gender: "F", PhoneNumber: "9001234568", Department: "Sales", Deductions:"600", Taxable_Pay: "600", Income_Tax: "1000", Net_Pay: "1000"));
            employee.Add(new EmpModel(Id: 9, Name: "Steve", Age: 14, Salary: 3000, StartDate: DateTime.Now, Gender: "M", PhoneNumber: "9001234569", Department: "Telecom", Deductions: "500", Taxable_Pay: "500", Income_Tax: "1500", Net_Pay: "4000"));
            employee.Add(new EmpModel(Id: 10, Name: "Romanoff", Age:19, Salary: 8000, StartDate: DateTime.Now, Gender: "F", PhoneNumber: "9001234599", Department: "Marketing", Deductions: "200", Taxable_Pay: "200", Income_Tax: "1200", Net_Pay: "3000"));

            Operation opera = new Operation();
            DateTime startDateTime = DateTime.Now;
            opera.addEmployeePayRoll(employee);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration Without Thread : " + (stopDateTime-startDateTime));

            DateTime startDateTimeThread = DateTime.Now;
            opera.addEmployeeToPayrollWithThread(employee);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration Without Thread : " + (stopDateTimeThread - startDateTimeThread));
        }
    }
}