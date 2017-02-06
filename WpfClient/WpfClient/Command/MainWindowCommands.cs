using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfClient.ViewModels;
using WpfClient.WcfServiceReference;

namespace WpfClient.Command
{
    public class MainWindowCommands
    {
        public class SubmitCommand : CommandBase
        {
            private readonly MainWindowViewModel _viewModel;
            private IWcfService _wcfService;

            public SubmitCommand(MainWindowViewModel viewModel, IWcfService wcfService)
            {
                _viewModel = viewModel;
                _wcfService = wcfService;
                _viewModel.NewFarkle.PropertyChanged += (sender, e) =>
                {
                    if (e.PropertyName == nameof(FarkleViewModel.Name))
                        OnCanExecuteChanged();
                };
            }

            public override void Execute(object parameter)
            {
                var response = _wcfService.CreateFarkle(new CreateFarkleRequest()
                {
                    Name = _viewModel.NewFarkle.Name,
                    Description = _viewModel.NewFarkle.Description,
                    IsFarked = _viewModel.NewFarkle.IsFarked
                });

                if (response.IsSuccess)
                {
                    _viewModel.SubmittedFarkles.Add(new FarkleViewModel()
                    {
                        Name = response.NewFarkle.Name,
                        Description = response.NewFarkle.Description,
                        IsFarked = response.NewFarkle.IsFarked,
                    });

                    _viewModel.NewFarkle.Name = "";
                    _viewModel.NewFarkle.Description = "";
                    _viewModel.NewFarkle.IsFarked = false;
                    _viewModel.ErrorText = "";
                }
                else
                {
                    _viewModel.ErrorText = response.FailureReason;
                }
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
