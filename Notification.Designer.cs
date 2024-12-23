namespace WinFormsApp4
{
    partial class Notification
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            noti_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Issues_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            Teams_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            issues_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            team_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Message_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            send_btn = new Guna.UI2.WinForms.Guna2Button();
            nav_panel = new Panel();
            Apic_box = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            NIRM_lbl = new Label();
            Message_txt = new Guna.UI2.WinForms.Guna2TextBox();
            nav_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Apic_box).BeginInit();
            SuspendLayout();
            // 
            // noti_lbl
            // 
            noti_lbl.BackColor = Color.Transparent;
            noti_lbl.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold);
            noti_lbl.Location = new Point(394, 120);
            noti_lbl.Name = "noti_lbl";
            noti_lbl.Size = new Size(223, 40);
            noti_lbl.TabIndex = 0;
            noti_lbl.Text = "Notification Hub";
            // 
            // Issues_combo
            // 
            Issues_combo.AutoRoundedCorners = true;
            Issues_combo.BackColor = Color.Transparent;
            Issues_combo.BorderColor = Color.Black;
            Issues_combo.BorderRadius = 17;
            Issues_combo.CustomizableEdges = customizableEdges1;
            Issues_combo.DrawMode = DrawMode.OwnerDrawFixed;
            Issues_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            Issues_combo.FocusedColor = Color.FromArgb(94, 148, 255);
            Issues_combo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Issues_combo.Font = new Font("Comic Sans MS", 10F);
            Issues_combo.ForeColor = Color.Black;
            Issues_combo.ItemHeight = 30;
            Issues_combo.Location = new Point(241, 249);
            Issues_combo.Name = "Issues_combo";
            Issues_combo.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Issues_combo.Size = new Size(577, 36);
            Issues_combo.TabIndex = 1;
            // 
            // Teams_combo
            // 
            Teams_combo.AutoRoundedCorners = true;
            Teams_combo.BackColor = Color.Transparent;
            Teams_combo.BorderColor = Color.Black;
            Teams_combo.BorderRadius = 17;
            Teams_combo.CustomizableEdges = customizableEdges3;
            Teams_combo.DrawMode = DrawMode.OwnerDrawFixed;
            Teams_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            Teams_combo.FocusedColor = Color.FromArgb(94, 148, 255);
            Teams_combo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Teams_combo.Font = new Font("Comic Sans MS", 10F);
            Teams_combo.ForeColor = Color.Black;
            Teams_combo.ItemHeight = 30;
            Teams_combo.Location = new Point(241, 361);
            Teams_combo.Name = "Teams_combo";
            Teams_combo.ShadowDecoration.CustomizableEdges = customizableEdges4;
            Teams_combo.Size = new Size(577, 36);
            Teams_combo.TabIndex = 2;
            // 
            // issues_lbl
            // 
            issues_lbl.BackColor = Color.Transparent;
            issues_lbl.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            issues_lbl.Location = new Point(241, 186);
            issues_lbl.Name = "issues_lbl";
            issues_lbl.Size = new Size(65, 31);
            issues_lbl.TabIndex = 3;
            issues_lbl.Text = "Issues";
            // 
            // team_lbl
            // 
            team_lbl.BackColor = Color.Transparent;
            team_lbl.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            team_lbl.Location = new Point(241, 314);
            team_lbl.Name = "team_lbl";
            team_lbl.Size = new Size(65, 31);
            team_lbl.TabIndex = 4;
            team_lbl.Text = "Teams";
            // 
            // Message_lbl
            // 
            Message_lbl.BackColor = Color.Transparent;
            Message_lbl.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            Message_lbl.Location = new Point(250, 430);
            Message_lbl.Name = "Message_lbl";
            Message_lbl.Size = new Size(85, 31);
            Message_lbl.TabIndex = 6;
            Message_lbl.Text = "Message";
            // 
            // send_btn
            // 
            send_btn.BorderRadius = 30;
            send_btn.CustomizableEdges = customizableEdges5;
            send_btn.DisabledState.BorderColor = Color.DarkGray;
            send_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            send_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            send_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            send_btn.FillColor = Color.Orange;
            send_btn.Font = new Font("Comic Sans MS", 9F);
            send_btn.ForeColor = Color.White;
            send_btn.HoverState.FillColor = Color.SteelBlue;
            send_btn.HoverState.ForeColor = Color.White;
            send_btn.Location = new Point(394, 627);
            send_btn.Name = "send_btn";
            send_btn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            send_btn.Size = new Size(241, 61);
            send_btn.TabIndex = 7;
            send_btn.Text = "Send";
            // 
            // nav_panel
            // 
            nav_panel.BackColor = Color.Orange;
            nav_panel.Controls.Add(Apic_box);
            nav_panel.Controls.Add(NIRM_lbl);
            nav_panel.ForeColor = Color.Black;
            nav_panel.ImeMode = ImeMode.NoControl;
            nav_panel.Location = new Point(0, 0);
            nav_panel.Name = "nav_panel";
            nav_panel.Size = new Size(1043, 54);
            nav_panel.TabIndex = 15;
            // 
            // Apic_box
            // 
            Apic_box.ImageRotate = 0F;
            Apic_box.Location = new Point(964, 10);
            Apic_box.Name = "Apic_box";
            Apic_box.ShadowDecoration.CustomizableEdges = customizableEdges7;
            Apic_box.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            Apic_box.Size = new Size(47, 37);
            Apic_box.TabIndex = 13;
            Apic_box.TabStop = false;
            // 
            // NIRM_lbl
            // 
            NIRM_lbl.AutoSize = true;
            NIRM_lbl.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold);
            NIRM_lbl.Location = new Point(30, 9);
            NIRM_lbl.Name = "NIRM_lbl";
            NIRM_lbl.Size = new Size(165, 39);
            NIRM_lbl.TabIndex = 0;
            NIRM_lbl.Text = "N I R M S";
            // 
            // Message_txt
            // 
            Message_txt.BackColor = Color.White;
            Message_txt.BorderColor = Color.Black;
            Message_txt.BorderRadius = 45;
            Message_txt.CustomizableEdges = customizableEdges8;
            Message_txt.DefaultText = "";
            Message_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Message_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Message_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Message_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Message_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Message_txt.Font = new Font("Comic Sans MS", 9F);
            Message_txt.ForeColor = Color.Black;
            Message_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Message_txt.Location = new Point(241, 478);
            Message_txt.Margin = new Padding(3, 4, 3, 4);
            Message_txt.Name = "Message_txt";
            Message_txt.PasswordChar = '\0';
            Message_txt.PlaceholderText = "";
            Message_txt.SelectedText = "";
            Message_txt.ShadowDecoration.CustomizableEdges = customizableEdges9;
            Message_txt.Size = new Size(577, 94);
            Message_txt.TabIndex = 14;
            // 
            // Notification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1037, 726);
            Controls.Add(Message_txt);
            Controls.Add(nav_panel);
            Controls.Add(send_btn);
            Controls.Add(Message_lbl);
            Controls.Add(team_lbl);
            Controls.Add(issues_lbl);
            Controls.Add(Teams_combo);
            Controls.Add(Issues_combo);
            Controls.Add(noti_lbl);
            Name = "Notification";
            Text = "Notification";
            nav_panel.ResumeLayout(false);
            nav_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Apic_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel noti_lbl;
        private Guna.UI2.WinForms.Guna2ComboBox Issues_combo;
        private Guna.UI2.WinForms.Guna2ComboBox Teams_combo;
        private Guna.UI2.WinForms.Guna2HtmlLabel issues_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel team_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel Message_lbl;
        private Guna.UI2.WinForms.Guna2Button send_btn;
        private Panel nav_panel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Apic_box;
        private Label NIRM_lbl;
        private Guna.UI2.WinForms.Guna2TextBox Message_txt;
    }
}