using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gloomi
{
    public partial class LampenAdd : Form
    {
        public LampenAdd(Form parent)
        {
            InitializeComponent();
            origin = (LampenMenu)parent;
            newLamp = new Lamp();
        }

        private LampenMenu origin;
        private Lamp newLamp;

        private void buttonLampToevoegen_Click(object sender, EventArgs e)
        {
            origin.SQLInsertLamp(newLamp);
            origin.SQLReRunLastSearchQueryAndUpdateList();
            this.Hide();
        }
        private void buttonAnnuleren_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void buttonKleurVeranderen_Click(object sender, EventArgs e)
        {
            if (colorDialogKleur.ShowDialog() == DialogResult.OK)
            {
                Color c = colorDialogKleur.Color;
                newLamp.kleur = Color.FromArgb(0, c.R, c.G, c.B);
                panelKleur.BackColor = colorDialogKleur.Color;
            }
        }

        private void textBoxProvincie_TextChanged(object sender, EventArgs e)
        {
            newLamp.provincie = textBoxProvincie.Text;
        }

        private void textBoxStad_TextChanged(object sender, EventArgs e)
        {
            newLamp.stad = textBoxStad.Text;
        }

        private void textBoxPostcode_TextChanged(object sender, EventArgs e)
        {
            newLamp.postcode = textBoxPostcode.Text;
        }

        private void numericLampCodeNummer_ValueChanged(object sender, EventArgs e)
        {
            newLamp.apparaatid = textBoxApparaatid.Text;
        }

        private void numericLichtIntensiteit_ValueChanged(object sender, EventArgs e)
        {
            newLamp.lichtintensiteit = decimal.ToSingle(numericLichtIntensiteit.Value);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
