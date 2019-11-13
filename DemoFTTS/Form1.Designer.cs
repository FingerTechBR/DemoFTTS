namespace DemoFTTS
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txtbox_digital = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
<<<<<<< HEAD
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_text_ip = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_status_text = new System.Windows.Forms.Label();
            this.lb_status = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picbox_img_digital = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_text_solicitante = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_img_digital)).BeginInit();
            this.groupBox2.SuspendLayout();
=======
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.lb_status_text = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_text_ip = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
>>>>>>> ba662f0a7f944a02a2b1a0270a5fed59f2b97255
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Capturar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtbox_digital
            // 
            this.txtbox_digital.Location = new System.Drawing.Point(9, 19);
            this.txtbox_digital.Name = "txtbox_digital";
            this.txtbox_digital.Size = new System.Drawing.Size(197, 200);
            this.txtbox_digital.TabIndex = 1;
            this.txtbox_digital.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox1);
<<<<<<< HEAD
            this.panel2.Location = new System.Drawing.Point(7, 12);
=======
            this.panel2.Location = new System.Drawing.Point(12, 42);
>>>>>>> ba662f0a7f944a02a2b1a0270a5fed59f2b97255
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 367);
            this.panel2.TabIndex = 4;
            // 
<<<<<<< HEAD
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_text_solicitante);
            this.groupBox4.Controls.Add(this.label2);
=======
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Enroll";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 299);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digital";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(252, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 200);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbox_digital);
            this.groupBox2.Location = new System.Drawing.Point(6, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 228);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TextEncode";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(243, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 228);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagem";
            // 
            // groupBox4
            // 
>>>>>>> ba662f0a7f944a02a2b1a0270a5fed59f2b97255
            this.groupBox4.Controls.Add(this.lb_text_ip);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.lb_status_text);
            this.groupBox4.Controls.Add(this.lb_status);
            this.groupBox4.Location = new System.Drawing.Point(513, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(244, 299);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status";
            // 
<<<<<<< HEAD
            // lb_text_ip
            // 
            this.lb_text_ip.AutoSize = true;
            this.lb_text_ip.Location = new System.Drawing.Point(52, 87);
            this.lb_text_ip.Name = "lb_text_ip";
            this.lb_text_ip.Size = new System.Drawing.Size(0, 13);
            this.lb_text_ip.TabIndex = 3;
=======
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(25, 65);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(52, 13);
            this.lb_status.TabIndex = 0;
            this.lb_status.Text = "Conexão:";
            // 
            // lb_status_text
            // 
            this.lb_status_text.AutoSize = true;
            this.lb_status_text.Location = new System.Drawing.Point(84, 65);
            this.lb_status_text.Name = "lb_status_text";
            this.lb_status_text.Size = new System.Drawing.Size(0, 13);
            this.lb_status_text.TabIndex = 1;
>>>>>>> ba662f0a7f944a02a2b1a0270a5fed59f2b97255
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP:";
            // 
<<<<<<< HEAD
            // lb_status_text
            // 
            this.lb_status_text.AutoSize = true;
            this.lb_status_text.Location = new System.Drawing.Point(84, 65);
            this.lb_status_text.Name = "lb_status_text";
            this.lb_status_text.Size = new System.Drawing.Size(0, 13);
            this.lb_status_text.TabIndex = 1;
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Location = new System.Drawing.Point(25, 65);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(52, 13);
            this.lb_status.TabIndex = 0;
            this.lb_status.Text = "Conexão:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picbox_img_digital);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(15, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 299);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digital";
            // 
            // picbox_img_digital
            // 
            this.picbox_img_digital.BackColor = System.Drawing.Color.White;
            this.picbox_img_digital.Location = new System.Drawing.Point(252, 84);
            this.picbox_img_digital.Name = "picbox_img_digital";
            this.picbox_img_digital.Size = new System.Drawing.Size(197, 200);
            this.picbox_img_digital.TabIndex = 3;
            this.picbox_img_digital.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Enroll";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbox_digital);
            this.groupBox2.Location = new System.Drawing.Point(6, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 228);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TextEncode";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(243, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 228);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Imagem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Solicitante:";
            // 
            // lb_text_solicitante
            // 
            this.lb_text_solicitante.AutoSize = true;
            this.lb_text_solicitante.Location = new System.Drawing.Point(87, 104);
            this.lb_text_solicitante.Name = "lb_text_solicitante";
            this.lb_text_solicitante.Size = new System.Drawing.Size(0, 13);
            this.lb_text_solicitante.TabIndex = 5;
=======
            // lb_text_ip
            // 
            this.lb_text_ip.AutoSize = true;
            this.lb_text_ip.Location = new System.Drawing.Point(52, 87);
            this.lb_text_ip.Name = "lb_text_ip";
            this.lb_text_ip.Size = new System.Drawing.Size(0, 13);
            this.lb_text_ip.TabIndex = 3;
>>>>>>> ba662f0a7f944a02a2b1a0270a5fed59f2b97255
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(816, 429);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_img_digital)).EndInit();
            this.groupBox2.ResumeLayout(false);
=======
            this.ClientSize = new System.Drawing.Size(800, 412);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
>>>>>>> ba662f0a7f944a02a2b1a0270a5fed59f2b97255
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txtbox_digital;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_status_text;
        private System.Windows.Forms.Label lb_status;
<<<<<<< HEAD
        private System.Windows.Forms.PictureBox picbox_img_digital;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_text_ip;
        private System.Windows.Forms.Label lb_text_solicitante;
        private System.Windows.Forms.Label label2;
=======
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_text_ip;
>>>>>>> ba662f0a7f944a02a2b1a0270a5fed59f2b97255
    }
}

