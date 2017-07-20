namespace GestionParcNautique
{
    partial class MenuReservation
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
            this.groupeAddResa = new System.Windows.Forms.GroupBox();
            this.effectifGridView = new System.Windows.Forms.DataGridView();
            this.numSecuriteSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPermisCotierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statutActiviteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parcNautiqueDataSet1 = new GestionParcNautique.ParcNautiqueDataSet1();
            this.AddEquipementView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixHT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idAddedClient = new System.Windows.Forms.Label();
            this.addedClient = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addDateFin = new System.Windows.Forms.DateTimePicker();
            this.addDateDebut = new System.Windows.Forms.DateTimePicker();
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parcNautiqueDataSet = new GestionParcNautique.ParcNautiqueDataSet();
            this.equipementParcNautique = new GestionParcNautique.EquipementParcNautique();
            this.equipementParcNautiqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipementTableAdapter = new GestionParcNautique.ParcNautiqueDataSet1TableAdapters.EquipementTableAdapter();
            this.equipementParcNautiqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parcNautiqueDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new GestionParcNautique.ParcNautiqueDataSet1TableAdapters.ClientTableAdapter();
            this.statutActivite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numPermisCotier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectifTableAdapter = new GestionParcNautique.ParcNautiqueDataSet1TableAdapters.EffectifTableAdapter();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.MessageError = new System.Windows.Forms.Label();
            this.groupeAddResa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectifGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcNautiqueDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEquipementView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcNautiqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementParcNautique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementParcNautiqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementParcNautiqueBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcNautiqueDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupeAddResa
            // 
            this.groupeAddResa.Controls.Add(this.MessageError);
            this.groupeAddResa.Controls.Add(this.btnAddReservation);
            this.groupeAddResa.Controls.Add(this.effectifGridView);
            this.groupeAddResa.Controls.Add(this.AddEquipementView);
            this.groupeAddResa.Controls.Add(this.idAddedClient);
            this.groupeAddResa.Controls.Add(this.addedClient);
            this.groupeAddResa.Controls.Add(this.button1);
            this.groupeAddResa.Controls.Add(this.label5);
            this.groupeAddResa.Controls.Add(this.label4);
            this.groupeAddResa.Controls.Add(this.label3);
            this.groupeAddResa.Controls.Add(this.label2);
            this.groupeAddResa.Controls.Add(this.addDateFin);
            this.groupeAddResa.Controls.Add(this.addDateDebut);
            this.groupeAddResa.Location = new System.Drawing.Point(13, 13);
            this.groupeAddResa.Name = "groupeAddResa";
            this.groupeAddResa.Size = new System.Drawing.Size(779, 367);
            this.groupeAddResa.TabIndex = 0;
            this.groupeAddResa.TabStop = false;
            this.groupeAddResa.Text = "Ajouter une reservation";
            // 
            // effectifGridView
            // 
            this.effectifGridView.AllowUserToAddRows = false;
            this.effectifGridView.AllowUserToDeleteRows = false;
            this.effectifGridView.AutoGenerateColumns = false;
            this.effectifGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.effectifGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numSecuriteSocialDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn2,
            this.numPermisCotierDataGridViewTextBoxColumn,
            this.statutActiviteDataGridViewTextBoxColumn});
            this.effectifGridView.DataSource = this.effectifBindingSource;
            this.effectifGridView.Location = new System.Drawing.Point(10, 235);
            this.effectifGridView.Name = "effectifGridView";
            this.effectifGridView.ReadOnly = true;
            this.effectifGridView.Size = new System.Drawing.Size(515, 126);
            this.effectifGridView.TabIndex = 15;
            // 
            // numSecuriteSocialDataGridViewTextBoxColumn
            // 
            this.numSecuriteSocialDataGridViewTextBoxColumn.DataPropertyName = "numSecuriteSocial";
            this.numSecuriteSocialDataGridViewTextBoxColumn.HeaderText = "numSecuriteSocial";
            this.numSecuriteSocialDataGridViewTextBoxColumn.Name = "numSecuriteSocialDataGridViewTextBoxColumn";
            this.numSecuriteSocialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn2
            // 
            this.nomDataGridViewTextBoxColumn2.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn2.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn2.Name = "nomDataGridViewTextBoxColumn2";
            this.nomDataGridViewTextBoxColumn2.ReadOnly = true;
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
            // AddEquipementView
            // 
            this.AddEquipementView.AllowUserToAddRows = false;
            this.AddEquipementView.AllowUserToDeleteRows = false;
            this.AddEquipementView.AutoGenerateColumns = false;
            this.AddEquipementView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddEquipementView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.puissance,
            this.prixHT});
            this.AddEquipementView.DataSource = this.equipementBindingSource;
            this.AddEquipementView.Location = new System.Drawing.Point(10, 36);
            this.AddEquipementView.MultiSelect = false;
            this.AddEquipementView.Name = "AddEquipementView";
            this.AddEquipementView.ReadOnly = true;
            this.AddEquipementView.Size = new System.Drawing.Size(515, 140);
            this.AddEquipementView.TabIndex = 14;
            this.AddEquipementView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // puissance
            // 
            this.puissance.DataPropertyName = "puissance";
            this.puissance.HeaderText = "puissance";
            this.puissance.Name = "puissance";
            this.puissance.ReadOnly = true;
            // 
            // prixHT
            // 
            this.prixHT.DataPropertyName = "prixHT";
            this.prixHT.HeaderText = "prixHT";
            this.prixHT.Name = "prixHT";
            this.prixHT.ReadOnly = true;
            // 
            // equipementBindingSource
            // 
            this.equipementBindingSource.DataMember = "Equipement";
            this.equipementBindingSource.DataSource = this.parcNautiqueDataSet1;
            // 
            // idAddedClient
            // 
            this.idAddedClient.AutoSize = true;
            this.idAddedClient.Location = new System.Drawing.Point(534, 102);
            this.idAddedClient.Name = "idAddedClient";
            this.idAddedClient.Size = new System.Drawing.Size(35, 13);
            this.idAddedClient.TabIndex = 13;
            this.idAddedClient.Text = "label1";
            this.idAddedClient.Visible = false;
            // 
            // addedClient
            // 
            this.addedClient.AutoSize = true;
            this.addedClient.Location = new System.Drawing.Point(531, 80);
            this.addedClient.Name = "addedClient";
            this.addedClient.Size = new System.Drawing.Size(123, 13);
            this.addedClient.TabIndex = 12;
            this.addedClient.Text = "Aucun client sélectionné";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Choix d\'un client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Liste du personnel habillité à encadrer/accompagner pour ce genre d\'équipement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Choix de l\'équipement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date de fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date de début";
            // 
            // addDateFin
            // 
            this.addDateFin.Location = new System.Drawing.Point(214, 195);
            this.addDateFin.Name = "addDateFin";
            this.addDateFin.Size = new System.Drawing.Size(200, 20);
            this.addDateFin.TabIndex = 5;
            // 
            // addDateDebut
            // 
            this.addDateDebut.Location = new System.Drawing.Point(6, 195);
            this.addDateDebut.Name = "addDateDebut";
            this.addDateDebut.Size = new System.Drawing.Size(200, 20);
            this.addDateDebut.TabIndex = 4;
            // 
            // clientBindingSource1
            // 
            this.clientBindingSource1.DataMember = "Client";
            this.clientBindingSource1.DataSource = this.parcNautiqueDataSet1;
            // 
            // parcNautiqueDataSet
            // 
            this.parcNautiqueDataSet.DataSetName = "ParcNautiqueDataSet";
            this.parcNautiqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipementParcNautique
            // 
            this.equipementParcNautique.DataSetName = "EquipementParcNautique";
            this.equipementParcNautique.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipementParcNautiqueBindingSource
            // 
            this.equipementParcNautiqueBindingSource.DataSource = this.equipementParcNautique;
            this.equipementParcNautiqueBindingSource.Position = 0;
            // 
            // equipementTableAdapter
            // 
            this.equipementTableAdapter.ClearBeforeFill = true;
            // 
            // equipementParcNautiqueBindingSource1
            // 
            this.equipementParcNautiqueBindingSource1.DataSource = this.equipementParcNautique;
            this.equipementParcNautiqueBindingSource1.Position = 0;
            // 
            // parcNautiqueDataSet1BindingSource
            // 
            this.parcNautiqueDataSet1BindingSource.DataSource = this.parcNautiqueDataSet1;
            this.parcNautiqueDataSet1BindingSource.Position = 0;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.parcNautiqueDataSet1BindingSource;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // statutActivite
            // 
            this.statutActivite.DataPropertyName = "statutActivite";
            this.statutActivite.HeaderText = "statutActivite";
            this.statutActivite.Name = "statutActivite";
            this.statutActivite.ReadOnly = true;
            // 
            // numPermisCotier
            // 
            this.numPermisCotier.DataPropertyName = "numPermisCotier";
            this.numPermisCotier.HeaderText = "numPermisCotier";
            this.numPermisCotier.Name = "numPermisCotier";
            this.numPermisCotier.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn1
            // 
            this.nomDataGridViewTextBoxColumn1.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn1.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
            this.nomDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // effectifTableAdapter
            // 
            this.effectifTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Location = new System.Drawing.Point(703, 337);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(75, 23);
            this.btnAddReservation.TabIndex = 16;
            this.btnAddReservation.Text = "Valider";
            this.btnAddReservation.UseVisualStyleBackColor = true;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // MessageError
            // 
            this.MessageError.AutoSize = true;
            this.MessageError.BackColor = System.Drawing.SystemColors.Control;
            this.MessageError.Location = new System.Drawing.Point(534, 315);
            this.MessageError.Name = "MessageError";
            this.MessageError.Size = new System.Drawing.Size(0, 13);
            this.MessageError.TabIndex = 17;
            // 
            // MenuReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 622);
            this.Controls.Add(this.groupeAddResa);
            this.Name = "MenuReservation";
            this.Text = "MenuReservation";
            this.Load += new System.EventHandler(this.MenuReservation_Load);
            this.groupeAddResa.ResumeLayout(false);
            this.groupeAddResa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectifGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcNautiqueDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddEquipementView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcNautiqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementParcNautique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementParcNautiqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementParcNautiqueBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcNautiqueDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupeAddResa;
        private ParcNautiqueDataSet parcNautiqueDataSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker addDateFin;
        private System.Windows.Forms.DateTimePicker addDateDebut;
        private ParcNautiqueDataSet1 parcNautiqueDataSet1;
        private System.Windows.Forms.BindingSource equipementParcNautiqueBindingSource;
        private EquipementParcNautique equipementParcNautique;
        private System.Windows.Forms.BindingSource equipementBindingSource;
        private ParcNautiqueDataSet1TableAdapters.EquipementTableAdapter equipementTableAdapter;
        private System.Windows.Forms.BindingSource equipementParcNautiqueBindingSource1;
        private System.Windows.Forms.BindingSource parcNautiqueDataSet1BindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private ParcNautiqueDataSet1TableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label idAddedClient;
        private System.Windows.Forms.Label addedClient;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.Windows.Forms.DataGridView AddEquipementView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixHT;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPermisCotier;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutActivite;
        private System.Windows.Forms.DataGridView effectifGridView;
        private System.Windows.Forms.BindingSource effectifBindingSource;
        private ParcNautiqueDataSet1TableAdapters.EffectifTableAdapter effectifTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numSecuriteSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numPermisCotierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statutActiviteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.Label MessageError;
    }
}