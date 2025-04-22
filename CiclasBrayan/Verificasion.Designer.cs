namespace Principal
{
    partial class Verificasion
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
            BtVerificar = new Button();
            CodigoV = new TextBox();
            CorreoV = new TextBox();
            SuspendLayout();
            // 
            // BtVerificar
            // 
            BtVerificar.Location = new Point(310, 182);
            BtVerificar.Name = "BtVerificar";
            BtVerificar.Size = new Size(163, 48);
            BtVerificar.TabIndex = 0;
            BtVerificar.Text = "Verificasion";
            BtVerificar.UseVisualStyleBackColor = true;
            BtVerificar.Click += BtVerificar_Click;
            // 
            // CodigoV
            // 
            CodigoV.Location = new Point(310, 141);
            CodigoV.Name = "CodigoV";
            CodigoV.PlaceholderText = "codigo";
            CodigoV.Size = new Size(163, 23);
            CodigoV.TabIndex = 1;
            // 
            // CorreoV
            // 
            CorreoV.Location = new Point(310, 103);
            CorreoV.Name = "CorreoV";
            CorreoV.PlaceholderText = "correo";
            CorreoV.Size = new Size(163, 23);
            CorreoV.TabIndex = 2;
            // 
            // Verificasion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CorreoV);
            Controls.Add(CodigoV);
            Controls.Add(BtVerificar);
            Name = "Verificasion";
            Text = "Verificasion";
            Load += Verificasion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtVerificar;
        private TextBox CodigoV;
        private TextBox CorreoV;
    }
}