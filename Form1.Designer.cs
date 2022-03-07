namespace WFcruzlara
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.img = new System.Windows.Forms.TabPage();
            this.info = new System.Windows.Forms.TabPage();
            this.video = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.procesador = new System.Windows.Forms.Button();
            this.mother = new System.Windows.Forms.Button();
            this.ram = new System.Windows.Forms.Button();
            this.storage = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.gpu = new System.Windows.Forms.Button();
            this.lector = new System.Windows.Forms.Button();
            this.externHardware = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.img.SuspendLayout();
            this.info.SuspendLayout();
            this.video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firmaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // firmaToolStripMenuItem
            // 
            this.firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.img);
            this.tabControl1.Controls.Add(this.info);
            this.tabControl1.Controls.Add(this.video);
            this.tabControl1.Location = new System.Drawing.Point(342, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 416);
            this.tabControl1.TabIndex = 1;
            // 
            // img
            // 
            this.img.Controls.Add(this.pictureBox1);
            this.img.Location = new System.Drawing.Point(4, 22);
            this.img.Name = "img";
            this.img.Padding = new System.Windows.Forms.Padding(3);
            this.img.Size = new System.Drawing.Size(529, 390);
            this.img.TabIndex = 0;
            this.img.Text = "Diagrama de una computadora";
            this.img.UseVisualStyleBackColor = true;
            // 
            // info
            // 
            this.info.Controls.Add(this.label2);
            this.info.Location = new System.Drawing.Point(4, 22);
            this.info.Name = "info";
            this.info.Padding = new System.Windows.Forms.Padding(3);
            this.info.Size = new System.Drawing.Size(529, 390);
            this.info.TabIndex = 1;
            this.info.Text = "Información del componente";
            this.info.UseVisualStyleBackColor = true;
            // 
            // video
            // 
            this.video.Controls.Add(this.webBrowser1);
            this.video.Location = new System.Drawing.Point(4, 22);
            this.video.Name = "video";
            this.video.Padding = new System.Windows.Forms.Padding(3);
            this.video.Size = new System.Drawing.Size(529, 390);
            this.video.TabIndex = 2;
            this.video.Text = "Video con información del componente";
            this.video.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione la parte de la computadora\r\nde la cual desea obtener información";
            // 
            // procesador
            // 
            this.procesador.Location = new System.Drawing.Point(35, 162);
            this.procesador.Name = "procesador";
            this.procesador.Size = new System.Drawing.Size(85, 23);
            this.procesador.TabIndex = 3;
            this.procesador.Text = "Procesador";
            this.procesador.UseVisualStyleBackColor = true;
            this.procesador.Click += new System.EventHandler(this.procesador_Click);
            // 
            // mother
            // 
            this.mother.Location = new System.Drawing.Point(35, 220);
            this.mother.Name = "mother";
            this.mother.Size = new System.Drawing.Size(86, 24);
            this.mother.TabIndex = 4;
            this.mother.Text = "Tarjeta Madre";
            this.mother.UseVisualStyleBackColor = true;
            this.mother.Click += new System.EventHandler(this.mother_Click);
            // 
            // ram
            // 
            this.ram.Location = new System.Drawing.Point(35, 275);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(85, 24);
            this.ram.TabIndex = 5;
            this.ram.Text = "Memoria RAM";
            this.ram.UseVisualStyleBackColor = true;
            this.ram.Click += new System.EventHandler(this.ram_Click);
            // 
            // storage
            // 
            this.storage.Location = new System.Drawing.Point(36, 338);
            this.storage.Name = "storage";
            this.storage.Size = new System.Drawing.Size(85, 26);
            this.storage.TabIndex = 6;
            this.storage.Text = "Discos Duros";
            this.storage.UseVisualStyleBackColor = true;
            this.storage.Click += new System.EventHandler(this.storage_Click);
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(178, 162);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(105, 23);
            this.power.TabIndex = 7;
            this.power.Text = "Fuente de poder";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // gpu
            // 
            this.gpu.Location = new System.Drawing.Point(178, 220);
            this.gpu.Name = "gpu";
            this.gpu.Size = new System.Drawing.Size(105, 23);
            this.gpu.TabIndex = 8;
            this.gpu.Text = "Tarjeta gráfica";
            this.gpu.UseVisualStyleBackColor = true;
            this.gpu.Click += new System.EventHandler(this.gpu_Click);
            // 
            // lector
            // 
            this.lector.Location = new System.Drawing.Point(178, 275);
            this.lector.Name = "lector";
            this.lector.Size = new System.Drawing.Size(105, 23);
            this.lector.TabIndex = 9;
            this.lector.Text = "Lectores";
            this.lector.UseVisualStyleBackColor = true;
            this.lector.Click += new System.EventHandler(this.lector_Click);
            // 
            // externHardware
            // 
            this.externHardware.Location = new System.Drawing.Point(178, 338);
            this.externHardware.Name = "externHardware";
            this.externHardware.Size = new System.Drawing.Size(105, 23);
            this.externHardware.TabIndex = 10;
            this.externHardware.Text = "Hardware externo";
            this.externHardware.UseVisualStyleBackColor = true;
            this.externHardware.Click += new System.EventHandler(this.externHardware_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(523, 384);
            this.webBrowser1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 540);
            this.Controls.Add(this.externHardware);
            this.Controls.Add(this.lector);
            this.Controls.Add(this.gpu);
            this.Controls.Add(this.power);
            this.Controls.Add(this.storage);
            this.Controls.Add(this.ram);
            this.Controls.Add(this.mother);
            this.Controls.Add(this.procesador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Práctica 15";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.img.ResumeLayout(false);
            this.info.ResumeLayout(false);
            this.info.PerformLayout();
            this.video.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage img;
        private System.Windows.Forms.TabPage info;
        private System.Windows.Forms.TabPage video;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button procesador;
        private System.Windows.Forms.Button mother;
        private System.Windows.Forms.Button ram;
        private System.Windows.Forms.Button storage;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button gpu;
        private System.Windows.Forms.Button lector;
        private System.Windows.Forms.Button externHardware;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label2;
    }
}

