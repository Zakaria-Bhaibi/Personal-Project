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
    public partial class VentesForm : Form
    {
        DBConnect dbconnect = new DBConnect();
        public VentesForm()
        {
            InitializeComponent();
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
        }
        private void getTable()
        {
            string q = "select prodnom,prodprix from Produit";
            SqlCommand cmd = new SqlCommand(q, dbconnect.GetCon());
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView_produit.DataSource = dt;
        }
        private void getventesTable()
        {
            string q = "select * from Facture";
            SqlCommand cmd = new SqlCommand(q, dbconnect.GetCon());
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView_VentesList.DataSource = dt;
        }

        private void VentesForm_Load(object sender, EventArgs e)
        {
            getTable();
            getcat();
            label_date.Text = DateTime.Now.ToString();
        }

        private void label_fermer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }
        int gtotal = 0, n = 0;

        private void button_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Facture Values (@pfid,@pvnom,@pvdate,@pmontanttotal)", dbconnect.GetCon());
                cmd.Parameters.AddWithValue("@pfid", textBox_fid.Text);
                cmd.Parameters.AddWithValue("@pvnom", label_nomvendeur.Text);
                cmd.Parameters.AddWithValue("@pvdate", label_date.Text);
                cmd.Parameters.AddWithValue("@pmontanttotal", gtotal.ToString());
                dbconnect.openCon();
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    MessageBox.Show("Ajout bien fait");
                    dbconnect.closeCon();
                    getventesTable();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            getTable();
        }

        private void dataGridView_VentesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_ajouterc_Click(object sender, EventArgs e)
        {
            if(textBox_nom.Text == "" || textBox_prix.Text == "" || textBox_quantite.Text == "")
            {
                MessageBox.Show("informations manquantes");
            }
            else
            {
                int Total = Convert.ToInt32(textBox_prix.Text) * Convert.ToInt32(textBox_quantite.Text);
                DataGridViewRow addRow = new DataGridViewRow();
                addRow.CreateCells(dataGridView_commande);
                addRow.Cells[0].Value = ++n;
                addRow.Cells[1].Value = textBox_nom.Text;
                addRow.Cells[2].Value = textBox_prix.Text;
                addRow.Cells[3].Value = textBox_quantite.Text;
                addRow.Cells[4].Value = Total;
                dataGridView_commande.Rows.Add(addRow);
                gtotal += Total;
                label12.Text = gtotal.ToString();
            }
            
        }
    }
}
