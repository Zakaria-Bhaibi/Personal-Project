using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PFF_Projet
{   
    public partial class LoginForm : Form
    {
        DBConnect dbconnect = new DBConnect();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lebel_exit_MouseEnter(object sender, EventArgs e)
        {
            label_fermer.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_fermer.ForeColor = Color.Orange;
        }

        private void label_clear_MouseEnter(object sender, EventArgs e)
        {
            label_vider.ForeColor = Color.Red;
        }

        private void label_clear_MouseLeave(object sender, EventArgs e)
        {
            label_vider.ForeColor = Color.Orange;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_clear_Click(object sender, EventArgs e)
        {
            textBox_username.Clear();
            textBox_password.Clear();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            if(comboBox_Role.Text == "ADMIN")
            {
                if (textBox_username.Text.ToLower() == "admin" && textBox_password.Text.ToLower() == "admin")
                {
                    PFF_Projet.ProduitForm produit = new PFF_Projet.ProduitForm();
                    this.Hide();
                    produit.Show();
                }
                else
                {
                    MessageBox.Show("nom d'utilisateur ou mot de mass est incorrect");
                }
            }
            else
            {
                if(comboBox_Role.Text == "VENDEUR")
                {
                    if(textBox_username.Text != string.Empty && textBox_password.Text != string.Empty)
                    {
                        string q = "select * from Vendeur where vnom=@pnom and vpass=@ppass";
                        SqlCommand cmd = new SqlCommand(q, dbconnect.GetCon());
                        cmd.Parameters.AddWithValue("@pnom", textBox_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@ppass", textBox_password.Text.Trim());
                        dbconnect.openCon();
                        SqlDataReader dr = cmd.ExecuteReader();
                        bool res = dr.Read();
                        if (res)
                        {
                            MessageBox.Show("connexion réussie");
                            dbconnect.closeCon();
                            VentesForm ventes = new VentesForm();
                            this.Hide();
                            ventes.Show();
                        }
                        else
                        {
                            MessageBox.Show("Nom d'utilisateur ou mot de pass est incorrect");
                            dbconnect.closeCon();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tu dois remplir le nom d'etuilisateur et mot de pass");
                    }
                }
                else
                {
                    MessageBox.Show("Tu dois choisissez un role");
                }
            }
        }
    }
}
