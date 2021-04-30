using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Chat_App
{
    /// <summary>
    /// a base value converter that allows direct XAML usage
    /// </summary>
    /// <typeparam name="T"> The type of this value converter </typeparam>
    public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter
        where T : class, new()
    {

        #region Private Members
        /// <summary>
        /// a single static instance of this value converter this will be called when used in XAML
        /// </summary>
        private static T mConverter = null;

        #endregion

        #region Markup Extension Methods
        /// <summary>
        /// Provides a static instance of the value converter
        /// </summary>
        /// <param name="serviceProvider"> the service provider </param>
        /// <returns></returns>
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            // return mConverter, if it doesn't exist return an mConverter of the type passed in
            return mConverter ?? (mConverter = new T());
        }
        #endregion

        #region Value Converter Methods

        /// <summary>
        /// The method to convert one type to another
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        /// <summary>
        /// the method to convert a value back to its source type
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);


        #endregion
    }
}
