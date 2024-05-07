using KCheck2;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


    Console.WriteLine("How many records do you want to add? ");

    var numberOfRecords = int.Parse(Console.ReadLine());

    var recordList = new Tests();

    for (int i = 0; i < numberOfRecords; i++)
    {

        var tests = new Tests();

        Console.WriteLine("Enter the name of horse ");

        tests.Name = Console.ReadLine();

        Console.WriteLine("Enter the breed of horse ");

        tests.Breed = Console.ReadLine();

        Console.WriteLine("Enter the sex of horse ");

        tests.Sex = Console.ReadLine();

        Console.WriteLine("Enter the height of horse (in hands)");

        tests.Height = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the enrolling class ");

        tests.ClassTest = Console.ReadLine();

        Console.WriteLine("Do you wish to qualify the score? ");

        tests.QualifyingScore = (Console.ReadLine() == "Y");

        recordList.Add(Tests);

    }
