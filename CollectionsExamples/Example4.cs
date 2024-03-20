using System.Collections;

namespace CollectionsExamples
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }

    }
    class Example4
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.EmpID = 101;
            emp1.EmpName = "Srikanth";
            emp1.Salary = 12345.67;

            //Employee emp2 = new Employee();
            //emp2.EmpID = 102;
            //emp2.EmpName = "Raju";
            //emp2.Salary = 33433.45;


            //object initilizers
            Employee emp2 = new Employee()
            {
                EmpID = 101,
                EmpName = "Raju",
                Salary = 23000
            };

            //Object Intilizer
            List<Employee> emps = new List<Employee>() { emp1, emp2 };

            //collection intilizer
            List<Employee> empList = new List<Employee>()
            {
                new Employee(){EmpID=101,EmpName="Srikanth",Salary=12345},
                new Employee(){EmpID=101,EmpName="Srikanth",Salary=12345},
                new Employee(){EmpID=101,EmpName="Srikanth",Salary=12345},
                new Employee(){EmpID=101,EmpName="Srikanth",Salary=12345},
                new Employee(){EmpID=101,EmpName="Srikanth",Salary=12345},
                new Employee(){EmpID=101,EmpName="Srikanth",Salary=12345},
                new Employee(){EmpID=101,EmpName="Srikanth",Salary=12345},
                new Employee(){EmpID=101,EmpName="Srikanth",Salary=12345}
            };
            Console.WriteLine("Elements of List are: ");
            foreach (var item in emps)
            {
                Console.WriteLine(item.EmpID + " " + item.EmpName + " " + item.Salary);

            }


}
    }
}
