using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace EnergyConsumption.Common
{
    internal class Messages : EventArgs
    {
        internal void OnEntriesAdded(object sender, EventArgs e)
        {
            MessageBox.Show("Entries has been added");
        }
    }
}
