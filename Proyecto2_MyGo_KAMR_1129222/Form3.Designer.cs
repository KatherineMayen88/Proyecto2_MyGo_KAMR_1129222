namespace Proyecto2_MyGo_KAMR_1129222
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.button_guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_avatarj1 = new System.Windows.Forms.Button();
            this.pictureBox_avatarj1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_piedrasj1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_nombrej1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_avatarj2 = new System.Windows.Forms.Button();
            this.pictureBox_avatarj2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_piedrasj2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_nombrej2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatarj1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatarj2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(47, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 47);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ingresar datos";
            // 
            // button_guardar
            // 
            this.button_guardar.BackColor = System.Drawing.Color.Transparent;
            this.button_guardar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guardar.ForeColor = System.Drawing.Color.Black;
            this.button_guardar.Location = new System.Drawing.Point(277, 565);
            this.button_guardar.Name = "button_guardar";
            this.button_guardar.Size = new System.Drawing.Size(196, 33);
            this.button_guardar.TabIndex = 5;
            this.button_guardar.Text = "Guardar datos";
            this.button_guardar.UseVisualStyleBackColor = false;
            this.button_guardar.Click += new System.EventHandler(this.button_guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_avatarj1);
            this.groupBox1.Controls.Add(this.pictureBox_avatarj1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_piedrasj1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_nombrej1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 429);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jugador 1";
            // 
            // button_avatarj1
            // 
            this.button_avatarj1.BackColor = System.Drawing.Color.Transparent;
            this.button_avatarj1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_avatarj1.ForeColor = System.Drawing.Color.Black;
            this.button_avatarj1.Location = new System.Drawing.Point(20, 369);
            this.button_avatarj1.Name = "button_avatarj1";
            this.button_avatarj1.Size = new System.Drawing.Size(244, 29);
            this.button_avatarj1.TabIndex = 10;
            this.button_avatarj1.Text = "Seleccionar";
            this.button_avatarj1.UseVisualStyleBackColor = false;
            this.button_avatarj1.Click += new System.EventHandler(this.button_avatarj1_Click);
            // 
            // pictureBox_avatarj1
            // 
            this.pictureBox_avatarj1.Location = new System.Drawing.Point(20, 257);
            this.pictureBox_avatarj1.Name = "pictureBox_avatarj1";
            this.pictureBox_avatarj1.Size = new System.Drawing.Size(244, 103);
            this.pictureBox_avatarj1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_avatarj1.TabIndex = 5;
            this.pictureBox_avatarj1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Avatar del jugador:";
            // 
            // comboBox_piedrasj1
            // 
            this.comboBox_piedrasj1.FormattingEnabled = true;
            this.comboBox_piedrasj1.Items.AddRange(new object[] {
            "Piedras blancas",
            "Piedras negras"});
            this.comboBox_piedrasj1.Location = new System.Drawing.Point(20, 168);
            this.comboBox_piedrasj1.Name = "comboBox_piedrasj1";
            this.comboBox_piedrasj1.Size = new System.Drawing.Size(244, 29);
            this.comboBox_piedrasj1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color de fichas del jugador:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del jugador:";
            // 
            // textBox_nombrej1
            // 
            this.textBox_nombrej1.Location = new System.Drawing.Point(20, 78);
            this.textBox_nombrej1.Name = "textBox_nombrej1";
            this.textBox_nombrej1.Size = new System.Drawing.Size(244, 28);
            this.textBox_nombrej1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_avatarj2);
            this.groupBox2.Controls.Add(this.pictureBox_avatarj2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox_piedrasj2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_nombrej2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(410, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 429);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jugador 2";
            // 
            // button_avatarj2
            // 
            this.button_avatarj2.BackColor = System.Drawing.Color.Transparent;
            this.button_avatarj2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_avatarj2.ForeColor = System.Drawing.Color.Black;
            this.button_avatarj2.Location = new System.Drawing.Point(20, 369);
            this.button_avatarj2.Name = "button_avatarj2";
            this.button_avatarj2.Size = new System.Drawing.Size(244, 29);
            this.button_avatarj2.TabIndex = 10;
            this.button_avatarj2.Text = "Seleccionar";
            this.button_avatarj2.UseVisualStyleBackColor = false;
            this.button_avatarj2.Click += new System.EventHandler(this.button_avatarj2_Click);
            // 
            // pictureBox_avatarj2
            // 
            this.pictureBox_avatarj2.Location = new System.Drawing.Point(20, 257);
            this.pictureBox_avatarj2.Name = "pictureBox_avatarj2";
            this.pictureBox_avatarj2.Size = new System.Drawing.Size(244, 103);
            this.pictureBox_avatarj2.TabIndex = 5;
            this.pictureBox_avatarj2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Avatar del jugador:";
            // 
            // comboBox_piedrasj2
            // 
            this.comboBox_piedrasj2.FormattingEnabled = true;
            this.comboBox_piedrasj2.Items.AddRange(new object[] {
            "Piedras blancas",
            "Piedras negras"});
            this.comboBox_piedrasj2.Location = new System.Drawing.Point(20, 168);
            this.comboBox_piedrasj2.Name = "comboBox_piedrasj2";
            this.comboBox_piedrasj2.Size = new System.Drawing.Size(244, 29);
            this.comboBox_piedrasj2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Color de fichas del jugador:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre del jugador:";
            // 
            // textBox_nombrej2
            // 
            this.textBox_nombrej2.Location = new System.Drawing.Point(20, 78);
            this.textBox_nombrej2.Name = "textBox_nombrej2";
            this.textBox_nombrej2.Size = new System.Drawing.Size(244, 28);
            this.textBox_nombrej2.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 621);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_guardar);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de datos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatarj1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatarj2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_avatarj1;
        private System.Windows.Forms.PictureBox pictureBox_avatarj1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_piedrasj1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_nombrej1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_avatarj2;
        private System.Windows.Forms.PictureBox pictureBox_avatarj2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_piedrasj2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_nombrej2;
    }
}