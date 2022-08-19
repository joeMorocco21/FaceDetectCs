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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fermerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerLimageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.choisirMaWebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.démmarerMaWebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêterLaCaméraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aIOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activationDeLaReconnaissanceFacialeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activationDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.détectionDesObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.trainBtn = new System.Windows.Forms.Button();
            this.textPersonName = new System.Windows.Forms.TextBox();
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.picCam = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start WebCAM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(874, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 61);
            this.button2.TabIndex = 3;
            this.button2.Text = "Face detect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.webCamToolStripMenuItem,
            this.aIOptionToolStripMenuItem});
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
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionToolStripMenuItem.Text = "Options";
            // 
            // fermerToolStripMenuItem
            // 
            this.fermerToolStripMenuItem.Name = "fermerToolStripMenuItem";
            this.fermerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.fermerToolStripMenuItem.Text = "Fermer";
            this.fermerToolStripMenuItem.Click += new System.EventHandler(this.fermerToolStripMenuItem_Click);
            // 
            // enregistrerLimageToolStripMenuItem
            // 
            this.enregistrerLimageToolStripMenuItem.Name = "enregistrerLimageToolStripMenuItem";
            this.enregistrerLimageToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.enregistrerLimageToolStripMenuItem.Text = "Enregistrer l\'image";
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.àProposToolStripMenuItem.Text = "à propos";
            // 
            // webCamToolStripMenuItem
            // 
            this.webCamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choisirMaWebCamToolStripMenuItem,
            this.démmarerMaWebCamToolStripMenuItem,
            this.arrêterLaCaméraToolStripMenuItem});
            this.webCamToolStripMenuItem.Name = "webCamToolStripMenuItem";
            this.webCamToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.webCamToolStripMenuItem.Text = "Caméra";
            this.webCamToolStripMenuItem.Click += new System.EventHandler(this.webCamToolStripMenuItem_Click);
            // 
            // choisirMaWebCamToolStripMenuItem
            // 
            this.choisirMaWebCamToolStripMenuItem.Name = "choisirMaWebCamToolStripMenuItem";
            this.choisirMaWebCamToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.choisirMaWebCamToolStripMenuItem.Text = "Choisir une caméra";
            // 
            // démmarerMaWebCamToolStripMenuItem
            // 
            this.démmarerMaWebCamToolStripMenuItem.Name = "démmarerMaWebCamToolStripMenuItem";
            this.démmarerMaWebCamToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.démmarerMaWebCamToolStripMenuItem.Text = "Démmarer la caméra";
            // 
            // arrêterLaCaméraToolStripMenuItem
            // 
            this.arrêterLaCaméraToolStripMenuItem.Name = "arrêterLaCaméraToolStripMenuItem";
            this.arrêterLaCaméraToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.arrêterLaCaméraToolStripMenuItem.Text = "Arrêter la caméra";
            // 
            // aIOptionToolStripMenuItem
            // 
            this.aIOptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activationDeLaReconnaissanceFacialeToolStripMenuItem,
            this.activationDeToolStripMenuItem,
            this.détectionDesObjectsToolStripMenuItem});
            this.aIOptionToolStripMenuItem.Name = "aIOptionToolStripMenuItem";
            this.aIOptionToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.aIOptionToolStripMenuItem.Text = "AI Outils";
            // 
            // activationDeLaReconnaissanceFacialeToolStripMenuItem
            // 
            this.activationDeLaReconnaissanceFacialeToolStripMenuItem.Name = "activationDeLaReconnaissanceFacialeToolStripMenuItem";
            this.activationDeLaReconnaissanceFacialeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.activationDeLaReconnaissanceFacialeToolStripMenuItem.Text = "Reconnaissance faciale";
            // 
            // activationDeToolStripMenuItem
            // 
            this.activationDeToolStripMenuItem.Name = "activationDeToolStripMenuItem";
            this.activationDeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.activationDeToolStripMenuItem.Text = "Détection des yeux";
            this.activationDeToolStripMenuItem.Click += new System.EventHandler(this.activationDeToolStripMenuItem_Click);
            // 
            // détectionDesObjectsToolStripMenuItem
            // 
            this.détectionDesObjectsToolStripMenuItem.Name = "détectionDesObjectsToolStripMenuItem";
            this.détectionDesObjectsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.détectionDesObjectsToolStripMenuItem.Text = "Détection des objets";
            // 
            // PersonBtn
            // 
            this.PersonBtn.Location = new System.Drawing.Point(874, 253);
            this.PersonBtn.Name = "PersonBtn";
            this.PersonBtn.Size = new System.Drawing.Size(225, 61);
            this.PersonBtn.TabIndex = 5;
            this.PersonBtn.Text = "Person ADD";
            this.PersonBtn.UseVisualStyleBackColor = true;
            this.PersonBtn.Click += new System.EventHandler(this.PersonBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(623, 377);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(225, 62);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save Image";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // trainBtn
            // 
            this.trainBtn.Location = new System.Drawing.Point(874, 377);
            this.trainBtn.Name = "trainBtn";
            this.trainBtn.Size = new System.Drawing.Size(225, 59);
            this.trainBtn.TabIndex = 7;
            this.trainBtn.Text = "Training";
            this.trainBtn.UseVisualStyleBackColor = true;
            this.trainBtn.Click += new System.EventHandler(this.trainBtn_Click);
            // 
            // textPersonName
            // 
            this.textPersonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.textPersonName.Location = new System.Drawing.Point(874, 204);
            this.textPersonName.Name = "textPersonName";
            this.textPersonName.Size = new System.Drawing.Size(225, 29);
            this.textPersonName.TabIndex = 8;
            // 
            // picCapture
            // 
            this.picCapture.BackColor = System.Drawing.Color.White;
            this.picCapture.BackgroundImage = global::FaceDetect.Properties.Resources._7727534_vision_eye_view_business_focus_icon;
            this.picCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCapture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCapture.Location = new System.Drawing.Point(623, 63);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(225, 135);
            this.picCapture.TabIndex = 2;
            this.picCapture.TabStop = false;
            // 
            // picCam
            // 
            this.picCam.BackColor = System.Drawing.Color.White;
            this.picCam.BackgroundImage = global::FaceDetect.Properties.Resources._6579051_and_camera_computers_hardware_video_icon__1_;
            this.picCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picCam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCam.Location = new System.Drawing.Point(33, 63);
            this.picCam.Name = "picCam";
            this.picCam.Size = new System.Drawing.Size(573, 505);
            this.picCam.TabIndex = 0;
            this.picCam.TabStop = false;
            // 
            // picBox1
            // 
            this.picBox1.BackColor = System.Drawing.Color.White;
            this.picBox1.BackgroundImage = global::FaceDetect.Properties.Resources._47230_picture_file_icon;
            this.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox1.Location = new System.Drawing.Point(623, 204);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(110, 156);
            this.picBox1.TabIndex = 9;
            this.picBox1.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.BackColor = System.Drawing.Color.White;
            this.picBox2.BackgroundImage = global::FaceDetect.Properties.Resources._47230_picture_file_icon;
            this.picBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox2.Location = new System.Drawing.Point(738, 204);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(110, 156);
            this.picBox2.TabIndex = 10;
            this.picBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FaceDetect.Properties.Resources.intelligence_artificielle_cerveau_maladie_mentale_6327680;
            this.ClientSize = new System.Drawing.Size(1140, 606);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.textPersonName);
            this.Controls.Add(this.trainBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.PersonBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.picCapture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picCam);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Smart Eyes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
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
        private System.Windows.Forms.TextBox textPersonName;
        private System.Windows.Forms.ToolStripMenuItem webCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem choisirMaWebCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem démmarerMaWebCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrêterLaCaméraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aIOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activationDeLaReconnaissanceFacialeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activationDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem détectionDesObjectsToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
    }
}

