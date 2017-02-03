using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfClient.ViewModels;

namespace WpfClient.Command
{
    public class MainWindowCommands
    {
        public class SubmitCommand : CommandBase
        {
            private readonly MainWindowViewModel _viewModel;

            public SubmitCommand(MainWindowViewModel viewModel)
            {
                _viewModel = viewModel;
                _viewModel.PropertyChanged += (sender, e) =>
                {
                    if (e.PropertyName == nameof(MainWindowViewModel.EnteredText))
                        OnCanExecuteChanged();
                };
            }

            public override void Execute(object parameter)
            {
                _viewModel.SubmittedValues.Add(_viewModel.EnteredText);
                _viewModel.EnteredText = "";
            }
            public override bool CanExecute(object parameter)
            {
                return !string.IsNullOrWhiteSpace(_viewModel.EnteredText);
            }
        }
        public class RemoveCommand : CommandBase
        {
            private readonly MainWindowViewModel _viewModel;

            public RemoveCommand(MainWindowViewModel viewModel)
            {
                _viewModel = viewModel;
            }

            public override void Execute(object parameter)
            {
                _viewModel.SubmittedValues.Remove(parameter?.ToString());
            }
        }
    }
}
