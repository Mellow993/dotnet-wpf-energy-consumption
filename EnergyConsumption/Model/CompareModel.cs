using EnergyConsumption.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnergyConsumption.Model
{
    internal class CompareModel : ICompare
    {
        private readonly EnergyModel _engergyModelNew;
        private readonly EnergyModel _engergyModelOld;
        internal CompareModel(EnergyModel energymodelnew, EnergyModel energymodelold)
        {
            _engergyModelNew = energymodelnew;
            _engergyModelOld = energymodelold;
        }

        void ICompare.CompareObjects()
        {
            var gasDifference = _engergyModelNew.Gas - _engergyModelOld.Gas;
            var waterDifference = _engergyModelNew.Water - _engergyModelOld.Water;
            var electricityDifference = _engergyModelNew.Electricity - _engergyModelOld.Electricity;
        }
    }
}
