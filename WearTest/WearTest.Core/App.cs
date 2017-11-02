using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using WearTest.Core.Helpers;
using WearTest.Core.ViewModels;

namespace WearTest.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            CreatableTypes().EndingWith("Repository").AsInterfaces().RegisterAsLazySingleton();
            CreatableTypes().EndingWith("Service").AsInterfaces().RegisterAsLazySingleton();

            Mvx.RegisterType<IBackingDictionary, BackingDictionary>();

            RegisterNavigationServiceAppStart<MainViewModel>();
        }
    }
}

