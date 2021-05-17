using System;
using System.Windows.Forms;

namespace Gloomi
{
    public partial class MessageBox : Form
    {
        public MessageBox(Panel Notification, string newHeader, string newBody)
        {
            InitializeComponent();
            parentNotification = Notification;
            header = newHeader;
            body = newBody;

            labelHeader.Text = header;
            labelBody.Text = body;
        }
        private string header = "";
        private string body = "";
        private Panel parentNotification;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void SetHeader(string newHeader)
        {
            header = newHeader;
            labelHeader.Text = header;
        }

        private void SetBody(string newHeader)
        {
            body = newHeader;
            labelBody.Text = body;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            Panel NotificationPanel = (Panel)parentNotification.Parent;
            Form Main = NotificationPanel.FindForm();
            NotificationPanel.Controls.Remove(parentNotification);
            parentNotification.Dispose();
            new MainMenu().NotificationsRedraw(NotificationPanel);
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
