using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Chat_App.Core
{
    /// <summary>
    /// an interface for a class that can provide a secure password
    /// </summary>
    public interface IHavePassword
    {
        /// <summary>
        /// the secure password
        /// </summary>
        SecureString SecurePassword { get; }
    }
}
