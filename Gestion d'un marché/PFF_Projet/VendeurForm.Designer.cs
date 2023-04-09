namespace PFF_Projet
{
    partial class VendeurForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView_Vendeur = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.textBox_phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_fermer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_age = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_nom = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vendeur)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(81, 621);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 35);
            this.label10.TabIndex = 26;
            this.label10.Text = "Logout";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dataGridView_Vendeur
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_Vendeur.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Vendeur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_Vendeur.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Vendeur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Vendeur.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Vendeur.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Vendeur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Vendeur.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Vendeur.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Vendeur.EnableHeadersVisualStyles = false;
            this.dataGridView_Vendeur.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Vendeur.Location = new System.Drawing.Point(411, 88);
            this.dataGridView_Vendeur.Name = "dataGridView_Vendeur";
            this.dataGridView_Vendeur.RowHeadersVisible = false;
            this.dataGridView_Vendeur.RowHeadersWidth = 51;
            this.dataGridView_Vendeur.RowTemplate.Height = 24;
            this.dataGridView_Vendeur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Vendeur.Size = new System.Drawing.Size(494, 529);
            this.dataGridView_Vendeur.TabIndex = 17;
            this.dataGridView_Vendeur.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Vendeur.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_Vendeur.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Vendeur.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_Vendeur.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_Vendeur.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Vendeur.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Vendeur.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_Vendeur.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Vendeur.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Vendeur.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_Vendeur.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView_Vendeur.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGridView_Vendeur.ThemeStyle.ReadOnly = false;
            this.dataGridView_Vendeur.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_Vendeur.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Vendeur.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_Vendeur.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_Vendeur.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridView_Vendeur.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_Vendeur.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(281, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 35);
            this.label7.TabIndex = 16;
            this.label7.Text = "VENDEURS MANAGEMENT";
            // 
            // button_supprimer
            // 
            this.button_supprimer.FlatAppearance.BorderSize = 0;
            this.button_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_supprimer.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_supprimer.ForeColor = System.Drawing.Color.White;
            this.button_supprimer.Location = new System.Drawing.Point(258, 332);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(132, 42);
            this.button_supprimer.TabIndex = 12;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.FlatAppearance.BorderSize = 0;
            this.button_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modifier.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_modifier.ForeColor = System.Drawing.Color.White;
            this.button_modifier.Location = new System.Drawing.Point(133, 332);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(109, 42);
            this.button_modifier.TabIndex = 11;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.FlatAppearance.BorderSize = 0;
            this.button_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ajouter.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ajouter.ForeColor = System.Drawing.Color.White;
            this.button_ajouter.Location = new System.Drawing.Point(22, 332);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(105, 42);
            this.button_ajouter.TabIndex = 10;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // textBox_phone
            // 
            this.textBox_phone.BorderRadius = 18;
            this.textBox_phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_phone.DefaultText = " ";
            this.textBox_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_phone.DisabledState.Parent = this.textBox_phone;
            this.textBox_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_phone.FocusedState.Parent = this.textBox_phone;
            this.textBox_phone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_phone.ForeColor = System.Drawing.Color.Black;
            this.textBox_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_phone.HoverState.Parent = this.textBox_phone;
            this.textBox_phone.Location = new System.Drawing.Point(166, 222);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.PasswordChar = '\0';
            this.textBox_phone.PlaceholderText = "";
            this.textBox_phone.SelectedText = "";
            this.textBox_phone.SelectionStart = 1;
            this.textBox_phone.ShadowDecoration.Parent = this.textBox_phone;
            this.textBox_phone.Size = new System.Drawing.Size(200, 36);
            this.textBox_phone.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(81, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 35);
            this.label8.TabIndex = 24;
            this.label8.Text = "Categorie";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(81, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 35);
            this.label6.TabIndex = 23;
            this.label6.Text = "Produit";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label_fermer
            // 
            this.label_fermer.AutoSize = true;
            this.label_fermer.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fermer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_fermer.Location = new System.Drawing.Point(1157, -11);
            this.label_fermer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_fermer.Name = "label_fermer";
            this.label_fermer.Size = new System.Drawing.Size(42, 45);
            this.label_fermer.TabIndex = 22;
            this.label_fermer.Text = "X";
            this.label_fermer.Click += new System.EventHandler(this.label_fermer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // textBox_age
            // 
            this.textBox_age.BorderRadius = 18;
            this.textBox_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_age.DefaultText = " ";
            this.textBox_age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_age.DisabledState.Parent = this.textBox_age;
            this.textBox_age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_age.FocusedState.Parent = this.textBox_age;
            this.textBox_age.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_age.ForeColor = System.Drawing.Color.Black;
            this.textBox_age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_age.HoverState.Parent = this.textBox_age;
            this.textBox_age.Location = new System.Drawing.Point(166, 180);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.PasswordChar = '\0';
            this.textBox_age.PlaceholderText = "";
            this.textBox_age.SelectedText = "";
            this.textBox_age.SelectionStart = 1;
            this.textBox_age.ShadowDecoration.Parent = this.textBox_age;
            this.textBox_age.Size = new System.Drawing.Size(200, 36);
            this.textBox_age.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // textBox_id
            // 
            this.textBox_id.BorderRadius = 18;
            this.textBox_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_id.DefaultText = " ";
            this.textBox_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_id.DisabledState.Parent = this.textBox_id;
            this.textBox_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_id.FocusedState.Parent = this.textBox_id;
            this.textBox_id.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_id.ForeColor = System.Drawing.Color.Black;
            this.textBox_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_id.HoverState.Parent = this.textBox_id;
            this.textBox_id.Location = new System.Drawing.Point(166, 96);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.PasswordChar = '\0';
            this.textBox_id.PlaceholderText = "";
            this.textBox_id.SelectedText = "";
            this.textBox_id.SelectionStart = 1;
            this.textBox_id.ShadowDecoration.Parent = this.textBox_id;
            this.textBox_id.Size = new System.Drawing.Size(200, 36);
            this.textBox_id.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(81, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 35);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ventes";
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
            this.textBox_nom.Location = new System.Drawing.Point(166, 138);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.PasswordChar = '\0';
            this.textBox_nom.PlaceholderText = "";
            this.textBox_nom.SelectedText = "";
            this.textBox_nom.SelectionStart = 1;
            this.textBox_nom.ShadowDecoration.Parent = this.textBox_nom;
            this.textBox_nom.Size = new System.Drawing.Size(200, 36);
            this.textBox_nom.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.textBox_password);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridView_Vendeur);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button_supprimer);
            this.panel1.Controls.Add(this.button_modifier);
            this.panel1.Controls.Add(this.button_ajouter);
            this.panel1.Controls.Add(this.textBox_phone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_age);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_nom);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(266, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 631);
            this.panel1.TabIndex = 21;
            // 
            // textBox_password
            // 
            this.textBox_password.BorderRadius = 18;
            this.textBox_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_password.DefaultText = " ";
            this.textBox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_password.DisabledState.Parent = this.textBox_password;
            this.textBox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_password.FocusedState.Parent = this.textBox_password;
            this.textBox_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_password.ForeColor = System.Drawing.Color.Black;
            this.textBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_password.HoverState.Parent = this.textBox_password;
            this.textBox_password.Location = new System.Drawing.Point(166, 264);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '\0';
            this.textBox_password.PlaceholderText = "";
            this.textBox_password.SelectedText = "";
            this.textBox_password.SelectionStart = 1;
            this.textBox_password.ShadowDecoration.Parent = this.textBox_password;
            this.textBox_password.Size = new System.Drawing.Size(200, 36);
            this.textBox_password.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Display", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 35);
            this.label5.TabIndex = 18;
            this.label5.Text = "Password";
            // 
            // VendeurForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 679);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_fermer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VendeurForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendeurForm";
            this.Load += new System.EventHandler(this.VendeurForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Vendeur)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_Vendeur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private Guna.UI2.WinForms.Guna2TextBox textBox_phone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_fermer;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox textBox_age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox textBox_nom;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox textBox_password;
        private System.Windows.Forms.Label label5;
    }
}