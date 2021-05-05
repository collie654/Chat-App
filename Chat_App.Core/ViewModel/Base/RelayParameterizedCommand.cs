using System;
using System.Windows.Input;

namespace Chat_App.Core
{
    /// <summary>
    /// a basic command that runs an Action
    /// </summary>
    public class RelayParameterizedCommand : ICommand
    {
        #region Private Members

        /// <summary>
        /// the action to run
        /// </summary>
        private Action<object> mAction;

        #endregion

        #region Public Events

        /// <summary>
        /// the event thats fired when the <see cref="CanExecute(object)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        #endregion

        #region Constructor

        /// <summary>
        /// default constructor
        /// </summary>
        public RelayParameterizedCommand(Action<object> action)
        {
            mAction = action;
        }

        #endregion

        #region Command Methods

        /// <summary>
        /// a relay commands can always execute
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// executes the commands action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            mAction(parameter);
        }

        #endregion 
    }
}
