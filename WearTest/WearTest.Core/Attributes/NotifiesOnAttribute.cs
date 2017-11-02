using System;

namespace WearTest.Core.Attributes
{
    /// <summary>
    /// This attribute is used to declare that a property should raise a notification
    /// when an independent property is raising a notification.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class NotifiesOnAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifiesOnAttribute"/> class.
        /// </summary>
        /// <param name="name">The name of the independent property.</param>
        /// <exception cref="ArgumentNullException"><paramref name="name"/> is null.</exception>
        public NotifiesOnAttribute(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// The name of the independent property.
        /// </summary>
        public string Name { get; private set; }
    }
}