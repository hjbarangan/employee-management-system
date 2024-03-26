## Problem: Employee Management System

You are tasked with creating an Employee Management System in C#. The system should include classes and functionalities related to employees.

Requirements:

    1. Create an Employee class with the following properties:
        EmployeeId (int)
        FirstName (string)
        LastName (string)
        Salary (double)

    2. Implement a parameterized constructor in the Employee class to initialize the properties.

    3. Create an EmployeeManager class that manages a list of employees. 
        It should have the following functionalities:
         * Add an employee to the list.
         * Remove an employee from the list based on the employee ID.
         * Display the details (ID, Name, Salary) of all employees.
         * Calculate and display the total salary of all employees.

    4. Implement a base class Person with properties FirstName and LastName. 
       Derive the Employee class from the Person class.

    5. Implement a static member in the Employee class to keep track of the total number of employees created.

    6. Create an Enum named Department with values representing different departments (e.g., IT, HR, Finance).

    7. Modify the Employee class to include a property Department of type Department.

    8. Implement a destructor in the Employee class to display a message when an employee object is destroyed.

    9. Create an interface IManager with a method AssignEmployeeToDepartment that takes an 
        employee and a department as parameters. Implement this interface in the EmployeeManager class.

    10. Demonstrate the functionalities of the Employee Management System by creating instances of the Employee 
        and EmployeeManager classes and performing operations like adding, removing, and displaying employees.

Constraints:

    Ensure that the Employee ID is unique for each employee.
    Use appropriate encapsulation techniques.
    Test the functionalities to showcase inheritance, static members, destructor, and interface implementation.
