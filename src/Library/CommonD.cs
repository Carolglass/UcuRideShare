namespace PII_Herencia
{
    public class CommonDriver:Driver
    {
        public CommonDriver(string ID, string name, string surename, string vehicle, string bio, int maxCapacity): base (ID, name, surename, vehicle,bio, maxCapacity)
        {
            if (this.MaxCapacity>1)
            {
                Console.WriteLine("La capacidad de pasajeros para la categoria Common Driver siempre será 1");
                this.MaxCapacity=1;
            }

        }
        
    }
}