namespace WinFormsApp4
{
    partial class Forgetpass
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgetpass));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            log_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            forpass_lbl = new Label();
            sendemail_btn = new Guna.UI2.WinForms.Guna2Button();
            Femail_txt = new Guna.UI2.WinForms.Guna2TextBox();
            Femail_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            log_picbox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            panel1 = new Panel();
            dot_lbl = new Label();
            brand_lbl = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            log_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)log_picbox).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // log_panel
            // 
            log_panel.BackColor = Color.Transparent;
            log_panel.Controls.Add(forpass_lbl);
            log_panel.Controls.Add(sendemail_btn);
            log_panel.Controls.Add(Femail_txt);
            log_panel.Controls.Add(Femail_lbl);
            log_panel.Controls.Add(log_picbox);
            log_panel.FillColor = SystemColors.Control;
            log_panel.Location = new Point(307, 127);
            log_panel.Name = "log_panel";
            log_panel.Radius = 20;
            log_panel.ShadowColor = Color.Black;
            log_panel.Size = new Size(399, 493);
            log_panel.TabIndex = 6;
            // 
            // forpass_lbl
            // 
            forpass_lbl.AutoSize = true;
            forpass_lbl.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            forpass_lbl.Location = new Point(100, 184);
            forpass_lbl.Name = "forpass_lbl";
            forpass_lbl.Size = new Size(208, 32);
            forpass_lbl.TabIndex = 8;
            forpass_lbl.Text = "Forget Passsword";
            // 
            // sendemail_btn
            // 
            sendemail_btn.BorderRadius = 20;
            sendemail_btn.CustomizableEdges = customizableEdges1;
            sendemail_btn.DisabledState.BorderColor = Color.DarkGray;
            sendemail_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            sendemail_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            sendemail_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            sendemail_btn.FillColor = Color.Orange;
            sendemail_btn.Font = new Font("Segoe UI", 9F);
            sendemail_btn.ForeColor = Color.Black;
            sendemail_btn.HoverState.FillColor = Color.SteelBlue;
            sendemail_btn.HoverState.ForeColor = Color.White;
            sendemail_btn.Location = new Point(73, 400);
            sendemail_btn.Name = "sendemail_btn";
            sendemail_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            sendemail_btn.Size = new Size(271, 37);
            sendemail_btn.TabIndex = 5;
            sendemail_btn.Text = "Send Email";
            // 
            // Femail_txt
            // 
            Femail_txt.BorderRadius = 20;
            Femail_txt.CustomizableEdges = customizableEdges3;
            Femail_txt.DefaultText = "";
            Femail_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Femail_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Femail_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Femail_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Femail_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Femail_txt.Font = new Font("Comic Sans MS", 9F);
            Femail_txt.ForeColor = Color.Black;
            Femail_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Femail_txt.Location = new Point(53, 307);
            Femail_txt.Margin = new Padding(3, 4, 3, 4);
            Femail_txt.Name = "Femail_txt";
            Femail_txt.PasswordChar = '\0';
            Femail_txt.PlaceholderText = "Email";
            Femail_txt.SelectedText = "";
            Femail_txt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Femail_txt.Size = new Size(305, 44);
            Femail_txt.TabIndex = 6;
            Femail_txt.TextChanged += Femail_txt_TextChanged;
            // 
            // Femail_lbl
            // 
            Femail_lbl.BackColor = Color.Transparent;
            Femail_lbl.Font = new Font("Comic Sans MS", 12F);
            Femail_lbl.Location = new Point(53, 270);
            Femail_lbl.Name = "Femail_lbl";
            Femail_lbl.Size = new Size(51, 30);
            Femail_lbl.TabIndex = 4;
            Femail_lbl.Text = "Email";
            // 
            // log_picbox
            // 
            log_picbox.FillColor = Color.DimGray;
            log_picbox.Image = (Image)resources.GetObject("log_picbox.Image");
            log_picbox.ImageRotate = 0F;
            log_picbox.InitialImage = (Image)resources.GetObject("log_picbox.InitialImage");
            log_picbox.Location = new Point(100, -16);
            log_picbox.Name = "log_picbox";
            log_picbox.ShadowDecoration.CustomizableEdges = customizableEdges5;
            log_picbox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            log_picbox.Size = new Size(194, 211);
            log_picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            log_picbox.TabIndex = 4;
            log_picbox.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(dot_lbl);
            panel1.Controls.Add(brand_lbl);
            panel1.Location = new Point(-121, -115);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 54);
            panel1.TabIndex = 5;
            // 
            // dot_lbl
            // 
            dot_lbl.AutoSize = true;
            dot_lbl.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dot_lbl.Location = new Point(988, 9);
            dot_lbl.Name = "dot_lbl";
            dot_lbl.Size = new Size(27, 38);
            dot_lbl.TabIndex = 2;
            dot_lbl.Text = "⋮";
            // 
            // brand_lbl
            // 
            brand_lbl.AutoSize = true;
            brand_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brand_lbl.Location = new Point(26, 6);
            brand_lbl.Name = "brand_lbl";
            brand_lbl.Size = new Size(150, 41);
            brand_lbl.TabIndex = 1;
            brand_lbl.Text = "N I R M S";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Orange;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1043, 54);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(988, 9);
            label1.Name = "label1";
            label1.Size = new Size(27, 38);
            label1.TabIndex = 2;
            label1.Text = "⋮";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            label2.Location = new Point(26, 6);
            label2.Name = "label2";
            label2.Size = new Size(176, 41);
            label2.TabIndex = 1;
            label2.Text = "N I R M S";
            // 
            // Forgetpass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1037, 726);
            Controls.Add(panel2);
            Controls.Add(log_panel);
            Controls.Add(panel1);
            Name = "Forgetpass";
            Text = "Form2";
            log_panel.ResumeLayout(false);
            log_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)log_picbox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel log_panel;
        private Label forpass_lbl;
        private Guna.UI2.WinForms.Guna2Button sendemail_btn;
        private Guna.UI2.WinForms.Guna2TextBox Femail_txt;
        private Guna.UI2.WinForms.Guna2TextBox lname_txt;
        private Guna.UI2.WinForms.Guna2HtmlLabel Femail_lbl;
        private Guna.UI2.WinForms.Guna2CirclePictureBox log_picbox;
        private Panel panel1;
        private Label dot_lbl;
        private Label brand_lbl;
        private Panel panel2;
        private Label label1;
        private Label label2;
    }
}