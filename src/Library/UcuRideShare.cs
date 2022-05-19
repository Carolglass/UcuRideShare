using System;
using System.Collections;


namespace PII_Herencia
{
    public class UcuRideShare
    {
        private IList Users = new ArrayList();
        public UcuRideShare()
        {
        }

        public void Add(Person NewUser)
        {
            if (!Users.Contains(NewUser))
            {
                Users.Add(NewUser);
                Console.WriteLine($"Se ha registrado a {NewUser.Name} {NewUser.Surename}");
            }
            else
            {
                Console.WriteLine("El usuario ya está registrado en UcuRideShare");
            }

        }
    }
}