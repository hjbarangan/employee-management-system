using System;
using System.Collections.Generic;

// 4. Base class Person
class Person
{
    public string FirstName { get; }
    public string LastName { get; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

// 6. Enum Department
enum Department
{
    IT,
    HR,
    Finance
}

// 1. Employee class derived from Person
class Employee : Person
{
    private static int nextEmployeeId = 1; // Tracks the next available employee ID
    private readonly int employeeId; // Employee ID is read-only and can only be set once

    public double Salary { get; set; }
    public Department Department { get; set; }

    // 5. Static member to track total number of employees
    private static int totalEmployees = 0;

    // Constructor
    public Employee(string firstName, string lastName, double salary, Department department) : base(firstName, lastName)
    {
        employeeId = nextEmployeeId++; // Assigns the next available employee ID and increments it for the next employee
        Salary = salary;
        Department = department;
        totalEmployees++;
    }

    // Employee ID property
    public int EmployeeId
    {
        get { return employeeId; }
    }

    // Static method to get total number of employees
    public static int GetTotalEmployees()
    {
        return totalEmployees;
    }

    // Destructor
    ~Employee()
    {
        Console.WriteLine($"Employee {FirstName} {LastName} with ID {employeeId} is destroyed.");
    }
}

// 9. Interface IManager
interface IManager
{
    void AssignEmployeeToDepartment(Employee employee, Department department);
}

// 3. EmployeeManager class
class EmployeeManager : IManager
{
    private List<Employee> employees = new List<Employee>();

    // Add an employee to the list
    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    // Remove an employee from the list based on employee ID
    public void RemoveEmployee(int employeeId)
    {
        employees.RemoveAll(emp => emp.EmployeeId == employeeId);
    }

    // Display details of all employees
    public void DisplayEmployees()
    {
        Console.WriteLine("Employee Details:");
        foreach (var employee in employees)
        {
            Console.WriteLine($"ID: {employee.EmployeeId}, Name: {employee.FirstName} {employee.LastName}, Salary: {employee.Salary}, Department: {employee.Department}");
        }
    }

    // Calculate and display total salary of all employees
    public void DisplayTotalSalary()
    {
        double totalSalary = 0;
        foreach (var employee in employees)
        {
            totalSalary += employee.Salary;
        }
        Console.WriteLine($"Total Salary of all employees: {totalSalary}");
    }

    // 9. Implementing IManager interface method
    public void AssignEmployeeToDepartment(Employee employee, Department department)
    {
        employee.Department = department;
        Console.WriteLine($"Employee {employee.FirstName} {employee.LastName} assigned to {department} department.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 10. Demonstration
        EmployeeManager manager = new EmployeeManager();

        // Adding employees
        Employee employee1 = new Employee("John", "Doe", 50000, Department.IT);
        manager.AddEmployee(employee1);

        Employee employee2 = new Employee("Jane", "Smith", 60000, Department.HR);
        manager.AddEmployee(employee2);

        Employee employee3 = new Employee("Tom", "Brown", 55000, Department.Finance);
        manager.AddEmployee(employee3);

        // Displaying employees
        manager.DisplayEmployees();

        // Displaying total salary
        manager.DisplayTotalSalary();

        // Removing an employee
        manager.RemoveEmployee(employee2.EmployeeId);
        Console.WriteLine("Employee removed.");

        // Displaying employees after removal
        manager.DisplayEmployees();

        // Assigning employee to department
        Employee newEmployee = new Employee("Alice", "Johnson", 70000, Department.IT);
        manager.AssignEmployeeToDepartment(newEmployee, Department.Finance);

        // Displaying employees after department assignment
        manager.DisplayEmployees();

        // Demonstrating total number of employees
        Console.WriteLine($"Total number of employees: {Employee.GetTotalEmployees()}");
    }
}
