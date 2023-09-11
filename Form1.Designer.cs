namespace Proyecto_U1_3_Arbol
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
            this.arbolDatos = new System.Windows.Forms.TreeView();
            this.botonAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // arbolDatos
            // 
            this.arbolDatos.Location = new System.Drawing.Point(12, 12);
            this.arbolDatos.Name = "arbolDatos";
            this.arbolDatos.Size = new System.Drawing.Size(212, 426);
            this.arbolDatos.TabIndex = 0;
            // 
            // botonAbrir
            // 
            this.botonAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAbrir.Location = new System.Drawing.Point(256, 12);
            this.botonAbrir.Name = "botonAbrir";
            this.botonAbrir.Size = new System.Drawing.Size(96, 40);
            this.botonAbrir.TabIndex = 1;
            this.botonAbrir.Text = "Abrir";
            this.botonAbrir.UseVisualStyleBackColor = true;
            this.botonAbrir.Click += new System.EventHandler(this.botonAbrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonAbrir);
            this.Controls.Add(this.arbolDatos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView arbolDatos;
        private System.Windows.Forms.Button botonAbrir;
    }
}

