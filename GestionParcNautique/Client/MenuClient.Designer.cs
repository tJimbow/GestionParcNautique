namespace GestionParcNautique
{
    partial class MenuClient
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddNumPermisCotier = new System.Windows.Forms.NumericUpDown();
            this.AddDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.AddTelephone = new System.Windows.Forms.TextBox();
            this.AddAdresse = new System.Windows.Forms.TextBox();
            this.LabelLog = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddPrenom = new System.Windows.Forms.TextBox();
            this.AddNom = new System.Windows.Forms.TextBox();
            this.AddClient = new System.Windows.Forms.Button();
            this.dataClients = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPermisCotierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parcNautiqueDataSet = new GestionParcNautique.ParcNautiqueDataSet();
            this.clientTableAdapter = new GestionParcNautique.ParcNautiqueDataSetTableAdapters.ClientTableAdapter();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddNumPermisCotier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcNautiqueDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AddNumPermisCotier);
            this.groupBox1.Controls.Add(this.AddDateNaissance);
            this.groupBox1.Controls.Add(this.AddTelephone);
            this.groupBox1.Controls.Add(this.AddAdresse);
            this.groupBox1.Controls.Add(this.LabelLog);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Prenom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddPrenom);
            this.groupBox1.Controls.Add(this.AddNom);
            this.groupBox1.Controls.Add(this.AddClient);
            this.groupBox1.Location = new System.Drawing.Point(148, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 199);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Console d\'ajout d\'un Client";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Numéroe de permis côtier";
            // 
            // AddNumPermisCotier
            // 
            this.AddNumPermisCotier.Location = new System.Drawing.Point(338, 117);
            this.AddNumPermisCotier.Name = "AddNumPermisCotier";
            this.AddNumPermisCotier.Size = new System.Drawing.Size(207, 20);
            this.AddNumPermisCotier.TabIndex = 15;
            // 
            // AddDateNaissance
            // 
            this.AddDateNaissance.Location = new System.Drawing.Point(135, 117);
            this.AddDateNaissance.Name = "AddDateNaissance";
            this.AddDateNaissance.Size = new System.Drawing.Size(178, 20);
            this.AddDateNaissance.TabIndex = 14;
            // 
            // AddTelephone
            // 
            this.AddTelephone.Location = new System.Drawing.Point(9, 117);
            this.AddTelephone.Name = "AddTelephone";
            this.AddTelephone.Size = new System.Drawing.Size(100, 20);
            this.AddTelephone.TabIndex = 13;
            // 
            // AddAdresse
            // 
            this.AddAdresse.Location = new System.Drawing.Point(255, 55);
            this.AddAdresse.Name = "AddAdresse";
            this.AddAdresse.Size = new System.Drawing.Size(290, 20);
            this.AddAdresse.TabIndex = 12;
            // 
            // LabelLog
            // 
            this.LabelLog.AutoSize = true;
            this.LabelLog.ForeColor = System.Drawing.Color.Red;
            this.LabelLog.Location = new System.Drawing.Point(6, 16);
            this.LabelLog.Name = "LabelLog";
            this.LabelLog.Size = new System.Drawing.Size(0, 13);
            this.LabelLog.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Numero de tel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adresse";
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(132, 36);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(43, 13);
            this.Prenom.TabIndex = 8;
            this.Prenom.Text = "Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date de naissance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // AddPrenom
            // 
            this.AddPrenom.Location = new System.Drawing.Point(135, 56);
            this.AddPrenom.Name = "AddPrenom";
            this.AddPrenom.Size = new System.Drawing.Size(100, 20);
            this.AddPrenom.TabIndex = 2;
            // 
            // AddNom
            // 
            this.AddNom.Location = new System.Drawing.Point(9, 56);
            this.AddNom.Name = "AddNom";
            this.AddNom.Size = new System.Drawing.Size(100, 20);
            this.AddNom.TabIndex = 1;
            // 
            // AddClient
            // 
            this.AddClient.Location = new System.Drawing.Point(415, 164);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(130, 23);
            this.AddClient.TabIndex = 0;
            this.AddClient.Text = "Ajouter client";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // dataClients
            // 
            this.dataClients.AllowUserToAddRows = false;
            this.dataClients.AllowUserToDeleteRows = false;
            this.dataClients.AutoGenerateColumns = false;
            this.dataClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.dateNaissanceDataGridViewTextBoxColumn,
            this.numPermisCotierDataGridViewTextBoxColumn});
            this.dataClients.DataSource = this.clientBindingSource;
            this.dataClients.Location = new System.Drawing.Point(12, 217);
            this.dataClients.Name = "dataClients";
            this.dataClients.ReadOnly = true;
            this.dataClients.Size = new System.Drawing.Size(816, 276);
            this.dataClients.TabIndex = 3;
            this.dataClients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClients_CellClick);
            this.dataClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataClients_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateNaissanceDataGridViewTextBoxColumn
            // 
            this.dateNaissanceDataGridViewTextBoxColumn.DataPropertyName = "dateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.HeaderText = "dateNaissance";
            this.dateNaissanceDataGridViewTextBoxColumn.Name = "dateNaissanceDataGridViewTextBoxColumn";
            this.dateNaissanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numPermisCotierDataGridViewTextBoxColumn
            // 
            this.numPermisCotierDataGridViewTextBoxColumn.DataPropertyName = "numPermisCotier";
            this.numPermisCotierDataGridViewTextBoxColumn.HeaderText = "numPermisCotier";
            this.numPermisCotierDataGridViewTextBoxColumn.Name = "numPermisCotierDataGridViewTextBoxColumn";
            this.numPermisCotierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.parcNautiqueDataSet;
            // 
            // parcNautiqueDataSet
            // 
            this.parcNautiqueDataSet.DataSetName = "ParcNautiqueDataSet";
            this.parcNautiqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // btnAccueil
            // 
            this.btnAccueil.Location = new System.Drawing.Point(370, 514);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(75, 23);
            this.btnAccueil.TabIndex = 6;
            this.btnAccueil.Text = "Menu Accueil";
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // MenuClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 549);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.dataClients);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuClient";
            this.Text = "MenuClient";
            this.Load += new System.EventHandler(this.MenuClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddNumPermisCotier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcNautiqueDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabelLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddPrenom;
        private System.Windows.Forms.TextBox AddNom;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.TextBox AddTelephone;
        private System.Windows.Forms.TextBox AddAdresse;
        private System.Windows.Forms.DateTimePicker AddDateNaissance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown AddNumPermisCotier;
        private System.Windows.Forms.DataGridView dataClients;
        private ParcNautiqueDataSet parcNautiqueDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private ParcNautiqueDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPermisCotierDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAccueil;
    }
}