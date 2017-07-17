namespace GestionParcNautique
{
    partial class MenuAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuAccueil));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGestaEquip = new System.Windows.Forms.Button();
            this.btnGestaEffectif = new System.Windows.Forms.Button();
            this.btnGestaResa = new System.Windows.Forms.Button();
            this.btnGestaClient = new System.Windows.Forms.Button();
            this.BntQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnGestaEquip
            // 
            resources.ApplyResources(this.btnGestaEquip, "btnGestaEquip");
            this.btnGestaEquip.Name = "btnGestaEquip";
            this.btnGestaEquip.UseVisualStyleBackColor = true;
            this.btnGestaEquip.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGestaEffectif
            // 
            resources.ApplyResources(this.btnGestaEffectif, "btnGestaEffectif");
            this.btnGestaEffectif.Name = "btnGestaEffectif";
            this.btnGestaEffectif.UseVisualStyleBackColor = true;
            // 
            // btnGestaResa
            // 
            resources.ApplyResources(this.btnGestaResa, "btnGestaResa");
            this.btnGestaResa.Name = "btnGestaResa";
            this.btnGestaResa.UseVisualStyleBackColor = true;
            // 
            // btnGestaClient
            // 
            resources.ApplyResources(this.btnGestaClient, "btnGestaClient");
            this.btnGestaClient.Name = "btnGestaClient";
            this.btnGestaClient.UseVisualStyleBackColor = true;
            // 
            // BntQuitter
            // 
            resources.ApplyResources(this.BntQuitter, "BntQuitter");
            this.BntQuitter.Name = "BntQuitter";
            this.BntQuitter.UseVisualStyleBackColor = true;
            // 
            // MenuAccueil
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BntQuitter);
            this.Controls.Add(this.btnGestaClient);
            this.Controls.Add(this.btnGestaResa);
            this.Controls.Add(this.btnGestaEffectif);
            this.Controls.Add(this.btnGestaEquip);
            this.Controls.Add(this.label1);
            this.Name = "MenuAccueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestaEquip;
        private System.Windows.Forms.Button btnGestaEffectif;
        private System.Windows.Forms.Button btnGestaResa;
        private System.Windows.Forms.Button btnGestaClient;
        private System.Windows.Forms.Button BntQuitter;
    }
}

