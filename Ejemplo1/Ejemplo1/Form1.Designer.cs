namespace Ejemplo1
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
            this.CHKMONITOR = new System.Windows.Forms.CheckBox();
            this.CHKTECLADO = new System.Windows.Forms.CheckBox();
            this.CHKMOUSE = new System.Windows.Forms.CheckBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CHKMONITOR
            // 
            this.CHKMONITOR.AutoSize = true;
            this.CHKMONITOR.Location = new System.Drawing.Point(100, 116);
            this.CHKMONITOR.Name = "CHKMONITOR";
            this.CHKMONITOR.Size = new System.Drawing.Size(128, 24);
            this.CHKMONITOR.TabIndex = 0;
            this.CHKMONITOR.Text = "Monitor $250";
            this.CHKMONITOR.UseVisualStyleBackColor = true;
            this.CHKMONITOR.CheckedChanged += new System.EventHandler(this.CHKMONITOR_CheckedChanged);
            // 
            // CHKTECLADO
            // 
            this.CHKTECLADO.AutoSize = true;
            this.CHKTECLADO.Location = new System.Drawing.Point(100, 165);
            this.CHKTECLADO.Name = "CHKTECLADO";
            this.CHKTECLADO.Size = new System.Drawing.Size(122, 24);
            this.CHKTECLADO.TabIndex = 1;
            this.CHKTECLADO.Text = "Teclado $15";
            this.CHKTECLADO.UseVisualStyleBackColor = true;
            // 
            // CHKMOUSE
            // 
            this.CHKMOUSE.AutoSize = true;
            this.CHKMOUSE.Location = new System.Drawing.Point(100, 217);
            this.CHKMOUSE.Name = "CHKMOUSE";
            this.CHKMOUSE.Size = new System.Drawing.Size(110, 24);
            this.CHKMOUSE.TabIndex = 2;
            this.CHKMOUSE.Text = "Mouse$20";
            this.CHKMOUSE.UseVisualStyleBackColor = true;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(451, 116);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(98, 35);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 448);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.CHKMOUSE);
            this.Controls.Add(this.CHKTECLADO);
            this.Controls.Add(this.CHKMONITOR);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CHKMONITOR;
        private System.Windows.Forms.CheckBox CHKTECLADO;
        private System.Windows.Forms.CheckBox CHKMOUSE;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label label1;
    }
}

