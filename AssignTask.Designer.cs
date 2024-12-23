namespace WinFormsApp4
{
    partial class AssignTask
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
            Submit_btn = new Guna.UI2.WinForms.Guna2Button();
            Assign_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Teams_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            assigning_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Hanging_radio = new Guna.UI2.WinForms.Guna2RadioButton();
            operation_radio = new Guna.UI2.WinForms.Guna2RadioButton();
            Installation_radio = new Guna.UI2.WinForms.Guna2RadioButton();
            Pulling_txt = new Guna.UI2.WinForms.Guna2RadioButton();
            tasks_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            decrip_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            des_txt = new Guna.UI2.WinForms.Guna2TextBox();
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
            nav_panel.TabIndex = 13;
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
            // Submit_btn
            // 
            Submit_btn.BorderRadius = 30;
            Submit_btn.CustomizableEdges = customizableEdges2;
            Submit_btn.DisabledState.BorderColor = Color.DarkGray;
            Submit_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            Submit_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Submit_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Submit_btn.FillColor = Color.Orange;
            Submit_btn.Font = new Font("Comic Sans MS", 9F);
            Submit_btn.ForeColor = Color.Black;
            Submit_btn.HoverState.FillColor = Color.SteelBlue;
            Submit_btn.HoverState.ForeColor = Color.White;
            Submit_btn.Location = new Point(441, 610);
            Submit_btn.Name = "Submit_btn";
            Submit_btn.ShadowDecoration.CustomizableEdges = customizableEdges3;
            Submit_btn.Size = new Size(265, 56);
            Submit_btn.TabIndex = 19;
            Submit_btn.Text = "Submit";
            Submit_btn.Click += Submit_btn_Click;
            // 
            // Assign_lbl
            // 
            Assign_lbl.BackColor = Color.Transparent;
            Assign_lbl.Font = new Font("Comic Sans MS", 18.2F, FontStyle.Bold);
            Assign_lbl.Location = new Point(441, 92);
            Assign_lbl.Name = "Assign_lbl";
            Assign_lbl.Size = new Size(177, 43);
            Assign_lbl.TabIndex = 14;
            Assign_lbl.Text = "Assign Task";
            // 
            // Teams_lbl
            // 
            Teams_lbl.BackColor = Color.Transparent;
            Teams_lbl.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold);
            Teams_lbl.Location = new Point(100, 170);
            Teams_lbl.Name = "Teams_lbl";
            Teams_lbl.Size = new Size(74, 34);
            Teams_lbl.TabIndex = 16;
            Teams_lbl.Text = "Teams";
            // 
            // assigning_lbl
            // 
            assigning_lbl.BackColor = Color.Transparent;
            assigning_lbl.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            assigning_lbl.Location = new Point(91, 384);
            assigning_lbl.Name = "assigning_lbl";
            assigning_lbl.Size = new Size(147, 31);
            assigning_lbl.TabIndex = 17;
            assigning_lbl.Text = "Assigning Task";
            // 
            // Hanging_radio
            // 
            Hanging_radio.AutoSize = true;
            Hanging_radio.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Hanging_radio.CheckedState.BorderThickness = 0;
            Hanging_radio.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Hanging_radio.CheckedState.InnerColor = Color.White;
            Hanging_radio.CheckedState.InnerOffset = -4;
            Hanging_radio.Font = new Font("Comic Sans MS", 9F);
            Hanging_radio.Location = new Point(154, 226);
            Hanging_radio.Name = "Hanging_radio";
            Hanging_radio.Size = new Size(86, 24);
            Hanging_radio.TabIndex = 20;
            Hanging_radio.Text = "Hanging";
            Hanging_radio.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Hanging_radio.UncheckedState.BorderThickness = 2;
            Hanging_radio.UncheckedState.FillColor = Color.Transparent;
            Hanging_radio.UncheckedState.InnerColor = Color.Transparent;
            // 
            // operation_radio
            // 
            operation_radio.AutoSize = true;
            operation_radio.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            operation_radio.CheckedState.BorderThickness = 0;
            operation_radio.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            operation_radio.CheckedState.InnerColor = Color.White;
            operation_radio.CheckedState.InnerOffset = -4;
            operation_radio.Font = new Font("Comic Sans MS", 9F);
            operation_radio.ForeColor = Color.Black;
            operation_radio.ImageAlign = ContentAlignment.BottomRight;
            operation_radio.Location = new Point(154, 256);
            operation_radio.Name = "operation_radio";
            operation_radio.Size = new Size(112, 24);
            operation_radio.TabIndex = 21;
            operation_radio.Text = "Operational";
            operation_radio.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            operation_radio.UncheckedState.BorderThickness = 2;
            operation_radio.UncheckedState.FillColor = Color.Transparent;
            operation_radio.UncheckedState.InnerColor = Color.Transparent;
            // 
            // Installation_radio
            // 
            Installation_radio.AutoSize = true;
            Installation_radio.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Installation_radio.CheckedState.BorderThickness = 0;
            Installation_radio.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Installation_radio.CheckedState.InnerColor = Color.White;
            Installation_radio.CheckedState.InnerOffset = -4;
            Installation_radio.Font = new Font("Comic Sans MS", 9F);
            Installation_radio.Location = new Point(154, 286);
            Installation_radio.Name = "Installation_radio";
            Installation_radio.Size = new Size(111, 24);
            Installation_radio.TabIndex = 22;
            Installation_radio.Text = "Installation";
            Installation_radio.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Installation_radio.UncheckedState.BorderThickness = 2;
            Installation_radio.UncheckedState.FillColor = Color.Transparent;
            Installation_radio.UncheckedState.InnerColor = Color.Transparent;
            // 
            // Pulling_txt
            // 
            Pulling_txt.AutoSize = true;
            Pulling_txt.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Pulling_txt.CheckedState.BorderThickness = 0;
            Pulling_txt.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Pulling_txt.CheckedState.InnerColor = Color.White;
            Pulling_txt.CheckedState.InnerOffset = -4;
            Pulling_txt.Font = new Font("Comic Sans MS", 9F);
            Pulling_txt.Location = new Point(154, 316);
            Pulling_txt.Name = "Pulling_txt";
            Pulling_txt.Size = new Size(74, 24);
            Pulling_txt.TabIndex = 23;
            Pulling_txt.Text = "Pulling";
            Pulling_txt.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Pulling_txt.UncheckedState.BorderThickness = 2;
            Pulling_txt.UncheckedState.FillColor = Color.Transparent;
            Pulling_txt.UncheckedState.InnerColor = Color.Transparent;
            // 
            // tasks_combo
            // 
            tasks_combo.AutoRoundedCorners = true;
            tasks_combo.BackColor = Color.Transparent;
            tasks_combo.BorderColor = Color.Black;
            tasks_combo.BorderRadius = 17;
            tasks_combo.CustomizableEdges = customizableEdges4;
            tasks_combo.DrawMode = DrawMode.OwnerDrawFixed;
            tasks_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            tasks_combo.FocusedColor = Color.FromArgb(94, 148, 255);
            tasks_combo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tasks_combo.Font = new Font("Comic Sans MS", 10F);
            tasks_combo.ForeColor = Color.Black;
            tasks_combo.ItemHeight = 30;
            tasks_combo.Location = new Point(259, 384);
            tasks_combo.Name = "tasks_combo";
            tasks_combo.ShadowDecoration.CustomizableEdges = customizableEdges5;
            tasks_combo.Size = new Size(632, 36);
            tasks_combo.TabIndex = 24;
            tasks_combo.SelectedIndexChanged += tasks_combo_SelectedIndexChanged_1;
            // 
            // decrip_lbl
            // 
            decrip_lbl.BackColor = Color.Transparent;
            decrip_lbl.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold);
            decrip_lbl.Location = new Point(91, 496);
            decrip_lbl.Name = "decrip_lbl";
            decrip_lbl.Size = new Size(102, 31);
            decrip_lbl.TabIndex = 25;
            decrip_lbl.Text = "Descripion";
            // 
            // des_txt
            // 
            des_txt.BorderColor = Color.Black;
            des_txt.BorderRadius = 30;
            des_txt.CustomizableEdges = customizableEdges6;
            des_txt.DefaultText = "";
            des_txt.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            des_txt.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            des_txt.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            des_txt.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            des_txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            des_txt.Font = new Font("Comic Sans MS", 9F);
            des_txt.ForeColor = Color.Black;
            des_txt.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            des_txt.Location = new Point(259, 478);
            des_txt.Margin = new Padding(3, 4, 3, 4);
            des_txt.Name = "des_txt";
            des_txt.PasswordChar = '\0';
            des_txt.PlaceholderText = "Description";
            des_txt.SelectedText = "";
            des_txt.ShadowDecoration.CustomizableEdges = customizableEdges7;
            des_txt.Size = new Size(644, 60);
            des_txt.TabIndex = 26;
            // 
            // AssignTask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1037, 726);
            Controls.Add(des_txt);
            Controls.Add(decrip_lbl);
            Controls.Add(tasks_combo);
            Controls.Add(Pulling_txt);
            Controls.Add(Installation_radio);
            Controls.Add(operation_radio);
            Controls.Add(Hanging_radio);
            Controls.Add(Assign_lbl);
            Controls.Add(Teams_lbl);
            Controls.Add(assigning_lbl);
            Controls.Add(nav_panel);
            Controls.Add(Submit_btn);
            Name = "AssignTask";
            Text = "AssignTask";
            Load += AssignTask_Load_1;
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
        private Guna.UI2.WinForms.Guna2Button Submit_btn;
        private Guna.UI2.WinForms.Guna2TextBox Anoti1_txt;
        private Guna.UI2.WinForms.Guna2HtmlLabel Assign_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel Teams_lbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel assigning_lbl;
        private Guna.UI2.WinForms.Guna2RadioButton Hanging_radio;
        private Guna.UI2.WinForms.Guna2RadioButton operation_radio;
        private Guna.UI2.WinForms.Guna2RadioButton Installation_radio;
        private Guna.UI2.WinForms.Guna2RadioButton Pulling_txt;
        private Guna.UI2.WinForms.Guna2ComboBox tasks_combo;
        private Guna.UI2.WinForms.Guna2HtmlLabel decrip_lbl;
        private Guna.UI2.WinForms.Guna2TextBox des_txt;
    }
}