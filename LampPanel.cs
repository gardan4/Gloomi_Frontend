using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gloomi
{
    public class LampPanel : Panel
    {
        public LampPanel(Panel originPanel, Lamp lampTarget)
        {
            //itself
            Parent = originPanel;
            int currentAmount = originPanel.Controls.Count;
            Width = Parent.Width - 24;
            Height = 48;
            Location = new Point(1, 1 + 50 * (currentAmount - 1));
            BorderStyle = BorderStyle.FixedSingle;

            Target = lampTarget;

            //content
            Label header = new Label();
            Controls.Add(header);
            header.Location = new Point(48, 4);
            header.Text = "Lamp: [" + Target.apparaatid + "]";
            header.Width = Width - 192;

            Label body = new Label();
            Controls.Add(body);
            body.Location = new Point(48, 28);
            body.Text = "Locatie: " + Target.provincie + "; " + Target.stad + "; " + Target.postcode;
            body.Width = Width - 192;

            Button openLink = new Button();
            Controls.Add(openLink);
            openLink.Size = new Size(40, 40);
            openLink.Location = new Point(Size.Width - 45, 3);
            openLink.Text = "i";
            openLink.Font = new Font(openLink.Font.FontFamily, 22);
            openLink.TextAlign = ContentAlignment.MiddleCenter;

            void actionButton(object sender, EventArgs e)
            {
                LampInterface lampInterface = new LampInterface(Target, originPanel.FindForm());
                lampInterface.Show();
            }
            openLink.Click += new System.EventHandler(actionButton);
        }

        private Lamp Target;
    }
}
