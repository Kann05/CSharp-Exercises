public abstract class BaseEmployee
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public string EmployeeAddress { get; set; }

    public BaseEmployee(int employeeId, string employeeName, string employeeAddress)
    {
        EmployeeID = employeeId;
        EmployeeName = employeeName;
        EmployeeAddress = employeeAddress;
    }

    public abstract void Show();

    public abstract void CalculateSalary(int workHours);

    public abstract void GetDepartment();
}

public class FullTimeEmployee : BaseEmployee
{
    public string EmployeePosition {get; set;}
    public string EmployeeDepartment {get; set;}

    
    public FullTimeEmployee(int employeeId, string employeeName, string employeeAddress, string employeePosition, string employeeDepartment)
        : base(employeeId, employeeName, employeeAddress)
    {
        EmployeePosition = employeePosition;
        EmployeeDepartment = employeeDepartment;
    }

    public override void Show()
    {
        System.Console.WriteLine($"Employee Id: {EmployeeID}");
        System.Console.WriteLine($"Employee Name: {EmployeeName}");
        System.Console.WriteLine($"Employee Address: {EmployeeAddress}");
        System.Console.WriteLine($"Employee Position: {EmployeePosition}");
        System.Console.WriteLine($"Employee Department: {EmployeeDepartment}");
    }

    public override void CalculateSalary(int workHours)
    {
        workHours = 250 + workHours * 1080;

        System.Console.WriteLine($"Monthly Salary: {workHours}");
    }

    public override void GetDepartment()
    {
        System.Console.WriteLine($"Employee Department: {EmployeeDepartment}");
    }

}

public class ContractEmployee : FullTimeEmployee
{
    public string EmployeeTask {get; set;}
    public ContractEmployee(int employeeId, string employeeName, string employeeAddress, string employeePosition, string employeeDepartment, string employeeTask)
        : base(employeeId, employeeName, employeeAddress, employeePosition, employeeDepartment)
    {
        EmployeeTask = employeeTask;
    }

    public override void Show()
    {
        System.Console.WriteLine($"Employee Id: {EmployeeID}");
        System.Console.WriteLine($"Employee Name: {EmployeeName}");
        System.Console.WriteLine($"Employee Address: {EmployeeAddress}");
        System.Console.WriteLine($"Employee Position: {EmployeePosition}");
        System.Console.WriteLine($"Employee Department: {EmployeeDepartment}");
        System.Console.WriteLine($"Employee Task: {EmployeeTask}");
    }

    public override void CalculateSalary(int workHours)
    {
        workHours = 250 + workHours * 1080;

        System.Console.WriteLine($"Monthly Salary: {workHours}");
    }

    public override void GetDepartment()
    {
        System.Console.WriteLine($"Employee Department: {EmployeeDepartment}");
    }
    
}

class Program
{
    public static void Main()
    {
      FullTimeEmployee fullEmployee = new FullTimeEmployee(1, "John", "Debree Street", "Programmer", "Web Development");
      fullEmployee.Show();
      fullEmployee.CalculateSalary(20);

      ContractEmployee contractEmployee = new ContractEmployee(2, "Sam", "Groove Street", "Programmer", "Game Development", "Design Abillities");
      contractEmployee.Show();
      contractEmployee.CalculateSalary(35);
    }
}
