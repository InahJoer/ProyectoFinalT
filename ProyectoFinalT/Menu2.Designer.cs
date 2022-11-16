namespace ProyectoFinalT
{
    partial class Menu2
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnConsularPuntos = new System.Windows.Forms.Button();
            this.btnCanjearPuntos = new System.Windows.Forms.Button();
            this.btnRetirarDinero = new System.Windows.Forms.Button();
            this.btnConsignarDinero = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu De Opciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Consultar mi saldo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConsularPuntos
            // 
            this.btnConsularPuntos.Location = new System.Drawing.Point(183, 83);
            this.btnConsularPuntos.Name = "btnConsularPuntos";
            this.btnConsularPuntos.Size = new System.Drawing.Size(78, 48);
            this.btnConsularPuntos.TabIndex = 2;
            this.btnConsularPuntos.Text = "Consultar mis puntos";
            this.btnConsularPuntos.UseVisualStyleBackColor = true;
            this.btnConsularPuntos.Click += new System.EventHandler(this.btnConsularPuntos_Click);
            // 
            // btnCanjearPuntos
            // 
            this.btnCanjearPuntos.Location = new System.Drawing.Point(312, 83);
            this.btnCanjearPuntos.Name = "btnCanjearPuntos";
            this.btnCanjearPuntos.Size = new System.Drawing.Size(75, 48);
            this.btnCanjearPuntos.TabIndex = 3;
            this.btnCanjearPuntos.Text = "Canjear Puntos";
            this.btnCanjearPuntos.UseVisualStyleBackColor = true;
            this.btnCanjearPuntos.Click += new System.EventHandler(this.btnCanjearPuntos_Click);
            // 
            // btnRetirarDinero
            // 
            this.btnRetirarDinero.Location = new System.Drawing.Point(35, 156);
            this.btnRetirarDinero.Name = "btnRetirarDinero";
            this.btnRetirarDinero.Size = new System.Drawing.Size(75, 46);
            this.btnRetirarDinero.TabIndex = 4;
            this.btnRetirarDinero.Text = "Retirar Dinero";
            this.btnRetirarDinero.UseVisualStyleBackColor = true;
            // 
            // btnConsignarDinero
            // 
            this.btnConsignarDinero.Location = new System.Drawing.Point(186, 156);
            this.btnConsignarDinero.Name = "btnConsignarDinero";
            this.btnConsignarDinero.Size = new System.Drawing.Size(75, 48);
            this.btnConsignarDinero.TabIndex = 5;
            this.btnConsignarDinero.Text = "Consignar Dinero";
            this.btnConsignarDinero.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(312, 224);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 48);
            this.button6.TabIndex = 6;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Menu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 284);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btnConsignarDinero);
            this.Controls.Add(this.btnRetirarDinero);
            this.Controls.Add(this.btnCanjearPuntos);
            this.Controls.Add(this.btnConsularPuntos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Menu2";
            this.Text = "Menu2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnConsularPuntos;
        private Button btnCanjearPuntos;
        private Button btnRetirarDinero;
        private Button btnConsignarDinero;
        private Button button6;
    }
}