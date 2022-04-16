using System;
using System.Collections.Generic;
using System.Text;

namespace EnergyConsumption.ViewModel
{

    internal class MainWindowViewModel : ViewModelBase
    {
        #region Fields

        #endregion

        #region Properties

        #endregion

        #region Events
        public event EventHandler firstEvent;
        public event EventHandler secondEvent;
        public event EventHandler thridEvent;
        #endregion
        #region DelegateCommands
        public DelegateCommand AddCommand { get; private set; }
        public DelegateCommand RemoveCommand { get; private set; }
        public DelegateCommand SaveAsCSVCommand { get; private set; }
        public DelegateCommand StoreInDatabaseCommand { get; private set; }
        public DelegateCommand ExitCommand { get; private set; }
        #endregion

        public MainWindowViewModel()
        {
            SetUpDelegateCommands();
        }

        private void SetUpDelegateCommands()
        {
            AddCommand = new DelegateCommand(AddInformation, CanAddInformation);
            RemoveCommand = new DelegateCommand(RemoveInformation, CanRemoveInformation);
            StoreInDatabaseCommand = new DelegateCommand(StoreInDatabase, CanStoreInDatabase);
            SaveAsCSVCommand = new DelegateCommand(SaveAsCSV, CanSaveAsCSV);
            ExitCommand = new DelegateCommand(Exit, CanExit);

        }

        #region MyRegion
        private void AddInformation()
        {
            throw new NotImplementedException();
        }        
        
        private void RemoveInformation()
        {
            throw new NotImplementedException();
        }      
        
        private void StoreInDatabase()
        {
            throw new NotImplementedException();
        }

        private void SaveAsCSV()
        {
            throw new NotImplementedException();
        }

        private void Exit()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region CanExecute
        private bool CanAddInformation() => true;
        private bool CanRemoveInformation() => true;
        private bool CanStoreInDatabase() => true;
        private bool CanSaveAsCSV() => true;
        private bool CanExit() => true;
        #endregion
    }
}
