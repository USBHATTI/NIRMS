namespace WinFormsApp4.User_Control
{
    partial class SignupControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupControl));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            sign_btn = new Guna.UI2.WinForms.Guna2Button();
            signchk = new CheckBox();
            semail_txt = new Guna.UI2.WinForms.Guna2TextBox();
            sname_txt = new Guna.UI2.WinForms.Guna2TextBox();
            spass_txt = new Guna.UI2.WinForms.Guna2TextBox();
            email_lbl = new Label();
            spass_lbl = new Label();
            sname_lbl = new Label();
            sign_pic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sign_pic).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(sign_btn);
            panel1.Controls.Add(signchk);
            panel1.Controls.Add(semail_txt);
            panel1.Controls.Add(sname_txt);
            panel1.Controls.Add(spass_txt);
            panel1.Controls.Add(email_lbl);
            panel1.Controls.Add(spass_lbl);
            panel1.Controls.Add(sname_lbl);
            panel1.Controls.Add(sign_pic);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 497);
            panel1.TabIndex = 0;
            // 
            // sign_btn
            // 
            sign_btn.BorderRadius = 20;
            sign_btn.CustomizableEdges = customizableEdges1;
            sign_btn.DisabledState.BorderColor = Color.DarkGray;
            sign_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            sign_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            sign_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            sign_btn.FillColor = Color.Orange;
            sign_btn.Font = new Font("Comic Sans MS", 9F);
            sign_btn.ForeColor = Color.Black;
            sign_btn.HoverState.FillColor = Color.SteelBlue;
            sign_btn.HoverState.ForeColor = Color.White;
            sign_btn.Location = new Point(83, 444);
            sign_btn.Name = "sign_btn";
            sign_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            sign_btn.Size = new Size(213, 37);
            sign_btn.TabIndex = 7;
            sign_btn.Text = "Signup";
            sign_btn.Click += sign_btn_Click;
            // 
            // signchk
            // 
            signchk.Font = new Font("Comic Sans MS", 9F);
            signchk.Location = new Point(47, 371);
            signchk.Name = "signchk";
            signchk.Size = new Size(299, 47);
            signchk.TabIndex = 1;
            signchk.Text = "you agree to NRMS's Conditions of Use and Privacy Notice.";
            signchk.UseVisualStyleBackColor = true;
            // 
            // semail_txt
            // 
            semail_txt.BorderRadius = 20;
            semail_txt.CustomizableEdges = customizableEdges3;
            semail_txt.DefaultText = "";
            semail_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            semail_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            semail_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            semail_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            semail_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            semail_txt.Font = new Font("Comic Sans MS", 9F);
            semail_txt.ForeColor = Color.Black;
            semail_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            semail_txt.Location = new Point(47, 314);
            semail_txt.Margin = new Padding(3, 4, 3, 4);
            semail_txt.Name = "semail_txt";
            semail_txt.PasswordChar = '\0';
            semail_txt.PlaceholderText = "Email";
            semail_txt.SelectedText = "";
            semail_txt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            semail_txt.Size = new Size(313, 37);
            semail_txt.TabIndex = 6;
            // 
            // sname_txt
            // 
            sname_txt.BorderRadius = 20;
            sname_txt.CustomizableEdges = customizableEdges5;
            sname_txt.DefaultText = "";
            sname_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            sname_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            sname_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            sname_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            sname_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            sname_txt.Font = new Font("Comic Sans MS", 9F);
            sname_txt.ForeColor = Color.Black;
            sname_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            sname_txt.Location = new Point(47, 173);
            sname_txt.Margin = new Padding(3, 4, 3, 4);
            sname_txt.Name = "sname_txt";
            sname_txt.PasswordChar = '\0';
            sname_txt.PlaceholderText = "Username";
            sname_txt.SelectedText = "";
            sname_txt.ShadowDecoration.CustomizableEdges = customizableEdges6;
            sname_txt.Size = new Size(313, 37);
            sname_txt.TabIndex = 5;
            // 
            // spass_txt
            // 
            spass_txt.BorderRadius = 20;
            spass_txt.CustomizableEdges = customizableEdges7;
            spass_txt.DefaultText = "";
            spass_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            spass_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            spass_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            spass_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            spass_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            spass_txt.Font = new Font("Comic Sans MS", 9F);
            spass_txt.ForeColor = Color.Black;
            spass_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            spass_txt.Location = new Point(47, 249);
            spass_txt.Margin = new Padding(3, 4, 3, 4);
            spass_txt.Name = "spass_txt";
            spass_txt.PasswordChar = '*';
            spass_txt.PlaceholderText = "Password";
            spass_txt.SelectedText = "";
            spass_txt.ShadowDecoration.CustomizableEdges = customizableEdges8;
            spass_txt.Size = new Size(313, 37);
            spass_txt.TabIndex = 4;
            // 
            // email_lbl
            // 
            email_lbl.AutoSize = true;
            email_lbl.Font = new Font("Comic Sans MS", 9F);
            email_lbl.Location = new Point(47, 290);
            email_lbl.Name = "email_lbl";
            email_lbl.Size = new Size(45, 20);
            email_lbl.TabIndex = 3;
            email_lbl.Text = "Email";
            // 
            // spass_lbl
            // 
            spass_lbl.AutoSize = true;
            spass_lbl.Font = new Font("Comic Sans MS", 9F);
            spass_lbl.Location = new Point(47, 214);
            spass_lbl.Name = "spass_lbl";
            spass_lbl.Size = new Size(74, 20);
            spass_lbl.TabIndex = 2;
            spass_lbl.Text = "Password";
            // 
            // sname_lbl
            // 
            sname_lbl.AutoSize = true;
            sname_lbl.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sname_lbl.Location = new Point(47, 136);
            sname_lbl.Name = "sname_lbl";
            sname_lbl.Size = new Size(77, 20);
            sname_lbl.TabIndex = 1;
            sname_lbl.Text = "Username";
            // 
            // sign_pic
            // 
            sign_pic.FillColor = Color.Transparent;
            sign_pic.Image = (Image)resources.GetObject("sign_pic.Image");
            sign_pic.ImageRotate = 0F;
            sign_pic.InitialImage = (Image)resources.GetObject("sign_pic.InitialImage");
            sign_pic.Location = new Point(83, -35);
            sign_pic.Name = "sign_pic";
            sign_pic.ShadowDecoration.CustomizableEdges = customizableEdges9;
            sign_pic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            sign_pic.Size = new Size(194, 211);
            sign_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            sign_pic.TabIndex = 0;
            sign_pic.TabStop = false;
            // 
            // SignupControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "SignupControl";
            Size = new Size(1055, 773);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sign_pic).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox sign_pic;
        private Guna.UI2.WinForms.Guna2TextBox semail_txt;
        private Guna.UI2.WinForms.Guna2TextBox sname_txt;
        private Guna.UI2.WinForms.Guna2TextBox spass_txt;
        private Label email_lbl;
        private Label spass_lbl;
        private Label sname_lbl;
        private CheckBox signchk;
        private Guna.UI2.WinForms.Guna2Button sign_btn;
    }
}
