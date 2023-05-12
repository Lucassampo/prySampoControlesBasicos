namespace prySampoControlesBasicos
{
    partial class frmSecundario
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
            this.lblCopiado = new System.Windows.Forms.Label();
            this.txtEscribir = new System.Windows.Forms.TextBox();
            this.optRojo = new System.Windows.Forms.RadioButton();
            this.optAzul = new System.Windows.Forms.RadioButton();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCopiado
            // 
            this.lblCopiado.AutoSize = true;
            this.lblCopiado.Location = new System.Drawing.Point(139, 119);
            this.lblCopiado.Name = "lblCopiado";
            this.lblCopiado.Size = new System.Drawing.Size(35, 13);
            this.lblCopiado.TabIndex = 0;
            this.lblCopiado.Text = "label1";
            // 
            // txtEscribir
            // 
            this.txtEscribir.Location = new System.Drawing.Point(229, 116);
            this.txtEscribir.Name = "txtEscribir";
            this.txtEscribir.Size = new System.Drawing.Size(100, 20);
            this.txtEscribir.TabIndex = 1;
            this.txtEscribir.TextChanged += new System.EventHandler(this.txtEscribir_TextChanged);
            // 
            // optRojo
            // 
            this.optRojo.AutoSize = true;
            this.optRojo.Location = new System.Drawing.Point(142, 239);
            this.optRojo.Name = "optRojo";
            this.optRojo.Size = new System.Drawing.Size(42, 17);
            this.optRojo.TabIndex = 2;
            this.optRojo.TabStop = true;
            this.optRojo.Text = "rojo";
            this.optRojo.UseVisualStyleBackColor = true;
            // 
            // optAzul
            // 
            this.optAzul.AutoSize = true;
            this.optAzul.Location = new System.Drawing.Point(331, 239);
            this.optAzul.Name = "optAzul";
            this.optAzul.Size = new System.Drawing.Size(44, 17);
            this.optAzul.TabIndex = 3;
            this.optAzul.TabStop = true;
            this.optAzul.Text = "azul";
            this.optAzul.UseVisualStyleBackColor = true;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(229, 308);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 4;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // frmSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.optAzul);
            this.Controls.Add(this.optRojo);
            this.Controls.Add(this.txtEscribir);
            this.Controls.Add(this.lblCopiado);
            this.Name = "frmSecundario";
            this.Text = "frmSecundario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCopiado;
        private System.Windows.Forms.TextBox txtEscribir;
        private System.Windows.Forms.RadioButton optRojo;
        private System.Windows.Forms.RadioButton optAzul;
        private System.Windows.Forms.Button btnAsignar;
    }
}