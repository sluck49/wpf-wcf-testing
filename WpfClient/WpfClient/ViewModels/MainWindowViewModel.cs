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
    public class FarkleViewModel : ViewModelBase
    {
        private string _text = "";
        public string Text
        {
            get { return _text; }
            set
            {
                SetValue(nameof(Text), value, () => _text = value);
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

        public ObservableCollection<string> SubmittedValues { get; set; } = new ObservableCollection<string>();

        public MainWindowCommands.SubmitCommand SubmitCommand { get; }
        public MainWindowCommands.RemoveCommand RemoveCommand { get; }
        
        public MainWindowViewModel(FarkleViewModel newFarkleViewModel)
        {
            NewFarkle = newFarkleViewModel;
            SubmitCommand = new MainWindowCommands.SubmitCommand(this);
            RemoveCommand = new MainWindowCommands.RemoveCommand(this);
        }
    }
}
