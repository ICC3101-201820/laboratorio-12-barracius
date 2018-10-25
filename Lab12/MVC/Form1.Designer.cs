namespace MVC
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
            this.NombreTexto = new System.Windows.Forms.TextBox();
            this.ProteinasTexto = new System.Windows.Forms.TextBox();
            this.GrasasTexto = new System.Windows.Forms.TextBox();
            this.CarbohidratosTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AgregarBoton = new System.Windows.Forms.Button();
            this.EliminarSeleccionBoton = new System.Windows.Forms.Button();
            this.comidasList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NombreTexto
            // 
            this.NombreTexto.Location = new System.Drawing.Point(90, 28);
            this.NombreTexto.Name = "NombreTexto";
            this.NombreTexto.Size = new System.Drawing.Size(100, 20);
            this.NombreTexto.TabIndex = 0;
            // 
            // ProteinasTexto
            // 
            this.ProteinasTexto.Location = new System.Drawing.Point(90, 64);
            this.ProteinasTexto.Name = "ProteinasTexto";
            this.ProteinasTexto.Size = new System.Drawing.Size(100, 20);
            this.ProteinasTexto.TabIndex = 1;
            // 
            // GrasasTexto
            // 
            this.GrasasTexto.Location = new System.Drawing.Point(90, 104);
            this.GrasasTexto.Name = "GrasasTexto";
            this.GrasasTexto.Size = new System.Drawing.Size(100, 20);
            this.GrasasTexto.TabIndex = 2;
            // 
            // CarbohidratosTexto
            // 
            this.CarbohidratosTexto.Location = new System.Drawing.Point(90, 145);
            this.CarbohidratosTexto.Name = "CarbohidratosTexto";
            this.CarbohidratosTexto.Size = new System.Drawing.Size(100, 20);
            this.CarbohidratosTexto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proteinas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Grasas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carbohidratos";
            // 
            // AgregarBoton
            // 
            this.AgregarBoton.Location = new System.Drawing.Point(56, 188);
            this.AgregarBoton.Name = "AgregarBoton";
            this.AgregarBoton.Size = new System.Drawing.Size(75, 23);
            this.AgregarBoton.TabIndex = 8;
            this.AgregarBoton.Text = "Agregar";
            this.AgregarBoton.UseVisualStyleBackColor = true;
            this.AgregarBoton.Click += new System.EventHandler(this.AgregarBoton_Click);
            // 
            // EliminarSeleccionBoton
            // 
            this.EliminarSeleccionBoton.Location = new System.Drawing.Point(405, 246);
            this.EliminarSeleccionBoton.Name = "EliminarSeleccionBoton";
            this.EliminarSeleccionBoton.Size = new System.Drawing.Size(109, 23);
            this.EliminarSeleccionBoton.TabIndex = 9;
            this.EliminarSeleccionBoton.Text = "Eliminar Seleccion";
            this.EliminarSeleccionBoton.UseVisualStyleBackColor = true;
            this.EliminarSeleccionBoton.Click += new System.EventHandler(this.EliminarSeleccionBoton_Click);
            // 
            // comidasList
            // 
            this.comidasList.FormattingEnabled = true;
            this.comidasList.Location = new System.Drawing.Point(278, 41);
            this.comidasList.Name = "comidasList";
            this.comidasList.Size = new System.Drawing.Size(341, 199);
            this.comidasList.TabIndex = 10;
            this.comidasList.SelectedIndexChanged += new System.EventHandler(this.comidasList_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Listado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 346);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comidasList);
            this.Controls.Add(this.EliminarSeleccionBoton);
            this.Controls.Add(this.AgregarBoton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CarbohidratosTexto);
            this.Controls.Add(this.GrasasTexto);
            this.Controls.Add(this.ProteinasTexto);
            this.Controls.Add(this.NombreTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreTexto;
        private System.Windows.Forms.TextBox ProteinasTexto;
        private System.Windows.Forms.TextBox GrasasTexto;
        private System.Windows.Forms.TextBox CarbohidratosTexto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AgregarBoton;
        private System.Windows.Forms.Button EliminarSeleccionBoton;
        private System.Windows.Forms.ListBox comidasList;
        private System.Windows.Forms.Label label5;
    }
}

