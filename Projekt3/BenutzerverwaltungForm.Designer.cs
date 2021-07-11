
namespace Projekt3
{
    partial class BenutzerverwaltungForm
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
            this.userList = new System.Windows.Forms.ListBox();
            this.zurueckBtn = new System.Windows.Forms.Button();
            this.userAddBtn = new System.Windows.Forms.Button();
            this.userDeleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(12, 12);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(326, 264);
            this.userList.TabIndex = 0;
            // 
            // zurueckBtn
            // 
            this.zurueckBtn.Location = new System.Drawing.Point(344, 253);
            this.zurueckBtn.Name = "zurueckBtn";
            this.zurueckBtn.Size = new System.Drawing.Size(152, 23);
            this.zurueckBtn.TabIndex = 1;
            this.zurueckBtn.Text = "Zurück";
            this.zurueckBtn.UseVisualStyleBackColor = true;
            this.zurueckBtn.Click += new System.EventHandler(this.zurueckBtn_Click);
            // 
            // userAddBtn
            // 
            this.userAddBtn.Location = new System.Drawing.Point(345, 13);
            this.userAddBtn.Name = "userAddBtn";
            this.userAddBtn.Size = new System.Drawing.Size(151, 23);
            this.userAddBtn.TabIndex = 2;
            this.userAddBtn.Text = "Benutzer hinzufügen";
            this.userAddBtn.UseVisualStyleBackColor = true;
            this.userAddBtn.Click += new System.EventHandler(this.userAddBtn_Click);
            // 
            // userDeleteBtn
            // 
            this.userDeleteBtn.Location = new System.Drawing.Point(345, 42);
            this.userDeleteBtn.Name = "userDeleteBtn";
            this.userDeleteBtn.Size = new System.Drawing.Size(151, 23);
            this.userDeleteBtn.TabIndex = 3;
            this.userDeleteBtn.Text = "Benutzer löschen";
            this.userDeleteBtn.UseVisualStyleBackColor = true;
            this.userDeleteBtn.Click += new System.EventHandler(this.userDeleteBtn_Click);
            // 
            // BenutzerverwaltungForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 286);
            this.Controls.Add(this.userDeleteBtn);
            this.Controls.Add(this.userAddBtn);
            this.Controls.Add(this.zurueckBtn);
            this.Controls.Add(this.userList);
            this.Name = "BenutzerverwaltungForm";
            this.Text = "BenutzerverwaltungForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BenutzerverwaltungForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox userList;
        private System.Windows.Forms.Button zurueckBtn;
        private System.Windows.Forms.Button userAddBtn;
        private System.Windows.Forms.Button userDeleteBtn;
    }
}