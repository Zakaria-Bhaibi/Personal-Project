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
    public partial class ProduitForm : Form
    {
        DBConnect dbconnect = new DBConnect();
        public ProduitForm()
        {
            InitializeComponent();
        }

        private void label_fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Produit Values (@pid,@pnom,@pprix,@ppq,@pcat)", dbconnect.GetCon());
                cmd.Parameters.AddWithValue("@pid", textBox_id.Text);
                cmd.Parameters.AddWithValue("@pnom", textBox_nom.Text);
                cmd.Parameters.AddWithValue("@pprix", textBox_prix.Text);
                cmd.Parameters.AddWithValue("@ppq", textBox_quantite.Text);
                cmd.Parameters.AddWithValue("@pcat", comboBox_categorie.Text);
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

        private void label8_Click(object sender, EventArgs e)
        {
            CategorieForm categorie = new CategorieForm();
            this.Hide();
            categorie.Show();
        }
        private void getcat()
        {
            string q = "select * from Categorie";
            SqlCommand cmd = new SqlCommand(q, dbconnect.GetCon());
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            comboBox_categorie.DataSource = dt;
            comboBox_categorie.ValueMember = "catnom";
            comboBox_search.DataSource = dt;
            comboBox_search.ValueMember = "catnom";
        }

        private void ProduitForm_Load(object sender, EventArgs e)
        {
            getcat();
            getTable();
        }
        private void getTable()
        {
            string q = "select * from Produit";
            SqlCommand cmd = new SqlCommand(q, dbconnect.GetCon());
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView_Produit.DataSource = dt;
        }
        private void clear()
        {
            textBox_id.Clear();
            textBox_nom.Clear();
            textBox_prix.Clear();
            textBox_quantite.Clear();
            comboBox_categorie.SelectedIndex = -1;
        }

        private void button_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "update Produit set prodnom=@pnom,prodprix=@pprix,prodqtt=@pq,prodcat=@pcat where prodid=@pid";
                SqlCommand cmd = new SqlCommand(q, dbconnect.GetCon());
                cmd.Parameters.AddWithValue("@pid", textBox_id.Text);
                cmd.Parameters.AddWithValue("@pnom", textBox_nom.Text);
                cmd.Parameters.AddWithValue("@pprix", textBox_prix.Text);
                cmd.Parameters.AddWithValue("@pq", textBox_quantite.Text);
                cmd.Parameters.AddWithValue("@pcat", comboBox_categorie.Text);
                dbconnect.openCon();
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    MessageBox.Show("modification est bien fait");
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

        private void button_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "delete from Produit where prodid=@pid";
                SqlCommand cmd = new SqlCommand(q, dbconnect.GetCon());
                cmd.Parameters.AddWithValue("@pid", textBox_id.Text);
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

        private void button_refraichir_Click(object sender, EventArgs e)
        {
            getTable();
        }

        private void comboBox_search_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string q = "select * from Produit where prodcat=@pprodcat";
            SqlCommand cmd = new SqlCommand(q, dbconnect.GetCon());
            cmd.Parameters.AddWithValue("@pprodcat", comboBox_categorie.SelectedValue.ToString());
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView_Produit.DataSource = dt;
        }

        private void label10_Click(object sender, EventArgs e)
        {
            PFF_Projet.LoginForm login = new PFF_Projet.LoginForm();
            login.Show();
            this.Hide();
        }

        private void label_fermer_MouseEnter_1(object sender, EventArgs e)
        {
            label_fermer.ForeColor = Color.Red;
        }

        private void label_fermer_MouseLeave_1(object sender, EventArgs e)
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

        private void label6_Click(object sender, EventArgs e)
        {
            VendeurForm vendeur = new VendeurForm();
            this.Hide();
            vendeur.Show();
        }
    }
}
