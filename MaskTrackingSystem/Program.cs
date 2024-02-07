// See https://aka.ms/new-console-template for more information

using Entities.Concretes;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Program created;");

        Person person1 = new Person();

        person1.FirstName = "Test1";
        person1.LastName = "Test1";
        person1.NationalIdentity = 11111111111;
        person1.DateOfBirthYear = 1998;

        Person person2 = new Person();

        person2.FirstName = "Test2";
        person2.LastName = "Test1";
        person2.NationalIdentity = 22222222222;
        person2.DateOfBirthYear = 1999;

        Person person3 = new Person();

        person3.FirstName = "Test1";
        person3.LastName = "Test1";
        person3.NationalIdentity = 33333333333;
        person3.DateOfBirthYear = 2000;

    }
}
