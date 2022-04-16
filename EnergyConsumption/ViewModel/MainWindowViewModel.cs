using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace EnergyConsumption.ViewModel
{

    internal class MainWindowViewModel : ViewModelBase
    {
        #region Fields
        private DateTime _today;
        private float _gas;
        private float _water;
        private float _electricity;
        #endregion

        #region Properties
        public DateTime Today 
        {
            get => _today; 
            set
            {
                if(_today != value)
                {
                    _today = value;
                    OnPropertyChanged(nameof(Today));
                }
            }
        } 
        public float Gas
        {
            get => _gas;
            set
            {
                if(_gas != value)
                {
                    _gas = value; 
                    OnPropertyChanged(nameof(Gas));
                }
            }
        }
        public float Water
        {
            get => _water;
            set
            {
                if(_water != value)
                {
                    _water = value;
                    OnPropertyChanged(nameof(Water));
                }
            }
        }
        public float Electricity
        {
            get => _electricity;
            set
            {
                if(_electricity != value)
                {
                    _electricity = value;
                    OnPropertyChanged(nameof(Electricity));
                }
            }
        }
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

        #region Constructor
        public MainWindowViewModel()
        {
            SetUpDelegateCommands();
        }
        #endregion

        #region Outsource Constructor Assignments
        private void SetUpDelegateCommands()
        {
            AddCommand = new DelegateCommand(AddInformation, CanAddInformation);
            RemoveCommand = new DelegateCommand(RemoveInformation, CanRemoveInformation);
            StoreInDatabaseCommand = new DelegateCommand(StoreInDatabase, CanStoreInDatabase);
            SaveAsCSVCommand = new DelegateCommand(SaveAsCSV, CanSaveAsCSV);
            ExitCommand = new DelegateCommand(Exit, CanExit);
        }
        #endregion

        #region Private Methods
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

        #region RaisePropertyChanged
        private void RaisePropertyChanged([CallerMemberName] string propname = "")
        {
            AddCommand.OnExecuteChanged();
            RemoveCommand.OnExecuteChanged();
            SaveAsCSVCommand.OnExecuteChanged();
            ExitCommand.OnExecuteChanged();
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
