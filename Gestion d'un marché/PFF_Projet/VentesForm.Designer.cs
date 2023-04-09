namespace PFF_Projet
{
    partial class VentesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_prix = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_fermer = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_ajouterc = new System.Windows.Forms.Button();
            this.textBox_quantite = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView_commande = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_fid = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button_venteslist = new System.Windows.Forms.Button();
            this.dataGridView_VentesList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_rafraichir = new System.Windows.Forms.Button();
            this.comboBox_categorie = new System.Windows.Forms.ComboBox();
            this.label_date = new System.Windows.Forms.Label();
            this.label_nomvendeur = new System.Windows.Forms.Label();
            this.dataGridView_produit = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_commande)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VentesList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produit)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(63, 504);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 28);
            this.label10.TabIndex = 32;
            this.label10.Text = "Logout";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox_prix
            // 
            this.textBox_prix.BorderRadius = 18;
            this.textBox_prix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_prix.DefaultText = " ";
            this.textBox_prix.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_prix.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_prix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_prix.DisabledState.Parent = this.textBox_prix;
            this.textBox_prix.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_prix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_prix.FocusedState.Parent = this.textBox_prix;
            this.textBox_prix.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_prix.ForeColor = System.Drawing.Color.Black;
            this.textBox_prix.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_prix.HoverState.Parent = this.textBox_prix;
            this.textBox_prix.Location = new System.Drawing.Point(124, 87);
            this.textBox_prix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_prix.Name = "textBox_prix";
            this.textBox_prix.PasswordChar = '\0';
            this.textBox_prix.PlaceholderText = "";
            this.textBox_prix.SelectedText = "";
            this.textBox_prix.SelectionStart = 1;
            this.textBox_prix.ShadowDecoration.Parent = this.textBox_prix;
            this.textBox_prix.Size = new System.Drawing.Size(150, 29);
            this.textBox_prix.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prix";
            // 
            // textBox_nom
            // 
            this.textBox_nom.BorderRadius = 18;
            this.textBox_nom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_nom.DefaultText = " ";
            this.textBox_nom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_nom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_nom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_nom.DisabledState.Parent = this.textBox_nom;
            this.textBox_nom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_nom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_nom.FocusedState.Parent = this.textBox_nom;
            this.textBox_nom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_nom.ForeColor = System.Drawing.Color.Black;
            this.textBox_nom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_nom.HoverState.Parent = this.textBox_nom;
            this.textBox_nom.Location = new System.Drawing.Point(124, 53);
            this.textBox_nom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.PasswordChar = '\0';
            this.textBox_nom.PlaceholderText = "";
            this.textBox_nom.SelectedText = "";
            this.textBox_nom.SelectionStart = 1;
            this.textBox_nom.ShadowDecoration.Parent = this.textBox_nom;
            this.textBox_nom.Size = new System.Drawing.Size(150, 29);
            this.textBox_nom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantite";
            // 
            // label_fermer
            // 
            this.label_fermer.AutoSize = true;
            this.label_fermer.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fermer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_fermer.Location = new System.Drawing.Point(870, -10);
            this.label_fermer.Name = "label_fermer";
            this.label_fermer.Size = new System.Drawing.Size(35, 37);
            this.label_fermer.TabIndex = 28;
            this.label_fermer.Text = "X";
            this.label_fermer.Click += new System.EventHandler(this.label_fermer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(211, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "VENTES MANAGEMENT";
            // 
            // button_ajouter
            // 
            this.button_ajouter.FlatAppearance.BorderSize = 0;
            this.button_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ajouter.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajouter.ForeColor = System.Drawing.Color.White;
            this.button_ajouter.Location = new System.Drawing.Point(602, 227);
            this.button_ajouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(82, 34);
            this.button_ajouter.TabIndex = 11;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_ajouterc
            // 
            this.button_ajouterc.FlatAppearance.BorderSize = 0;
            this.button_ajouterc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ajouterc.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajouterc.ForeColor = System.Drawing.Color.White;
            this.button_ajouterc.Location = new System.Drawing.Point(48, 163);
            this.button_ajouterc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ajouterc.Name = "button_ajouterc";
            this.button_ajouterc.Size = new System.Drawing.Size(180, 34);
            this.button_ajouterc.TabIndex = 10;
            this.button_ajouterc.Text = "Ajouter Commande";
            this.button_ajouterc.UseVisualStyleBackColor = true;
            this.button_ajouterc.Click += new System.EventHandler(this.button_ajouterc_Click);
            // 
            // textBox_quantite
            // 
            this.textBox_quantite.BorderRadius = 18;
            this.textBox_quantite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_quantite.DefaultText = " ";
            this.textBox_quantite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_quantite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_quantite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_quantite.DisabledState.Parent = this.textBox_quantite;
            this.textBox_quantite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_quantite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_quantite.FocusedState.Parent = this.textBox_quantite;
            this.textBox_quantite.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_quantite.ForeColor = System.Drawing.Color.Black;
            this.textBox_quantite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_quantite.HoverState.Parent = this.textBox_quantite;
            this.textBox_quantite.Location = new System.Drawing.Point(124, 121);
            this.textBox_quantite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_quantite.Name = "textBox_quantite";
            this.textBox_quantite.PasswordChar = '\0';
            this.textBox_quantite.PlaceholderText = "";
            this.textBox_quantite.SelectedText = "";
            this.textBox_quantite.SelectionStart = 1;
            this.textBox_quantite.ShadowDecoration.Parent = this.textBox_quantite;
            this.textBox_quantite.Size = new System.Drawing.Size(150, 29);
            this.textBox_quantite.TabIndex = 7;
            // 
            // dataGridView_commande
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_commande.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_commande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_commande.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_commande.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_commande.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_commande.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_commande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_commande.ColumnHeadersHeight = 4;
            this.dataGridView_commande.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdNom,
            this.ProdPrix,
            this.ProdQte,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_commande.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_commande.EnableHeadersVisualStyles = false;
            this.dataGridView_commande.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_commande.Location = new System.Drawing.Point(308, 50);
            this.dataGridView_commande.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_commande.Name = "dataGridView_commande";
            this.dataGridView_commande.RowHeadersVisible = false;
            this.dataGridView_commande.RowHeadersWidth = 51;
            this.dataGridView_commande.RowTemplate.Height = 24;
            this.dataGridView_commande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_commande.Size = new System.Drawing.Size(370, 135);
            this.dataGridView_commande.TabIndex = 17;
            this.dataGridView_commande.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_commande.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_commande.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_commande.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_commande.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_commande.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_commande.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_commande.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_commande.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_commande.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_commande.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_commande.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_commande.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView_commande.ThemeStyle.ReadOnly = false;
            this.dataGridView_commande.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_commande.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_commande.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_commande.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_commande.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_commande.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_commande.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ProdId
            // 
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.MinimumWidth = 6;
            this.ProdId.Name = "ProdId";
            // 
            // ProdNom
            // 
            this.ProdNom.HeaderText = "ProdNom";
            this.ProdNom.MinimumWidth = 6;
            this.ProdNom.Name = "ProdNom";
            // 
            // ProdPrix
            // 
            this.ProdPrix.HeaderText = "ProxPrid";
            this.ProdPrix.MinimumWidth = 6;
            this.ProdPrix.Name = "ProdPrix";
            // 
            // ProdQte
            // 
            this.ProdQte.HeaderText = "ProdQte";
            this.ProdQte.MinimumWidth = 6;
            this.ProdQte.Name = "ProdQte";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.textBox_fid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.button_venteslist);
            this.panel1.Controls.Add(this.dataGridView_VentesList);
            this.panel1.Controls.Add(this.button_rafraichir);
            this.panel1.Controls.Add(this.comboBox_categorie);
            this.panel1.Controls.Add(this.label_date);
            this.panel1.Controls.Add(this.label_nomvendeur);
            this.panel1.Controls.Add(this.dataGridView_produit);
            this.panel1.Controls.Add(this.dataGridView_commande);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_ajouter);
            this.panel1.Controls.Add(this.button_ajouterc);
            this.panel1.Controls.Add(this.textBox_quantite);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_prix);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_nom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(202, 29);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(688, 513);
            this.panel1.TabIndex = 27;
            // 
            // textBox_fid
            // 
            this.textBox_fid.BorderRadius = 18;
            this.textBox_fid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_fid.DefaultText = " ";
            this.textBox_fid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_fid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_fid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_fid.DisabledState.Parent = this.textBox_fid;
            this.textBox_fid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_fid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_fid.FocusedState.Parent = this.textBox_fid;
            this.textBox_fid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_fid.ForeColor = System.Drawing.Color.Black;
            this.textBox_fid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_fid.HoverState.Parent = this.textBox_fid;
            this.textBox_fid.Location = new System.Drawing.Point(507, 233);
            this.textBox_fid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_fid.Name = "textBox_fid";
            this.textBox_fid.PasswordChar = '\0';
            this.textBox_fid.PlaceholderText = "";
            this.textBox_fid.SelectedText = "";
            this.textBox_fid.SelectionStart = 1;
            this.textBox_fid.ShadowDecoration.Parent = this.textBox_fid;
            this.textBox_fid.Size = new System.Drawing.Size(90, 29);
            this.textBox_fid.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(411, 231);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 28);
            this.label6.TabIndex = 28;
            this.label6.Text = "factureID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(344, 194);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 28);
            this.label12.TabIndex = 27;
            this.label12.Text = "Montant";
            // 
            // button_venteslist
            // 
            this.button_venteslist.FlatAppearance.BorderSize = 0;
            this.button_venteslist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_venteslist.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_venteslist.ForeColor = System.Drawing.Color.White;
            this.button_venteslist.Location = new System.Drawing.Point(298, 229);
            this.button_venteslist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_venteslist.Name = "button_venteslist";
            this.button_venteslist.Size = new System.Drawing.Size(108, 32);
            this.button_venteslist.TabIndex = 26;
            this.button_venteslist.Text = "Ventes List";
            this.button_venteslist.UseVisualStyleBackColor = true;
            // 
            // dataGridView_VentesList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView_VentesList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_VentesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_VentesList.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_VentesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_VentesList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_VentesList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_VentesList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_VentesList.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_VentesList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_VentesList.EnableHeadersVisualStyles = false;
            this.dataGridView_VentesList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_VentesList.Location = new System.Drawing.Point(308, 266);
            this.dataGridView_VentesList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_VentesList.Name = "dataGridView_VentesList";
            this.dataGridView_VentesList.RowHeadersVisible = false;
            this.dataGridView_VentesList.RowHeadersWidth = 51;
            this.dataGridView_VentesList.RowTemplate.Height = 24;
            this.dataGridView_VentesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_VentesList.Size = new System.Drawing.Size(370, 237);
            this.dataGridView_VentesList.TabIndex = 25;
            this.dataGridView_VentesList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_VentesList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_VentesList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_VentesList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_VentesList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_VentesList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_VentesList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_VentesList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_VentesList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_VentesList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_VentesList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_VentesList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_VentesList.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView_VentesList.ThemeStyle.ReadOnly = false;
            this.dataGridView_VentesList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_VentesList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_VentesList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_VentesList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_VentesList.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_VentesList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_VentesList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_VentesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_VentesList_CellContentClick);
            // 
            // button_rafraichir
            // 
            this.button_rafraichir.FlatAppearance.BorderSize = 0;
            this.button_rafraichir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_rafraichir.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rafraichir.ForeColor = System.Drawing.Color.White;
            this.button_rafraichir.Location = new System.Drawing.Point(184, 228);
            this.button_rafraichir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_rafraichir.Name = "button_rafraichir";
            this.button_rafraichir.Size = new System.Drawing.Size(98, 33);
            this.button_rafraichir.TabIndex = 24;
            this.button_rafraichir.Text = "Rafraichir";
            this.button_rafraichir.UseVisualStyleBackColor = true;
            // 
            // comboBox_categorie
            // 
            this.comboBox_categorie.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_categorie.FormattingEnabled = true;
            this.comboBox_categorie.Location = new System.Drawing.Point(24, 233);
            this.comboBox_categorie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_categorie.Name = "comboBox_categorie";
            this.comboBox_categorie.Size = new System.Drawing.Size(152, 28);
            this.comboBox_categorie.TabIndex = 23;
            this.comboBox_categorie.Text = "Choisissez une catégorie";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(535, 23);
            this.label_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(59, 28);
            this.label_date.TabIndex = 22;
            this.label_date.Text = "Date :";
            // 
            // label_nomvendeur
            // 
            this.label_nomvendeur.AutoSize = true;
            this.label_nomvendeur.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomvendeur.ForeColor = System.Drawing.Color.White;
            this.label_nomvendeur.Location = new System.Drawing.Point(20, 15);
            this.label_nomvendeur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nomvendeur.Name = "label_nomvendeur";
            this.label_nomvendeur.Size = new System.Drawing.Size(148, 28);
            this.label_nomvendeur.TabIndex = 21;
            this.label_nomvendeur.Text = "Nom du Vendeur";
            // 
            // dataGridView_produit
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataGridView_produit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_produit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_produit.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_produit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_produit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_produit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_produit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_produit.ColumnHeadersHeight = 4;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_produit.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_produit.EnableHeadersVisualStyles = false;
            this.dataGridView_produit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_produit.Location = new System.Drawing.Point(24, 266);
            this.dataGridView_produit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_produit.Name = "dataGridView_produit";
            this.dataGridView_produit.RowHeadersVisible = false;
            this.dataGridView_produit.RowHeadersWidth = 51;
            this.dataGridView_produit.RowTemplate.Height = 24;
            this.dataGridView_produit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_produit.Size = new System.Drawing.Size(258, 237);
            this.dataGridView_produit.TabIndex = 20;
            this.dataGridView_produit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_produit.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_produit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_produit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_produit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_produit.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_produit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_produit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_produit.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_produit.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_produit.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_produit.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_produit.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView_produit.ThemeStyle.ReadOnly = false;
            this.dataGridView_produit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_produit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_produit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_produit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_produit.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_produit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_produit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // VentesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 552);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_fermer);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VentesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentesForm";
            this.Load += new System.EventHandler(this.VentesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_commande)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_VentesList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_produit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox textBox_prix;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textBox_nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_fermer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_ajouterc;
        private Guna.UI2.WinForms.Guna2TextBox textBox_quantite;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_commande;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_rafraichir;
        private System.Windows.Forms.ComboBox comboBox_categorie;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.Label label_nomvendeur;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_produit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_venteslist;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_VentesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2TextBox textBox_fid;
        private System.Windows.Forms.Label label6;
    }
}