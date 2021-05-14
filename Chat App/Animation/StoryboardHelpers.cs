using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace Chat_App
{
    /// <summary>
    /// animation helpers for <see cref="StoryBoard"/>
    /// </summary>
    public static class StoryboardHelpers
    {
        /// <summary>
        /// adds a slide from right animation to the storyboard
        /// </summary>
        /// <param name="storyboard"> the storyboard to add the animation to </param>
        /// <param name="seconds"> the time the animation will take </param>
        /// <param name="offset"> the distance to the right to start from </param>
        /// <param name="decelerationRatio"> the rate of deceleration </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation</param>
        public static void AddSlideFromRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(keepMargin ? offset : 0, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };

            // set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // add this to the storyboard
            storyboard.Children.Add(animation);

        }

        /// <summary>
        /// adds a slide from left animation to the storyboard
        /// </summary>
        /// <param name="storyboard"> the storyboard to add the animation to </param>
        /// <param name="seconds"> the time the animation will take </param>
        /// <param name="offset"> the distance to the left to start from </param>
        /// <param name="decelerationRatio"> the rate of deceleration </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation</param>
        public static void AddSlideFromLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(-offset, 0, keepMargin ? offset : 0, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio
            };

            // set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // add this to the storyboard
            storyboard.Children.Add(animation);

        }

        /// <summary>
        /// adds a slide to left animation to the storyboard
        /// </summary>
        /// <param name="storyboard"> the storyboard to add the animation to </param>
        /// <param name="seconds"> the time the animation will take </param>
        /// <param name="offset"> the distance to the left to end from </param>
        /// <param name="decelerationRatio"> the rate of deceleration </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation</param>
        public static void AddSlideToLeft(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, 0, keepMargin ? offset : 0, 0),
                DecelerationRatio = decelerationRatio
            };

            // set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // add this to the storyboard
            storyboard.Children.Add(animation);

        }

        /// <summary>
        /// adds a slide to right animation to the storyboard
        /// </summary>
        /// <param name="storyboard"> the storyboard to add the animation to </param>
        /// <param name="seconds"> the time the animation will take </param>
        /// <param name="offset"> the distance to the right to end at </param>
        /// <param name="decelerationRatio"> the rate of deceleration </param>
        /// <param name="keepMargin"> Whether to keep the element at the same width during animation</param>
        public static void AddSlideToRight(this Storyboard storyboard, float seconds, double offset, float decelerationRatio = 0.9f, bool keepMargin = true)
        {
            // create the margin animate from right
            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(keepMargin ? offset : 0, 0, -offset, 0),
                DecelerationRatio = decelerationRatio
            };

            // set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));

            // add this to the storyboard
            storyboard.Children.Add(animation);

        }

        /// <summary>
        /// adds a fade in animation to the storyboard
        /// </summary>
        /// <param name="storyboard"> the storyboard to add the animation to </param>
        /// <param name="seconds"> the time the animation will take </param>
        public static void AddFadeIn(this Storyboard storyboard, float seconds)
        {
            // create the margin animate from right
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 0,
                To = 1,
            };

            // set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            // add this to the storyboard
            storyboard.Children.Add(animation);

        }

        /// <summary>
        /// adds a fade out animation to the storyboard
        /// </summary>
        /// <param name="storyboard"> the storyboard to add the animation to </param>
        /// <param name="seconds"> the time the animation will take </param>
        public static void AddFadeOut(this Storyboard storyboard, float seconds)
        {
            // create the margin animate from right
            var animation = new DoubleAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 1,
                To = 0,
            };

            // set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));

            // add this to the storyboard
            storyboard.Children.Add(animation);

        }
    }
}
