using KCheck2;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("How many records do you want to add? ");
    
int numberOfRecords = int.Parse(Console.ReadLine());

List<Scoring> recordList = new List<Scoring>();

for (int i = 0; i < numberOfRecords; i++)
{ 

    Scoring scoring = new Scoring();

    Console.WriteLine("Enter the name of horse ");

    scoring.Name = Console.ReadLine();

    Console.WriteLine("Enter the breed of horse ");

    scoring.Breed = Console.ReadLine();

    Console.WriteLine("Enter the sex of horse ");

    scoring.Sex = Console.ReadLine();

    Console.WriteLine("Enter the height of horse (in hands)");

    scoring.Height = double.Parse(Console.ReadLine());

    Console.WriteLine("Enter the enrolling class ");

    scoring.ClassTest = Console.ReadLine();

    Console.WriteLine("Do you wish to qualify the score? ");

    scoring.QualifyingScore = Console.ReadLine();

    bool result;

    if (scoring.QualifyingScore.ToLower() == "yes")
    {
        result = true;
    }
    else if (scoring.QualifyingScore.ToLower() == "no")
    {
        result = false;
    }
    else 
    {
        Console.WriteLine("Invalid input.  Please enter yes or no.");
        return;
    }

    recordList.Add(scoring);
}


    foreach (var scoring in recordList)
    {

        Console.WriteLine($"Name: {scoring.Name}, Breed: {scoring.Breed}, Sex: {scoring.Sex}, Height: {scoring.Height}, Enrolled class: {scoring.ClassTest}, Score qualifying: {scoring.QualifyingScore}");

    }

        
        
