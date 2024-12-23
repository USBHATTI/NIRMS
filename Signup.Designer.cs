namespace WinFormsApp4
{
    partial class Signup
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
            panel1 = new Panel();
            signdot_lbl = new Label();
            NIRM_lbl = new Label();
            Signup_panel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            haveacc_btn = new Guna.UI2.WinForms.Guna2Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Orange;
            panel1.Controls.Add(signdot_lbl);
            panel1.Controls.Add(NIRM_lbl);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1043, 62);
            panel1.TabIndex = 0;
            // 
            // signdot_lbl
            // 
            signdot_lbl.AutoSize = true;
            signdot_lbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            signdot_lbl.Location = new Point(990, 9);
            signdot_lbl.Name = "signdot_lbl";
            signdot_lbl.Size = new Size(23, 32);
            signdot_lbl.TabIndex = 1;
            signdot_lbl.Text = "⋮";
            // 
            // NIRM_lbl
            // 
            NIRM_lbl.AutoSize = true;
            NIRM_lbl.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            NIRM_lbl.Location = new Point(38, 9);
            NIRM_lbl.Name = "NIRM_lbl";
            NIRM_lbl.Size = new Size(176, 41);
            NIRM_lbl.TabIndex = 0;
            NIRM_lbl.Text = "N I R M S";
            // 
            // Signup_panel
            // 
            Signup_panel.BackColor = Color.Transparent;
            Signup_panel.FillColor = SystemColors.Control;
            Signup_panel.Location = new Point(333, 119);
            Signup_panel.Name = "Signup_panel";
            Signup_panel.Radius = 20;
            Signup_panel.ShadowColor = Color.Black;
            Signup_panel.Size = new Size(399, 522);
            Signup_panel.TabIndex = 2;
            Signup_panel.Paint += Signup_panel_Paint;
            // 
            // haveacc_btn
            // 
            haveacc_btn.BorderRadius = 20;
            haveacc_btn.CustomizableEdges = customizableEdges1;
            haveacc_btn.DisabledState.BorderColor = Color.DarkGray;
            haveacc_btn.DisabledState.CustomBorderColor = Color.DarkGray;
            haveacc_btn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            haveacc_btn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            haveacc_btn.FillColor = Color.Orange;
            haveacc_btn.Font = new Font("Comic Sans MS", 9F);
            haveacc_btn.ForeColor = Color.Black;
            haveacc_btn.HoverState.FillColor = Color.SteelBlue;
            haveacc_btn.HoverState.ForeColor = Color.White;
            haveacc_btn.Location = new Point(333, 658);
            haveacc_btn.Name = "haveacc_btn";
            haveacc_btn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            haveacc_btn.Size = new Size(399, 37);
            haveacc_btn.TabIndex = 0;
            haveacc_btn.Text = "Already have an account";
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1037, 726);
            Controls.Add(haveacc_btn);
            Controls.Add(Signup_panel);
            Controls.Add(panel1);
            Name = "Signup";
            Text = "Signup";
            Load += Signup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label signdot_lbl;
        private Label NIRM_lbl;
        private Guna.UI2.WinForms.Guna2ShadowPanel Signup_panel;
        private Guna.UI2.WinForms.Guna2Button haveacc_btn;
    }
}