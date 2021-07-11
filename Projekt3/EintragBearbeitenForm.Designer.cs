
namespace Projekt3
{
    partial class EintragBearbeitenForm
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
            this.kundeBearbeitenBtn = new System.Windows.Forms.Button();
            this.ansprechpartnerTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.plzTextBox = new System.Windows.Forms.TextBox();
            this.hausnrTextBox = new System.Windows.Forms.TextBox();
            this.strasseTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.vornameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kundenLoeschenBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kundeBearbeitenBtn
            // 
            this.kundeBearbeitenBtn.Location = new System.Drawing.Point(27, 208);
            this.kundeBearbeitenBtn.Name = "kundeBearbeitenBtn";
            this.kundeBearbeitenBtn.Size = new System.Drawing.Size(170, 38);
            this.kundeBearbeitenBtn.TabIndex = 29;
            this.kundeBearbeitenBtn.Text = "Kunden bearbeiten";
            this.kundeBearbeitenBtn.UseVisualStyleBackColor = true;
            this.kundeBearbeitenBtn.Click += new System.EventHandler(this.kundeBearbeitenBtn_Click);
            // 
            // ansprechpartnerTextBox
            // 
            this.ansprechpartnerTextBox.Location = new System.Drawing.Point(116, 169);
            this.ansprechpartnerTextBox.Name = "ansprechpartnerTextBox";
            this.ansprechpartnerTextBox.Size = new System.Drawing.Size(245, 20);
            this.ansprechpartnerTextBox.TabIndex = 28;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(116, 143);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(245, 20);
            this.telefonTextBox.TabIndex = 27;
            // 
            // plzTextBox
            // 
            this.plzTextBox.Location = new System.Drawing.Point(116, 117);
            this.plzTextBox.Name = "plzTextBox";
            this.plzTextBox.Size = new System.Drawing.Size(245, 20);
            this.plzTextBox.TabIndex = 26;
            // 
            // hausnrTextBox
            // 
            this.hausnrTextBox.Location = new System.Drawing.Point(116, 91);
            this.hausnrTextBox.Name = "hausnrTextBox";
            this.hausnrTextBox.Size = new System.Drawing.Size(245, 20);
            this.hausnrTextBox.TabIndex = 25;
            // 
            // strasseTextBox
            // 
            this.strasseTextBox.Location = new System.Drawing.Point(116, 65);
            this.strasseTextBox.Name = "strasseTextBox";
            this.strasseTextBox.Size = new System.Drawing.Size(245, 20);
            this.strasseTextBox.TabIndex = 24;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(116, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(245, 20);
            this.nameTextBox.TabIndex = 23;
            // 
            // vornameTextBox
            // 
            this.vornameTextBox.Location = new System.Drawing.Point(116, 12);
            this.vornameTextBox.Name = "vornameTextBox";
            this.vornameTextBox.Size = new System.Drawing.Size(245, 20);
            this.vornameTextBox.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ansprechpartner:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Telefonnummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Postleitzahl:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Hausnummer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Straße:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Vorname:";
            // 
            // kundenLoeschenBtn
            // 
            this.kundenLoeschenBtn.Location = new System.Drawing.Point(206, 208);
            this.kundenLoeschenBtn.Name = "kundenLoeschenBtn";
            this.kundenLoeschenBtn.Size = new System.Drawing.Size(170, 38);
            this.kundenLoeschenBtn.TabIndex = 30;
            this.kundenLoeschenBtn.Text = "Kunden löschen";
            this.kundenLoeschenBtn.UseVisualStyleBackColor = true;
            this.kundenLoeschenBtn.Click += new System.EventHandler(this.kundenLoeschenBtn_Click);
            // 
            // EintragBearbeitenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 269);
            this.Controls.Add(this.kundenLoeschenBtn);
            this.Controls.Add(this.kundeBearbeitenBtn);
            this.Controls.Add(this.ansprechpartnerTextBox);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.plzTextBox);
            this.Controls.Add(this.hausnrTextBox);
            this.Controls.Add(this.strasseTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.vornameTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EintragBearbeitenForm";
            this.Text = "EintragBearbeitenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kundeBearbeitenBtn;
        private System.Windows.Forms.TextBox ansprechpartnerTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox plzTextBox;
        private System.Windows.Forms.TextBox hausnrTextBox;
        private System.Windows.Forms.TextBox strasseTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox vornameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kundenLoeschenBtn;
    }
}