namespace FaceDetect
{
    partial class Form1
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
            this.picCam = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerLimageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.trainBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCam
            // 
            this.picCam.Location = new System.Drawing.Point(12, 40);
            this.picCam.Name = "picCam";
            this.picCam.Size = new System.Drawing.Size(743, 554);
            this.picCam.TabIndex = 0;
            this.picCam.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start WebCAM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picCapture
            // 
            this.picCapture.Location = new System.Drawing.Point(874, 112);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(225, 121);
            this.picCapture.TabIndex = 2;
            this.picCapture.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(874, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "Face detect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fermerToolStripMenuItem,
            this.enregistrerLimageToolStripMenuItem,
            this.àProposToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // enregistrerLimageToolStripMenuItem
            // 
            this.enregistrerLimageToolStripMenuItem.Name = "enregistrerLimageToolStripMenuItem";
            this.enregistrerLimageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enregistrerLimageToolStripMenuItem.Text = "Enregistrer l\'image";
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.àProposToolStripMenuItem.Text = "à propos";
            // 
            // PersonBtn
            // 
            this.PersonBtn.Location = new System.Drawing.Point(874, 372);
            this.PersonBtn.Name = "PersonBtn";
            this.PersonBtn.Size = new System.Drawing.Size(225, 61);
            this.PersonBtn.TabIndex = 5;
            this.PersonBtn.Text = "Person ADD";
            this.PersonBtn.UseVisualStyleBackColor = true;
            this.PersonBtn.Click += new System.EventHandler(this.PersonBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(874, 450);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(225, 62);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save Image";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // trainBtn
            // 
            this.trainBtn.Location = new System.Drawing.Point(874, 535);
            this.trainBtn.Name = "trainBtn";
            this.trainBtn.Size = new System.Drawing.Size(225, 59);
            this.trainBtn.TabIndex = 7;
            this.trainBtn.Text = "Training";
            this.trainBtn.UseVisualStyleBackColor = true;
            this.trainBtn.Click += new System.EventHandler(this.trainBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(874, 326);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 606);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.trainBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.PersonBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.picCapture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picCam);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fermerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerLimageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
        private System.Windows.Forms.Button PersonBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button trainBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

