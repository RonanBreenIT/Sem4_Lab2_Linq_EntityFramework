using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Linq_and_EntityFramework
{
    public class Car
    {
        private string make;
        private string model;
        private string registration;
        private int cc;

        public string Make { get { return this.make; } }

        public string Model { get { return this.model; } }
        public string Registration { get { return this.registration; } }
        public int CC { get { return this.cc; } }

        public List<Car> Fleet;

        public Car(string _make, string _model, string _reg, int _cc)
        {
            this.make = _make;
            this.model = _model;
            this.registration = _reg;
            this.cc = _cc;

        }

        public override string ToString()
        {
            return "\nMake: " + this.Make + "\nModel: " + this.Model + "\nRegistration: " + this.Registration + "\nCC: " + this.CC;

        }
    }
}
