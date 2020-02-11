using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

//using Friuts.Data.Oracle;
//using SunriseSys.CommonClass;
//using Friuts;

namespace Bsoft.AppCom
{
    public class UserInfo
    {
        #region Member variables

        private int _sN = 0;
        private string _userID = string.Empty;
        private string _userPassword = string.Empty;
        private string _nepName = string.Empty;
        private string _engName = string.Empty;
        private int _userStatus = 0;
        private DateTime _lastLoginDateTime = new DateTime();
        private DateTime _lastLogoutDateTime = new DateTime();
        private string _grants = string.Empty;
        private int _updatedBy = 0;

        StringBuilder sql = new StringBuilder();
        private Bsoft.Common.clsEncryptorDecryptor _encDrcypt = new Bsoft.Common.clsEncryptorDecryptor();
        #endregion

       

        #region Properties

        /// <summary>
        /// Gets or sets the internal primary key ID of the User.
        /// </summary>
        public int SN
        {
          get { return _sN; }
          set { _sN = value; }
        }

        /// <summary>
        /// Gets or sets the internal primary key ID of the User.
        /// </summary>
        public int ID
        {
            get { return _sN; }
            set { _sN = value; }
        }

        /// <summary>
        /// Gets or sets  User Login ID
        /// </summary>
        public string UserID
        {
          get { return _userID; }
          set { _userID = value; }
        }

        /// <summary>
        /// Gets or sets the user Password.
        /// The returns the decrypted password to the user.
        /// </summary>
        public string UserPassword
        {
            get { return _encDrcypt.Decrypt(_userPassword); }
            set { _userPassword = _encDrcypt.Encrypt (value.ToString()); }
        }

        /// <summary>
        /// Gets or set the Nepali Name of the user
        /// </summary>
        public string NepName
        {
            get { return _nepName; }
            set { _nepName = value; }
        }

        /// <summary>
        /// Gets or sets the English Nepali name of user
        /// </summary>
        public string EngName
        {
            get { return _engName; }
            set { _engName = value; }
        }

        /// <summary>
        /// Gets or Sets the user Status
        /// </summary>
        public int UserStatus
        {
            get { return _userStatus; }
            set { _userStatus = value; }
        }

        /// <summary>
        /// Gets or sets the Last Login date and time
        /// </summary>
        public DateTime LastLoginDateTime
        {
            get { return _lastLoginDateTime; }
            set { _lastLoginDateTime = value; }
        }

        /// <summary>
        /// Gets or Sets Last Logout Date Time
        /// </summary>
        public DateTime LastLogoutDateTime
        {
            get { return _lastLogoutDateTime; }
            set { _lastLogoutDateTime = value; }
        }

        /// <summary>
        /// Gets or sets user Grant (Rights)
        /// </summary>
        public string Grants
        {
            get { return _grants; }
            set { _grants = value; }
        }

        /// <summary>
        /// Gets or sets the which updated the User Information
        /// </summary>
        public int UpdatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; }
        }

        #endregion

         
    }
}
