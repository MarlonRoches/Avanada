namespace WinListaSimplePA18
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btncrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtmaximo = new System.Windows.Forms.TextBox();
            this.btnpush = new System.Windows.Forms.Button();
            this.btnpop = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.txtmaximo2 = new System.Windows.Forms.TextBox();
            this.btncrear2 = new System.Windows.Forms.Button();
            this.btnterminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(196, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 41);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(196, 58);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 2;
            // 
            // btncrear
            // 
            this.btncrear.Location = new System.Drawing.Point(408, 147);
            this.btncrear.Margin = new System.Windows.Forms.Padding(4);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(100, 28);
            this.btncrear.TabIndex = 3;
            this.btncrear.Text = "crear";
            this.btncrear.UseVisualStyleBackColor = true;
            this.btncrear.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Numero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maximo";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(196, 174);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(132, 22);
            this.txtnumero.TabIndex = 7;
            // 
            // txtmaximo
            // 
            this.txtmaximo.Location = new System.Drawing.Point(196, 142);
            this.txtmaximo.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaximo.Name = "txtmaximo";
            this.txtmaximo.Size = new System.Drawing.Size(132, 22);
            this.txtmaximo.TabIndex = 6;
            // 
            // btnpush
            // 
            this.btnpush.Location = new System.Drawing.Point(408, 183);
            this.btnpush.Margin = new System.Windows.Forms.Padding(4);
            this.btnpush.Name = "btnpush";
            this.btnpush.Size = new System.Drawing.Size(100, 28);
            this.btnpush.TabIndex = 10;
            this.btnpush.Text = "push";
            this.btnpush.UseVisualStyleBackColor = true;
            this.btnpush.Click += new System.EventHandler(this.btnpush_Click);
            // 
            // btnpop
            // 
            this.btnpop.Location = new System.Drawing.Point(408, 219);
            this.btnpop.Margin = new System.Windows.Forms.Padding(4);
            this.btnpop.Name = "btnpop";
            this.btnpop.Size = new System.Drawing.Size(100, 28);
            this.btnpop.TabIndex = 11;
            this.btnpop.Text = "pop";
            this.btnpop.UseVisualStyleBackColor = true;
            this.btnpop.Click += new System.EventHandler(this.btnpop_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(408, 338);
            this.btneliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(100, 28);
            this.btneliminar.TabIndex = 18;
            this.btneliminar.Text = "eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(408, 302);
            this.agregar.Margin = new System.Windows.Forms.Padding(4);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(100, 28);
            this.agregar.TabIndex = 17;
            this.agregar.Text = "agregar";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Numero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Maximo";
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(196, 293);
            this.txtnumero2.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(132, 22);
            this.txtnumero2.TabIndex = 14;
            // 
            // txtmaximo2
            // 
            this.txtmaximo2.Location = new System.Drawing.Point(196, 261);
            this.txtmaximo2.Margin = new System.Windows.Forms.Padding(4);
            this.txtmaximo2.Name = "txtmaximo2";
            this.txtmaximo2.Size = new System.Drawing.Size(132, 22);
            this.txtmaximo2.TabIndex = 13;
            // 
            // btncrear2
            // 
            this.btncrear2.Location = new System.Drawing.Point(408, 266);
            this.btncrear2.Margin = new System.Windows.Forms.Padding(4);
            this.btncrear2.Name = "btncrear2";
            this.btncrear2.Size = new System.Drawing.Size(100, 28);
            this.btncrear2.TabIndex = 12;
            this.btncrear2.Text = "crear";
            this.btncrear2.UseVisualStyleBackColor = true;
            this.btncrear2.Click += new System.EventHandler(this.btncrear2_Click);
            // 
            // btnterminar
            // 
            this.btnterminar.Location = new System.Drawing.Point(539, 338);
            this.btnterminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnterminar.Name = "btnterminar";
            this.btnterminar.Size = new System.Drawing.Size(100, 28);
            this.btnterminar.TabIndex = 19;
            this.btnterminar.Text = "terminar";
            this.btnterminar.UseVisualStyleBackColor = true;
            this.btnterminar.Click += new System.EventHandler(this.btnterminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 391);
            this.Controls.Add(this.btnterminar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtmaximo2);
            this.Controls.Add(this.btncrear2);
            this.Controls.Add(this.btnpop);
            this.Controls.Add(this.btnpush);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.txtmaximo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncrear);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btncrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtmaximo;
        private System.Windows.Forms.Button btnpush;
        private System.Windows.Forms.Button btnpop;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.TextBox txtmaximo2;
        private System.Windows.Forms.Button btncrear2;
        private System.Windows.Forms.Button btnterminar;
    }
}

