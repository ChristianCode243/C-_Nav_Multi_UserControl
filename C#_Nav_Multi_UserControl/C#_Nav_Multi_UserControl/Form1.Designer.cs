namespace C__Nav_Multi_UserControl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            BTN_exit = new Button();
            PNL_main = new Panel();
            BTN_home = new Button();
            BTN_services = new Button();
            BTN_produits = new Button();
            BTN_categories = new Button();
            BTN_employes = new Button();
            BTN_apropos = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(BTN_exit);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 30);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 1;
            label1.Text = "Mon Logiciel";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BTN_exit
            // 
            BTN_exit.Dock = DockStyle.Right;
            BTN_exit.FlatAppearance.BorderSize = 0;
            BTN_exit.FlatStyle = FlatStyle.Flat;
            BTN_exit.Location = new Point(751, 0);
            BTN_exit.Name = "BTN_exit";
            BTN_exit.Size = new Size(49, 30);
            BTN_exit.TabIndex = 0;
            BTN_exit.Text = "x";
            BTN_exit.UseVisualStyleBackColor = true;
            BTN_exit.Click += BTN_exit_Click;
            // 
            // PNL_main
            // 
            PNL_main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PNL_main.BackColor = SystemColors.ControlLight;
            PNL_main.Location = new Point(0, 33);
            PNL_main.Name = "PNL_main";
            PNL_main.Size = new Size(800, 374);
            PNL_main.TabIndex = 0;
            // 
            // BTN_home
            // 
            BTN_home.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BTN_home.BackColor = Color.DarkBlue;
            BTN_home.FlatAppearance.BorderSize = 0;
            BTN_home.FlatAppearance.CheckedBackColor = Color.DodgerBlue;
            BTN_home.FlatStyle = FlatStyle.Flat;
            BTN_home.ForeColor = Color.White;
            BTN_home.Location = new Point(12, 413);
            BTN_home.Name = "BTN_home";
            BTN_home.Size = new Size(100, 25);
            BTN_home.TabIndex = 1;
            BTN_home.Text = "Home";
            BTN_home.UseVisualStyleBackColor = false;
            BTN_home.Click += BTN_home_Click;
            // 
            // BTN_services
            // 
            BTN_services.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BTN_services.BackColor = Color.DarkBlue;
            BTN_services.FlatAppearance.BorderSize = 0;
            BTN_services.FlatAppearance.CheckedBackColor = Color.DodgerBlue;
            BTN_services.FlatStyle = FlatStyle.Flat;
            BTN_services.ForeColor = Color.White;
            BTN_services.Location = new Point(147, 413);
            BTN_services.Name = "BTN_services";
            BTN_services.Size = new Size(100, 25);
            BTN_services.TabIndex = 1;
            BTN_services.Text = "Service";
            BTN_services.UseVisualStyleBackColor = false;
            BTN_services.Click += BTN_services_Click;
            // 
            // BTN_produits
            // 
            BTN_produits.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BTN_produits.BackColor = Color.DarkBlue;
            BTN_produits.FlatAppearance.BorderSize = 0;
            BTN_produits.FlatAppearance.CheckedBackColor = Color.DodgerBlue;
            BTN_produits.FlatStyle = FlatStyle.Flat;
            BTN_produits.ForeColor = Color.White;
            BTN_produits.Location = new Point(282, 413);
            BTN_produits.Name = "BTN_produits";
            BTN_produits.Size = new Size(100, 25);
            BTN_produits.TabIndex = 1;
            BTN_produits.Text = "Produit";
            BTN_produits.UseVisualStyleBackColor = false;
            BTN_produits.Click += BTN_produits_Click;
            // 
            // BTN_categories
            // 
            BTN_categories.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BTN_categories.BackColor = Color.DarkBlue;
            BTN_categories.FlatAppearance.BorderSize = 0;
            BTN_categories.FlatAppearance.CheckedBackColor = Color.DodgerBlue;
            BTN_categories.FlatStyle = FlatStyle.Flat;
            BTN_categories.ForeColor = Color.White;
            BTN_categories.Location = new Point(417, 413);
            BTN_categories.Name = "BTN_categories";
            BTN_categories.Size = new Size(100, 25);
            BTN_categories.TabIndex = 1;
            BTN_categories.Text = "Catégorie";
            BTN_categories.UseVisualStyleBackColor = false;
            BTN_categories.Click += BTN_categories_Click;
            // 
            // BTN_employes
            // 
            BTN_employes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BTN_employes.BackColor = Color.DarkBlue;
            BTN_employes.FlatAppearance.BorderSize = 0;
            BTN_employes.FlatAppearance.CheckedBackColor = Color.DodgerBlue;
            BTN_employes.FlatStyle = FlatStyle.Flat;
            BTN_employes.ForeColor = Color.White;
            BTN_employes.Location = new Point(552, 413);
            BTN_employes.Name = "BTN_employes";
            BTN_employes.Size = new Size(100, 25);
            BTN_employes.TabIndex = 1;
            BTN_employes.Text = "Employé";
            BTN_employes.UseVisualStyleBackColor = false;
            BTN_employes.Click += BTN_employes_Click;
            // 
            // BTN_apropos
            // 
            BTN_apropos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            BTN_apropos.BackColor = Color.DarkBlue;
            BTN_apropos.FlatAppearance.BorderSize = 0;
            BTN_apropos.FlatAppearance.CheckedBackColor = Color.DodgerBlue;
            BTN_apropos.FlatStyle = FlatStyle.Flat;
            BTN_apropos.ForeColor = Color.White;
            BTN_apropos.Location = new Point(687, 413);
            BTN_apropos.Name = "BTN_apropos";
            BTN_apropos.Size = new Size(100, 25);
            BTN_apropos.TabIndex = 1;
            BTN_apropos.Text = "A propos";
            BTN_apropos.UseVisualStyleBackColor = false;
            BTN_apropos.Click += BTN_apropos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTN_apropos);
            Controls.Add(BTN_employes);
            Controls.Add(BTN_categories);
            Controls.Add(BTN_produits);
            Controls.Add(BTN_services);
            Controls.Add(BTN_home);
            Controls.Add(PNL_main);
            Controls.Add(panel1);
            ForeColor = Color.DodgerBlue;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mon Application";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button BTN_exit;
        private Panel PNL_main;
        private Button BTN_home;
        private Button BTN_services;
        private Button BTN_produits;
        private Button BTN_categories;
        private Button BTN_employes;
        private Button BTN_apropos;
    }
}
