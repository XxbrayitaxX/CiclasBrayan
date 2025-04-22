namespace Principal
{
    partial class Login
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
            Contraseña = new TextBox();
            BtIniciarSesion = new Button();
            Correo = new TextBox();
            SuspendLayout();
            // 
            // Contraseña
            // 
            Contraseña.Location = new Point(276, 158);
            Contraseña.Name = "Contraseña";
            Contraseña.PasswordChar = '*';
            Contraseña.PlaceholderText = "contraseña";
            Contraseña.Size = new Size(191, 23);
            Contraseña.TabIndex = 1;
            // 
            // BtIniciarSesion
            // 
            BtIniciarSesion.Location = new Point(276, 197);
            BtIniciarSesion.Name = "BtIniciarSesion";
            BtIniciarSesion.Size = new Size(191, 57);
            BtIniciarSesion.TabIndex = 2;
            BtIniciarSesion.Text = "Iniciar sesion";
            BtIniciarSesion.UseVisualStyleBackColor = true;
            BtIniciarSesion.Click += BtIniciarSesion_Click;
            // 
            // Correo
            // 
            Correo.Location = new Point(276, 118);
            Correo.Name = "Correo";
            Correo.PlaceholderText = "correo";
            Correo.Size = new Size(191, 23);
            Correo.TabIndex = 3;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Correo);
            Controls.Add(BtIniciarSesion);
            Controls.Add(Contraseña);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Contraseña;
        private Button BtIniciarSesion;
        private TextBox Correo;
    }
}