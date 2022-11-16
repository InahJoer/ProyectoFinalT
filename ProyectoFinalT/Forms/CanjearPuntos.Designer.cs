namespace ProyectoFinalT.Forms
{
    partial class CanjearPuntos
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
            this.txtCanjePuntos = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lbxDatos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuantos Puntos Quieres Canjear?";
            // 
            // txtCanjePuntos
            // 
            this.txtCanjePuntos.Location = new System.Drawing.Point(12, 41);
            this.txtCanjePuntos.Name = "txtCanjePuntos";
            this.txtCanjePuntos.Size = new System.Drawing.Size(100, 23);
            this.txtCanjePuntos.TabIndex = 1;
            this.txtCanjePuntos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(212, 164);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lbxDatos
            // 
            this.lbxDatos.FormattingEnabled = true;
            this.lbxDatos.ItemHeight = 15;
            this.lbxDatos.Location = new System.Drawing.Point(149, 41);
            this.lbxDatos.Name = "lbxDatos";
            this.lbxDatos.Size = new System.Drawing.Size(120, 94);
            this.lbxDatos.TabIndex = 3;
            // 
            // CanjearPuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 199);
            this.Controls.Add(this.lbxDatos);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.txtCanjePuntos);
            this.Controls.Add(this.label1);
            this.Name = "CanjearPuntos";
            this.Text = "CanjearPuntos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtCanjePuntos;
        private Button btnRegresar;
        private ListBox lbxDatos;
    }
}