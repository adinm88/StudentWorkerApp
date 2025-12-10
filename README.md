# StudentWorker weekly salary calculator

This application has a Student class and a StudentWorker class. It uses that hierarchy to calculate the weekly salary of a student worker based on validated input. The project includes a driver that collects the student worker information, has the business logic built in, and a full set of unit tests for verifying the CalculateWeeklyPay() method.

# Project purpose

The goal of this project is to demonstrate
* Class design
* Inheritance
* Method overriding with ToString()
* Input validation / implementing business logic
* Interaction with model classes using the driver
* Unit testing with xUnit
* Clean documentation

The user enters the information for the student worker, and the system redisplays that info along with their weekly salary

# How to run unit tests?
The unit tests test the CalculateWeeklyPay() method. They test Invalid hours (too low), Invalid hours (too high), Invalid hourly wage (too low), Invalid hourly wage (too high), and a Valid input test

In a command line, type "dotnet test" to run the unit tests.
Or in Visual Studio, build the solution and open Test Explorer, and click on run all to run the unit tests.

# Business logic?

* Hours worked:
    - Must be 1 to 15 hours per day

* Hourly pay
    - Must be $7.25 to $14.75
 
If any of these rules are violated, the weekly salary is set to $0




