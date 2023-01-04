namespace WindowsFormsApp1
{
    partial class Minty
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minty));
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.siticoneButton1 = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.X = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneAnimateWindow1 = new Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow(this.components);
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.spam = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.msg = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneToggleSwitch1 = new Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(103)))));
            this.siticonePanel1.Controls.Add(this.label1);
            this.siticonePanel1.Controls.Add(this.siticoneButton1);
            this.siticonePanel1.Controls.Add(this.X);
            this.siticonePanel1.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Size = new System.Drawing.Size(575, 38);
            this.siticonePanel1.TabIndex = 0;
            this.siticonePanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.siticonePanel1_MouseDown);
            this.siticonePanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.siticonePanel1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(64)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(253, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Minty";
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.AutoRoundedCorners = true;
            this.siticoneButton1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneButton1.BorderRadius = 14;
            this.siticoneButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneButton1.FillColor = System.Drawing.Color.DarkRed;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.Location = new System.Drawing.Point(486, 3);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.Size = new System.Drawing.Size(40, 31);
            this.siticoneButton1.TabIndex = 1;
            this.siticoneButton1.Text = "-";
            this.siticoneButton1.Click += new System.EventHandler(this.minimize_Click);
            // 
            // X
            // 
            this.X.AutoRoundedCorners = true;
            this.X.BackColor = System.Drawing.Color.Transparent;
            this.X.BorderRadius = 14;
            this.X.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.X.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.X.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.X.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.X.FillColor = System.Drawing.Color.DarkRed;
            this.X.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.X.ForeColor = System.Drawing.Color.White;
            this.X.Location = new System.Drawing.Point(532, 3);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(40, 31);
            this.X.TabIndex = 0;
            this.X.Text = "X";
            this.X.Click += new System.EventHandler(this.close_Click);
            // 
            // siticoneAnimateWindow1
            // 
            this.siticoneAnimateWindow1.AnimationType = Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow.AnimateWindowType.AW_VER_POSITIVE;
            this.siticoneAnimateWindow1.TargetForm = this;
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.AutoRoundedCorners = true;
            this.siticoneTextBox1.BorderRadius = 17;
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Location = new System.Drawing.Point(121, 66);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "Enter webhook";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.Size = new System.Drawing.Size(332, 36);
            this.siticoneTextBox1.TabIndex = 1;
            // 
            // spam
            // 
            this.spam.AutoRoundedCorners = true;
            this.spam.BackColor = System.Drawing.Color.Transparent;
            this.spam.BorderRadius = 14;
            this.spam.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.spam.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.spam.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.spam.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.spam.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(103)))));
            this.spam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.spam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(49)))), ((int)(((byte)(107)))));
            this.spam.Location = new System.Drawing.Point(224, 209);
            this.spam.Name = "spam";
            this.spam.Size = new System.Drawing.Size(125, 31);
            this.spam.TabIndex = 3;
            this.spam.Text = "Spam";
            this.spam.Click += new System.EventHandler(this.spam_ClickAsync);
            // 
            // msg
            // 
            this.msg.AutoRoundedCorners = true;
            this.msg.BorderRadius = 17;
            this.msg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.msg.DefaultText = "";
            this.msg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.msg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.msg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.msg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.msg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.msg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.msg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.msg.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.msg.Location = new System.Drawing.Point(121, 118);
            this.msg.Name = "msg";
            this.msg.PasswordChar = '\0';
            this.msg.PlaceholderText = "Enter message";
            this.msg.SelectedText = "";
            this.msg.Size = new System.Drawing.Size(332, 36);
            this.msg.TabIndex = 4;
            // 
            // siticoneToggleSwitch1
            // 
            this.siticoneToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.siticoneToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.siticoneToggleSwitch1.Location = new System.Drawing.Point(304, 173);
            this.siticoneToggleSwitch1.Name = "siticoneToggleSwitch1";
            this.siticoneToggleSwitch1.Size = new System.Drawing.Size(45, 21);
            this.siticoneToggleSwitch1.TabIndex = 5;
            this.siticoneToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.siticoneToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.siticoneToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.siticoneToggleSwitch1.CheckedChanged += new System.EventHandler(this.siticoneToggleSwitch1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(103)))));
            this.label2.Location = new System.Drawing.Point(220, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Use proxy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(103)))));
            this.label3.Location = new System.Drawing.Point(12, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Made by Kweeper#8135";
            // 
            // Minty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(64)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(575, 267);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siticoneToggleSwitch1);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.spam);
            this.Controls.Add(this.siticoneTextBox1);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Minty";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minty";
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton X;
        private Siticone.Desktop.UI.WinForms.SiticoneButton siticoneButton1;
        private Siticone.Desktop.UI.WinForms.SiticoneAnimateWindow siticoneAnimateWindow1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Siticone.Desktop.UI.WinForms.SiticoneToggleSwitch siticoneToggleSwitch1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox msg;
        private Siticone.Desktop.UI.WinForms.SiticoneButton spam;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
    }
}

