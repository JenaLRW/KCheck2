using KCheck2;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


    Console.WriteLine("How many records do you want to add? ");

    var numberOfRecords = int.Parse(Console.ReadLine());

    var recordList = new Tests();

    for (int i = 0; i < numberOfRecords; i++)
    {

        var demographics = new Demographics();

        Console.WriteLine("Enter the name of horse ");

        demographics.Name = Console.ReadLine();

        Console.WriteLine("Enter the breed of horse ");

        demographics.Breed = Console.ReadLine();

        Console.WriteLine("Enter the sex of horse ");

        demographics.Sex = Console.ReadLine();

        Console.WriteLine("Enter the height of horse (in hands)");

        demographics.Height = double.Parse(Console.ReadLine());

        var tests = new Tests();

        Console.WriteLine("Enter the enrolling class ");

        tests.ClassTest = Console.ReadLine();

        Console.WriteLine("Do you wish to qualify the score? ");

        tests.QualifyingScore = (Console.ReadLine() == "Y");

        recordList.Add(Tests);

    }



//static void Main(string[] args)
//static means the method 'Main' belongs
//to the program class and not an object of the program class.  
//void means this method does not have a return value. 
//argument means when a parameter/value is passed to the method
//Name is a parameter/value and <Horse name> is an argument. 

//string name = Name.ToString();
//string breed = Breed.ToString();
//string sex = Sex.ToString();
//string height = Height.ToString();
//string classTests = ClassTests.ToString();
//string qualifyingScore = QualifyingScore.ToString();


//public override string ToString()

//{
//    return String.Format("Name : {0}");
//}





// Print out the list of records using Console.WriteLine()


