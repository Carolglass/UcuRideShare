using System;
using System.Collections;

namespace PII_Herencia
{
    public class Person
    {
        // Static field currentID stores the user ID of the last Person that
        // has been created.
        private static int currentID;
                //Properties.
        public string ID { get; private set; }
        public string Name { get; private set; }
        public string Surename { get; private set; }
        public int Calification { get; set; }


        private IList users = new ArrayList();
        // Default constructor. If a derived class does not invoke a base-
        // class constructor explicitly, the default constructor is called
        // implicitly.
        public Person(string Id, string name, string surename)
        {
        this.ID= Id;
        this.Name=name;
        this.Surename=surename;

        }

        // Static constructor to initialize the static member, currentID. This
        // constructor is called one time, automatically, before any instance
        // of Person or Passenger or Driver is created, or currentID is referenced.
        static Person() => currentID = 0;

        // currentID is a static field. It is incremented each time a new
        // instance of Person is created.
        protected int GetNextID() => ++currentID;

    }
}
