using AutoMapper;
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
            private readonly IWcfService _wcfService;
            private readonly IMapper _mapper;

            public SubmitCommand(MainWindowViewModel viewModel, IWcfService wcfService, IMapper mapper)
            {
                _viewModel = viewModel;
                _wcfService = wcfService;
                _mapper = mapper;

                _viewModel.NewFarkle.PropertyChanged += (sender, e) =>
                {
                    if (e.PropertyName == nameof(FarkleViewModel.Name))
                        OnCanExecuteChanged();
                };
            }

            public override void Execute(object parameter)
            {
                var request = _mapper.Map<CreateFarkleRequest>(_viewModel.NewFarkle);
                var response = _wcfService.CreateFarkle(request);

                if (response.IsSuccess)
                {
                    var farkleViewModel = _mapper.Map<FarkleViewModel>(response.NewFarkle);
                    _viewModel.SubmittedFarkles.Add(farkleViewModel);

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
            private readonly IWcfService _wcfService;

            public RemoveCommand(MainWindowViewModel viewModel, IWcfService wcfService)
            {
                _viewModel = viewModel;
                _wcfService = wcfService;
            }

            public override void Execute(object parameter)
            {
                var farkle = (FarkleViewModel)parameter;
                _wcfService.RemoveFarkle(farkle.Id);
                _viewModel.SubmittedFarkles.Remove(farkle);
            }
        }
    }
}
