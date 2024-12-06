namespace Lab_2
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_mymessage = new System.Windows.Forms.Button();
            this.btn_messenger = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(242)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.btn_mymessage);
            this.panel1.Controls.Add(this.btn_messenger);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 568);
            this.panel1.TabIndex = 1;
            // 
            // btn_mymessage
            // 
            this.btn_mymessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(251)))), ((int)(((byte)(167)))));
            this.btn_mymessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mymessage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(222)))), ((int)(((byte)(148)))));
            this.btn_mymessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mymessage.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mymessage.Location = new System.Drawing.Point(196, 261);
            this.btn_mymessage.Name = "btn_mymessage";
            this.btn_mymessage.Size = new System.Drawing.Size(255, 84);
            this.btn_mymessage.TabIndex = 5;
            this.btn_mymessage.Text = "My message";
            this.btn_mymessage.UseVisualStyleBackColor = false;
            this.btn_mymessage.Click += new System.EventHandler(this.btn_mymessage_Click);
            // 
            // btn_messenger
            // 
            this.btn_messenger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(251)))), ((int)(((byte)(167)))));
            this.btn_messenger.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_messenger.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_messenger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(222)))), ((int)(((byte)(148)))));
            this.btn_messenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_messenger.Font = new System.Drawing.Font("Lucida Calligraphy", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_messenger.Location = new System.Drawing.Point(196, 365);
            this.btn_messenger.Name = "btn_messenger";
            this.btn_messenger.Size = new System.Drawing.Size(255, 84);
            this.btn_messenger.TabIndex = 4;
            this.btn_messenger.Text = "Messenger";
            this.btn_messenger.UseVisualStyleBackColor = false;
            this.btn_messenger.Click += new System.EventHandler(this.btn_messenger_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 64F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 174);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 568);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_messenger;
        private System.Windows.Forms.Button btn_mymessage;
    }
}