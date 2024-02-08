namespace C__Nav_Multi_UserControl
{
    partial class uc_service
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.ForeColor = Color.MidnightBlue;
            label2.Location = new Point(3, 86);
            label2.Name = "label2";
            label2.Size = new Size(344, 23);
            label2.TabIndex = 1;
            label2.Text = "Bienvenue dans votre espace de services";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 42);
            label1.Name = "label1";
            label1.Size = new Size(344, 44);
            label1.TabIndex = 2;
            label1.Text = "Services";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uc_service
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.DodgerBlue;
            Name = "uc_service";
            Size = new Size(350, 150);
            ResumeLayout(false);
        }

        #endregion

        private Label label2;
        private Label label1;
    }
}
