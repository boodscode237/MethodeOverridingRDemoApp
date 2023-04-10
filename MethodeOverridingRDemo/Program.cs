using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeOverridingRDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel 
            { 
                FirstName = "mail",
                LastName = "list",
                Email = "mail@list.ru",
            };
            Console.WriteLine(person.ToString());
            Console.ReadLine();
        }
    }

    public abstract class Car
    {
        public virtual void StartCar() // by doing so you make the method overridable
        {
            Console.WriteLine("Turn Key and start");
        }

        public abstract void SetClock(); // by doing so you oblige the daughter class to implement this method
    }

    public class Corolla : Car
    {
        public override void SetClock()
        {
            Console.WriteLine("Set clock"); 
        }
    }

    public class Tesla : Car
    {
        public override void StartCar()
        {
            Console.WriteLine("Just sit and say hello tesla");
        }

        public override void SetClock()
        {
            Console.WriteLine("From internet");
        }
    }
}
