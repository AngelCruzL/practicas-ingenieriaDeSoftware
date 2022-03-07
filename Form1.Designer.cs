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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputGroup = new System.Windows.Forms.GroupBox();
            this.proccessGroup = new System.Windows.Forms.GroupBox();
            this.outputGroup = new System.Windows.Forms.GroupBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.ListBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.subtraction = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.exponential = new System.Windows.Forms.Button();
            this.factorial = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.sen = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            this.cot = new System.Windows.Forms.Button();
            this.sec = new System.Windows.Forms.Button();
            this.csc = new System.Windows.Forms.Button();
            this.csch = new System.Windows.Forms.Button();
            this.sech = new System.Windows.Forms.Button();
            this.coth = new System.Windows.Forms.Button();
            this.tanh = new System.Windows.Forms.Button();
            this.senh = new System.Windows.Forms.Button();
            this.cosh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.inputGroup.SuspendLayout();
            this.proccessGroup.SuspendLayout();
            this.outputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 24);
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
            // inputGroup
            // 
            this.inputGroup.Controls.Add(this.input2);
            this.inputGroup.Controls.Add(this.input1);
            this.inputGroup.Location = new System.Drawing.Point(41, 101);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Size = new System.Drawing.Size(156, 285);
            this.inputGroup.TabIndex = 1;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Entrada";
            // 
            // proccessGroup
            // 
            this.proccessGroup.Controls.Add(this.csch);
            this.proccessGroup.Controls.Add(this.sech);
            this.proccessGroup.Controls.Add(this.coth);
            this.proccessGroup.Controls.Add(this.tanh);
            this.proccessGroup.Controls.Add(this.senh);
            this.proccessGroup.Controls.Add(this.cosh);
            this.proccessGroup.Controls.Add(this.csc);
            this.proccessGroup.Controls.Add(this.sec);
            this.proccessGroup.Controls.Add(this.cot);
            this.proccessGroup.Controls.Add(this.tan);
            this.proccessGroup.Controls.Add(this.sen);
            this.proccessGroup.Controls.Add(this.cos);
            this.proccessGroup.Controls.Add(this.factorial);
            this.proccessGroup.Controls.Add(this.exponential);
            this.proccessGroup.Controls.Add(this.division);
            this.proccessGroup.Controls.Add(this.multiplication);
            this.proccessGroup.Controls.Add(this.subtraction);
            this.proccessGroup.Controls.Add(this.messageLabel);
            this.proccessGroup.Controls.Add(this.sum);
            this.proccessGroup.Location = new System.Drawing.Point(240, 101);
            this.proccessGroup.Name = "proccessGroup";
            this.proccessGroup.Size = new System.Drawing.Size(383, 285);
            this.proccessGroup.TabIndex = 2;
            this.proccessGroup.TabStop = false;
            this.proccessGroup.Text = "Proceso";
            // 
            // outputGroup
            // 
            this.outputGroup.Controls.Add(this.output);
            this.outputGroup.Location = new System.Drawing.Point(663, 101);
            this.outputGroup.Name = "outputGroup";
            this.outputGroup.Size = new System.Drawing.Size(237, 285);
            this.outputGroup.TabIndex = 3;
            this.outputGroup.TabStop = false;
            this.outputGroup.Text = "Salida";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(20, 44);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(112, 20);
            this.input1.TabIndex = 0;
            this.input1.Text = "0";
            this.input1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(20, 83);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(112, 20);
            this.input2.TabIndex = 1;
            this.input2.Text = "0";
            this.input2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(325, 29);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(41, 23);
            this.sum.TabIndex = 0;
            this.sum.Text = "+";
            this.sum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // output
            // 
            this.output.FormattingEnabled = true;
            this.output.Items.AddRange(new object[] {
            " "});
            this.output.Location = new System.Drawing.Point(6, 28);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(225, 251);
            this.output.TabIndex = 0;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.messageLabel.Location = new System.Drawing.Point(50, 264);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(55, 15);
            this.messageLabel.TabIndex = 4;
            this.messageLabel.Text = "Mensaje";
            // 
            // subtraction
            // 
            this.subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtraction.Location = new System.Drawing.Point(325, 58);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(41, 23);
            this.subtraction.TabIndex = 5;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplication.Location = new System.Drawing.Point(325, 87);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(41, 23);
            this.multiplication.TabIndex = 6;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(325, 116);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(41, 23);
            this.division.TabIndex = 7;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // exponential
            // 
            this.exponential.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exponential.Location = new System.Drawing.Point(325, 145);
            this.exponential.Name = "exponential";
            this.exponential.Size = new System.Drawing.Size(41, 23);
            this.exponential.TabIndex = 8;
            this.exponential.Text = "x^y";
            this.exponential.UseVisualStyleBackColor = true;
            this.exponential.Click += new System.EventHandler(this.exponential_Click);
            // 
            // factorial
            // 
            this.factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorial.Location = new System.Drawing.Point(325, 174);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(41, 23);
            this.factorial.TabIndex = 9;
            this.factorial.Text = "n!";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // cos
            // 
            this.cos.Location = new System.Drawing.Point(66, 29);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(46, 23);
            this.cos.TabIndex = 10;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.cos_Click);
            // 
            // sen
            // 
            this.sen.Location = new System.Drawing.Point(14, 29);
            this.sen.Name = "sen";
            this.sen.Size = new System.Drawing.Size(46, 23);
            this.sen.TabIndex = 11;
            this.sen.Text = "sen";
            this.sen.UseVisualStyleBackColor = true;
            this.sen.Click += new System.EventHandler(this.sen_Click);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(118, 29);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(46, 23);
            this.tan.TabIndex = 12;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.tan_Click);
            // 
            // cot
            // 
            this.cot.Location = new System.Drawing.Point(170, 29);
            this.cot.Name = "cot";
            this.cot.Size = new System.Drawing.Size(46, 23);
            this.cot.TabIndex = 13;
            this.cot.Text = "cot";
            this.cot.UseVisualStyleBackColor = true;
            this.cot.Click += new System.EventHandler(this.cot_Click);
            // 
            // sec
            // 
            this.sec.Location = new System.Drawing.Point(222, 29);
            this.sec.Name = "sec";
            this.sec.Size = new System.Drawing.Size(46, 23);
            this.sec.TabIndex = 14;
            this.sec.Text = "sec";
            this.sec.UseVisualStyleBackColor = true;
            this.sec.Click += new System.EventHandler(this.sec_Click);
            // 
            // csc
            // 
            this.csc.Location = new System.Drawing.Point(273, 29);
            this.csc.Name = "csc";
            this.csc.Size = new System.Drawing.Size(46, 23);
            this.csc.TabIndex = 15;
            this.csc.Text = "csc";
            this.csc.UseVisualStyleBackColor = true;
            this.csc.Click += new System.EventHandler(this.csc_Click);
            // 
            // csch
            // 
            this.csch.Location = new System.Drawing.Point(273, 58);
            this.csch.Name = "csch";
            this.csch.Size = new System.Drawing.Size(46, 23);
            this.csch.TabIndex = 21;
            this.csch.Text = "csch";
            this.csch.UseVisualStyleBackColor = true;
            this.csch.Click += new System.EventHandler(this.csch_Click);
            // 
            // sech
            // 
            this.sech.Location = new System.Drawing.Point(222, 58);
            this.sech.Name = "sech";
            this.sech.Size = new System.Drawing.Size(46, 23);
            this.sech.TabIndex = 20;
            this.sech.Text = "sech";
            this.sech.UseVisualStyleBackColor = true;
            this.sech.Click += new System.EventHandler(this.sech_Click);
            // 
            // coth
            // 
            this.coth.Location = new System.Drawing.Point(170, 58);
            this.coth.Name = "coth";
            this.coth.Size = new System.Drawing.Size(46, 23);
            this.coth.TabIndex = 19;
            this.coth.Text = "coth";
            this.coth.UseVisualStyleBackColor = true;
            this.coth.Click += new System.EventHandler(this.coth_Click);
            // 
            // tanh
            // 
            this.tanh.Location = new System.Drawing.Point(118, 58);
            this.tanh.Name = "tanh";
            this.tanh.Size = new System.Drawing.Size(46, 23);
            this.tanh.TabIndex = 18;
            this.tanh.Text = "tanh";
            this.tanh.UseVisualStyleBackColor = true;
            this.tanh.Click += new System.EventHandler(this.tanh_Click);
            // 
            // senh
            // 
            this.senh.Location = new System.Drawing.Point(14, 58);
            this.senh.Name = "senh";
            this.senh.Size = new System.Drawing.Size(46, 23);
            this.senh.TabIndex = 17;
            this.senh.Text = "senh";
            this.senh.UseVisualStyleBackColor = true;
            this.senh.Click += new System.EventHandler(this.senh_Click);
            // 
            // cosh
            // 
            this.cosh.Location = new System.Drawing.Point(66, 58);
            this.cosh.Name = "cosh";
            this.cosh.Size = new System.Drawing.Size(46, 23);
            this.cosh.TabIndex = 16;
            this.cosh.Text = "cosh";
            this.cosh.UseVisualStyleBackColor = true;
            this.cosh.Click += new System.EventHandler(this.cosh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 548);
            this.Controls.Add(this.outputGroup);
            this.Controls.Add(this.proccessGroup);
            this.Controls.Add(this.inputGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Práctica 17 | Calculadora";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.inputGroup.ResumeLayout(false);
            this.inputGroup.PerformLayout();
            this.proccessGroup.ResumeLayout(false);
            this.proccessGroup.PerformLayout();
            this.outputGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmaToolStripMenuItem;
        private System.Windows.Forms.GroupBox inputGroup;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.GroupBox proccessGroup;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.GroupBox outputGroup;
        private System.Windows.Forms.ListBox output;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button exponential;
        private System.Windows.Forms.Button factorial;
        private System.Windows.Forms.Button csc;
        private System.Windows.Forms.Button sec;
        private System.Windows.Forms.Button cot;
        private System.Windows.Forms.Button tan;
        private System.Windows.Forms.Button sen;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button csch;
        private System.Windows.Forms.Button sech;
        private System.Windows.Forms.Button coth;
        private System.Windows.Forms.Button tanh;
        private System.Windows.Forms.Button senh;
        private System.Windows.Forms.Button cosh;
    }
}

