using System;
using System.Collections;


namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            UcuRideShare rideShare = new UcuRideShare();

            Driver carol= new CommonDriver("1","Carol","Glass","SHB-3032","Suele anda por pocitos");
            Person juan= new PoolDriver("49122568", "Juan", "Gomez", "SCB-1030", "Lleva no mas de 3",3);
            Person uno = new Passenger("26134720", "Uno","Perez");
            Person dos= new Passenger("26134720", "Dos","Gonzalez");
            Person tres= new Passenger("26134720", "Tres","Gonzalez");
            Person cuatro= new Passenger("26134720", "Cuatro","Fernandez");
            
            rideShare.Add(uno);
            
            Console.WriteLine(carol.Name);
            Console.WriteLine(carol.ID);


            carol.takePassenger(uno);


            var twitter = new TwitterImage();
            Console.WriteLine(twitter.PublishToTwitter("hey hey", @"bill2.jpg"));

            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!
            Usuario pasajero1 = nuevo Pasajero()
            Usuario pasajero2 = nuevo Pasajero()
            Usuario pasajero3 = nuevo Pasajero()
            Usuario conductor1 = nuevo Conductor()
            Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            UcuRideShare rideShare = nuevo UcuRideShare()
            
            rideShare.Add(conductor1)
            Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Twitter un nuevo conductor!
            
            rideShare.Add(pasajero1)
            Se publica en Twitter nuevo registro de pasajero!
            
            rideShare.Add(pasajero2)
            Se publica en Twitter nuevo registro de pasajero!
            rideShare.Add(pasajero3)
            Se publica en Twitter nuevo registro de pasajero!
            */
        }
    }
}