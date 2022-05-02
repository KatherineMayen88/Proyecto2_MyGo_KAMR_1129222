namespace Proyecto2_MyGo_KAMR_1129222
{
    partial class Form4_tablero
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
            this.label_nombrej1 = new System.Windows.Forms.Label();
            this.label_piezasj1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_piezasj2 = new System.Windows.Forms.Label();
            this.label_nombrej2 = new System.Windows.Forms.Label();
            this.button_pasar = new System.Windows.Forms.Button();
            this.button_terminar = new System.Windows.Forms.Button();
            this.button_punteo = new System.Windows.Forms.Button();
            this.label_puntos_fichasblancas = new System.Windows.Forms.Label();
            this.label_puntos_fichasnegras = new System.Windows.Forms.Label();
            this.label_turno = new System.Windows.Forms.Label();
            this.pictureBox_avatar2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_avatar1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nombrej1
            // 
            this.label_nombrej1.AutoSize = true;
            this.label_nombrej1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombrej1.Location = new System.Drawing.Point(129, 51);
            this.label_nombrej1.Name = "label_nombrej1";
            this.label_nombrej1.Size = new System.Drawing.Size(0, 19);
            this.label_nombrej1.TabIndex = 2;
            // 
            // label_piezasj1
            // 
            this.label_piezasj1.AutoSize = true;
            this.label_piezasj1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_piezasj1.Location = new System.Drawing.Point(129, 85);
            this.label_piezasj1.Name = "label_piezasj1";
            this.label_piezasj1.Size = new System.Drawing.Size(0, 19);
            this.label_piezasj1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox_avatar1);
            this.groupBox1.Controls.Add(this.label_piezasj1);
            this.groupBox1.Controls.Add(this.label_nombrej1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(489, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 137);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jugador 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox_avatar2);
            this.groupBox2.Controls.Add(this.label_piezasj2);
            this.groupBox2.Controls.Add(this.label_nombrej2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(489, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 137);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jugador 2";
            // 
            // label_piezasj2
            // 
            this.label_piezasj2.AutoSize = true;
            this.label_piezasj2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_piezasj2.Location = new System.Drawing.Point(129, 85);
            this.label_piezasj2.Name = "label_piezasj2";
            this.label_piezasj2.Size = new System.Drawing.Size(0, 19);
            this.label_piezasj2.TabIndex = 3;
            // 
            // label_nombrej2
            // 
            this.label_nombrej2.AutoSize = true;
            this.label_nombrej2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombrej2.Location = new System.Drawing.Point(129, 51);
            this.label_nombrej2.Name = "label_nombrej2";
            this.label_nombrej2.Size = new System.Drawing.Size(0, 19);
            this.label_nombrej2.TabIndex = 2;
            // 
            // button_pasar
            // 
            this.button_pasar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pasar.Location = new System.Drawing.Point(490, 555);
            this.button_pasar.Name = "button_pasar";
            this.button_pasar.Size = new System.Drawing.Size(329, 34);
            this.button_pasar.TabIndex = 10;
            this.button_pasar.Text = "Pasar de turno";
            this.button_pasar.UseVisualStyleBackColor = true;
            this.button_pasar.Click += new System.EventHandler(this.button_pasar_Click);
            // 
            // button_terminar
            // 
            this.button_terminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_terminar.Location = new System.Drawing.Point(490, 602);
            this.button_terminar.Name = "button_terminar";
            this.button_terminar.Size = new System.Drawing.Size(329, 34);
            this.button_terminar.TabIndex = 11;
            this.button_terminar.Text = "Terminar juego";
            this.button_terminar.UseVisualStyleBackColor = true;
            this.button_terminar.Click += new System.EventHandler(this.button_terminar_Click);
            // 
            // button_punteo
            // 
            this.button_punteo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_punteo.Location = new System.Drawing.Point(489, 448);
            this.button_punteo.Name = "button_punteo";
            this.button_punteo.Size = new System.Drawing.Size(157, 28);
            this.button_punteo.TabIndex = 12;
            this.button_punteo.Text = "Punteo";
            this.button_punteo.UseVisualStyleBackColor = true;
            this.button_punteo.Click += new System.EventHandler(this.button_punteo_Click);
            // 
            // label_puntos_fichasblancas
            // 
            this.label_puntos_fichasblancas.AutoSize = true;
            this.label_puntos_fichasblancas.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_puntos_fichasblancas.Location = new System.Drawing.Point(510, 517);
            this.label_puntos_fichasblancas.Name = "label_puntos_fichasblancas";
            this.label_puntos_fichasblancas.Size = new System.Drawing.Size(0, 21);
            this.label_puntos_fichasblancas.TabIndex = 14;
            // 
            // label_puntos_fichasnegras
            // 
            this.label_puntos_fichasnegras.AutoSize = true;
            this.label_puntos_fichasnegras.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_puntos_fichasnegras.Location = new System.Drawing.Point(510, 485);
            this.label_puntos_fichasnegras.Name = "label_puntos_fichasnegras";
            this.label_puntos_fichasnegras.Size = new System.Drawing.Size(0, 21);
            this.label_puntos_fichasnegras.TabIndex = 13;
            // 
            // label_turno
            // 
            this.label_turno.AutoSize = true;
            this.label_turno.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_turno.Location = new System.Drawing.Point(594, 73);
            this.label_turno.Name = "label_turno";
            this.label_turno.Size = new System.Drawing.Size(0, 19);
            this.label_turno.TabIndex = 15;
            // 
            // pictureBox_avatar2
            // 
            this.pictureBox_avatar2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox_avatar2.Location = new System.Drawing.Point(25, 34);
            this.pictureBox_avatar2.Name = "pictureBox_avatar2";
            this.pictureBox_avatar2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_avatar2.TabIndex = 0;
            this.pictureBox_avatar2.TabStop = false;
            // 
            // pictureBox_avatar1
            // 
            this.pictureBox_avatar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox_avatar1.Location = new System.Drawing.Point(25, 34);
            this.pictureBox_avatar1.Name = "pictureBox_avatar1";
            this.pictureBox_avatar1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_avatar1.TabIndex = 0;
            this.pictureBox_avatar1.TabStop = false;
            // 
            // Form4_tablero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(893, 687);
            this.Controls.Add(this.label_turno);
            this.Controls.Add(this.label_puntos_fichasblancas);
            this.Controls.Add(this.label_puntos_fichasnegras);
            this.Controls.Add(this.button_punteo);
            this.Controls.Add(this.button_terminar);
            this.Controls.Add(this.button_pasar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4_tablero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tablero";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_avatar1;
        private System.Windows.Forms.Label label_nombrej1;
        private System.Windows.Forms.Label label_piezasj1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox_avatar2;
        private System.Windows.Forms.Label label_piezasj2;
        private System.Windows.Forms.Label label_nombrej2;
        private System.Windows.Forms.Button button_pasar;
        private System.Windows.Forms.Button button_terminar;
        private System.Windows.Forms.Button button_punteo;
        private System.Windows.Forms.Label label_puntos_fichasblancas;
        private System.Windows.Forms.Label label_puntos_fichasnegras;
        private System.Windows.Forms.Label label_turno;
    }
}