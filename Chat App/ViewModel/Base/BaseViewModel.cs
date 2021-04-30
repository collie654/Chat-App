using System.ComponentModel;
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
    }
}
