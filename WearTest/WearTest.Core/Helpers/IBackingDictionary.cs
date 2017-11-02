using System.Runtime.CompilerServices;

namespace WearTest.Core.Helpers
{
    public interface IBackingDictionary
    {
        T GetPropertyValue<T>([CallerMemberName] string propertyName = null);
        bool SetPropertyValue<T>(T newValue, [CallerMemberName] string propertyName = null);
    }
}
