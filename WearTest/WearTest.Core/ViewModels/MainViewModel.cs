using MvvmCross.Core.Navigation;
using WearTest.Core.ViewModels.BaseViewModels;

namespace WearTest.Core.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        #region Private Properties

        private readonly IMvxNavigationService _navigationService;

        #endregion

        #region Constructors

        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        #endregion
    }
}
