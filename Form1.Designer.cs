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
            this.input2 = new System.Windows.Forms.TextBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.proccessGroup = new System.Windows.Forms.GroupBox();
            this.factorial = new System.Windows.Forms.Button();
            this.exponential = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Button();
            this.outputGroup = new System.Windows.Forms.GroupBox();
            this.output = new System.Windows.Forms.ListBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
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
            this.firmaToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.firmaToolStripMenuItem.Text = "Firma";
            this.firmaToolStripMenuItem.Click += new System.EventHandler(this.firmaToolStripMenuItem_Click);
            // 
            // inputGroup
            // 
            this.inputGroup.Controls.Add(this.input2);
            this.inputGroup.Controls.Add(this.input1);
            this.inputGroup.Location = new System.Drawing.Point(37, 49);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Size = new System.Drawing.Size(156, 285);
            this.inputGroup.TabIndex = 1;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Entrada";
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
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(20, 44);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(112, 20);
            this.input1.TabIndex = 0;
            this.input1.Text = "0";
            this.input1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // proccessGroup
            // 
            this.proccessGroup.Controls.Add(this.factorial);
            this.proccessGroup.Controls.Add(this.exponential);
            this.proccessGroup.Controls.Add(this.division);
            this.proccessGroup.Controls.Add(this.multiplication);
            this.proccessGroup.Controls.Add(this.subtraction);
            this.proccessGroup.Controls.Add(this.messageLabel);
            this.proccessGroup.Controls.Add(this.sum);
            this.proccessGroup.Location = new System.Drawing.Point(233, 49);
            this.proccessGroup.Name = "proccessGroup";
            this.proccessGroup.Size = new System.Drawing.Size(234, 285);
            this.proccessGroup.TabIndex = 2;
            this.proccessGroup.TabStop = false;
            this.proccessGroup.Text = "Proceso";
            // 
            // factorial
            // 
            this.factorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorial.Location = new System.Drawing.Point(145, 150);
            this.factorial.Name = "factorial";
            this.factorial.Size = new System.Drawing.Size(53, 23);
            this.factorial.TabIndex = 9;
            this.factorial.Text = "n!";
            this.factorial.UseVisualStyleBackColor = true;
            this.factorial.Click += new System.EventHandler(this.factorial_Click);
            // 
            // exponential
            // 
            this.exponential.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exponential.Location = new System.Drawing.Point(37, 150);
            this.exponential.Name = "exponential";
            this.exponential.Size = new System.Drawing.Size(53, 23);
            this.exponential.TabIndex = 8;
            this.exponential.Text = "x^y";
            this.exponential.UseVisualStyleBackColor = true;
            this.exponential.Click += new System.EventHandler(this.exponential_Click);
            // 
            // division
            // 
            this.division.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(145, 97);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(53, 23);
            this.division.TabIndex = 7;
            this.division.Text = "÷";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // multiplication
            // 
            this.multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplication.Location = new System.Drawing.Point(37, 97);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(53, 23);
            this.multiplication.TabIndex = 6;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // subtraction
            // 
            this.subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtraction.Location = new System.Drawing.Point(145, 44);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(53, 23);
            this.subtraction.TabIndex = 5;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.subtraction_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.messageLabel.Location = new System.Drawing.Point(35, 255);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(55, 15);
            this.messageLabel.TabIndex = 4;
            this.messageLabel.Text = "Mensaje";
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(37, 44);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(53, 23);
            this.sum.TabIndex = 0;
            this.sum.Text = "+";
            this.sum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // outputGroup
            // 
            this.outputGroup.Controls.Add(this.output);
            this.outputGroup.Location = new System.Drawing.Point(504, 49);
            this.outputGroup.Name = "outputGroup";
            this.outputGroup.Size = new System.Drawing.Size(237, 285);
            this.outputGroup.TabIndex = 3;
            this.outputGroup.TabStop = false;
            this.outputGroup.Text = "Salida";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 391);
            this.Controls.Add(this.outputGroup);
            this.Controls.Add(this.proccessGroup);
            this.Controls.Add(this.inputGroup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Práctica 17 | Calculadora Básica";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

