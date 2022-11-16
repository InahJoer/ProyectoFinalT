namespace ProyectoFinalT
{
    partial class Menu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciarS = new System.Windows.Forms.Button();
            this.btnCrearU = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu De Inicio";
            // 
            // btnIniciarS
            // 
            this.btnIniciarS.Location = new System.Drawing.Point(28, 138);
            this.btnIniciarS.Name = "btnIniciarS";
            this.btnIniciarS.Size = new System.Drawing.Size(75, 41);
            this.btnIniciarS.TabIndex = 1;
            this.btnIniciarS.Text = "Iniciar Sesion";
            this.btnIniciarS.UseVisualStyleBackColor = true;
            this.btnIniciarS.Click += new System.EventHandler(this.btnIniciarS_Click);
            // 
            // btnCrearU
            // 
            this.btnCrearU.Location = new System.Drawing.Point(28, 62);
            this.btnCrearU.Name = "btnCrearU";
            this.btnCrearU.Size = new System.Drawing.Size(75, 42);
            this.btnCrearU.TabIndex = 2;
            this.btnCrearU.Text = "Crear Usuario";
            this.btnCrearU.UseVisualStyleBackColor = true;
            this.btnCrearU.Click += new System.EventHandler(this.btnCrearU_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(193, 235);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 270);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrearU);
            this.Controls.Add(this.btnIniciarS);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnIniciarS;
        private Button btnCrearU;
        private Button btnSalir;
    }
}