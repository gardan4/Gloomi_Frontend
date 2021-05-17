namespace Gloomi
{
    partial class LampenAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialogKleur = new System.Windows.Forms.ColorDialog();
            this.buttonLampToevoegen = new System.Windows.Forms.Button();
            this.textBoxPostcode = new System.Windows.Forms.TextBox();
            this.textBoxProvincie = new System.Windows.Forms.TextBox();
            this.textBoxStad = new System.Windows.Forms.TextBox();
            this.buttonKleurVeranderen = new System.Windows.Forms.Button();
            this.panelKleur = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericLichtIntensiteit = new System.Windows.Forms.NumericUpDown();
            this.buttonAnnuleren = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxApparaatid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericLichtIntensiteit)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLampToevoegen
            // 
            this.buttonLampToevoegen.Location = new System.Drawing.Point(397, 185);
            this.buttonLampToevoegen.Name = "buttonLampToevoegen";
            this.buttonLampToevoegen.Size = new System.Drawing.Size(75, 23);
            this.buttonLampToevoegen.TabIndex = 0;
            this.buttonLampToevoegen.Text = "Toevoegen";
            this.buttonLampToevoegen.UseVisualStyleBackColor = true;
            this.buttonLampToevoegen.Click += new System.EventHandler(this.buttonLampToevoegen_Click);
            // 
            // textBoxPostcode
            // 
            this.textBoxPostcode.Location = new System.Drawing.Point(116, 58);
            this.textBoxPostcode.Name = "textBoxPostcode";
            this.textBoxPostcode.Size = new System.Drawing.Size(356, 20);
            this.textBoxPostcode.TabIndex = 1;
            this.textBoxPostcode.TextChanged += new System.EventHandler(this.textBoxPostcode_TextChanged);
            // 
            // textBoxProvincie
            // 
            this.textBoxProvincie.Location = new System.Drawing.Point(116, 6);
            this.textBoxProvincie.Name = "textBoxProvincie";
            this.textBoxProvincie.Size = new System.Drawing.Size(356, 20);
            this.textBoxProvincie.TabIndex = 2;
            this.textBoxProvincie.TextChanged += new System.EventHandler(this.textBoxProvincie_TextChanged);
            // 
            // textBoxStad
            // 
            this.textBoxStad.Location = new System.Drawing.Point(116, 32);
            this.textBoxStad.Name = "textBoxStad";
            this.textBoxStad.Size = new System.Drawing.Size(356, 20);
            this.textBoxStad.TabIndex = 3;
            this.textBoxStad.TextChanged += new System.EventHandler(this.textBoxStad_TextChanged);
            // 
            // buttonKleurVeranderen
            // 
            this.buttonKleurVeranderen.Location = new System.Drawing.Point(116, 136);
            this.buttonKleurVeranderen.Name = "buttonKleurVeranderen";
            this.buttonKleurVeranderen.Size = new System.Drawing.Size(75, 23);
            this.buttonKleurVeranderen.TabIndex = 6;
            this.buttonKleurVeranderen.Text = "Veranderen";
            this.buttonKleurVeranderen.UseVisualStyleBackColor = true;
            this.buttonKleurVeranderen.Click += new System.EventHandler(this.buttonKleurVeranderen_Click);
            // 
            // panelKleur
            // 
            this.panelKleur.BackColor = System.Drawing.Color.White;
            this.panelKleur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelKleur.ForeColor = System.Drawing.Color.White;
            this.panelKleur.Location = new System.Drawing.Point(197, 136);
            this.panelKleur.Name = "panelKleur";
            this.panelKleur.Size = new System.Drawing.Size(275, 24);
            this.panelKleur.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Provincie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Postcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lamp apparaat id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Licht intensiteit";
            // 
            // numericLichtIntensiteit
            // 
            this.numericLichtIntensiteit.Location = new System.Drawing.Point(116, 110);
            this.numericLichtIntensiteit.Name = "numericLichtIntensiteit";
            this.numericLichtIntensiteit.Size = new System.Drawing.Size(356, 20);
            this.numericLichtIntensiteit.TabIndex = 13;
            this.numericLichtIntensiteit.ValueChanged += new System.EventHandler(this.numericLichtIntensiteit_ValueChanged);
            // 
            // buttonAnnuleren
            // 
            this.buttonAnnuleren.Location = new System.Drawing.Point(316, 185);
            this.buttonAnnuleren.Name = "buttonAnnuleren";
            this.buttonAnnuleren.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnuleren.TabIndex = 15;
            this.buttonAnnuleren.Text = "Annuleren";
            this.buttonAnnuleren.UseVisualStyleBackColor = true;
            this.buttonAnnuleren.Click += new System.EventHandler(this.buttonAnnuleren_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kleur";
            // 
            // textBoxApparaatid
            // 
            this.textBoxApparaatid.Location = new System.Drawing.Point(116, 83);
            this.textBoxApparaatid.Name = "textBoxApparaatid";
            this.textBoxApparaatid.Size = new System.Drawing.Size(356, 20);
            this.textBoxApparaatid.TabIndex = 17;
            // 
            // LampenAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 220);
            this.Controls.Add(this.textBoxApparaatid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAnnuleren);
            this.Controls.Add(this.numericLichtIntensiteit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelKleur);
            this.Controls.Add(this.buttonKleurVeranderen);
            this.Controls.Add(this.textBoxStad);
            this.Controls.Add(this.textBoxProvincie);
            this.Controls.Add(this.textBoxPostcode);
            this.Controls.Add(this.buttonLampToevoegen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LampenAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lamp Toevoegen";
            ((System.ComponentModel.ISupportInitialize)(this.numericLichtIntensiteit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialogKleur;
        private System.Windows.Forms.Button buttonLampToevoegen;
        private System.Windows.Forms.TextBox textBoxPostcode;
        private System.Windows.Forms.TextBox textBoxProvincie;
        private System.Windows.Forms.TextBox textBoxStad;
        private System.Windows.Forms.Button buttonKleurVeranderen;
        private System.Windows.Forms.Panel panelKleur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericLichtIntensiteit;
        private System.Windows.Forms.Button buttonAnnuleren;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxApparaatid;
    }
}