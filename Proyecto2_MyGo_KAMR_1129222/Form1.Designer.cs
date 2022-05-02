namespace Proyecto2_MyGo_KAMR_1129222
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_salir = new System.Windows.Forms.Button();
            this.button_tablero13 = new System.Windows.Forms.Button();
            this.button_tablero9 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_salir);
            this.panel1.Controls.Add(this.button_tablero13);
            this.panel1.Controls.Add(this.button_tablero9);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 382);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 49);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iniciar juego";
            // 
            // button_salir
            // 
            this.button_salir.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salir.ForeColor = System.Drawing.Color.Black;
            this.button_salir.Location = new System.Drawing.Point(174, 241);
            this.button_salir.Name = "button_salir";
            this.button_salir.Size = new System.Drawing.Size(194, 33);
            this.button_salir.TabIndex = 3;
            this.button_salir.Text = "Salir";
            this.button_salir.UseVisualStyleBackColor = true;
            this.button_salir.Click += new System.EventHandler(this.button_salir_Click);
            // 
            // button_tablero13
            // 
            this.button_tablero13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tablero13.Location = new System.Drawing.Point(174, 188);
            this.button_tablero13.Name = "button_tablero13";
            this.button_tablero13.Size = new System.Drawing.Size(194, 33);
            this.button_tablero13.TabIndex = 2;
            this.button_tablero13.Text = "Tablero 13x13";
            this.button_tablero13.UseVisualStyleBackColor = true;
            this.button_tablero13.Click += new System.EventHandler(this.button_tablero13_Click);
            // 
            // button_tablero9
            // 
            this.button_tablero9.BackColor = System.Drawing.Color.Transparent;
            this.button_tablero9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tablero9.ForeColor = System.Drawing.Color.Black;
            this.button_tablero9.Location = new System.Drawing.Point(174, 139);
            this.button_tablero9.Name = "button_tablero9";
            this.button_tablero9.Size = new System.Drawing.Size(194, 33);
            this.button_tablero9.TabIndex = 1;
            this.button_tablero9.Text = "Tablero 9x9";
            this.button_tablero9.UseVisualStyleBackColor = false;
            this.button_tablero9.Click += new System.EventHandler(this.button_tablero9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto2_MyGo_KAMR_1129222.Properties.Resources._0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 374);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú 1: Iniciar juego";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_salir;
        private System.Windows.Forms.Button button_tablero13;
        private System.Windows.Forms.Button button_tablero9;
        private System.Windows.Forms.Label label1;
    }
}

