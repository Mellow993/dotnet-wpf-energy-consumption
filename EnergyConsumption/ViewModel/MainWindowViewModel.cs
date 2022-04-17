using EnergyConsumption.Common;
using EnergyConsumption.Model;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;

namespace EnergyConsumption.ViewModel
{

    internal class MainWindowViewModel : ViewModelBase
    {
        #region Fields
        private DateTime _today;
        private float _gas;
        private float _water;
        private float _electricity;
        private string _result;
        #endregion

        #region Properties
        public string Result 
        {
            get => _result;
            set
            { 
                if(_result != value)
                {
                    _result = value;
                    OnPropertyChanged(nameof(Result));
                }
            }
        }
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
                if(_gas != value && value > 0)
                {
                    _gas = value; 
                    OnPropertyChanged(nameof(Gas));
                    RaisePropertyChanged();
                }
            }
        }
        public float Water
        {
            get => _water;
            set
            {
                if(_water != value && value > 0)
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
                if(_electricity != value && value > 0)
                {
                    _electricity = value;
                    OnPropertyChanged(nameof(Electricity));
                }
            }
        }
        public EnergyModel EnergyModel { get; private set; }
        public CompareModel CompareModel { get; private set; }
        public Messages Messages { get; private set; }
        #endregion

        #region Events
        public event EventHandler? EntryAdded;
        //public event EventHandler secondEvent;
        //public event EventHandler thridEvent;
        #endregion

        #region DelegateCommands
        public DelegateCommand AddCommand { get; private set; }
        public DelegateCommand RemoveCommand { get; private set; }
        public DelegateCommand SaveAsCSVCommand { get; private set; }
        public DelegateCommand StoreInDatabaseCommand { get; private set; }
        public DelegateCommand ResetCommand { get; private set; }
        public DelegateCommand ExitCommand { get; private set; }
        #endregion

        #region Constructor
        public MainWindowViewModel()
        {
            SetUpDelegateCommands();
            CreateObjects();
            SubscribeToEvents();
        }
        #endregion

        #region Outsource Constructor Assignments
        private void SetUpDelegateCommands()
        {
            AddCommand = new DelegateCommand(AddInformation, CanAddInformation);
            RemoveCommand = new DelegateCommand(RemoveInformation, CanRemoveInformation);
            StoreInDatabaseCommand = new DelegateCommand(StoreInDatabase, CanStoreInDatabase);
            SaveAsCSVCommand = new DelegateCommand(SaveAsCSV, CanSaveAsCSV);
            ResetCommand = new DelegateCommand(Reset, CanReset);
            ExitCommand = new DelegateCommand(Exit, CanExit);
        }

        private void CreateObjects()
        {
            Messages = new Messages();
        }

        private void SubscribeToEvents()
        {
            EntryAdded += Messages.OnEntriesAdded;
        }
        #endregion

        #region Private Methods
        private void AddInformation()
        {
            EnergyModel = new EnergyModel(Gas, Water, Electricity, Today);
            Result = EnergyModel.ReturnInputs();
            EntryAdded?.Invoke(this, EventArgs.Empty);
            //MessageBox.Show(EnergyModel.ReturnInputs());
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
        private void Reset()
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
            ResetCommand.OnExecuteChanged();
            ExitCommand.OnExecuteChanged();
        } 
        #endregion

        #region CanExecute
        private bool CanAddInformation() => true;
        private bool CanRemoveInformation() => true;
        private bool CanStoreInDatabase() => true;
        private bool CanSaveAsCSV() => true;
        private bool CanReset() => true;
        private bool CanExit() => true;
        #endregion
    }
}
