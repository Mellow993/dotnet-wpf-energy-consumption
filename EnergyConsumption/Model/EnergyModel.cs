using System;
using System.Collections.Generic;
using System.Text;

namespace EnergyConsumption.Model
{
    internal class EnergyModel
    {
        public double Gas { get; private set; }
        public double Water { get; private set; }
        public DateTime Today { get; private set; }
        public double Electricity { get; private set; }
        
        public EnergyModel(double gas, double water, double electricity, DateTime today)
        {
            Gas = gas;
            Water = water;
            Electricity = electricity;
            Today = today;
        }
        public string ReturnInputs()
        {
            return  Gas.ToString() + " " + Water.ToString() + " " + Electricity.ToString();
        }
    }
}
