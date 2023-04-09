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
    public partial class CategorieForm : Form
    {
        DBConnect dbconnect = new DBConnect();
        public CategorieForm()
        {
            InitializeComponent();
        }
        private void getTable()
        {
            string q = "select * from Categorie";
            SqlCommand cmd = new SqlCommand(q, dbconnect.GetCon());
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView_categorie.DataSource = dt;
        }
        private void button_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Categorie Values (@pid,@pnom,@pdes)", dbconnect.GetCon());
                cmd.Parameters.AddWithValue("@pid", textBox_id.Text);
                cmd.Parameters.AddWithValue("@pnom", textBox_nom.Text);
                cmd.Parameters.AddWithValue("@pdes", textBox_des.Text);
                dbconnect.openCon();
                int n = cmd.ExecuteNonQuery();
                if(n==1)
                {
                    MessageBox.Show("Ajout bien fait");
                    dbconnect.closeCon();
                    clear();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            getTable();
        }

        private void label_fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            getTable();
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "update Categorie set catdes=@pdes, catnom=@pnom  where catid=@pid";
                SqlCommand cmd = new SqlCommand(q, dbconnect.GetCon());
                cmd.Parameters.AddWithValue("@pid", textBox_id.Text);
                cmd.Parameters.AddWithValue("@pnom", textBox_nom.Text);
                cmd.Parameters.AddWithValue("@pdes", textBox_des.Text);
                dbconnect.openCon();
                int n= cmd.ExecuteNonQuery();
                if(n==1)
                {
                    MessageBox.Show("modification est bien fait");
                    dbconnect.closeCon();
                    clear();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            getTable();
        }

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "delete from Categorie where catid=@pid";
                SqlCommand cmd = new SqlCommand(q, dbconnect.GetCon());
                cmd.Parameters.AddWithValue("@pid", textBox_id.Text);
                dbconnect.openCon();
                int n = cmd.ExecuteNonQuery();
                if(n==1)
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
        private void clear()
        {
            textBox_id.Clear();
            textBox_nom.Clear();
            textBox_des.Clear();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            PFF_Projet.LoginForm login = new PFF_Projet.LoginForm();
            login.Show();
            this.Hide();
        }

        private void label_fermer_MouseEnter(object sender, EventArgs e)
        {
            label_fermer.ForeColor = Color.Red;
        }

        private void label_fermer_MouseLeave(object sender, EventArgs e)
        {
            label_fermer.ForeColor = Color.Orange;
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Red;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Orange;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ProduitForm produit = new ProduitForm();
            this.Hide();
            produit.Show();
        }

        private void label_vendeur_Click(object sender, EventArgs e)
        {
            VendeurForm vendeur = new VendeurForm();
            this.Hide();
            vendeur.Show();
        }
    }
}
