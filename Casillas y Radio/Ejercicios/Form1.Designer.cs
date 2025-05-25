namespace Ejercicios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnsalir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RB1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB2 = new System.Windows.Forms.RadioButton();
            this.RB3 = new System.Windows.Forms.RadioButton();
            this.RB4 = new System.Windows.Forms.RadioButton();
            this.RB5 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB10 = new System.Windows.Forms.RadioButton();
            this.RB9 = new System.Windows.Forms.RadioButton();
            this.RB8 = new System.Windows.Forms.RadioButton();
            this.RB7 = new System.Windows.Forms.RadioButton();
            this.RB6 = new System.Windows.Forms.RadioButton();
            this.lblmarca = new System.Windows.Forms.Label();
            this.lblModelo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(50, 336);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(96, 40);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(277, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ver Modelo Seleccionado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RB1
            // 
            this.RB1.AutoSize = true;
            this.RB1.Checked = true;
            this.RB1.Location = new System.Drawing.Point(0, 44);
            this.RB1.Name = "RB1";
            this.RB1.Size = new System.Drawing.Size(80, 24);
            this.RB1.TabIndex = 4;
            this.RB1.TabStop = true;
            this.RB1.Text = "Ferrari";
            this.RB1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB5);
            this.groupBox1.Controls.Add(this.RB4);
            this.groupBox1.Controls.Add(this.RB3);
            this.groupBox1.Controls.Add(this.RB2);
            this.groupBox1.Controls.Add(this.RB1);
            this.groupBox1.Location = new System.Drawing.Point(22, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 218);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marca";
            // 
            // RB2
            // 
            this.RB2.AutoSize = true;
            this.RB2.Location = new System.Drawing.Point(0, 74);
            this.RB2.Name = "RB2";
            this.RB2.Size = new System.Drawing.Size(83, 24);
            this.RB2.TabIndex = 5;
            this.RB2.Text = "Jaguar";
            this.RB2.UseVisualStyleBackColor = true;
            // 
            // RB3
            // 
            this.RB3.AutoSize = true;
            this.RB3.Location = new System.Drawing.Point(0, 104);
            this.RB3.Name = "RB3";
            this.RB3.Size = new System.Drawing.Size(145, 24);
            this.RB3.TabIndex = 6;
            this.RB3.Text = "Mercedes Benz";
            this.RB3.UseVisualStyleBackColor = true;
            this.RB3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // RB4
            // 
            this.RB4.AutoSize = true;
            this.RB4.Location = new System.Drawing.Point(0, 134);
            this.RB4.Name = "RB4";
            this.RB4.Size = new System.Drawing.Size(66, 24);
            this.RB4.TabIndex = 7;
            this.RB4.Text = "Audi";
            this.RB4.UseVisualStyleBackColor = true;
            // 
            // RB5
            // 
            this.RB5.AutoSize = true;
            this.RB5.Location = new System.Drawing.Point(0, 164);
            this.RB5.Name = "RB5";
            this.RB5.Size = new System.Drawing.Size(124, 24);
            this.RB5.TabIndex = 8;
            this.RB5.Text = "Asron Martin";
            this.RB5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RB10);
            this.groupBox2.Controls.Add(this.RB9);
            this.groupBox2.Controls.Add(this.RB8);
            this.groupBox2.Controls.Add(this.RB7);
            this.groupBox2.Controls.Add(this.RB6);
            this.groupBox2.Location = new System.Drawing.Point(403, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 218);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modelo";
            // 
            // RB10
            // 
            this.RB10.AutoSize = true;
            this.RB10.Location = new System.Drawing.Point(0, 164);
            this.RB10.Name = "RB10";
            this.RB10.Size = new System.Drawing.Size(70, 24);
            this.RB10.TabIndex = 8;
            this.RB10.Text = "2013";
            this.RB10.UseVisualStyleBackColor = true;
            // 
            // RB9
            // 
            this.RB9.AutoSize = true;
            this.RB9.Location = new System.Drawing.Point(0, 134);
            this.RB9.Name = "RB9";
            this.RB9.Size = new System.Drawing.Size(70, 24);
            this.RB9.TabIndex = 7;
            this.RB9.Text = "2012";
            this.RB9.UseVisualStyleBackColor = true;
            // 
            // RB8
            // 
            this.RB8.AutoSize = true;
            this.RB8.Location = new System.Drawing.Point(0, 104);
            this.RB8.Name = "RB8";
            this.RB8.Size = new System.Drawing.Size(70, 24);
            this.RB8.TabIndex = 6;
            this.RB8.Text = "2011";
            this.RB8.UseVisualStyleBackColor = true;
            // 
            // RB7
            // 
            this.RB7.AutoSize = true;
            this.RB7.Location = new System.Drawing.Point(0, 74);
            this.RB7.Name = "RB7";
            this.RB7.Size = new System.Drawing.Size(70, 24);
            this.RB7.TabIndex = 5;
            this.RB7.Text = "2010";
            this.RB7.UseVisualStyleBackColor = true;
            // 
            // RB6
            // 
            this.RB6.AutoSize = true;
            this.RB6.Checked = true;
            this.RB6.Location = new System.Drawing.Point(0, 44);
            this.RB6.Name = "RB6";
            this.RB6.Size = new System.Drawing.Size(70, 24);
            this.RB6.TabIndex = 4;
            this.RB6.TabStop = true;
            this.RB6.Text = "2009";
            this.RB6.UseVisualStyleBackColor = true;
            this.RB6.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(95, 290);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(53, 20);
            this.lblmarca.TabIndex = 7;
            this.lblmarca.Text = "Marca";
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(449, 290);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(61, 20);
            this.lblModelo.TabIndex = 8;
            this.lblModelo.Text = "Modelo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsalir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton RB1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB5;
        private System.Windows.Forms.RadioButton RB4;
        private System.Windows.Forms.RadioButton RB3;
        private System.Windows.Forms.RadioButton RB2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB10;
        private System.Windows.Forms.RadioButton RB9;
        private System.Windows.Forms.RadioButton RB8;
        private System.Windows.Forms.RadioButton RB7;
        private System.Windows.Forms.RadioButton RB6;
        private System.Windows.Forms.Label lblmarca;
        private System.Windows.Forms.Label lblModelo;
    }
}

