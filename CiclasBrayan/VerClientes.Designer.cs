namespace Principal
{
    partial class VerClientes
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
            BtVerClientes = new Button();
            ClientesGuardados = new Label();
            SuspendLayout();
            // 
            // BtVerClientes
            // 
            BtVerClientes.Location = new Point(287, 111);
            BtVerClientes.Name = "BtVerClientes";
            BtVerClientes.Size = new Size(189, 75);
            BtVerClientes.TabIndex = 0;
            BtVerClientes.Text = "Ver clientes guardados";
            BtVerClientes.UseVisualStyleBackColor = true;
            BtVerClientes.Click += BtVerClientes_Click;
            // 
            // ClientesGuardados
            // 
            ClientesGuardados.AccessibleName = "";
            ClientesGuardados.AllowDrop = true;
            ClientesGuardados.AutoSize = true;
            ClientesGuardados.Location = new Point(287, 212);
            ClientesGuardados.Name = "ClientesGuardados";
            ClientesGuardados.Size = new Size(52, 15);
            ClientesGuardados.TabIndex = 1;
            ClientesGuardados.Text = "Clientes:\r\n";
            // 
            // VerClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ClientesGuardados);
            Controls.Add(BtVerClientes);
            Name = "VerClientes";
            Text = "VerClientes";
            Load += VerClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtVerClientes;
        private Label ClientesGuardados;
    }
}