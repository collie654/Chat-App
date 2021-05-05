namespace Chat_App.Core
{
    /// <summary>
    /// the design-time data for a <see cref="ChatListItemViewModel"/>
    /// </summary>
    public class ChatListItemDesignModel : ChatListItemViewModel
    {

        #region Singleton

        /// <summary>
        /// a single instance of the design model
        /// </summary>
        public static ChatListItemDesignModel Instance => new ChatListItemDesignModel();

        #endregion

        #region Constructor     
        /// <summary>
        /// default constructor
        /// </summary>
        public ChatListItemDesignModel()
        {
            Initials = "LM";
            Name = "Luke";
            Message = "This chat app is awesome! I bet it will be fast too";
            ProfilePictureRGB = "3099c5";
        }
        #endregion
    }
}
