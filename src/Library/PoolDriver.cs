using System;
using System.Collections;
namespace PII_Herencia
{
    public class PoolDriver:Driver
    {
        //protected int MaxCapacity {get; set;}
        public PoolDriver(string ID, string name, string surename, string vehicle, string bio, int maxCapacity): base (ID, name, surename, vehicle,bio)
        {
            this.MaxCapacity=maxCapacity;
        }
        
    }
}