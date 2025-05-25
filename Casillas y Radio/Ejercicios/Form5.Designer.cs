namespace Ejercicios
{
    partial class Form5
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
            this.LBL1 = new System.Windows.Forms.Label();
            this.TXT1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.CHK4 = new System.Windows.Forms.CheckBox();
            this.CHK3 = new System.Windows.Forms.CheckBox();
            this.CHK1 = new System.Windows.Forms.CheckBox();
            this.CHK2 = new System.Windows.Forms.CheckBox();
            this.btnaplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBL1
            // 
            this.LBL1.AutoSize = true;
            this.LBL1.Location = new System.Drawing.Point(62, 9);
            this.LBL1.Name = "LBL1";
            this.LBL1.Size = new System.Drawing.Size(119, 20);
            this.LBL1.TabIndex = 0;
            this.LBL1.Text = "Texto a mostrar";
            // 
            // TXT1
            // 
            this.TXT1.Location = new System.Drawing.Point(81, 39);
            this.TXT1.Name = "TXT1";
            this.TXT1.Size = new System.Drawing.Size(242, 26);
            this.TXT1.TabIndex = 1;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(64, 349);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(48, 20);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "Texto";
            // 
            // CHK4
            // 
            this.CHK4.AutoSize = true;
            this.CHK4.Location = new System.Drawing.Point(68, 231);
            this.CHK4.Name = "CHK4";
            this.CHK4.Size = new System.Drawing.Size(97, 24);
            this.CHK4.TabIndex = 7;
            this.CHK4.Text = "Tachada";
            this.CHK4.UseVisualStyleBackColor = true;
            // 
            // CHK3
            // 
            this.CHK3.AutoSize = true;
            this.CHK3.Location = new System.Drawing.Point(68, 192);
            this.CHK3.Name = "CHK3";
            this.CHK3.Size = new System.Drawing.Size(113, 24);
            this.CHK3.TabIndex = 8;
            this.CHK3.Text = "checkBox2";
            this.CHK3.UseVisualStyleBackColor = true;
            this.CHK3.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // CHK1
            // 
            this.CHK1.AutoSize = true;
            this.CHK1.Location = new System.Drawing.Point(68, 112);
            this.CHK1.Name = "CHK1";
            this.CHK1.Size = new System.Drawing.Size(86, 24);
            this.CHK1.TabIndex = 9;
            this.CHK1.Text = "Negrita";
            this.CHK1.UseVisualStyleBackColor = true;
            // 
            // CHK2
            // 
            this.CHK2.AutoSize = true;
            this.CHK2.Location = new System.Drawing.Point(68, 153);
            this.CHK2.Name = "CHK2";
            this.CHK2.Size = new System.Drawing.Size(77, 24);
            this.CHK2.TabIndex = 10;
            this.CHK2.Text = "Italica";
            this.CHK2.UseVisualStyleBackColor = true;
            // 
            // btnaplicar
            // 
            this.btnaplicar.Location = new System.Drawing.Point(415, 176);
            this.btnaplicar.Name = "btnaplicar";
            this.btnaplicar.Size = new System.Drawing.Size(96, 49);
            this.btnaplicar.TabIndex = 11;
            this.btnaplicar.Text = "Aplicar";
            this.btnaplicar.UseVisualStyleBackColor = true;
            this.btnaplicar.Click += new System.EventHandler(this.btnaplicar_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.btnaplicar);
            this.Controls.Add(this.CHK2);
            this.Controls.Add(this.CHK1);
            this.Controls.Add(this.CHK3);
            this.Controls.Add(this.CHK4);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.TXT1);
            this.Controls.Add(this.LBL1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL1;
        private System.Windows.Forms.TextBox TXT1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.CheckBox CHK4;
        private System.Windows.Forms.CheckBox CHK3;
        private System.Windows.Forms.CheckBox CHK1;
        private System.Windows.Forms.CheckBox CHK2;
        private System.Windows.Forms.Button btnaplicar;
    }
}