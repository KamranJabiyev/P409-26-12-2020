using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceIndexerExtention
{
    class Program
    {
        public enum Weekdays { Monday=1,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday};
        static void Main(string[] args)
        {
            #region Nullable value types
            //int a = 5;
            //bool isMaried = true;

            //int? x = null;
            //bool? isExist = null;
            //Print(null);
            #endregion

            #region Interface
            //IRun person = new Person();
            //Person person1 = new Person();
            //Person p1 = new Person("Pervin",24);
            //Person p2 = new Person("Anar", 20);
            //Person p3 = new Person("Ayten", 23);
            //Person p4 = new Person("Elvin", 19);

            //Person[] people ={ p1, p2, p3, p4 };
            //Array.Sort(people);
            //foreach (Person p in people)
            //{
            //    Console.WriteLine($"{p.Name}-{p.Age}");
            //}
            #endregion

            #region Enum - value
            //foreach (var item in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("1-7 arasi eded daxil edin:");
            //int number;
            //bool isNumber = int.TryParse(Console.ReadLine(),out number);
            //if (isNumber)
            //{
            //    switch (number)
            //    {
            //        case (int)Weekdays.Monday:
            //            Console.WriteLine("Monday");
            //            break;
            //        case (int)Weekdays.Tuesday:
            //            Console.WriteLine("Tuesday");
            //            break;
            //        case (int)Weekdays.Wednesday:
            //            Console.WriteLine("Wednesday");
            //            break;
            //        default:
            //            Console.WriteLine("Other week day");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Eded daxil etmediniz");
            //}

            #endregion

            #region Extension
            //Console.WriteLine("Mail daxil edin:");
            //string mail = Console.ReadLine();
            //if (mail.IsEmail())
            //{
            //    Console.WriteLine("Mail dogrudur");
            //}
            //else
            //{
            //    Console.WriteLine("Duzgun mail daxil etmediniz");
            //}
            //int a = 10;
            //int b = 20;
            //int result = a.Sum(b);
            //Console.WriteLine($"Netice:{result}");
            double number = 5;
            double power = 3;
            /*Console.WriteLine(number.GetPower(power));*/  //-5 * 5 * 5 = 125 - 25
            Console.WriteLine(Math.Pow(number, power));
            #endregion
        }

        //static bool IsEmail(string mail)
        //{
        //    try
        //    {
        //        MailAddress address = new MailAddress(mail);
        //        return true;
        //    }
        //    catch (Exception)
        //    {

        //        return false;
        //    }
            
        //}

        #region Nullable value types
        public static void Print(int? n)
        {
            if (n == null)
            {
                Console.WriteLine("Deyer null-dir");
                return;
            }
            Console.WriteLine(n);
        }
        #endregion
    }

    #region Interface
    //class X
    //{

    //}
    //interface IRun
    //{
    //    void Run();
    //    string Fullname(string name, string surname);
    //}

    //interface ITest
    //{
    //    void Test();
    //}

    //class Person : X,IRun,ITest,IComparable
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public Person(string name,int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }
    //    public string Fullname(string name, string surname)
    //    {
    //        return $"{name} {surname}";
    //    }

    //    public void Run()
    //    {
    //        Console.WriteLine("Run as person");
    //    }

    //    public void Test()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int CompareTo(object obj)
    //    {
    //        return Age.CompareTo(((Person)obj).Age);
    //    }
    //}
    #endregion
}
