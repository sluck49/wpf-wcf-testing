using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfClient.Command;
using WpfClient.WcfServiceReference;

namespace WpfClient.ViewModels
{
    public class FarkleViewModel : ViewModelBase
    {
        private string _name = "";
        public string Name
        {
            get { return _name; }
            set
            {
                SetValue(nameof(Name), value, () => _name = value);
            }
        }
        private string _description = "";
        public string Description
        {
            get { return _description; }
            set
            {
                SetValue(nameof(Description), value, () => _description = value);
            }
        }

        private bool _isFarked;
        public bool IsFarked
        {
            get { return _isFarked; }
            set
            {
                SetValue(nameof(IsFarked), value, () => _isFarked = value);
            }
        }
    }

    public class MainWindowViewModel : ViewModelBase
    {
        public FarkleViewModel NewFarkle { get; } 

        public ObservableCollection<FarkleViewModel> SubmittedFarkles { get; set; } = new ObservableCollection<FarkleViewModel>();

        public MainWindowCommands.SubmitCommand SubmitCommand { get; }
        public MainWindowCommands.RemoveCommand RemoveCommand { get; }
        
        public MainWindowViewModel(FarkleViewModel newFarkleViewModel, IWcfService wcfService)
        {
            NewFarkle = newFarkleViewModel;
            SubmitCommand = new MainWindowCommands.SubmitCommand(this, wcfService);
            RemoveCommand = new MainWindowCommands.RemoveCommand(this);
        }
    }
}
