using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfClient.Command;

namespace WpfClient.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _enteredText = "";
        public string EnteredText
        {
            get { return _enteredText; }
            set
            {
                SetValue(nameof(EnteredText), value, () => _enteredText = value);
            }
        }

        public ObservableCollection<string> SubmittedValues { get; set; } = new ObservableCollection<string>();

        public MainWindowCommands.SubmitCommand SubmitCommand { get; }
        public MainWindowCommands.RemoveCommand RemoveCommand { get; }
        
        public MainWindowViewModel()
        {
            SubmitCommand = new MainWindowCommands.SubmitCommand(this);
            RemoveCommand = new MainWindowCommands.RemoveCommand(this);
        }
    }
}
