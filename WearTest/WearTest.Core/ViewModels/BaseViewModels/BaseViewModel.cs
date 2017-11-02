using System.Runtime.CompilerServices;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using MvvmCross.Localization;
using MvvmCross.Platform;
using WearTest.Core.Helpers;

namespace WearTest.Core.ViewModels.BaseViewModels
{
    public abstract class BaseViewModel : MvxViewModel, IBackingDictionary
    {
        #region Private properties

        private readonly IBackingDictionary _backingDictionaryHelper;

        #endregion

        #region Properties

        protected IMvxNavigationService NavigationService { get; }

        public IMvxLanguageBinder TextSource => new MvxLanguageBinder("", GetType().Name);

        #endregion

        #region Constructors

        protected BaseViewModel()
        {
            NavigationService = Mvx.Resolve<IMvxNavigationService>();
            _backingDictionaryHelper = Mvx.Resolve<IBackingDictionary>();
        }

        #endregion

        #region Backing Dictionary

        public T GetPropertyValue<T>([CallerMemberName] string propertyName = null)
        {
            return _backingDictionaryHelper.GetPropertyValue<T>(propertyName);
        }

        public bool SetPropertyValue<T>(T newValue, [CallerMemberName] string propertyName = null)
        {
            return _backingDictionaryHelper.SetPropertyValue(newValue, propertyName);
        }

        #endregion
    }

    public abstract class BaseViewModel<TParam> : MvxViewModel<TParam>, IBackingDictionary
        where TParam : class
    {
        #region Private properties

        private readonly IBackingDictionary _backingDictionaryHelper;

        #endregion

        #region Properties

        protected IMvxNavigationService NavigationService { get; }
        public IMvxLanguageBinder TextSource => new MvxLanguageBinder("", GetType().Name);

        #endregion

        #region Constructors

        protected BaseViewModel()
        {
            NavigationService = Mvx.Resolve<IMvxNavigationService>();
            _backingDictionaryHelper = Mvx.Resolve<IBackingDictionary>();
        }

        #endregion

        #region Backing Dictionary

        public T GetPropertyValue<T>([CallerMemberName] string propertyName = null)
        {
            return _backingDictionaryHelper.GetPropertyValue<T>();
        }

        public bool SetPropertyValue<T>(T newValue, [CallerMemberName] string propertyName = null)
        {
            return _backingDictionaryHelper.SetPropertyValue(newValue, propertyName);
        }

        #endregion
    }

    public abstract class BaseViewModel<TParam, TReturn> : MvxViewModel<TParam, TReturn>, IBackingDictionary
        where TParam : class
        where TReturn : class
    {
        #region Private properties

        private readonly IBackingDictionary _backingDictionaryHelper;

        #endregion

        #region Properties

        protected IMvxNavigationService NavigationService { get; }
        public IMvxLanguageBinder TextSource => new MvxLanguageBinder("", GetType().Name);

        #endregion

        #region Constructors

        protected BaseViewModel()
        {
            NavigationService = Mvx.Resolve<IMvxNavigationService>();
            _backingDictionaryHelper = Mvx.Resolve<IBackingDictionary>();
        }

        #endregion

        #region Backing Dictionary

        public T GetPropertyValue<T>([CallerMemberName] string propertyName = null)
        {
            return _backingDictionaryHelper.GetPropertyValue<T>(propertyName);
        }

        public bool SetPropertyValue<T>(T newValue, [CallerMemberName] string propertyName = null)
        {
            return _backingDictionaryHelper.SetPropertyValue(newValue, propertyName);
        }

        #endregion
    }
}