using System;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello, World!");
    }
  }
}

// using System;
// using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> employees = new List<string>() { "adam", "amy" };
      employees.Add("barbara");
      employees.Add("billy");
      Console.WriteLine("Please enter a name: ");
      // Get a name from the console and assign it to a variable
      string input = Console.ReadLine();
      employees.Add(input);
      for (int i = 0; i < employees.Count; i++) 
      {
        Console.WriteLine(employees[i]);
      }
    }
  }
}

// static void Main(string[] args)
// {
//   List<string> employees = new List<string>();
//   Console.WriteLine("Please enter a name: ");
//   string input = Console.ReadLine();
//   employees.Add(input);
//   for (int i = 0; i < employees.Count; i++) 
//   {
//     Console.WriteLine(employees[i]);
//   }
// }

// static void Main(string[] args)
// {
//   List<string> employees = new List<string>();
//   // Collect user values until the value is an empty string
//   while (true)
//   {
//     Console.WriteLine("Please enter a name: ");
//     string input = Console.ReadLine();
//     employees.Add(input);
//   } 
//   for (int i = 0; i < employees.Count; i++) 
//   {
//     Console.WriteLine(employees[i]);
//   }
// }

// Console.Readline().

while (true)
{
  Console.WriteLine("Please enter a name: (leave empty to exit): ");
  string input = Console.ReadLine();
  // Break if the user hits ENTER without typing a name
  if (input == "") 
  {
    break;
  }
  employees.Add(input);
}

static List<string> GetEmployees()
{
  // I will return a List of strings
}

static List<string> GetEmployees()
{
  List<string> employees = new List<string>();
  while (true) 
  {
    Console.WriteLine("Please enter a name: (leave empty to exit): ");
    string input = Console.ReadLine();
    if (input == "") 
    {
      break;
    }

    employees.Add(input);
  }
  // This is important!
  return employees;
}

static void Main(string[] args)
{
  // This is our employee-getting code now
  List<string> employees = GetEmployees();

  for (int i = 0; i < employees.Count; i++) 
  {
    Console.WriteLine(employees[i]);
  }
}

static List<string> GetEmployees()
{
  List<string> employees = new List<string>();
  while (true) 
  {
    Console.WriteLine("Please enter a name: (leave empty to exit): ");
    string input = Console.ReadLine();
    if (input == "") 
    {
      break;
    }
      
    employees.Add(input);
  }
  // This is important!
  return employees;
}

List<string> employees = new List<string>();

static void PrintEmployees(List<string> employees)
{
  for (int i = 0; i < employees.Count; i++) 
  {

    Console.WriteLine(employees[i]);

  }
}

class Program
{
  static List<string> GetEmployees()
  {
    List<string> employees = new List<string>();
    while (true)
    {

      Console.WriteLine("Please enter a name: (leave empty to exit): ");

      string input = Console.ReadLine();

      if (input == "")
      {
        break;
      }
      employees.Add(input);
    }
    return employees;
  }

  static void PrintEmployees(List<string> employees)
  {
    for (int i = 0; i < employees.Count; i++)
    {
      Console.WriteLine(employees[i]);
    }
  }

  static void Main(string[] args)
  {
    List<string> employees = GetEmployees();
    PrintEmployees(employees);
  }
}

// Employee</td>
//     <td></td>
//   </tr>
//   <tr>
//     <td>string</td>
//     <td>First Name</td>
//   </tr>
//   <tr>
//     <td>string</td>
//     <td>Last Name</td>
//   </tr>
//   <tr>
//     <td>integer</td>
//     <td>Id</td>
//   </tr>
//   <tr>
//     <td>string</td>
//     <td>Photo URL

namespace CatWorx.BadgeMaker
{
  class Employee
  {
    // more to come!
  }
}

// dataType variableName = value

// ____?____ currentEmployee = new Employee();

while (true)
{
  Console.WriteLine("Please enter a name: (leave empty to exit): ");
  string input = Console.ReadLine();
  if (input == "")
  {
    break;
  }

  // Create a new Employee instance
  Employee currentEmployee = new Employee();
  employees.Add(input);
}

class Employee
{
  string FirstName;
}