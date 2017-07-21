namespace GestionParcNautique
{
    partial class MenuEquipement
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
            this.AddEquipement = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelLog = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Etat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddPrixHT = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDescriptif = new System.Windows.Forms.RichTextBox();
            this.AddPuissance = new System.Windows.Forms.NumericUpDown();
            this.AddEtat = new System.Windows.Forms.TextBox();
            this.AddNom = new System.Windows.Forms.TextBox();
            this.equipementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipementParcNautique = new GestionParcNautique.EquipementParcNautique();
            this.equipementTableAdapter = new GestionParcNautique.EquipementParcNautiqueTableAdapters.EquipementTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataEquipemts = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixHTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuAccueil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPrixHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPuissance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementParcNautique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEquipemts)).BeginInit();
            this.SuspendLayout();
            // 
            // AddEquipement
            // 
            this.AddEquipement.Location = new System.Drawing.Point(415, 213);
            this.AddEquipement.Name = "AddEquipement";
            this.AddEquipement.Size = new System.Drawing.Size(130, 23);
            this.AddEquipement.TabIndex = 0;
            this.AddEquipement.Text = "Ajouter l\'équipement";
            this.AddEquipement.UseVisualStyleBackColor = true;
            this.AddEquipement.Click += new System.EventHandler(this.AddEquipement_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelLog);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Etat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddPrixHT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddDescriptif);
            this.groupBox1.Controls.Add(this.AddPuissance);
            this.groupBox1.Controls.Add(this.AddEtat);
            this.groupBox1.Controls.Add(this.AddNom);
            this.groupBox1.Controls.Add(this.AddEquipement);
            this.groupBox1.Location = new System.Drawing.Point(108, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 242);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Console d\'ajout d\'un équipement";
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
            this.label4.Location = new System.Drawing.Point(395, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Prix de location HT/h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Puissance";
            // 
            // Etat
            // 
            this.Etat.AutoSize = true;
            this.Etat.Location = new System.Drawing.Point(132, 36);
            this.Etat.Name = "Etat";
            this.Etat.Size = new System.Drawing.Size(26, 13);
            this.Etat.TabIndex = 8;
            this.Etat.Text = "Etat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descriptif";
            // 
            // AddPrixHT
            // 
            this.AddPrixHT.DecimalPlaces = 2;
            this.AddPrixHT.Location = new System.Drawing.Point(398, 57);
            this.AddPrixHT.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.AddPrixHT.Name = "AddPrixHT";
            this.AddPrixHT.Size = new System.Drawing.Size(120, 20);
            this.AddPrixHT.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // AddDescriptif
            // 
            this.AddDescriptif.Location = new System.Drawing.Point(6, 111);
            this.AddDescriptif.Name = "AddDescriptif";
            this.AddDescriptif.Size = new System.Drawing.Size(539, 96);
            this.AddDescriptif.TabIndex = 4;
            this.AddDescriptif.Text = "";
            // 
            // AddPuissance
            // 
            this.AddPuissance.Location = new System.Drawing.Point(255, 56);
            this.AddPuissance.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.AddPuissance.Name = "AddPuissance";
            this.AddPuissance.Size = new System.Drawing.Size(120, 20);
            this.AddPuissance.TabIndex = 3;
            // 
            // AddEtat
            // 
            this.AddEtat.Location = new System.Drawing.Point(135, 56);
            this.AddEtat.Name = "AddEtat";
            this.AddEtat.Size = new System.Drawing.Size(100, 20);
            this.AddEtat.TabIndex = 2;
            // 
            // AddNom
            // 
            this.AddNom.Location = new System.Drawing.Point(6, 56);
            this.AddNom.Name = "AddNom";
            this.AddNom.Size = new System.Drawing.Size(100, 20);
            this.AddNom.TabIndex = 1;
            // 
            // equipementBindingSource
            // 
            this.equipementBindingSource.DataMember = "Equipement";
            this.equipementBindingSource.DataSource = this.equipementParcNautique;
            // 
            // equipementParcNautique
            // 
            this.equipementParcNautique.DataSetName = "EquipementParcNautique";
            this.equipementParcNautique.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipementTableAdapter
            // 
            this.equipementTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Liste des équipements";
            // 
            // dataEquipemts
            // 
            this.dataEquipemts.AllowUserToAddRows = false;
            this.dataEquipemts.AllowUserToDeleteRows = false;
            this.dataEquipemts.AutoGenerateColumns = false;
            this.dataEquipemts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEquipemts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nomDataGridViewTextBoxColumn,
            this.etatDataGridViewTextBoxColumn,
            this.puissanceDataGridViewTextBoxColumn,
            this.prixHTDataGridViewTextBoxColumn});
            this.dataEquipemts.DataSource = this.equipementBindingSource;
            this.dataEquipemts.Location = new System.Drawing.Point(108, 288);
            this.dataEquipemts.Name = "dataEquipemts";
            this.dataEquipemts.ReadOnly = true;
            this.dataEquipemts.Size = new System.Drawing.Size(551, 233);
            this.dataEquipemts.TabIndex = 4;
            this.dataEquipemts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEquipemts_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // etatDataGridViewTextBoxColumn
            // 
            this.etatDataGridViewTextBoxColumn.DataPropertyName = "etat";
            this.etatDataGridViewTextBoxColumn.HeaderText = "etat";
            this.etatDataGridViewTextBoxColumn.Name = "etatDataGridViewTextBoxColumn";
            this.etatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // puissanceDataGridViewTextBoxColumn
            // 
            this.puissanceDataGridViewTextBoxColumn.DataPropertyName = "puissance";
            this.puissanceDataGridViewTextBoxColumn.HeaderText = "puissance";
            this.puissanceDataGridViewTextBoxColumn.Name = "puissanceDataGridViewTextBoxColumn";
            this.puissanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prixHTDataGridViewTextBoxColumn
            // 
            this.prixHTDataGridViewTextBoxColumn.DataPropertyName = "prixHT";
            this.prixHTDataGridViewTextBoxColumn.HeaderText = "prixHT";
            this.prixHTDataGridViewTextBoxColumn.Name = "prixHTDataGridViewTextBoxColumn";
            this.prixHTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MenuAccueil
            // 
            this.MenuAccueil.Location = new System.Drawing.Point(363, 535);
            this.MenuAccueil.Name = "MenuAccueil";
            this.MenuAccueil.Size = new System.Drawing.Size(75, 23);
            this.MenuAccueil.TabIndex = 5;
            this.MenuAccueil.Text = "Menu";
            this.MenuAccueil.UseVisualStyleBackColor = true;
            this.MenuAccueil.Click += new System.EventHandler(this.MenuAccueil_Click);
            // 
            // MenuEquipement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 570);
            this.Controls.Add(this.MenuAccueil);
            this.Controls.Add(this.dataEquipemts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuEquipement";
            this.Text = "MenuEquipement";
            this.Load += new System.EventHandler(this.MenuEquipement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPrixHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPuissance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementParcNautique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEquipemts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddEquipement;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown AddPuissance;
        private System.Windows.Forms.TextBox AddEtat;
        private System.Windows.Forms.TextBox AddNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox AddDescriptif;
        private System.Windows.Forms.NumericUpDown AddPrixHT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Etat;
        private System.Windows.Forms.Label LabelLog;
        private EquipementParcNautique equipementParcNautique;
        private System.Windows.Forms.BindingSource equipementBindingSource;
        private EquipementParcNautiqueTableAdapters.EquipementTableAdapter equipementTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataEquipemts;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixHTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button MenuAccueil;
    }
}