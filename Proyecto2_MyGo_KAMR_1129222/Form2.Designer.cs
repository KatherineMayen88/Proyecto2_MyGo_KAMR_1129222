namespace Proyecto2_MyGo_KAMR_1129222
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button_regresar = new System.Windows.Forms.Button();
            this.button_empezar = new System.Windows.Forms.Button();
            this.button_ingresar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_regresar);
            this.panel1.Controls.Add(this.button_empezar);
            this.panel1.Controls.Add(this.button_ingresar);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 341);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(120, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 47);
            this.label1.TabIndex = 4;
            this.label1.Text = "Iniciar juego";
            // 
            // button_regresar
            // 
            this.button_regresar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_regresar.ForeColor = System.Drawing.Color.Black;
            this.button_regresar.Location = new System.Drawing.Point(139, 233);
            this.button_regresar.Name = "button_regresar";
            this.button_regresar.Size = new System.Drawing.Size(223, 33);
            this.button_regresar.TabIndex = 3;
            this.button_regresar.Text = "Regresar";
            this.button_regresar.UseVisualStyleBackColor = true;
            this.button_regresar.Click += new System.EventHandler(this.button_regresar_Click);
            // 
            // button_empezar
            // 
            this.button_empezar.Enabled = false;
            this.button_empezar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_empezar.Location = new System.Drawing.Point(139, 180);
            this.button_empezar.Name = "button_empezar";
            this.button_empezar.Size = new System.Drawing.Size(223, 33);
            this.button_empezar.TabIndex = 2;
            this.button_empezar.Text = "Empezar partida";
            this.button_empezar.UseVisualStyleBackColor = true;
            this.button_empezar.Click += new System.EventHandler(this.button_empezar_Click);
            // 
            // button_ingresar
            // 
            this.button_ingresar.BackColor = System.Drawing.Color.Transparent;
            this.button_ingresar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ingresar.ForeColor = System.Drawing.Color.Black;
            this.button_ingresar.Location = new System.Drawing.Point(139, 129);
            this.button_ingresar.Name = "button_ingresar";
            this.button_ingresar.Size = new System.Drawing.Size(223, 33);
            this.button_ingresar.TabIndex = 1;
            this.button_ingresar.Text = "Ingresar jugadores";
            this.button_ingresar.UseVisualStyleBackColor = false;
            this.button_ingresar.Click += new System.EventHandler(this.button_ingresar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(519, 339);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú 2: Iniciar juego";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_regresar;
        private System.Windows.Forms.Button button_empezar;
        private System.Windows.Forms.Button button_ingresar;
    }
}