using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_App.Core
{
    public class ApplicationViewModel: BaseViewModel
    {
        /// <summary>
        /// The current page of the application
        /// </summary>
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;

        /// <summary>
        /// true if the side menu should be shown
        /// </summary>
        public bool SideMenuVisible { get; set; } = false;
    }
}
