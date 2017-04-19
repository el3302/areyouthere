namespace areyouthere1
{
    partial class urlping
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
            this.urltestinput = new System.Windows.Forms.TextBox();
            this.testbutton = new System.Windows.Forms.Button();
            this.responselabel = new System.Windows.Forms.Label();
            this.responsebox = new System.Windows.Forms.TextBox();
            this.statuscodelabel = new System.Windows.Forms.Label();
            this.statustextbox = new System.Windows.Forms.TextBox();
            this.clearallbutton = new System.Windows.Forms.Button();
            this.quitbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urltestinput
            // 
            this.urltestinput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.urltestinput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.urltestinput.Location = new System.Drawing.Point(24, 23);
            this.urltestinput.Name = "urltestinput";
            this.urltestinput.Size = new System.Drawing.Size(266, 20);
            this.urltestinput.TabIndex = 0;
            this.urltestinput.Text = "http://website.com";
            // 
            // testbutton
            // 
            this.testbutton.BackColor = System.Drawing.SystemColors.HotTrack;
            this.testbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.testbutton.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.testbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testbutton.ForeColor = System.Drawing.SystemColors.Control;
            this.testbutton.Location = new System.Drawing.Point(377, 23);
            this.testbutton.Name = "testbutton";
            this.testbutton.Size = new System.Drawing.Size(75, 23);
            this.testbutton.TabIndex = 1;
            this.testbutton.Text = "Test";
            this.testbutton.UseVisualStyleBackColor = false;
            this.testbutton.Click += new System.EventHandler(this.testbutton_Click);
            // 
            // responselabel
            // 
            this.responselabel.AutoSize = true;
            this.responselabel.Location = new System.Drawing.Point(24, 69);
            this.responselabel.Name = "responselabel";
            this.responselabel.Size = new System.Drawing.Size(55, 13);
            this.responselabel.TabIndex = 2;
            this.responselabel.Text = "Response";
            // 
            // responsebox
            // 
            this.responsebox.BackColor = System.Drawing.SystemColors.Window;
            this.responsebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.responsebox.Location = new System.Drawing.Point(85, 66);
            this.responsebox.Multiline = true;
            this.responsebox.Name = "responsebox";
            this.responsebox.ReadOnly = true;
            this.responsebox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.responsebox.Size = new System.Drawing.Size(367, 116);
            this.responsebox.TabIndex = 3;
            // 
            // statuscodelabel
            // 
            this.statuscodelabel.AutoSize = true;
            this.statuscodelabel.Location = new System.Drawing.Point(12, 211);
            this.statuscodelabel.Name = "statuscodelabel";
            this.statuscodelabel.Size = new System.Drawing.Size(65, 13);
            this.statuscodelabel.TabIndex = 4;
            this.statuscodelabel.Text = "Status Code";
            // 
            // statustextbox
            // 
            this.statustextbox.BackColor = System.Drawing.SystemColors.Window;
            this.statustextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statustextbox.Location = new System.Drawing.Point(85, 208);
            this.statustextbox.Name = "statustextbox";
            this.statustextbox.ReadOnly = true;
            this.statustextbox.Size = new System.Drawing.Size(113, 20);
            this.statustextbox.TabIndex = 5;
            // 
            // clearallbutton
            // 
            this.clearallbutton.BackColor = System.Drawing.Color.Red;
            this.clearallbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearallbutton.ForeColor = System.Drawing.SystemColors.Window;
            this.clearallbutton.Location = new System.Drawing.Point(296, 23);
            this.clearallbutton.Name = "clearallbutton";
            this.clearallbutton.Size = new System.Drawing.Size(75, 23);
            this.clearallbutton.TabIndex = 6;
            this.clearallbutton.Text = "Clear";
            this.clearallbutton.UseVisualStyleBackColor = false;
            this.clearallbutton.Click += new System.EventHandler(this.clearallbutton_Click);
            // 
            // quitbutton
            // 
            this.quitbutton.BackColor = System.Drawing.Color.Fuchsia;
            this.quitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitbutton.ForeColor = System.Drawing.Color.White;
            this.quitbutton.Location = new System.Drawing.Point(377, 208);
            this.quitbutton.Name = "quitbutton";
            this.quitbutton.Size = new System.Drawing.Size(75, 23);
            this.quitbutton.TabIndex = 7;
            this.quitbutton.Text = "Quit";
            this.quitbutton.UseVisualStyleBackColor = false;
            this.quitbutton.Click += new System.EventHandler(this.quitbutton_Click);
            // 
            // urlping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 261);
            this.ControlBox = false;
            this.Controls.Add(this.quitbutton);
            this.Controls.Add(this.clearallbutton);
            this.Controls.Add(this.statustextbox);
            this.Controls.Add(this.statuscodelabel);
            this.Controls.Add(this.responsebox);
            this.Controls.Add(this.responselabel);
            this.Controls.Add(this.testbutton);
            this.Controls.Add(this.urltestinput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "urlping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "URL Ping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urltestinput;
        private System.Windows.Forms.Button testbutton;
        private System.Windows.Forms.Label responselabel;
        private System.Windows.Forms.TextBox responsebox;
        private System.Windows.Forms.Label statuscodelabel;
        private System.Windows.Forms.TextBox statustextbox;
        private System.Windows.Forms.Button clearallbutton;
        private System.Windows.Forms.Button quitbutton;
    }
}

