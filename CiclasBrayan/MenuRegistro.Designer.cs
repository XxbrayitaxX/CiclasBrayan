namespace Principal
{
    partial class MenuRegistro
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
            BtRegistrarse = new Button();
            BtVerRegistrador = new Button();
            BtLogin = new Button();
            SuspendLayout();
            // 
            // BtRegistrarse
            // 
            BtRegistrarse.Location = new Point(115, 122);
            BtRegistrarse.Name = "BtRegistrarse";
            BtRegistrarse.Size = new Size(167, 89);
            BtRegistrarse.TabIndex = 0;
            BtRegistrarse.Text = "Registrarse";
            BtRegistrarse.UseVisualStyleBackColor = true;
            BtRegistrarse.Click += BtRegistrarse_Click;
            // 
            // BtVerRegistrador
            // 
            BtVerRegistrador.Location = new Point(513, 122);
            BtVerRegistrador.Name = "BtVerRegistrador";
            BtVerRegistrador.Size = new Size(167, 89);
            BtVerRegistrador.TabIndex = 1;
            BtVerRegistrador.Text = "Ver registros";
            BtVerRegistrador.UseVisualStyleBackColor = true;
            BtVerRegistrador.Click += BtVerRegistrador_Click;
            // 
            // BtLogin
            // 
            BtLogin.Location = new Point(313, 122);
            BtLogin.Name = "BtLogin";
            BtLogin.Size = new Size(167, 89);
            BtLogin.TabIndex = 2;
            BtLogin.Text = "Iniciar sesion";
            BtLogin.UseVisualStyleBackColor = true;
            BtLogin.Click += BtLogin_Click;
            // 
            // MenuRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtLogin);
            Controls.Add(BtVerRegistrador);
            Controls.Add(BtRegistrarse);
            Name = "MenuRegistro";
            Text = "MenuRegistro";
            Load += MenuRegistro_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button BtRegistrarse;
        private Button BtVerRegistrador;
        private Button BtLogin;
    }
}