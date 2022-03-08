namespace HolaMundo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_revisar = new System.Windows.Forms.Button();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.txt_psw_second = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_revisar
            // 
            this.btn_revisar.BackColor = System.Drawing.Color.Tomato;
            this.btn_revisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_revisar.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_revisar.Location = new System.Drawing.Point(517, 289);
            this.btn_revisar.Name = "btn_revisar";
            this.btn_revisar.Size = new System.Drawing.Size(119, 45);
            this.btn_revisar.TabIndex = 0;
            this.btn_revisar.Text = "REVISAR";
            this.btn_revisar.UseVisualStyleBackColor = false;
            this.btn_revisar.Click += new System.EventHandler(this.btn_revisar_Click);
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(107, 117);
            this.txt_input.Multiline = true;
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(529, 41);
            this.txt_input.TabIndex = 1;
            // 
            // txt_psw_second
            // 
            this.txt_psw_second.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_psw_second.Location = new System.Drawing.Point(107, 224);
            this.txt_psw_second.Name = "txt_psw_second";
            this.txt_psw_second.Size = new System.Drawing.Size(529, 41);
            this.txt_psw_second.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingresa la contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Repite la contraseña";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_psw_second);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.btn_revisar);
            this.Name = "Form1";
            this.Text = "Formulario \"Hola Mundo\"";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_revisar;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.TextBox txt_psw_second;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

