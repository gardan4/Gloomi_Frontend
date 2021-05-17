using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Gloomi
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.Text = "Gloomi - Home";

            //init msg
            Panel notif1 = AddNotification(panelNotif);
            NotificationMessage(notif1, "Welkom", "info");
            NotificationContent(notif1, "Controlepaneel opgestart.");
        }
        //create new notification
        private Panel AddNotification(Panel originPanel)
        {
            int currentAmount = originPanel.Controls.Count;
            Panel notification = new Panel();
            originPanel.Controls.Add(notification);
            notification.BorderStyle = BorderStyle.FixedSingle;
            notification.Size = new Size(originPanel.Size.Width - 24, 48);
            notification.Location = new Point(1, 1 + 50 * currentAmount);

            return notification;
        }
        //set notification message header
        public void NotificationMessage(Panel notification, string text, string icon)
        {
            Label label = new Label();
            notification.Controls.Add(label);
            label.Location = new Point(48, 4);
            label.Text = text;

            PictureBox pictureIcon = new PictureBox();
            notification.Controls.Add(pictureIcon);
            pictureIcon.Size = new Size(40, 40);
            pictureIcon.Location = new Point(2, 2);
            pictureIcon.SizeMode = PictureBoxSizeMode.Zoom;
            switch (icon)
            {
                case "warning":
                    pictureIcon.Image = Properties.Resources.warning2;
                    break;
                case "error":
                    pictureIcon.Image = Properties.Resources.error2;
                    notification.BackColor = Color.Pink;
                    break;
                case "info":
                    pictureIcon.Image = Properties.Resources.info2;
                    break;
                case "check":
                    pictureIcon.Image = Properties.Resources.mark2;
                    break;
                default:
                    pictureIcon.Dispose();
                    break;
            }
        }
        //add content to notification
        public void NotificationContent(Panel notification, string body)
        {
            Button openLink = new Button();
            notification.Controls.Add(openLink);
            openLink.Size = new Size(40, 40);
            openLink.Location = new Point(notification.Size.Width - 45, 3);
            openLink.Text = "i";
            openLink.Font = new Font(openLink.Font.FontFamily, 22);
            openLink.TextAlign = ContentAlignment.MiddleCenter;

            void actionButton(object sender, EventArgs e)
            {
                MessageBox msgBox = new MessageBox(notification, notification.Controls[0].Text, body);
                msgBox.Show();
            }
            openLink.Click += new System.EventHandler(actionButton);
        }
        //update notifications panel
        public void NotificationsRedraw(Panel notificationPanel)
        {
            int counter = 0;
            foreach (Panel Notification in notificationPanel.Controls)
            {
                Notification.Location = new Point(1, 1 + 50 * counter);
                counter++;
            }
        }
        //default notification finisher
        public void NotificationCloseButton(Panel notification)
        {
            Button removeButton = new Button();
            notification.Controls.Add(removeButton);
            removeButton.Size = new Size(40, 40);
            removeButton.Location = new Point(notification.Size.Width - 45, 3);
            removeButton.Text = "X";
            //maak dit mooier
            removeButton.Font = new Font(removeButton.Font.FontFamily, 22);
            void ActionButton(object sender, EventArgs e)
            {
                Panel parent = (Panel)notification.Parent;
                notification.Dispose();
                NotificationsRedraw(parent);
            }
            removeButton.Click += new System.EventHandler(ActionButton);
        }
        //open lampen menu
        private void buttonLinkLampen_Click(object sender, EventArgs e)
        {
            void ReactivateButtonAfterClosing(object sender2, CancelEventArgs e2)
            {
                buttonLinkLampen.Enabled = true;
            }
            buttonLinkLampen.Enabled = false;

            LampenMenu Menu = new LampenMenu(this);
            Menu.Show();
            Menu.Closing += new CancelEventHandler(ReactivateButtonAfterClosing);
        }
        //outside reference
        public Panel AddNotificationFromOutside()
        {
            return AddNotification(panelNotif);
        }
        //things network console access
        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://console.thethingsnetwork.org/");
        }
    }
}
