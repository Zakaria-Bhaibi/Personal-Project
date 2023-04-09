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
    public partial class VendeurForm : Form
    {
        DBConnect dbconnect = new DBConnect();
        public VendeurForm()
        {
            InitializeComponent();
        }

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Vendeur Values (@pvid,@pvnom,@pvage,@pvphone,@pvpass)", dbconnect.GetCon());
                cmd.Parameters.AddWithValue("@pvid", textBox_id.Text);
                cmd.Parameters.AddWithValue("@pvnom", textBox_nom.Text);
                cmd.Parameters.AddWithValue("@pvage", textBox_age.Text);
                cmd.Parameters.AddWithValue("@pvphone", textBox_phone.Text);
                cmd.Parameters.AddWithValue("@pvpass", textBox_password.Text);
                dbconnect.openCon();
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    MessageBox.Show("Ajout bien fait");
                    dbconnect.closeCon();
                    getTable();
                    clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            getTable();
        }
        private void clear()
        {
            textBox_id.Clear();
            textBox_nom.Clear();
            textBox_age.Clear();
            textBox_phone.Clear();
            textBox_password.Clear();
        }
        private void getTable()
        {
            string q = "select * from Vendeur";
            SqlCommand cmd = new SqlCommand(q, dbconnect.GetCon());
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView_Vendeur.DataSource = dt;
        }

        private void label_fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            PFF_Projet.LoginForm login = new PFF_Projet.LoginForm();
            login.Show();
            this.Hide();
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "update Vendeur set vnom=@pvnom,vage=@pvage,vphone=@pvphone,vpass=@pvpass where vid=@pvid";
                SqlCommand cmd = new SqlCommand(q, dbconnect.GetCon());
                cmd.Parameters.AddWithValue("@pvnom", textBox_nom.Text);
                cmd.Parameters.AddWithValue("@pvage", textBox_age.Text);
                cmd.Parameters.AddWithValue("@pvphone", textBox_phone.Text);
                cmd.Parameters.AddWithValue("@pvpass", textBox_password.Text);
                cmd.Parameters.AddWithValue("@pvid", textBox_id.Text);
                dbconnect.openCon();
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    MessageBox.Show("Modification est bien fait");
                    dbconnect.closeCon();
                    clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            getTable();
        }

        private void VendeurForm_Load(object sender, EventArgs e)
        {
            getTable();
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "delete from Vendeur where vid=@pvid";
                SqlCommand cmd = new SqlCommand(q, dbconnect.GetCon());
                cmd.Parameters.AddWithValue("@pvid", textBox_id.Text);
                dbconnect.openCon();
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    MessageBox.Show("suppression est bien fait");
                }
                dbconnect.closeCon();
                getTable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ProduitForm produit = new ProduitForm();
            this.Hide();
            produit.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            CategorieForm categorie = new CategorieForm();
            this.Hide();
            categorie.Show();
        }
    }
}
