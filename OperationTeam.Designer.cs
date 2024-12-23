namespace WinFormsApp4
{
    partial class OperationTeam
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            nav_panel = new Panel();
            Apic_box = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            NIRM_lbl = new Label();
            pending_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            pending_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            OTnoti_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            OTnoti1_txt = new Guna.UI2.WinForms.Guna2TextBox();
            OTnoti2_txt = new Guna.UI2.WinForms.Guna2TextBox();
            OT_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            OThistory_btn = new Guna.UI2.WinForms.Guna2Button();
            view1_button = new Guna.UI2.WinForms.Guna2Button();
            view2_btn = new Guna.UI2.WinForms.Guna2Button();
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
            nav_panel.TabIndex = 14;
            // 
            // Apic_box
            // 
            Apic_box.ImageRotate = 0F;
            Apic_box.Location = new Point(964, 10);
            Apic_box.Name = "Apic_box";
            Apic_box.ShadowDecoration.CustomizableEdges = customizableEdges14;
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
            // pending_lbl
            // 
            pending_lbl.BackColor = Color.Transparent;
            pending_lbl.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            pending_lbl.Location = new Point(174, 201);
            pending_lbl.Name = "pending_lbl";
            pending_lbl.Size = new Size(157, 34);
            pending_lbl.TabIndex = 17;
            pending_lbl.Text = "Pending Tasks";
            // 
            // pending_combo
            // 
            pending_combo.BackColor = Color.Transparent;
            pending_combo.BorderColor = Color.Black;
            pending_combo.BorderRadius = 20;
            pending_combo.CustomizableEdges = customizableEdges15;
            pending_combo.DrawMode = DrawMode.OwnerDrawFixed;
            pending_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            pending_combo.FocusedColor = Color.FromArgb(94, 148, 255);
            pending_combo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            pending_combo.Font = new Font("Comic Sans MS", 10F);
            pending_combo.ForeColor = Color.Black;
            pending_combo.ItemHeight = 30;
            pending_combo.Location = new Point(220, 261);
            pending_combo.Name = "pending_combo";
            pending_combo.ShadowDecoration.CustomizableEdges = customizableEdges16;
            pending_combo.Size = new Size(593, 36);
            pending_combo.TabIndex = 18;
            // 
            // OTnoti_lbl
            // 
            OTnoti_lbl.BackColor = Color.Transparent;
            OTnoti_lbl.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            OTnoti_lbl.Location = new Point(174, 329);
            OTnoti_lbl.Name = "OTnoti_lbl";
            OTnoti_lbl.Size = new Size(146, 34);
            OTnoti_lbl.TabIndex = 19;
            OTnoti_lbl.Text = "Notifications";
            // 
            // OTnoti1_txt
            // 
            OTnoti1_txt.BackColor = Color.White;
            OTnoti1_txt.BorderColor = Color.Black;
            OTnoti1_txt.BorderRadius = 35;
            OTnoti1_txt.CustomizableEdges = customizableEdges17;
            OTnoti1_txt.DefaultText = "";
            OTnoti1_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            OTnoti1_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            OTnoti1_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            OTnoti1_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            OTnoti1_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            OTnoti1_txt.Font = new Font("Comic Sans MS", 9F);
            OTnoti1_txt.ForeColor = Color.Black;
            OTnoti1_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            OTnoti1_txt.Location = new Point(220, 401);
            OTnoti1_txt.Margin = new Padding(3, 4, 3, 4);
            OTnoti1_txt.Name = "OTnoti1_txt";
            OTnoti1_txt.PasswordChar = '\0';
            OTnoti1_txt.PlaceholderText = "";
            OTnoti1_txt.SelectedText = "";
            OTnoti1_txt.ShadowDecoration.CustomizableEdges = customizableEdges18;
            OTnoti1_txt.Size = new Size(593, 75);
            OTnoti1_txt.TabIndex = 20;
            // 
            // OTnoti2_txt
            // 
            OTnoti2_txt.BackColor = Color.White;
            OTnoti2_txt.BorderColor = Color.Black;
            OTnoti2_txt.BorderRadius = 35;
            OTnoti2_txt.CustomizableEdges = customizableEdges19;
            OTnoti2_txt.DefaultText = "";
            OTnoti2_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            OTnoti2_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            OTnoti2_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            OTnoti2_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            OTnoti2_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            OTnoti2_txt.Font = new Font("Comic Sans MS", 9F);
            OTnoti2_txt.ForeColor = Color.Black;
            OTnoti2_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            OTnoti2_txt.Location = new Point(220, 498);
            OTnoti2_txt.Margin = new Padding(3, 4, 3, 4);
            OTnoti2_txt.Name = "OTnoti2_txt";
            OTnoti2_txt.PasswordChar = '\0';
            OTnoti2_txt.PlaceholderText = "";
            OTnoti2_txt.SelectedText = "";
            OTnoti2_txt.ShadowDecoration.CustomizableEdges = customizableEdges20;
            OTnoti2_txt.Size = new Size(593, 75);
            OTnoti2_txt.TabIndex = 21;
            // 
            // OT_lbl
            // 
            OT_lbl.BackColor = Color.Transparent;
            OT_lbl.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            OT_lbl.Location = new Point(411, 112);
            OT_lbl.Name = "OT_lbl";
            OT_lbl.Size = new Size(261, 43);
            OT_lbl.TabIndex = 22;
            OT_lbl.Text = "Operational Team";
            // 
            // OThistory_btn
            // 
            OThistory_btn.BorderRadius = 33;
            OThistory_btn.CustomizableEdges = customizableEdges21;
            OThistory_btn.DisabledState.BorderColor = Color.DarkGray;
            OThistory_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            OThistory_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            OThistory_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            OThistory_btn.FillColor = Color.Orange;
            OThistory_btn.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OThistory_btn.ForeColor = Color.Black;
            OThistory_btn.HoverState.FillColor = Color.SteelBlue;
            OThistory_btn.HoverState.ForeColor = Color.White;
            OThistory_btn.Location = new Point(220, 618);
            OThistory_btn.Name = "OThistory_btn";
            OThistory_btn.ShadowDecoration.CustomizableEdges = customizableEdges22;
            OThistory_btn.Size = new Size(270, 61);
            OThistory_btn.TabIndex = 23;
            OThistory_btn.Text = "View History";
            // 
            // view1_button
            // 
            view1_button.BackColor = Color.White;
            view1_button.BorderRadius = 18;
            view1_button.CustomizableEdges = customizableEdges23;
            view1_button.DisabledState.BorderColor = Color.DarkGray;
            view1_button.DisabledState.CustomBorderColor = Color.DarkGray;
            view1_button.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            view1_button.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            view1_button.FillColor = Color.Orange;
            view1_button.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            view1_button.ForeColor = Color.Black;
            view1_button.HoverState.FillColor = Color.SteelBlue;
            view1_button.HoverState.ForeColor = Color.White;
            view1_button.Location = new Point(711, 423);
            view1_button.Name = "view1_button";
            view1_button.ShadowDecoration.CustomizableEdges = customizableEdges24;
            view1_button.Size = new Size(84, 36);
            view1_button.TabIndex = 24;
            view1_button.Text = "View";
            // 
            // view2_btn
            // 
            view2_btn.BackColor = Color.White;
            view2_btn.BorderRadius = 18;
            view2_btn.CustomizableEdges = customizableEdges25;
            view2_btn.DisabledState.BorderColor = Color.DarkGray;
            view2_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            view2_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            view2_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            view2_btn.FillColor = Color.Orange;
            view2_btn.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            view2_btn.ForeColor = Color.Black;
            view2_btn.HoverState.FillColor = Color.SteelBlue;
            view2_btn.HoverState.ForeColor = Color.White;
            view2_btn.Location = new Point(711, 518);
            view2_btn.Name = "view2_btn";
            view2_btn.ShadowDecoration.CustomizableEdges = customizableEdges26;
            view2_btn.Size = new Size(84, 36);
            view2_btn.TabIndex = 25;
            view2_btn.Text = "View";
            // 
            // OperationTeam
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1037, 726);
            Controls.Add(view2_btn);
            Controls.Add(view1_button);
            Controls.Add(OThistory_btn);
            Controls.Add(OT_lbl);
            Controls.Add(OTnoti2_txt);
            Controls.Add(OTnoti1_txt);
            Controls.Add(OTnoti_lbl);
            Controls.Add(pending_combo);
            Controls.Add(pending_lbl);
            Controls.Add(nav_panel);
            Name = "OperationTeam";
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
        private Guna.UI2.WinForms.Guna2HtmlLabel pending_lbl;
        private Guna.UI2.WinForms.Guna2ComboBox pending_combo;
        private Guna.UI2.WinForms.Guna2HtmlLabel OTnoti_lbl;
        private Guna.UI2.WinForms.Guna2TextBox OTnoti1_txt;
        private Guna.UI2.WinForms.Guna2TextBox OTnoti2_txt;
        private Guna.UI2.WinForms.Guna2HtmlLabel OT_lbl;
        private Guna.UI2.WinForms.Guna2Button OThistory_btn;
        private Guna.UI2.WinForms.Guna2Button view1_button;
        private Guna.UI2.WinForms.Guna2Button view2_btn;
    }
}