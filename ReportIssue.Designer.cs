namespace WinFormsApp4
{
    partial class ReportIssue
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            report_lbl = new Label();
            nav_panel = new Panel();
            Apic_box = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            NIRM_lbl = new Label();
            date_lbl = new Label();
            location_lbl = new Label();
            image_lbl = new Label();
            descrip_lbl = new Label();
            issue_lbl = new Label();
            issuename_txt = new Guna.UI2.WinForms.Guna2TextBox();
            datepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            location_txt = new Guna.UI2.WinForms.Guna2TextBox();
            image_btn = new Guna.UI2.WinForms.Guna2Button();
            submit_btn = new Guna.UI2.WinForms.Guna2Button();
            desc_txt = new Guna.UI2.WinForms.Guna2TextBox();
            nav_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Apic_box).BeginInit();
            SuspendLayout();
            // 
            // report_lbl
            // 
            report_lbl.AutoSize = true;
            report_lbl.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            report_lbl.Location = new Point(431, 90);
            report_lbl.Name = "report_lbl";
            report_lbl.Size = new Size(207, 39);
            report_lbl.TabIndex = 0;
            report_lbl.Text = "Report Issues";
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
            nav_panel.TabIndex = 16;
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
            // date_lbl
            // 
            date_lbl.AutoSize = true;
            date_lbl.BackColor = Color.White;
            date_lbl.Font = new Font("Comic Sans MS", 9F);
            date_lbl.Location = new Point(203, 281);
            date_lbl.Name = "date_lbl";
            date_lbl.Size = new Size(176, 20);
            date_lbl.TabIndex = 17;
            date_lbl.Text = "Date of Reporting Issue";
            // 
            // location_lbl
            // 
            location_lbl.AutoSize = true;
            location_lbl.Font = new Font("Comic Sans MS", 9F);
            location_lbl.Location = new Point(203, 354);
            location_lbl.Name = "location_lbl";
            location_lbl.Size = new Size(68, 20);
            location_lbl.TabIndex = 18;
            location_lbl.Text = "Location";
            // 
            // image_lbl
            // 
            image_lbl.AutoSize = true;
            image_lbl.Font = new Font("Comic Sans MS", 9F);
            image_lbl.Location = new Point(203, 424);
            image_lbl.Name = "image_lbl";
            image_lbl.Size = new Size(52, 20);
            image_lbl.TabIndex = 19;
            image_lbl.Text = "Image";
            // 
            // descrip_lbl
            // 
            descrip_lbl.AutoSize = true;
            descrip_lbl.Font = new Font("Comic Sans MS", 9F);
            descrip_lbl.Location = new Point(202, 510);
            descrip_lbl.Name = "descrip_lbl";
            descrip_lbl.Size = new Size(89, 20);
            descrip_lbl.TabIndex = 20;
            descrip_lbl.Text = "Description";
            // 
            // issue_lbl
            // 
            issue_lbl.AutoSize = true;
            issue_lbl.Font = new Font("Comic Sans MS", 9F);
            issue_lbl.Location = new Point(203, 209);
            issue_lbl.Name = "issue_lbl";
            issue_lbl.Size = new Size(84, 20);
            issue_lbl.TabIndex = 21;
            issue_lbl.Text = "Issue Title";
            // 
            // issuename_txt
            // 
            issuename_txt.BorderColor = Color.Black;
            issuename_txt.BorderRadius = 20;
            issuename_txt.CustomizableEdges = customizableEdges2;
            issuename_txt.DefaultText = "";
            issuename_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            issuename_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            issuename_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            issuename_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            issuename_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            issuename_txt.Font = new Font("Comic Sans MS", 9F);
            issuename_txt.ForeColor = Color.Black;
            issuename_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            issuename_txt.Location = new Point(406, 197);
            issuename_txt.Margin = new Padding(3, 4, 3, 4);
            issuename_txt.Name = "issuename_txt";
            issuename_txt.PasswordChar = '\0';
            issuename_txt.PlaceholderForeColor = Color.Gray;
            issuename_txt.PlaceholderText = "Issue Title ";
            issuename_txt.SelectedText = "";
            issuename_txt.ShadowDecoration.CustomizableEdges = customizableEdges3;
            issuename_txt.Size = new Size(433, 46);
            issuename_txt.TabIndex = 22;
            // 
            // datepicker
            // 
            datepicker.BorderRadius = 20;
            datepicker.Checked = true;
            datepicker.CustomizableEdges = customizableEdges4;
            datepicker.FillColor = Color.Orange;
            datepicker.Font = new Font("Segoe UI", 9F);
            datepicker.Format = DateTimePickerFormat.Long;
            datepicker.Location = new Point(406, 270);
            datepicker.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            datepicker.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            datepicker.Name = "datepicker";
            datepicker.ShadowDecoration.CustomizableEdges = customizableEdges5;
            datepicker.Size = new Size(433, 45);
            datepicker.TabIndex = 23;
            datepicker.Value = new DateTime(2024, 12, 19, 14, 25, 54, 471);
            // 
            // location_txt
            // 
            location_txt.BackColor = Color.White;
            location_txt.BorderColor = Color.Black;
            location_txt.BorderRadius = 20;
            location_txt.CustomizableEdges = customizableEdges6;
            location_txt.DefaultText = "";
            location_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            location_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            location_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            location_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            location_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            location_txt.Font = new Font("Comic Sans MS", 9F);
            location_txt.ForeColor = Color.Black;
            location_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            location_txt.Location = new Point(406, 344);
            location_txt.Margin = new Padding(3, 4, 3, 4);
            location_txt.Name = "location_txt";
            location_txt.PasswordChar = '\0';
            location_txt.PlaceholderText = "Location";
            location_txt.SelectedText = "";
            location_txt.ShadowDecoration.CustomizableEdges = customizableEdges7;
            location_txt.Size = new Size(433, 46);
            location_txt.TabIndex = 24;
            // 
            // image_btn
            // 
            image_btn.BorderRadius = 20;
            image_btn.CustomizableEdges = customizableEdges8;
            image_btn.DisabledState.BorderColor = Color.DarkGray;
            image_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            image_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            image_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            image_btn.FillColor = Color.Orange;
            image_btn.Font = new Font("Comic Sans MS", 9F);
            image_btn.ForeColor = Color.Black;
            image_btn.HoverState.FillColor = Color.SteelBlue;
            image_btn.HoverState.ForeColor = Color.White;
            image_btn.Location = new Point(406, 424);
            image_btn.Name = "image_btn";
            image_btn.ShadowDecoration.CustomizableEdges = customizableEdges9;
            image_btn.Size = new Size(433, 39);
            image_btn.TabIndex = 25;
            image_btn.Text = "Select Image";
            image_btn.Click += image_btn_Click;
            // 
            // submit_btn
            // 
            submit_btn.BackColor = Color.White;
            submit_btn.BorderRadius = 25;
            submit_btn.CustomizableEdges = customizableEdges10;
            submit_btn.DisabledState.BorderColor = Color.DarkGray;
            submit_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            submit_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            submit_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            submit_btn.FillColor = Color.Orange;
            submit_btn.Font = new Font("Comic Sans MS", 9F);
            submit_btn.ForeColor = Color.Black;
            submit_btn.HoverState.FillColor = Color.SteelBlue;
            submit_btn.HoverState.ForeColor = Color.White;
            submit_btn.Location = new Point(448, 614);
            submit_btn.Name = "submit_btn";
            submit_btn.ShadowDecoration.CustomizableEdges = customizableEdges11;
            submit_btn.Size = new Size(225, 56);
            submit_btn.TabIndex = 27;
            submit_btn.Text = "Submit Report";
            submit_btn.Click += submit_btn_Click;
            // 
            // desc_txt
            // 
            desc_txt.BackColor = Color.White;
            desc_txt.BorderColor = Color.Black;
            desc_txt.BorderRadius = 30;
            desc_txt.CustomizableEdges = customizableEdges12;
            desc_txt.DefaultText = "";
            desc_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            desc_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            desc_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            desc_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            desc_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            desc_txt.Font = new Font("Comic Sans MS", 9F);
            desc_txt.ForeColor = Color.Black;
            desc_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            desc_txt.Location = new Point(406, 490);
            desc_txt.Margin = new Padding(3, 4, 3, 4);
            desc_txt.Name = "desc_txt";
            desc_txt.PasswordChar = '\0';
            desc_txt.PlaceholderText = "Description";
            desc_txt.SelectedText = "";
            desc_txt.ShadowDecoration.CustomizableEdges = customizableEdges13;
            desc_txt.Size = new Size(433, 60);
            desc_txt.TabIndex = 28;
            // 
            // ReportIssue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1037, 726);
            Controls.Add(desc_txt);
            Controls.Add(submit_btn);
            Controls.Add(image_btn);
            Controls.Add(location_txt);
            Controls.Add(datepicker);
            Controls.Add(issuename_txt);
            Controls.Add(issue_lbl);
            Controls.Add(descrip_lbl);
            Controls.Add(image_lbl);
            Controls.Add(location_lbl);
            Controls.Add(date_lbl);
            Controls.Add(nav_panel);
            Controls.Add(report_lbl);
            Name = "ReportIssue";
            Text = "ReportIssue";
            nav_panel.ResumeLayout(false);
            nav_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Apic_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label report_lbl;
        private Panel nav_panel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Apic_box;
        private Label NIRM_lbl;
        private Label date_lbl;
        private Label location_lbl;
        private Label image_lbl;
        private Label descrip_lbl;
        private Label issue_lbl;
        private Guna.UI2.WinForms.Guna2TextBox issuename_txt;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepicker;
        private Guna.UI2.WinForms.Guna2TextBox location_txt;
        private Guna.UI2.WinForms.Guna2Button image_btn;
        private Guna.UI2.WinForms.Guna2Button submit_btn;
        private Guna.UI2.WinForms.Guna2TextBox desc_txt;
    }
}