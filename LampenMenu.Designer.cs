namespace Gloomi
{
    partial class LampenMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LampenMenu));
            this.panelLampen = new System.Windows.Forms.Panel();
            this.labellampen2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProvincie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxStad = new System.Windows.Forms.TextBox();
            this.textBoxPostcode = new System.Windows.Forms.TextBox();
            this.textBoxLampCodeNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonZoek = new System.Windows.Forms.Button();
            this.buttonAddLamp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelLampen
            // 
            this.panelLampen.AutoScroll = true;
            this.panelLampen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLampen.Location = new System.Drawing.Point(401, 38);
            this.panelLampen.Name = "panelLampen";
            this.panelLampen.Size = new System.Drawing.Size(396, 408);
            this.panelLampen.TabIndex = 0;
            // 
            // labellampen2
            // 
            this.labellampen2.AutoSize = true;
            this.labellampen2.Location = new System.Drawing.Point(398, 9);
            this.labellampen2.Name = "labellampen2";
            this.labellampen2.Size = new System.Drawing.Size(41, 13);
            this.labellampen2.TabIndex = 0;
            this.labellampen2.Text = "lampen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zoeken";
            // 
            // textBoxProvincie
            // 
            this.textBoxProvincie.Location = new System.Drawing.Point(128, 45);
            this.textBoxProvincie.Name = "textBoxProvincie";
            this.textBoxProvincie.Size = new System.Drawing.Size(267, 20);
            this.textBoxProvincie.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Provincie";
            // 
            // textBoxStad
            // 
            this.textBoxStad.Location = new System.Drawing.Point(128, 71);
            this.textBoxStad.Name = "textBoxStad";
            this.textBoxStad.Size = new System.Drawing.Size(267, 20);
            this.textBoxStad.TabIndex = 4;
            // 
            // textBoxPostcode
            // 
            this.textBoxPostcode.Location = new System.Drawing.Point(128, 97);
            this.textBoxPostcode.Name = "textBoxPostcode";
            this.textBoxPostcode.Size = new System.Drawing.Size(267, 20);
            this.textBoxPostcode.TabIndex = 5;
            // 
            // textBoxLampCodeNum
            // 
            this.textBoxLampCodeNum.Location = new System.Drawing.Point(128, 123);
            this.textBoxLampCodeNum.Name = "textBoxLampCodeNum";
            this.textBoxLampCodeNum.Size = new System.Drawing.Size(267, 20);
            this.textBoxLampCodeNum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Postcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lamp code nummer";
            // 
            // buttonZoek
            // 
            this.buttonZoek.Location = new System.Drawing.Point(320, 149);
            this.buttonZoek.Name = "buttonZoek";
            this.buttonZoek.Size = new System.Drawing.Size(75, 23);
            this.buttonZoek.TabIndex = 10;
            this.buttonZoek.Text = "Zoek";
            this.buttonZoek.UseVisualStyleBackColor = true;
            this.buttonZoek.Click += new System.EventHandler(this.buttonZoek_Click);
            // 
            // buttonAddLamp
            // 
            this.buttonAddLamp.Location = new System.Drawing.Point(722, 9);
            this.buttonAddLamp.Name = "buttonAddLamp";
            this.buttonAddLamp.Size = new System.Drawing.Size(75, 23);
            this.buttonAddLamp.TabIndex = 11;
            this.buttonAddLamp.Text = "Toevoegen";
            this.buttonAddLamp.UseVisualStyleBackColor = true;
            this.buttonAddLamp.Click += new System.EventHandler(this.buttonAddLamp_Click);
            // 
            // LampenMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddLamp);
            this.Controls.Add(this.buttonZoek);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLampCodeNum);
            this.Controls.Add(this.textBoxPostcode);
            this.Controls.Add(this.textBoxStad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxProvincie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labellampen2);
            this.Controls.Add(this.panelLampen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LampenMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lampen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLampen;
        private System.Windows.Forms.Label labellampen2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProvincie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStad;
        private System.Windows.Forms.TextBox textBoxPostcode;
        private System.Windows.Forms.TextBox textBoxLampCodeNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonZoek;
        private System.Windows.Forms.Button buttonAddLamp;
    }
}