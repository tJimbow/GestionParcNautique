namespace GestionParcNautique
{
    partial class MenuEffectif
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
            this.btnAccueil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddStatutActivite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddDateVisiteMedical = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddNumPermisCotier = new System.Windows.Forms.NumericUpDown();
            this.AddDateEmbauche = new System.Windows.Forms.DateTimePicker();
            this.AddStatutContrat = new System.Windows.Forms.TextBox();
            this.LabelLog = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddNom = new System.Windows.Forms.TextBox();
            this.AddEffectif = new System.Windows.Forms.Button();
            this.dataEffectifs = new System.Windows.Forms.DataGridView();
            this.numSecuriteSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEmbaucheDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateVisiteMedicalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutContratDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPermisCotierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutActiviteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parcNautiqueDataSet1 = new GestionParcNautique.ParcNautiqueDataSet1();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new GestionParcNautique.ParcNautiqueDataSet1TableAdapters.ClientTableAdapter();
            this.effectifTableAdapter = new GestionParcNautique.ParcNautiqueDataSet1TableAdapters.EffectifTableAdapter();
            this.AddNumSecuriteSocial = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddNumPermisCotier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEffectifs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcNautiqueDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNumSecuriteSocial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccueil
            // 
            this.btnAccueil.Location = new System.Drawing.Point(381, 515);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(75, 23);
            this.btnAccueil.TabIndex = 9;
            this.btnAccueil.Text = "Menu Accueil";
            this.btnAccueil.UseVisualStyleBackColor = true;
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddNumSecuriteSocial);
            this.groupBox1.Controls.Add(this.AddStatutActivite);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.AddDateVisiteMedical);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.AddNumPermisCotier);
            this.groupBox1.Controls.Add(this.AddDateEmbauche);
            this.groupBox1.Controls.Add(this.AddStatutContrat);
            this.groupBox1.Controls.Add(this.LabelLog);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Prenom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddNom);
            this.groupBox1.Controls.Add(this.AddEffectif);
            this.groupBox1.Location = new System.Drawing.Point(159, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 199);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Console d\'ajout d\'un Effectif";
            // 
            // AddStatutActivite
            // 
            this.AddStatutActivite.Location = new System.Drawing.Point(6, 159);
            this.AddStatutActivite.Name = "AddStatutActivite";
            this.AddStatutActivite.Size = new System.Drawing.Size(230, 20);
            this.AddStatutActivite.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Statut de l\'activite";
            // 
            // AddDateVisiteMedical
            // 
            this.AddDateVisiteMedical.Location = new System.Drawing.Point(187, 108);
            this.AddDateVisiteMedical.Name = "AddDateVisiteMedical";
            this.AddDateVisiteMedical.Size = new System.Drawing.Size(178, 20);
            this.AddDateVisiteMedical.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Date de la visite médicale";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Numero de permis côtier";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // AddNumPermisCotier
            // 
            this.AddNumPermisCotier.Location = new System.Drawing.Point(371, 108);
            this.AddNumPermisCotier.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.AddNumPermisCotier.Name = "AddNumPermisCotier";
            this.AddNumPermisCotier.Size = new System.Drawing.Size(171, 20);
            this.AddNumPermisCotier.TabIndex = 15;
            // 
            // AddDateEmbauche
            // 
            this.AddDateEmbauche.Location = new System.Drawing.Point(6, 108);
            this.AddDateEmbauche.Name = "AddDateEmbauche";
            this.AddDateEmbauche.Size = new System.Drawing.Size(178, 20);
            this.AddDateEmbauche.TabIndex = 14;
            // 
            // AddStatutContrat
            // 
            this.AddStatutContrat.Location = new System.Drawing.Point(415, 55);
            this.AddStatutContrat.Name = "AddStatutContrat";
            this.AddStatutContrat.Size = new System.Drawing.Size(130, 20);
            this.AddStatutContrat.TabIndex = 12;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Statut du contrat de travail";
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(6, 36);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(133, 13);
            this.Prenom.TabIndex = 8;
            this.Prenom.Text = "Numero de Securite Social";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Date d\'embauche";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // AddNom
            // 
            this.AddNom.Location = new System.Drawing.Point(179, 55);
            this.AddNom.Name = "AddNom";
            this.AddNom.Size = new System.Drawing.Size(230, 20);
            this.AddNom.TabIndex = 1;
            // 
            // AddEffectif
            // 
            this.AddEffectif.Location = new System.Drawing.Point(415, 164);
            this.AddEffectif.Name = "AddEffectif";
            this.AddEffectif.Size = new System.Drawing.Size(130, 23);
            this.AddEffectif.TabIndex = 0;
            this.AddEffectif.Text = "Ajouter un effectif";
            this.AddEffectif.UseVisualStyleBackColor = true;
            this.AddEffectif.Click += new System.EventHandler(this.AddEffectif_Click);
            // 
            // dataEffectifs
            // 
            this.dataEffectifs.AllowUserToAddRows = false;
            this.dataEffectifs.AllowUserToDeleteRows = false;
            this.dataEffectifs.AutoGenerateColumns = false;
            this.dataEffectifs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEffectifs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSecuriteSocialDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.dateEmbaucheDataGridViewTextBoxColumn,
            this.dateVisiteMedicalDataGridViewTextBoxColumn,
            this.statutContratDataGridViewTextBoxColumn,
            this.numPermisCotierDataGridViewTextBoxColumn,
            this.statutActiviteDataGridViewTextBoxColumn});
            this.dataEffectifs.DataSource = this.effectifBindingSource;
            this.dataEffectifs.Location = new System.Drawing.Point(12, 218);
            this.dataEffectifs.Name = "dataEffectifs";
            this.dataEffectifs.ReadOnly = true;
            this.dataEffectifs.Size = new System.Drawing.Size(838, 291);
            this.dataEffectifs.TabIndex = 10;
            this.dataEffectifs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEffectifs_CellClick);
            // 
            // numSecuriteSocialDataGridViewTextBoxColumn
            // 
            this.numSecuriteSocialDataGridViewTextBoxColumn.DataPropertyName = "numSecuriteSocial";
            this.numSecuriteSocialDataGridViewTextBoxColumn.HeaderText = "numSecuriteSocial";
            this.numSecuriteSocialDataGridViewTextBoxColumn.Name = "numSecuriteSocialDataGridViewTextBoxColumn";
            this.numSecuriteSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateEmbaucheDataGridViewTextBoxColumn
            // 
            this.dateEmbaucheDataGridViewTextBoxColumn.DataPropertyName = "dateEmbauche";
            this.dateEmbaucheDataGridViewTextBoxColumn.HeaderText = "dateEmbauche";
            this.dateEmbaucheDataGridViewTextBoxColumn.Name = "dateEmbaucheDataGridViewTextBoxColumn";
            this.dateEmbaucheDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateVisiteMedicalDataGridViewTextBoxColumn
            // 
            this.dateVisiteMedicalDataGridViewTextBoxColumn.DataPropertyName = "dateVisiteMedical";
            this.dateVisiteMedicalDataGridViewTextBoxColumn.HeaderText = "dateVisiteMedical";
            this.dateVisiteMedicalDataGridViewTextBoxColumn.Name = "dateVisiteMedicalDataGridViewTextBoxColumn";
            this.dateVisiteMedicalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statutContratDataGridViewTextBoxColumn
            // 
            this.statutContratDataGridViewTextBoxColumn.DataPropertyName = "statutContrat";
            this.statutContratDataGridViewTextBoxColumn.HeaderText = "statutContrat";
            this.statutContratDataGridViewTextBoxColumn.Name = "statutContratDataGridViewTextBoxColumn";
            this.statutContratDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numPermisCotierDataGridViewTextBoxColumn
            // 
            this.numPermisCotierDataGridViewTextBoxColumn.DataPropertyName = "numPermisCotier";
            this.numPermisCotierDataGridViewTextBoxColumn.HeaderText = "numPermisCotier";
            this.numPermisCotierDataGridViewTextBoxColumn.Name = "numPermisCotierDataGridViewTextBoxColumn";
            this.numPermisCotierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statutActiviteDataGridViewTextBoxColumn
            // 
            this.statutActiviteDataGridViewTextBoxColumn.DataPropertyName = "statutActivite";
            this.statutActiviteDataGridViewTextBoxColumn.HeaderText = "statutActivite";
            this.statutActiviteDataGridViewTextBoxColumn.Name = "statutActiviteDataGridViewTextBoxColumn";
            this.statutActiviteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // effectifBindingSource
            // 
            this.effectifBindingSource.DataMember = "Effectif";
            this.effectifBindingSource.DataSource = this.parcNautiqueDataSet1;
            // 
            // parcNautiqueDataSet1
            // 
            this.parcNautiqueDataSet1.DataSetName = "ParcNautiqueDataSet1";
            this.parcNautiqueDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.parcNautiqueDataSet1;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // effectifTableAdapter
            // 
            this.effectifTableAdapter.ClearBeforeFill = true;
            // 
            // AddNumSecuriteSocial
            // 
            this.AddNumSecuriteSocial.Location = new System.Drawing.Point(6, 56);
            this.AddNumSecuriteSocial.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.AddNumSecuriteSocial.Name = "AddNumSecuriteSocial";
            this.AddNumSecuriteSocial.Size = new System.Drawing.Size(171, 20);
            this.AddNumSecuriteSocial.TabIndex = 21;
            // 
            // MenuEffectif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 551);
            this.Controls.Add(this.dataEffectifs);
            this.Controls.Add(this.btnAccueil);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuEffectif";
            this.Text = "MenuEffectif";
            this.Load += new System.EventHandler(this.MenuEffectif_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddNumPermisCotier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataEffectifs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcNautiqueDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNumSecuriteSocial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker AddDateVisiteMedical;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown AddNumPermisCotier;
        private System.Windows.Forms.DateTimePicker AddDateEmbauche;
        private System.Windows.Forms.TextBox AddStatutContrat;
        private System.Windows.Forms.Label LabelLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddNom;
        private System.Windows.Forms.Button AddEffectif;
        private System.Windows.Forms.TextBox AddStatutActivite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataEffectifs;
        private ParcNautiqueDataSet1 parcNautiqueDataSet1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private ParcNautiqueDataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource effectifBindingSource;
        private ParcNautiqueDataSet1TableAdapters.EffectifTableAdapter effectifTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSecuriteSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEmbaucheDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateVisiteMedicalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutContratDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPermisCotierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutActiviteDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown AddNumSecuriteSocial;
    }
}