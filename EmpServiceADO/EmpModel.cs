using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpServiceADO
{
    public class EmpModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Department { get; set; }
        public decimal Deductions { get; set; }
        public decimal Taxable_Pay { get; set; }
        public decimal Income_Tax { get; set; }
        public decimal Net_Pay { get; set; }
        public string deductions { get; set; }
        public string taxable_Pay { get; set; }
        public string income_Tax { get; set; }
        public string net_Pay { get; set; }


        public EmpModel(int Id, string Name, int Age, int Salary, DateTime StartDate, string Gender, string PhoneNumber, 
            string Department, string Deductions, string Taxable_Pay, string Income_Tax, string Net_Pay)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
            this.Salary = Salary;
            this.StartDate = StartDate;
            this.Gender = Gender;
            this.PhoneNumber = PhoneNumber;
            this.Department = Department;
            this.deductions = Deductions;
            this.taxable_Pay = Taxable_Pay;
            this.income_Tax = Income_Tax;
            this.net_Pay = Net_Pay;
        }
        public EmpModel()
        {

        }
    }
}