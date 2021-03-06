using Chat_App.Core;
using Ninject;
using System;
using System.Diagnostics;
using System.Globalization;


namespace Chat_App
{
    /// <summary>
    /// converts the <see cref="ApplicationPage"/> to an actual view/page
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // find the appropriate page
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Login:
                    return new LoginPage();
                case ApplicationPage.Chat:
                    return new ChatPage();
                case ApplicationPage.Register:
                    return new RegisterPage();
                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
