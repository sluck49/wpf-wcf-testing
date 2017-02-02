using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfClient.Command;

namespace WpfClient
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _enteredText = "";
        public string EnteredText
        {
            get { return _enteredText; }
            set
            {
                var changed = _enteredText != value;
                _enteredText = value;
                if (changed)
                {
                    OnPropertyChanged(nameof(EnteredText));
                }
            }
        }

        public ObservableCollection<string> SubmittedValues { get; set; } = new ObservableCollection<string>();

        public MainWindowCommands.SubmitCommand SubmitCommand { get; }
        public MainWindowCommands.RemoveCommand RemoveCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindowViewModel()
        {
            SubmitCommand = new MainWindowCommands.SubmitCommand(this);
            RemoveCommand = new MainWindowCommands.RemoveCommand(this);
        }
    }
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
