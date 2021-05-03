namespace Chat_App
{

    /// <summary>
    /// styles of page animations for appearing/disappearing
    /// </summary>
    public enum PageAnimation
    {
        /// <summary>
        /// no animation takes place 
        /// </summary>
        None = 0,

        /// <summary>
        /// the page slides in and fades in from the right 
        /// </summary>
        SlideAndFadeInFromRight = 1,

        /// <summary>
        /// the page slides out and fades out to the left
        /// </summary>
        SlideAndFadeOutFromLeft = 2,
    }
}
