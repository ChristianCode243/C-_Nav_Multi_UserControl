using Accessibility;

namespace C__Nav_Multi_UserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewControls(UserControl uc, Button btn)
        {
            PNL_main.Controls.Clear();

            BTN_home.BackColor = Color.DarkBlue; BTN_categories.BackColor = Color.DarkBlue;
            BTN_services.BackColor = Color.DarkBlue; BTN_employes.BackColor = Color.DarkBlue;
            BTN_produits.BackColor = Color.DarkBlue; BTN_apropos.BackColor = Color.DarkBlue;

            uc.Dock = DockStyle.Fill;
            btn.BackColor = Color.DodgerBlue;

            PNL_main.Controls.Add(uc);
        }

        private void BTN_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            viewControls(new uc_home(), BTN_home);
        }

        private void BTN_services_Click(object sender, EventArgs e)
        {
            viewControls(new uc_service(), BTN_services);
        }

        private void BTN_produits_Click(object sender, EventArgs e)
        {
            viewControls(new uc_produit(), BTN_produits);
        }

        private void BTN_categories_Click(object sender, EventArgs e)
        {
            viewControls(new uc_categorie(), BTN_categories);
        }

        private void BTN_employes_Click(object sender, EventArgs e)
        {
            viewControls(new uc_employe(), BTN_employes);
        }

        private void BTN_apropos_Click(object sender, EventArgs e)
        {
            viewControls(new uc_apropos(), BTN_apropos);
        }

        private void BTN_home_Click(object sender, EventArgs e)
        {
            viewControls(new uc_home(), BTN_home);
        }
    }
}
