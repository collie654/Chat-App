using Ninject;
using System;

/// <summary>
/// the IoC container for our application
/// </summary>
namespace Chat_App.Core
{

    public static class IoC
    {
        #region Public Properties

        /// <summary>
        /// the kernel for our IoC container
        /// </summary>
        public static IKernel Kernal { get; private set; } = new StandardKernel();

        #endregion

        #region Construction

        /// <summary>
        /// sets up the IoC container and binds all information required and is ready for use
        /// NOTE: Must be called as soon as your application starts up to ensure all 
        ///       services can be found
        /// </summary>
        public static void Setup()
        {
            // bind all required view models
            BindViewModels();
        }

        /// <summary>
        /// binds all singleton view models
        /// </summary>
        private static void BindViewModels()
        {
            // bind to a single instance of Application view model
            Kernal.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());
        }

        #endregion

        /// <summary>
        /// gets a service from the IoC of the specified type
        /// </summary>
        /// <typeparam name="T"> type to get </typeparam>
        /// <returns></returns>
        public static T Get<T>()
        {
            return Kernal.Get<T>();
        }
    }
}
