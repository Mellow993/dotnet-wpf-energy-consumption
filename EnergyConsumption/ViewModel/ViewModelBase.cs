using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace EnergyConsumption.ViewModel
{
    internal class ViewModelBase : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected ViewModelBase() { }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposeManagedResources) { }

        protected virtual void OnPropertyChanged([CallerMemberName] string propname = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propname));
    }
}
