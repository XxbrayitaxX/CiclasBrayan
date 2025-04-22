namespace Principal
{
    partial class Registro
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
            BtGuardarCliente = new Button();
            NombreCliente = new TextBox();
            textBox1 = new TextBox();
            ContraseñaCliente = new TextBox();
            CorreoCliente = new TextBox();
            SuspendLayout();
            // 
            // BtGuardarCliente
            // 
            BtGuardarCliente.Location = new Point(273, 195);
            BtGuardarCliente.Name = "BtGuardarCliente";
            BtGuardarCliente.Size = new Size(185, 58);
            BtGuardarCliente.TabIndex = 0;
            BtGuardarCliente.Text = "Guardar";
            BtGuardarCliente.UseVisualStyleBackColor = true;
            BtGuardarCliente.Click += BtGuardarCliente_Click;
            // 
            // NombreCliente
            // 
            NombreCliente.Location = new Point(273, 85);
            NombreCliente.Name = "NombreCliente";
            NombreCliente.PlaceholderText = "Nombre";
            NombreCliente.Size = new Size(185, 23);
            NombreCliente.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // ContraseñaCliente
            // 
            ContraseñaCliente.HideSelection = false;
            ContraseñaCliente.Location = new Point(273, 166);
            ContraseñaCliente.Name = "ContraseñaCliente";
            ContraseñaCliente.PasswordChar = '*';
            ContraseñaCliente.PlaceholderText = "Contraseña";
            ContraseñaCliente.ShortcutsEnabled = false;
            ContraseñaCliente.Size = new Size(185, 23);
            ContraseñaCliente.TabIndex = 3;
            ContraseñaCliente.Tag = "";
            // 
            // CorreoCliente
            // 
            CorreoCliente.Location = new Point(273, 126);
            CorreoCliente.Name = "CorreoCliente";
            CorreoCliente.PlaceholderText = "correo";
            CorreoCliente.Size = new Size(185, 23);
            CorreoCliente.TabIndex = 4;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CorreoCliente);
            Controls.Add(ContraseñaCliente);
            Controls.Add(NombreCliente);
            Controls.Add(BtGuardarCliente);
            Name = "Registro";
            Text = "Registro";
            Load += Registro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtGuardarCliente;
        private TextBox NombreCliente;
        private TextBox textBox1;
        private TextBox ContraseñaCliente;
        private TextBox CorreoCliente;
    }
}