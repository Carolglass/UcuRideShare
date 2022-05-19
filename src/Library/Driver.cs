using System;
using System.Collections;
namespace PII_Herencia
{
    public class Driver:Person
    {
        protected string Vehicle {get; set;}
        protected string Bio {get; set;}
        protected int MaxCapacity {get; set;}
       
        public Driver(string ID, string name, string surename, string vehicle, string bio): base (ID, name, surename)
        {

            this.Vehicle=vehicle;
            this.Bio=bio;
            this.MaxCapacity=1;
        }

        private IList passengersOnBoard = new ArrayList();

        public void takePassenger(Person pas)
        {
            if (passengersOnBoard.Count <= this.MaxCapacity)
            {
                passengersOnBoard.Add(pas);
                Console.WriteLine("OK! Ha tomado el Ride");
            }
            else
            {
                Console.WriteLine($"El móvil de {this.Name}{this.Surename} ya llegó a la capacidad máxima");
            }
        }

        public void leavePassenger(Passenger pas)
        {
            passengersOnBoard.Remove(pas);
            Console.WriteLine($"Ha dejado a {pas.Name}{pas.Surename}");
        }
    }
}