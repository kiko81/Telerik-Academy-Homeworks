﻿/*
Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
*/

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Company name: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Company address: ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.WriteLine("Website: ");
        string webSite = Console.ReadLine();
        Console.WriteLine("Manager's first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Manager's last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Manager's age: ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Manager's phone number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", faxNumber);
        Console.WriteLine("Web Site: {0}", webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, managerPhone);
    }
}