namespace Presentacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label10 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_Id = new TextBox();
            txt_Contacto = new TextBox();
            txt_Correo = new TextBox();
            txt_Direccion = new TextBox();
            txt_s_apellido = new TextBox();
            txt_p_apellido = new TextBox();
            txt_s_nombre = new TextBox();
            txt_p_nombre = new TextBox();
            textBox9 = new TextBox();
            txt_Edad = new TextBox();
            pictureBox1 = new PictureBox();
            cmb_Nestudio = new ComboBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label10);
            panel1.ForeColor = SystemColors.ControlDark;
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1103, 55);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Sitka Small", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(451, 9);
            label10.Name = "label10";
            label10.Size = new Size(233, 31);
            label10.TabIndex = 0;
            label10.Text = "Modulo - Candidatos";
            label10.Click += label10_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(66, 95);
            label1.Name = "label1";
            label1.Size = new Size(164, 35);
            label1.TabIndex = 1;
            label1.Text = "Identificacion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 310);
            label2.Name = "label2";
            label2.Size = new Size(183, 28);
            label2.TabIndex = 2;
            label2.Text = "Segundo apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(47, 251);
            label3.Name = "label3";
            label3.Size = new Size(169, 28);
            label3.TabIndex = 3;
            label3.Text = "Primer apellido:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 202);
            label4.Name = "label4";
            label4.Size = new Size(178, 28);
            label4.TabIndex = 4;
            label4.Text = "Segundo nombre:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(52, 150);
            label5.Name = "label5";
            label5.Size = new Size(164, 28);
            label5.TabIndex = 5;
            label5.Text = "Primer nombre:";
            label5.Click += label5_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(47, 583);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(133, 468);
            label9.Name = "label9";
            label9.Size = new Size(83, 28);
            label9.TabIndex = 9;
            label9.Text = "Correo:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(149, 516);
            label11.Name = "label11";
            label11.Size = new Size(67, 28);
            label11.TabIndex = 11;
            label11.Text = "Edad:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(117, 417);
            label12.Name = "label12";
            label12.Size = new Size(110, 28);
            label12.TabIndex = 12;
            label12.Text = "Direccion:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(113, 365);
            label13.Name = "label13";
            label13.Size = new Size(103, 28);
            label13.TabIndex = 13;
            label13.Text = "Contacto:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(39, 586);
            label6.Name = "label6";
            label6.Size = new Size(177, 28);
            label6.TabIndex = 14;
            label6.Text = "Nivel de estudio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(80, 645);
            label7.Name = "label7";
            label7.Size = new Size(125, 28);
            label7.TabIndex = 15;
            label7.Text = "Acudientes:";
            // 
            // txt_Id
            // 
            txt_Id.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Id.Location = new Point(227, 95);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(305, 31);
            txt_Id.TabIndex = 16;
            // 
            // txt_Contacto
            // 
            txt_Contacto.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Contacto.Location = new Point(227, 365);
            txt_Contacto.Name = "txt_Contacto";
            txt_Contacto.Size = new Size(305, 31);
            txt_Contacto.TabIndex = 17;
            // 
            // txt_Correo
            // 
            txt_Correo.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Correo.Location = new Point(227, 468);
            txt_Correo.Name = "txt_Correo";
            txt_Correo.Size = new Size(305, 31);
            txt_Correo.TabIndex = 18;
            // 
            // txt_Direccion
            // 
            txt_Direccion.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Direccion.Location = new Point(227, 417);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(305, 31);
            txt_Direccion.TabIndex = 19;
            // 
            // txt_s_apellido
            // 
            txt_s_apellido.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_s_apellido.Location = new Point(227, 310);
            txt_s_apellido.Name = "txt_s_apellido";
            txt_s_apellido.Size = new Size(305, 31);
            txt_s_apellido.TabIndex = 20;
            // 
            // txt_p_apellido
            // 
            txt_p_apellido.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_p_apellido.Location = new Point(227, 251);
            txt_p_apellido.Name = "txt_p_apellido";
            txt_p_apellido.Size = new Size(305, 31);
            txt_p_apellido.TabIndex = 21;
            // 
            // txt_s_nombre
            // 
            txt_s_nombre.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_s_nombre.Location = new Point(227, 202);
            txt_s_nombre.Name = "txt_s_nombre";
            txt_s_nombre.Size = new Size(305, 31);
            txt_s_nombre.TabIndex = 22;
            // 
            // txt_p_nombre
            // 
            txt_p_nombre.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_p_nombre.Location = new Point(227, 147);
            txt_p_nombre.Name = "txt_p_nombre";
            txt_p_nombre.Size = new Size(305, 31);
            txt_p_nombre.TabIndex = 23;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(227, 642);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(305, 31);
            textBox9.TabIndex = 24;
            // 
            // txt_Edad
            // 
            txt_Edad.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Edad.Location = new Point(227, 525);
            txt_Edad.Name = "txt_Edad";
            txt_Edad.Size = new Size(305, 31);
            txt_Edad.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_usuario_masculino_en_círculo_100;
            pictureBox1.Location = new Point(810, 135);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 108);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // cmb_Nestudio
            // 
            cmb_Nestudio.Font = new Font("Sitka Small", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmb_Nestudio.FormattingEnabled = true;
            cmb_Nestudio.Location = new Point(227, 583);
            cmb_Nestudio.Name = "cmb_Nestudio";
            cmb_Nestudio.Size = new Size(305, 36);
            cmb_Nestudio.TabIndex = 28;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_ver_archivo_50;
            pictureBox2.Location = new Point(888, 482);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 50);
            pictureBox2.TabIndex = 29;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_actualizaciones_disponibles_50;
            pictureBox3.Location = new Point(771, 482);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 50);
            pictureBox3.TabIndex = 30;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(888, 394);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 51);
            pictureBox4.TabIndex = 31;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_añadir_usuario_masculino_50;
            pictureBox5.Location = new Point(771, 394);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(58, 50);
            pictureBox5.TabIndex = 32;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(12, 695);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(58, 50);
            pictureBox6.TabIndex = 33;
            pictureBox6.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1099, 757);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(cmb_Nestudio);
            Controls.Add(pictureBox1);
            Controls.Add(txt_Edad);
            Controls.Add(textBox9);
            Controls.Add(txt_p_nombre);
            Controls.Add(txt_s_nombre);
            Controls.Add(txt_p_apellido);
            Controls.Add(txt_s_apellido);
            Controls.Add(txt_Direccion);
            Controls.Add(txt_Correo);
            Controls.Add(txt_Contacto);
            Controls.Add(txt_Id);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label10;
        private Label label6;
        private Label label7;
        private TextBox txt_Id;
        private TextBox txt_Contacto;
        private TextBox txt_Correo;
        private TextBox txt_Direccion;
        private TextBox txt_s_apellido;
        private TextBox txt_p_apellido;
        private TextBox txt_s_nombre;
        private TextBox txt_p_nombre;
        private TextBox textBox9;
        private TextBox txt_Edad;
        private PictureBox pictureBox1;
        private ComboBox cmb_Nestudio;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}