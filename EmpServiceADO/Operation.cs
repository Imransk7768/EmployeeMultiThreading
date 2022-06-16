using System;
using EmpServiceADO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpServiceADO
{
    public class Operation
    {
        public List<EmpModel> empList = new List<EmpModel>();
        public void addEmployeePayRoll(List<EmpModel> empList)
        {
            empList.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being Added : " + employeeData.Name);
                this.empList.Add(employeeData);
                Console.WriteLine("Employee Added : " + employeeData.Name);
            });
            Console.WriteLine(this.empList.ToString());
        }
        public void addEmployeeToPayrollWithThread(List<EmpModel> empDataList)
        {
            empDataList.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                 {
                     Console.WriteLine("Employee being Added : " + employeeData.Name);
                     this.empList.Add(employeeData);
                     Console.WriteLine("Employee Added : " + employeeData.Name);
                 });
                thread.Start();
            });
            Console.WriteLine(this.empList.Count);
        }
    }
}