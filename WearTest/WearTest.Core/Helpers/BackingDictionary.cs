using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using MvvmCross.Core.ViewModels;

namespace WearTest.Core.Helpers
{
    public class BackingDictionary : MvxNotifyPropertyChanged, IBackingDictionary
    {
        #region Private Properties

        private readonly Dictionary<string, object> _propertyBackingDictionary;

        #endregion

        #region Constructor

        public BackingDictionary()
        {
            _propertyBackingDictionary = new Dictionary<string, object>();
        }

        #endregion

        #region Backing Dictionary

        public T GetPropertyValue<T>([CallerMemberName] string propertyName = null)
        {
            if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));

            object value;
            if (_propertyBackingDictionary.TryGetValue(propertyName, out value))
            {
                return (T)value;
            }

            return default(T);
        }

        public bool SetPropertyValue<T>(T newValue, [CallerMemberName] string propertyName = null)
        {
            if (propertyName == null) throw new ArgumentNullException(nameof(propertyName));
            var propertyChanged = !EqualityComparer<T>.Default.Equals(newValue, GetPropertyValue<T>(propertyName));


            _propertyBackingDictionary[propertyName] = newValue;
            if (propertyChanged)
                RaisePropertyChanged(propertyName);
            return propertyChanged;
        }

        #endregion Backing Dictionary
    }
}
