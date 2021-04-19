using System;


namespace NvwaFactory
{
    class Program
    {
        static void Main()
        {
            IPerson person;
            person = Factory.GetPerson("M");
            person = Factory.GetPerson("W");
            person = Factory.GetPerson("R");
            Console.Read();
        }
    }
}
