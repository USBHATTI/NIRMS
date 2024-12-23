namespace WinFormsApp4
{
    partial class Communication
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
            nav_panel = new Panel();
            Apic_box = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            NIRM_lbl = new Label();
            send_btn = new Guna.UI2.WinForms.Guna2Button();
            Message_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            issues_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            commu_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Message_txt = new Guna.UI2.WinForms.Guna2TextBox();
            nav_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Apic_box).BeginInit();
            SuspendLayout();
            // 
            // nav_panel
            // 
            nav_panel.BackColor = Color.Orange;
            nav_panel.Controls.Add(Apic_box);
            nav_panel.Controls.Add(NIRM_lbl);
            nav_panel.ImeMode = ImeMode.NoControl;
            nav_panel.Location = new Point(0, 0);
            nav_panel.Name = "nav_panel";
            nav_panel.Size = new Size(1043, 54);
            nav_panel.TabIndex = 24;
            // 
            // Apic_box
            // 
            Apic_box.ImageRotate = 0F;
            Apic_box.Location = new Point(964, 10);
            Apic_box.Name = "Apic_box";
            Apic_box.ShadowDecoration.CustomizableEdges = customizableEdges1;
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
            // send_btn
            // 
            send_btn.BorderRadius = 28;
            send_btn.CustomizableEdges = customizableEdges2;
            send_btn.DisabledState.BorderColor = Color.DarkGray;
            send_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            send_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            send_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            send_btn.FillColor = Color.Orange;
            send_btn.Font = new Font("Comic Sans MS", 9F);
            send_btn.ForeColor = Color.Black;
            send_btn.HoverState.FillColor = Color.SteelBlue;
            send_btn.HoverState.ForeColor = Color.White;
            send_btn.Location = new Point(415, 593);
            send_btn.Name = "send_btn";
            send_btn.ShadowDecoration.CustomizableEdges = customizableEdges3;
            send_btn.Size = new Size(225, 56);
            send_btn.TabIndex = 23;
            send_btn.Text = "Send";
            // 
            // Message_lbl
            // 
            Message_lbl.BackColor = Color.Transparent;
            Message_lbl.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            Message_lbl.Location = new Point(238, 377);
            Message_lbl.Name = "Message_lbl";
            Message_lbl.Size = new Size(85, 31);
            Message_lbl.TabIndex = 22;
            Message_lbl.Text = "Message";
            // 
            // issues_lbl
            // 
            issues_lbl.BackColor = Color.Transparent;
            issues_lbl.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            issues_lbl.Location = new Point(238, 236);
            issues_lbl.Name = "issues_lbl";
            issues_lbl.Size = new Size(65, 31);
            issues_lbl.TabIndex = 19;
            issues_lbl.Text = "Issues";
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.AllowDrop = true;
            guna2ComboBox1.AutoRoundedCorners = true;
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.BorderColor = Color.Black;
            guna2ComboBox1.BorderRadius = 17;
            guna2ComboBox1.CustomizableEdges = customizableEdges4;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F);
            guna2ComboBox1.ForeColor = Color.Black;
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Location = new Point(238, 297);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2ComboBox1.Size = new Size(577, 36);
            guna2ComboBox1.TabIndex = 17;
            // 
            // commu_lbl
            // 
            commu_lbl.BackColor = Color.Transparent;
            commu_lbl.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            commu_lbl.Location = new Point(373, 132);
            commu_lbl.Name = "commu_lbl";
            commu_lbl.Size = new Size(253, 40);
            commu_lbl.TabIndex = 16;
            commu_lbl.Text = "Communication Hub";
            // 
            // Message_txt
            // 
            Message_txt.BorderColor = Color.Black;
            Message_txt.BorderRadius = 50;
            Message_txt.CustomizableEdges = customizableEdges6;
            Message_txt.DefaultText = "";
            Message_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Message_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Message_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Message_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Message_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Message_txt.Font = new Font("Comic Sans MS", 9F);
            Message_txt.ForeColor = Color.Black;
            Message_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Message_txt.Location = new Point(238, 415);
            Message_txt.Margin = new Padding(3, 4, 3, 4);
            Message_txt.Name = "Message_txt";
            Message_txt.PasswordChar = '\0';
            Message_txt.PlaceholderText = "";
            Message_txt.SelectedText = "";
            Message_txt.ShadowDecoration.CustomizableEdges = customizableEdges7;
            Message_txt.Size = new Size(577, 113);
            Message_txt.TabIndex = 14;
            // 
            // Communication
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1037, 726);
            Controls.Add(Message_txt);
            Controls.Add(nav_panel);
            Controls.Add(send_btn);
            Controls.Add(Message_lbl);
            Controls.Add(issues_lbl);
            Controls.Add(guna2ComboBox1);
            Controls.Add(commu_lbl);
            Name = "Communication";
            Text = "Communication";
            nav_panel.ResumeLayout(false);
            nav_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Apic_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel nav_panel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Apic_box;
        private Label NIRM_lbl;
        private Guna.UI2.WinForms.Guna2Button send_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel Message_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel issues_lbl;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel commu_lbl;
        private Guna.UI2.WinForms.Guna2TextBox Message_txt;
    }
}