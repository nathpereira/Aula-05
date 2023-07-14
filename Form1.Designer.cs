
namespace Aula05_MaqdeComida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCoca = new System.Windows.Forms.Button();
            this.btnFantaUva = new System.Windows.Forms.Button();
            this.btnFantaLaranja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCoca = new System.Windows.Forms.Label();
            this.lblFantaLaranja = new System.Windows.Forms.Label();
            this.lblFantaUva = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCoca
            // 
            this.btnCoca.Location = new System.Drawing.Point(345, 36);
            this.btnCoca.Name = "btnCoca";
            this.btnCoca.Size = new System.Drawing.Size(112, 34);
            this.btnCoca.TabIndex = 0;
            this.btnCoca.Text = "Comprar";
            this.btnCoca.UseVisualStyleBackColor = true;
            this.btnCoca.Click += new System.EventHandler(this.bntCoca_Click);
            // 
            // btnFantaUva
            // 
            this.btnFantaUva.Location = new System.Drawing.Point(345, 320);
            this.btnFantaUva.Name = "btnFantaUva";
            this.btnFantaUva.Size = new System.Drawing.Size(112, 35);
            this.btnFantaUva.TabIndex = 1;
            this.btnFantaUva.Text = "Comprar";
            this.btnFantaUva.UseVisualStyleBackColor = true;
            this.btnFantaUva.Click += new System.EventHandler(this.btnFantaUva_Click);
            // 
            // btnFantaLaranja
            // 
            this.btnFantaLaranja.Location = new System.Drawing.Point(345, 169);
            this.btnFantaLaranja.Name = "btnFantaLaranja";
            this.btnFantaLaranja.Size = new System.Drawing.Size(112, 37);
            this.btnFantaLaranja.TabIndex = 2;
            this.btnFantaLaranja.Text = "Comprar";
            this.btnFantaLaranja.UseVisualStyleBackColor = true;
            this.btnFantaLaranja.Click += new System.EventHandler(this.btnFantaLaranja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coca-Cola 350ml";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fanta Laranja 600ml";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fanta Uva 350ml";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 273);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFantaUva);
            this.panel1.Controls.Add(this.lblFantaLaranja);
            this.panel1.Controls.Add(this.lblCoca);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnCoca);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFantaUva);
            this.panel1.Controls.Add(this.btnFantaLaranja);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 395);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Swis721 BlkEx BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(464, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Máquina de Refrigerantes ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fanta Uva 350ml";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblCoca
            // 
            this.lblCoca.AutoSize = true;
            this.lblCoca.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoca.Location = new System.Drawing.Point(164, 41);
            this.lblCoca.Name = "lblCoca";
            this.lblCoca.Size = new System.Drawing.Size(101, 19);
            this.lblCoca.TabIndex = 10;
            this.lblCoca.Text = "R$ 5,00";
            // 
            // lblFantaLaranja
            // 
            this.lblFantaLaranja.AutoSize = true;
            this.lblFantaLaranja.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFantaLaranja.Location = new System.Drawing.Point(164, 177);
            this.lblFantaLaranja.Name = "lblFantaLaranja";
            this.lblFantaLaranja.Size = new System.Drawing.Size(101, 19);
            this.lblFantaLaranja.TabIndex = 11;
            this.lblFantaLaranja.Text = "R$ 7,00";
            // 
            // lblFantaUva
            // 
            this.lblFantaUva.AutoSize = true;
            this.lblFantaUva.Font = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFantaUva.Location = new System.Drawing.Point(164, 320);
            this.lblFantaUva.Name = "lblFantaUva";
            this.lblFantaUva.Size = new System.Drawing.Size(101, 19);
            this.lblFantaUva.TabIndex = 12;
            this.lblFantaUva.Text = "R$ 5,50";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(559, 93);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(183, 20);
            this.txtValor.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(543, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Digite o valor do produto desejado :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCoca;
        private System.Windows.Forms.Button btnFantaUva;
        private System.Windows.Forms.Button btnFantaLaranja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFantaUva;
        private System.Windows.Forms.Label lblFantaLaranja;
        private System.Windows.Forms.Label lblCoca;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label6;
    }
}

