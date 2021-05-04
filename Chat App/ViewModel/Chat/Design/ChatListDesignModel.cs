using System.Collections.Generic;

namespace Chat_App
{
    /// <summary>
    /// the design-time data for a <see cref="ChatListViewModel"/>
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {

        #region Singleton

        /// <summary>
        /// a single instance of the design model
        /// </summary>
        public static ChatListDesignModel Instance => new ChatListDesignModel();

        #endregion

        #region Constructor     
        /// <summary>
        /// default constructor
        /// </summary>
        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "3099c5",
                    NewContentAvailable = true
                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jesse",
                    Message = "hey dude, here are the new icons",
                    ProfilePictureRGB = "fe4503"
                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "The new server is up, got 192.168.1.1",
                    ProfilePictureRGB = "00d405",
                    IsSelected = true
                },
                new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "3099c5"
                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jesse",
                    Message = "hey dude, here are the new icons",
                    ProfilePictureRGB = "fe4503"
                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "The new server is up, got 192.168.1.1",
                    ProfilePictureRGB = "00d405"
                },
                new ChatListItemViewModel
                {
                    Initials = "LM",
                    Name = "Luke",
                    Message = "This chat app is awesome! I bet it will be fast too",
                    ProfilePictureRGB = "3099c5"
                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jesse",
                    Message = "hey dude, here are the new icons",
                    ProfilePictureRGB = "fe4503"
                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "The new server is up, got 192.168.1.1",
                    ProfilePictureRGB = "00d405"
                },
            };
        }
        #endregion
    }
}
