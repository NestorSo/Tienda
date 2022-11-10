namespace TareaDeCurso
{
    partial class frmRegistro
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
            this.btnRegistrtar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrtar
            // 
            this.btnRegistrtar.Location = new System.Drawing.Point(323, 203);
            this.btnRegistrtar.Name = "btnRegistrtar";
            this.btnRegistrtar.Size = new System.Drawing.Size(125, 23);
            this.btnRegistrtar.TabIndex = 0;
            this.btnRegistrtar.Text = "Registrar Inventario";
            this.btnRegistrtar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrtar.UseVisualStyleBackColor = true;
            this.btnRegistrtar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(89, 203);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 1;
            this.btnComprar.Text = "Comprar ";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Que desea realizar ";
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnRegistrtar);
            this.Name = "frmRegistro";
            this.Text = "TiendaDeRopa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegistrtar;
        private Button btnComprar;
        private Label label1;
    }
}