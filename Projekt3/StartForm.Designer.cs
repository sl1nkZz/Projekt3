
namespace Projekt3
{
    partial class StartForm
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
            this.beendenBtn = new System.Windows.Forms.Button();
            this.kundenDatenView = new System.Windows.Forms.DataGridView();
            this.neuerEintragBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.benutzerverwaltungBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kundenDatenView)).BeginInit();
            this.SuspendLayout();
            // 
            // beendenBtn
            // 
            this.beendenBtn.Location = new System.Drawing.Point(815, 404);
            this.beendenBtn.Name = "beendenBtn";
            this.beendenBtn.Size = new System.Drawing.Size(93, 34);
            this.beendenBtn.TabIndex = 1;
            this.beendenBtn.Text = "Beenden";
            this.beendenBtn.UseVisualStyleBackColor = true;
            this.beendenBtn.Click += new System.EventHandler(this.beendenBtn_Click);
            // 
            // kundenDatenView
            // 
            this.kundenDatenView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kundenDatenView.Location = new System.Drawing.Point(13, 12);
            this.kundenDatenView.Name = "kundenDatenView";
            this.kundenDatenView.Size = new System.Drawing.Size(895, 386);
            this.kundenDatenView.TabIndex = 2;
            // 
            // neuerEintragBtn
            // 
            this.neuerEintragBtn.Location = new System.Drawing.Point(12, 404);
            this.neuerEintragBtn.Name = "neuerEintragBtn";
            this.neuerEintragBtn.Size = new System.Drawing.Size(93, 34);
            this.neuerEintragBtn.TabIndex = 3;
            this.neuerEintragBtn.Text = "Neuer Eintrag";
            this.neuerEintragBtn.UseVisualStyleBackColor = true;
            this.neuerEintragBtn.Click += new System.EventHandler(this.neuerEintragBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Eintrag bearbeiten";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // benutzerverwaltungBtn
            // 
            this.benutzerverwaltungBtn.Location = new System.Drawing.Point(210, 404);
            this.benutzerverwaltungBtn.Name = "benutzerverwaltungBtn";
            this.benutzerverwaltungBtn.Size = new System.Drawing.Size(115, 34);
            this.benutzerverwaltungBtn.TabIndex = 5;
            this.benutzerverwaltungBtn.Text = "Benutzerverwaltung";
            this.benutzerverwaltungBtn.UseVisualStyleBackColor = true;
            this.benutzerverwaltungBtn.Click += new System.EventHandler(this.benutzerverwaltungBtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.benutzerverwaltungBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.neuerEintragBtn);
            this.Controls.Add(this.kundenDatenView);
            this.Controls.Add(this.beendenBtn);
            this.Name = "StartForm";
            this.Text = "Kundendaten";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.kundenDatenView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button beendenBtn;
        private System.Windows.Forms.DataGridView kundenDatenView;
        private System.Windows.Forms.Button neuerEintragBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button benutzerverwaltungBtn;
    }
}