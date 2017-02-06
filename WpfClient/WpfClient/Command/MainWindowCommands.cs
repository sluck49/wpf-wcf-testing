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
                _viewModel.NewFarkle.PropertyChanged += (sender, e) =>
                {
                    if (e.PropertyName == nameof(FarkleViewModel.Name))
                        OnCanExecuteChanged();
                };
            }

            public override void Execute(object parameter)
            {
                _viewModel.SubmittedFarkles.Add(new FarkleViewModel()
                {
                    Name = _viewModel.NewFarkle.Name,
                    Description = _viewModel.NewFarkle.Description,
                    IsFarked = _viewModel.NewFarkle.IsFarked,
                });

                _viewModel.NewFarkle.Name = "";
                _viewModel.NewFarkle.Description = "";
                _viewModel.NewFarkle.IsFarked = false;
            }
            public override bool CanExecute(object parameter)
            {
                return !string.IsNullOrWhiteSpace(_viewModel.NewFarkle?.Name);
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
                _viewModel.SubmittedFarkles.Remove((FarkleViewModel)parameter);
            }
        }
    }
}
