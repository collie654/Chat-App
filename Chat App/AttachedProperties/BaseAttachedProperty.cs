using System;
using System.Windows;

namespace Chat_App
{
    /// <summary>
    /// a base attached property to replace the vanilla WPF attached property
    /// </summary>
    /// <typeparam name="Parent"> The parent class to be the attached property </typeparam>
    /// <typeparam name="Property"> The type of this attached property </typeparam>
    public abstract class BaseAttachedProperty<Parent, Property>
        where Parent : BaseAttachedProperty<Parent, Property>, new()
    {
        #region Public Events

        /// <summary>
        /// fired when the value changes
        /// </summary>
        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = (sender, e ) => { };

        /// <summary>
        /// fired when the value changes, even when the value is the same
        /// </summary>
        public event Action<DependencyObject, object> ValueUpdated = (sender, value) => { };


        #endregion

        #region Public Properties

        /// <summary>
        /// a singleton instance of our parent class
        /// </summary>
        public static Parent Instance { get; private set; } = new Parent();

        #endregion

        #region Attached Property Definitions

        /// <summary>
        /// the attached property for this class
        /// </summary>
        public static readonly DependencyProperty ValueProperty = DependencyProperty.RegisterAttached(
            "Value", 
            typeof(Property), 
            typeof(BaseAttachedProperty<Parent, Property>), 
                new PropertyMetadata(
                    default(Property),
                    new PropertyChangedCallback(OnValuePropertyChanged),
                    new CoerceValueCallback(OnValuePropertyUpdated)
                ));

        /// <summary>
        /// the callback event when the <see cref="ValueProperty"/> is changed, even if it is teh same value
        /// </summary>
        /// <param name="d"> the UI element that had it's property changed</param>
        /// <param name="e"> the arguments for the event</param>
        private static object OnValuePropertyUpdated(DependencyObject d, object value)
        {
            // Call the parent function
            Instance.OnValueUpdated(d, value);

            // call event listeners
            Instance.ValueUpdated(d, value);

            return value;
        }

        /// <summary>
        /// the callback event when the <see cref="ValueProperty"/> is changed
        /// </summary>
        /// <param name="d"> the UI element that had it's property changed</param>
        /// <param name="e"> the arguments for the event</param>
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Call the parent function
            Instance.OnValueChanged(d, e);

            // call event listeners
            Instance.ValueChanged(d, e);
        }

        /// <summary>
        /// Gets the attached property
        /// </summary>
        /// <param name="d"> the element to get the property from </param>
        /// <returns></returns>
        public static Property GetValue(DependencyObject d) => (Property)d.GetValue(ValueProperty);

        /// <summary>
        /// sets the attached property
        /// </summary>
        /// <param name="d"> the element to get the property from </param>
        /// <param name="value"> the value to set the property to</param>
        public static void SetValue(DependencyObject d, Property value) => d.SetValue(ValueProperty, value);

        #endregion

        #region Event Methods

        /// <summary>
        /// the method that is called when any attached property of this type is changed
        /// </summary>
        /// <param name="sender"> the UI element that this property was changed for </param>
        /// <param name="e"> the arguments for the event </param>
        public virtual void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e) { }

        /// <summary>
        /// the method that is called when any attached property of this type is changed, even if it's the same value
        /// </summary>
        /// <param name="sender"> the UI element that this property was changed for </param>
        /// <param name="e"> the arguments for the event </param>
        public virtual void OnValueUpdated(DependencyObject sender, object value) { }



        #endregion
    }
}
