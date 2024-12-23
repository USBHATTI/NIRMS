namespace WinFormsApp4
{
    partial class History
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
            nav_panel = new Panel();
            Apic_box = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            NIRM_lbl = new Label();
            nav_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Apic_box).BeginInit();
            SuspendLayout();
            // 
            // nav_panel
            // 
            nav_panel.BackColor = Color.Orange;
            nav_panel.Controls.Add(Apic_box);
            nav_panel.Controls.Add(NIRM_lbl);
            nav_panel.Font = new Font("Comic Sans MS", 9F);
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
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1037, 726);
            Controls.Add(nav_panel);
            Name = "History";
            Text = "History";
            nav_panel.ResumeLayout(false);
            nav_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Apic_box).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel nav_panel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Apic_box;
        private Label NIRM_lbl;
    }
}