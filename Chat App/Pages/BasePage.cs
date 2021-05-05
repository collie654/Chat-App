using Chat_App.Core;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Chat_App
{
    /// <summary>
    /// a base page for all other pages to inherit from
    /// </summary>
    public class BasePage<VM> : Page
        where VM : BaseViewModel, new()
    {
        #region Private Members

        /// <summary>
        /// the View Model associated with this page
        /// </summary>
        private VM mViewModel;

        #endregion

        #region Public Properties
        /// <summary>
        /// the animation that plays when the first page loads
        /// </summary>
        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        /// <summary>
        /// animation to play when the page is unloaded
        /// </summary>
        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutFromLeft;

        /// <summary>
        /// the time any slide animation takes to complete
        /// </summary>
        public float SlideSeconds { get; set; } = 0.8f;

        /// <summary>
        /// the View Model associated with this page
        /// </summary>
        public VM ViewModel
        {
            get { return mViewModel; }
            set
            {
                // if nothing has changed, return
                if (mViewModel == value)
                    return;

                // update the value
                mViewModel = value;

                // Set the data context for this page
                this.DataContext = mViewModel;
            }
        }


        #endregion

        #region Constructor
        /// <summary>
        /// default constructor
        /// </summary>
        public BasePage()
        {
            // if we are animating in, hide to begin with
            if (this.PageLoadAnimation != PageAnimation.None)
                this.Visibility = Visibility.Collapsed;

            // listen out for the page loading
            this.Loaded += BasePage_LoadedAsync;

            // create a default view model
            this.ViewModel = new VM();
        }

        #endregion

        #region Animation Load/Unload
        /// <summary>
        /// once the page is loaded, perform any required animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_LoadedAsync(object sender, RoutedEventArgs e)
        {
            // animate the page in
            await AnimateInAsync();
        }

        /// <summary>
        /// animates this page in
        /// </summary>
        /// <returns></returns>
        public async Task AnimateInAsync()
        {
            // make sure we have something to do
            if (PageLoadAnimation == PageAnimation.None)
                return;

            switch (PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:

                    // start the animation
                    await this.SlideAndFadeInFromRightAsync(SlideSeconds);

                    break;
            }
        }

        /// <summary>
        /// animates this page out
        /// </summary>
        /// <returns></returns>
        public async Task Async()
        {
            // make sure we have something to do
            if (PageUnloadAnimation == PageAnimation.None)
                return;

            switch (PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeOutFromLeft:

                    // start the animation
                    await this.SlideAndFadeOutToLeftAsync(SlideSeconds);

                    break;
            }
        }

        #endregion
    }
}
