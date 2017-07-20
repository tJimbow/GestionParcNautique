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
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.effectifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parcNautiqueDataSet1 = new GestionParcNautique.ParcNautiqueDataSet1();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddEquipement = new System.Windows.Forms.ListBox();
            this.equipementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parcNautiqueDataSet = new GestionParcNautique.ParcNautiqueDataSet();
            this.effectifTableAdapter = new GestionParcNautique.ParcNautiqueDataSet1TableAdapters.EffectifTableAdapter();
            this.equipementParcNautique = new GestionParcNautique.EquipementParcNautique();
            this.equipementParcNautiqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipementTableAdapter = new GestionParcNautique.ParcNautiqueDataSet1TableAdapters.EquipementTableAdapter();
            this.equipementParcNautiqueBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parcNautiqueDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new GestionParcNautique.ParcNautiqueDataSet1TableAdapters.ClientTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.addedClient = new System.Windows.Forms.Label();
            this.idAddedClient = new System.Windows.Forms.Label();
            this.groupeAddResa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcNautiqueDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementBindingSource)).BeginInit();
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
            this.groupeAddResa.Controls.Add(this.idAddedClient);
            this.groupeAddResa.Controls.Add(this.addedClient);
            this.groupeAddResa.Controls.Add(this.button1);
            this.groupeAddResa.Controls.Add(this.label5);
            this.groupeAddResa.Controls.Add(this.listBox1);
            this.groupeAddResa.Controls.Add(this.label4);
            this.groupeAddResa.Controls.Add(this.label3);
            this.groupeAddResa.Controls.Add(this.label2);
            this.groupeAddResa.Controls.Add(this.dateTimePicker2);
            this.groupeAddResa.Controls.Add(this.dateTimePicker1);
            this.groupeAddResa.Controls.Add(this.AddEquipement);
            this.groupeAddResa.Location = new System.Drawing.Point(13, 13);
            this.groupeAddResa.Name = "groupeAddResa";
            this.groupeAddResa.Size = new System.Drawing.Size(779, 212);
            this.groupeAddResa.TabIndex = 0;
            this.groupeAddResa.TabStop = false;
            this.groupeAddResa.Text = "Ajouter une reservation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(390, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Liste du personnel habillité à encadrer/accompagner pour ce genre d\'équipement";
            // 
            // listBox1
            // 
            this.listBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.effectifBindingSource, "numSecuriteSocial", true));
            this.listBox1.DataSource = this.effectifBindingSource;
            this.listBox1.DisplayMember = "nom";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 150);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(407, 56);
            this.listBox1.TabIndex = 9;
            this.listBox1.ValueMember = "numPermisCotier";
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
            this.label3.Location = new System.Drawing.Point(211, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date de fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Date de début";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(212, 96);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 96);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // AddEquipement
            // 
            this.AddEquipement.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.equipementBindingSource, "id", true));
            this.AddEquipement.DataSource = this.equipementBindingSource;
            this.AddEquipement.DisplayMember = "nom";
            this.AddEquipement.FormattingEnabled = true;
            this.AddEquipement.Location = new System.Drawing.Point(6, 35);
            this.AddEquipement.Name = "AddEquipement";
            this.AddEquipement.Size = new System.Drawing.Size(264, 43);
            this.AddEquipement.Sorted = true;
            this.AddEquipement.TabIndex = 3;
            this.AddEquipement.ValueMember = "puissance";
            // 
            // equipementBindingSource
            // 
            this.equipementBindingSource.DataMember = "Equipement";
            this.equipementBindingSource.DataSource = this.parcNautiqueDataSet1;
            // 
            // parcNautiqueDataSet
            // 
            this.parcNautiqueDataSet.DataSetName = "ParcNautiqueDataSet";
            this.parcNautiqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // effectifTableAdapter
            // 
            this.effectifTableAdapter.ClearBeforeFill = true;
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
            // addedClient
            // 
            this.addedClient.AutoSize = true;
            this.addedClient.Location = new System.Drawing.Point(531, 80);
            this.addedClient.Name = "addedClient";
            this.addedClient.Size = new System.Drawing.Size(123, 13);
            this.addedClient.TabIndex = 12;
            this.addedClient.Text = "Aucun client sélectionné";
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
            // MenuReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 261);
            this.Controls.Add(this.groupeAddResa);
            this.Name = "MenuReservation";
            this.Text = "MenuReservation";
            this.Load += new System.EventHandler(this.MenuReservation_Load);
            this.groupeAddResa.ResumeLayout(false);
            this.groupeAddResa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.effectifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parcNautiqueDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipementBindingSource)).EndInit();
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox AddEquipement;
        private ParcNautiqueDataSet1 parcNautiqueDataSet1;
        private System.Windows.Forms.BindingSource effectifBindingSource;
        private ParcNautiqueDataSet1TableAdapters.EffectifTableAdapter effectifTableAdapter;
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
    }
}