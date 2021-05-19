namespace MultiForm
{
    partial class Form2
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
            this.listViewGuardaTodo = new System.Windows.Forms.ListView();
            this.ColumnaNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaApellido1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnaEstado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.Label();
            this.TextBoxnombre1 = new System.Windows.Forms.TextBox();
            this.TextBoxapellido2 = new System.Windows.Forms.TextBox();
            this.TextBoxnumero3 = new System.Windows.Forms.TextBox();
            this.TextBoxestado4 = new System.Windows.Forms.TextBox();
            this.Boton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewGuardaTodo
            // 
            this.listViewGuardaTodo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnaNombre,
            this.ColumnaApellido1,
            this.ColumnaTelefono,
            this.ColumnaEstado});
            this.listViewGuardaTodo.HideSelection = false;
            this.listViewGuardaTodo.Location = new System.Drawing.Point(54, 126);
            this.listViewGuardaTodo.Name = "listViewGuardaTodo";
            this.listViewGuardaTodo.Size = new System.Drawing.Size(641, 273);
            this.listViewGuardaTodo.TabIndex = 1;
            this.listViewGuardaTodo.UseCompatibleStateImageBehavior = false;
            this.listViewGuardaTodo.View = System.Windows.Forms.View.Details;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.Text = "Nombre(s)";
            this.ColumnaNombre.Width = 104;
            // 
            // ColumnaApellido1
            // 
            this.ColumnaApellido1.Text = "Apellido";
            this.ColumnaApellido1.Width = 98;
            // 
            // ColumnaTelefono
            // 
            this.ColumnaTelefono.Text = "Telefono";
            this.ColumnaTelefono.Width = 101;
            // 
            // ColumnaEstado
            // 
            this.ColumnaEstado.Text = "Estado";
            this.ColumnaEstado.Width = 144;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(57, 26);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(72, 19);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre:";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.Location = new System.Drawing.Point(50, 57);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(90, 19);
            this.Apellido.TabIndex = 3;
            this.Apellido.Text = "Apellido:";
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.Location = new System.Drawing.Point(387, 38);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(72, 19);
            this.Numero.TabIndex = 4;
            this.Numero.Text = "Numero:";
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.Location = new System.Drawing.Point(387, 66);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(72, 19);
            this.Estado.TabIndex = 5;
            this.Estado.Text = "Estado:";
            // 
            // TextBoxnombre1
            // 
            this.TextBoxnombre1.Location = new System.Drawing.Point(135, 27);
            this.TextBoxnombre1.Name = "TextBoxnombre1";
            this.TextBoxnombre1.Size = new System.Drawing.Size(175, 20);
            this.TextBoxnombre1.TabIndex = 6;
            // 
            // TextBoxapellido2
            // 
            this.TextBoxapellido2.Location = new System.Drawing.Point(146, 56);
            this.TextBoxapellido2.Name = "TextBoxapellido2";
            this.TextBoxapellido2.Size = new System.Drawing.Size(164, 20);
            this.TextBoxapellido2.TabIndex = 7;
            // 
            // TextBoxnumero3
            // 
            this.TextBoxnumero3.Location = new System.Drawing.Point(463, 37);
            this.TextBoxnumero3.Name = "TextBoxnumero3";
            this.TextBoxnumero3.Size = new System.Drawing.Size(176, 20);
            this.TextBoxnumero3.TabIndex = 8;
            // 
            // TextBoxestado4
            // 
            this.TextBoxestado4.Location = new System.Drawing.Point(465, 66);
            this.TextBoxestado4.Name = "TextBoxestado4";
            this.TextBoxestado4.Size = new System.Drawing.Size(173, 20);
            this.TextBoxestado4.TabIndex = 9;
            // 
            // Boton
            // 
            this.Boton.BackColor = System.Drawing.Color.LightPink;
            this.Boton.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Boton.Location = new System.Drawing.Point(674, 47);
            this.Boton.Name = "Boton";
            this.Boton.Size = new System.Drawing.Size(117, 38);
            this.Boton.TabIndex = 10;
            this.Boton.Text = "Siguiente";
            this.Boton.UseVisualStyleBackColor = false;
            this.Boton.Click += new System.EventHandler(this.Boton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Boton);
            this.Controls.Add(this.TextBoxestado4);
            this.Controls.Add(this.TextBoxnumero3);
            this.Controls.Add(this.TextBoxapellido2);
            this.Controls.Add(this.TextBoxnombre1);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.listViewGuardaTodo);
            this.Name = "Form2";
            this.Text = "sd";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewGuardaTodo;
        private System.Windows.Forms.ColumnHeader ColumnaNombre;
        private System.Windows.Forms.ColumnHeader ColumnaApellido1;
        private System.Windows.Forms.ColumnHeader ColumnaTelefono;
        private System.Windows.Forms.ColumnHeader ColumnaEstado;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.TextBox TextBoxnombre1;
        private System.Windows.Forms.TextBox TextBoxapellido2;
        private System.Windows.Forms.TextBox TextBoxnumero3;
        private System.Windows.Forms.TextBox TextBoxestado4;
        private System.Windows.Forms.Button Boton;
    }
}