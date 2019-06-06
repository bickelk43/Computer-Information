using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.DirectoryServices;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Timers;

namespace ComputerInformation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            string ipAdd = string.Empty;

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            GetSystemInfo();
            GetLocalIPAddress();
            passwordExpiresLabel.Text = GetPasswordExpirationDate(Environment.UserName, Environment.UserDomainName).ToString();

            computerInfoNotifyIcon.Text = Convert.ToString(ipAddressLabel.Text +
                "\n" + computerNameLabel.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer refreshTimer = new System.Windows.Forms.Timer();
            refreshTimer.Interval = 60000;// 60 seconds
            refreshTimer.Tick += new System.EventHandler(Refresh_Tick);
            refreshTimer.Start();

            this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - this.Width, 0);
            this.TransparencyKey = BackColor;
            this.ShowInTaskbar = false;

            this.Visible = false;
        }
        private void Refresh_Tick(object sender, EventArgs e)
        {
            //do whatever you want 
            GetSystemInfo();
        }

        public void GetSystemInfo()
        {
            // Logged In User
            loggedInUserLabel.Text = Environment.UserName;
            loggedInUserLabel.AutoSize = false;
            loggedInUserLabel.TextAlign = ContentAlignment.TopRight;
            loggedInInfoLabel.AutoSize = false;
            loggedInInfoLabel.TextAlign = ContentAlignment.TopRight;

            // Pw Expires
            passwordExpiresLabel.AutoSize = false;
            passwordExpiresLabel.TextAlign = ContentAlignment.TopRight;
            passwordExpiresInfoLabel.AutoSize = false;
            passwordExpiresInfoLabel.TextAlign = ContentAlignment.TopRight;

            // Ip Address
            ipAddressInfoLabel.AutoSize = false;
            ipAddressInfoLabel.TextAlign = ContentAlignment.TopRight;
            ipAddressLabel.AutoSize = false;
            ipAddressLabel.TextAlign = ContentAlignment.TopRight;

            // Computer Name
            computerNameInfoLabel.AutoSize = false;
            computerNameInfoLabel.TextAlign = ContentAlignment.TopRight;
            computerNameLabel.AutoSize = false;
            computerNameLabel.TextAlign = ContentAlignment.TopRight;

            // DID
            didInfoLabel.AutoSize = false;
            didInfoLabel.TextAlign = ContentAlignment.TopRight;
            didLabel.AutoSize = false;
            didLabel.TextAlign = ContentAlignment.TopRight;

            // Extension
            extensionInfoLabel.AutoSize = false;
            extensionInfoLabel.TextAlign = ContentAlignment.TopRight;
            extensionLabel.AutoSize = false;
            extensionLabel.TextAlign = ContentAlignment.TopRight;

            // Other AD attribs
            computerNameLabel.Text = Environment.MachineName;
            didLabel.Text = ADPhoneNumber();
            extensionLabel.Text = ADExtension();
        }

        public static DateTime GetPasswordExpirationDate(string userId, string domainOrMachineName)
        {
            using (var userEntry = new DirectoryEntry("WinNT://" + domainOrMachineName + '/' + userId + ",user"))
            {
                var output = (DateTime)userEntry.InvokeGet("PasswordExpirationDate");
                return output;
            }
        }

        public void GetLocalIPAddress()
        {
            string localIP;
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                localIP = endPoint.Address.ToString();

                ipAddressLabel.Text = localIP;
                
            }
        }

        static DirectoryEntry createDirectoryEntry()
        {
            // create and return new LDAP connection with desired settings  
            DirectoryEntry ldapConnection = new DirectoryEntry(Environment.UserDomainName);
            ldapConnection.Path = "LDAP://" + Environment.UserDomainName;
            return ldapConnection;
        }

        private static string ADPhoneNumber()
        {
            try
            {
                // create ldap connection object
                DirectoryEntry myLdapConnection = createDirectoryEntry();
                DirectorySearcher usernameSearch = new DirectorySearcher(myLdapConnection);

                //search for the username (sAMAccountName)
                usernameSearch.Filter = "(&(sAMAccountName=" + Environment.UserName + "))";
                
                //will need telephoneNumber <- AD attribute

                //filtered fields for the listbox
                SearchResult result = usernameSearch.FindOne();

                if (result != null)
                {
                    return result.Properties["telephoneNumber"][0].ToString();
                }
                else
                {
                    //let the progam user know that their search was invalid
                    var resultElse = "N/A";
                    return resultElse;
                }
            }
            catch
            {
                //throw an error if the program becomes sad and flips out
                return "N/A";
            }
        }

        private static string ADExtension()
        {
            try
            {
                // create ldap connection object
                DirectoryEntry myLdapConnection = createDirectoryEntry();
                DirectorySearcher usernameSearch = new DirectorySearcher(myLdapConnection);

                //search for the username (sAMAccountName)
                usernameSearch.Filter = "(&(sAMAccountName=" + Environment.UserName + "))";

                //will need telephoneNumber <- AD attribute

                //filtered fields for the listbox
                SearchResult result = usernameSearch.FindOne();

                if (result != null)
                {
                    return result.Properties["ipPhone"][0].ToString();
                }
                else
                {
                    //let the progam user know that their search was invalid
                    var resultElse = "N/A";
                    return resultElse;
                }
            }
            catch
            {
                //throw an error if the program becomes sad and flips out
                return "N/A";
            }
        }

        private void showHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        private void computerInfoNotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == true)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }
    }
}
