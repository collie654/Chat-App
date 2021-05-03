using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Chat_App
{
    /// <summary>
    /// a base view model that fires property changed events as needed
    /// </summary>

    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// the event is fired when any child property chnages its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => {};


        /// <summary>
        /// Call this to fire a <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #region Command Helpers

        /// <summary>
        /// runs a command if the updating flag is not set
        /// if the flag is true (indicating the function is already running) then the action is not run
        /// if the flag is false (indicating no running function) then the action is run
        /// once the action is finished if it was run, then the falg is reset to false
        /// </summary>
        /// <param name="updatingFlag">the boolean property flag defining if the command is already running </param>
        /// <param name="action"> the action to run if the command is not already running </param>
        /// <returns></returns>
        protected async Task RunCommand(Expression<Func<bool>> updatingFlag, Func<Task> action)
        {
            // check if the flag property is true (meaning the function is already running)
            if (updatingFlag.GetPropertyValue())
                return;

            // set the property flag to true
            updatingFlag.SetPropertyValue(true);

            try
            {
                // run the passed action
                await action();
            }
            finally
            {
                // set the property flag back to false, now it's finished
                updatingFlag.SetPropertyValue(false);
            }
        }
        #endregion 

    }
}
