namespace Ejemplo2
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbdividir = new System.Windows.Forms.RadioButton();
            this.rbmultiplicar = new System.Windows.Forms.RadioButton();
            this.Rbresta = new System.Windows.Forms.RadioButton();
            this.rbsuma = new System.Windows.Forms.RadioButton();
            this.lblresultado = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(45, 36);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(156, 26);
            this.txt1.TabIndex = 0;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(45, 68);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(156, 26);
            this.txt2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbdividir);
            this.groupBox1.Controls.Add(this.rbmultiplicar);
            this.groupBox1.Controls.Add(this.Rbresta);
            this.groupBox1.Controls.Add(this.rbsuma);
            this.groupBox1.Location = new System.Drawing.Point(45, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 159);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbdividir
            // 
            this.rbdividir.AutoSize = true;
            this.rbdividir.Location = new System.Drawing.Point(0, 110);
            this.rbdividir.Name = "rbdividir";
            this.rbdividir.Size = new System.Drawing.Size(76, 24);
            this.rbdividir.TabIndex = 3;
            this.rbdividir.Text = "Dividir";
            this.rbdividir.UseVisualStyleBackColor = true;
            // 
            // rbmultiplicar
            // 
            this.rbmultiplicar.AutoSize = true;
            this.rbmultiplicar.Location = new System.Drawing.Point(0, 80);
            this.rbmultiplicar.Name = "rbmultiplicar";
            this.rbmultiplicar.Size = new System.Drawing.Size(104, 24);
            this.rbmultiplicar.TabIndex = 2;
            this.rbmultiplicar.Text = "Multiplicar";
            this.rbmultiplicar.UseVisualStyleBackColor = true;
            // 
            // Rbresta
            // 
            this.Rbresta.AutoSize = true;
            this.Rbresta.Location = new System.Drawing.Point(0, 50);
            this.Rbresta.Name = "Rbresta";
            this.Rbresta.Size = new System.Drawing.Size(77, 24);
            this.Rbresta.TabIndex = 1;
            this.Rbresta.Text = "Resta\r\n";
            this.Rbresta.UseVisualStyleBackColor = true;
            // 
            // rbsuma
            // 
            this.rbsuma.AutoSize = true;
            this.rbsuma.Checked = true;
            this.rbsuma.Location = new System.Drawing.Point(0, 20);
            this.rbsuma.Name = "rbsuma";
            this.rbsuma.Size = new System.Drawing.Size(76, 24);
            this.rbsuma.TabIndex = 0;
            this.rbsuma.TabStop = true;
            this.rbsuma.Text = "Suma";
            this.rbsuma.UseVisualStyleBackColor = true;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(41, 107);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(51, 20);
            this.lblresultado.TabIndex = 6;
            this.lblresultado.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 337);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbdividir;
        private System.Windows.Forms.RadioButton rbmultiplicar;
        private System.Windows.Forms.RadioButton Rbresta;
        private System.Windows.Forms.RadioButton rbsuma;
        private System.Windows.Forms.Label lblresultado;
    }
}

