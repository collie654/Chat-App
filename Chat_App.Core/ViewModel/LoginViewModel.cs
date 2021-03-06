using System;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Chat_App.Core
{

    /// <summary>
    /// The View Model for a login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {
        #region Public Properties

        /// <summary>
        /// Email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// a flag indicating if the login command is running
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion

        #region Commands


        /// <summary>
        /// the command to login 
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// the command to move to the register page
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion

        #region Constructor
        /// <summary>
        /// default constructure
        /// </summary>
        public LoginViewModel()
        {

            LoginCommand = new RelayParameterizedCommand(async (parameter) => await LoginAsync(parameter));

            RegisterCommand = new RelayCommand(async () => await RegisterAsync());

        }

        #endregion

        /// <summary>
        /// attempts to log the user in
        /// </summary>
        /// <param name="parameter"> the <see cref="SecureString"/> passed in from the view for the users password </param>
        /// <returns></returns>
        public async Task LoginAsync(object parameter)
        {
            await RunCommmandAsync(() => this.LoginIsRunning, async () =>
            {
                await Task.Delay(5000);

                // IMPORTANT: never store unsecure passowrd in variable like this
                var pass = (parameter as IHavePassword).SecurePassword.Unsecure();
            });
        }

        /// <summary>
        /// Takes the user to the registerPage
        /// </summary>
        /// <returns></returns>
        public async Task RegisterAsync()
        {
            // TODO: Go to register page
            IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.Register;

            await Task.Delay(1);
        }
    }
}
