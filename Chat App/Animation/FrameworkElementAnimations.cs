
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Chat_App
{
    /// <summary>
    /// helpers to aniamte framework elements in specific ways
    /// </summary>
    public static class FrameworkElementAnimations
    {
        /// <summary>
        /// slide the element in from the right 
        /// </summary>
        /// <param name="element"> element to animate </param>
        /// <param name="seconds"> the time the animation will take </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRightAsync(this FrameworkElement element, float seconds, bool keepMargin = true)
        {
            // create the storyboard
            var sb = new Storyboard();

            // add slide from right animation
            sb.AddSlideFromRight(seconds, element.ActualWidth, keepMargin: keepMargin);

            // add fade in animation
            sb.AddFadeIn(seconds);

            // start animating 
            sb.Begin(element);

            // make page visible
            element.Visibility = Visibility.Visible;

            // wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// slide the element in from the right 
        /// </summary>
        /// <param name="element"> element to animate </param>
        /// <param name="seconds"> the time the animation will take </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true)
        {
            // create the storyboard
            var sb = new Storyboard();

            // add slide from right animation
            sb.AddSlideFromLeft(seconds, element.ActualWidth, keepMargin: keepMargin);

            // add fade in animation
            sb.AddFadeIn(seconds);

            // start animating 
            sb.Begin(element);

            // make page visible
            element.Visibility = Visibility.Visible;

            // wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// slide the element out to the left
        /// </summary>
        /// <param name="element"> element to animate </param>
        /// <param name="seconds"> the time the animation will take </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true)
        {
            // create the storyboard
            var sb = new Storyboard();

            // add slide from right animation
            sb.AddSlideToLeft(seconds, element.ActualWidth, keepMargin: keepMargin);

            // add fade in animation
            sb.AddFadeOut(seconds);

            // start animating 
            sb.Begin(element);

            // make page visible
            element.Visibility = Visibility.Visible;

            // wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// slide the element out to the right
        /// </summary>
        /// <param name="element"> element to animate </param>
        /// <param name="seconds"> the time the animation will take </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToRightAsync(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true)
        {
            // create the storyboard
            var sb = new Storyboard();

            // add slide from right animation
            sb.AddSlideToRight(seconds, element.ActualWidth, keepMargin: keepMargin);

            // add fade in animation
            sb.AddFadeOut(seconds);

            // start animating 
            sb.Begin(element);

            // make page visible
            element.Visibility = Visibility.Visible;

            // wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }
    }
}
