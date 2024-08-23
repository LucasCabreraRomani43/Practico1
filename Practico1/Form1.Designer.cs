namespace Practico1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            BGuardar = new Button();
            BEliminar = new Button();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            txtdato = new TextBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 48);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(71, 167);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 3;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(169, 167);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 4;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(71, 40);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(173, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(71, 106);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtdato
            // 
            txtdato.Location = new Point(295, 40);
            txtdato.Multiline = true;
            txtdato.Name = "txtdato";
            txtdato.Size = new Size(157, 150);
            txtdato.TabIndex = 7;
            txtdato.TextChanged += textBox3_TextChanged;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(397, 226);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(484, 316);
            Controls.Add(btnSalir);
            Controls.Add(txtdato);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Mi Primer Forms";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button BGuardar;
        private Button BEliminar;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private TextBox txtdato;
        private Button btnSalir;
    }
}
