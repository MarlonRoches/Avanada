namespace Ejercicio_PreExamen
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelcontador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cajero1 = new System.Windows.Forms.Timer(this.components);
            this.cajero2 = new System.Windows.Forms.Timer(this.components);
            this.cajero3 = new System.Windows.Forms.Timer(this.components);
            this.cajero4 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tiempocajero1 = new System.Windows.Forms.Label();
            this.tiempocajero2 = new System.Windows.Forms.Label();
            this.tiempocajero3 = new System.Windows.Forms.Label();
            this.tiempocajero4 = new System.Windows.Forms.Label();
            this.total1 = new System.Windows.Forms.Label();
            this.total2 = new System.Windows.Forms.Label();
            this.total3 = new System.Windows.Forms.Label();
            this.total4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.prome4 = new System.Windows.Forms.Label();
            this.prome3 = new System.Windows.Forms.Label();
            this.prome2 = new System.Windows.Forms.Label();
            this.prome1 = new System.Windows.Forms.Label();
            this.segtotal4 = new System.Windows.Forms.Label();
            this.segtotal3 = new System.Windows.Forms.Label();
            this.segtotal2 = new System.Windows.Forms.Label();
            this.segtotal1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.validar = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Monto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clientes En Cola";
            // 
            // labelcontador
            // 
            this.labelcontador.AutoSize = true;
            this.labelcontador.Location = new System.Drawing.Point(399, 27);
            this.labelcontador.Name = "labelcontador";
            this.labelcontador.Size = new System.Drawing.Size(20, 17);
            this.labelcontador.TabIndex = 3;
            this.labelcontador.Text = "...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar Clientes ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cajero1
            // 
            this.cajero1.Interval = 1000;
            this.cajero1.Tick += new System.EventHandler(this.cajero1_Tick);
            // 
            // cajero2
            // 
            this.cajero2.Interval = 1000;
            this.cajero2.Tick += new System.EventHandler(this.cajero2_Tick);
            // 
            // cajero3
            // 
            this.cajero3.Interval = 1000;
            this.cajero3.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cajero4
            // 
            this.cajero4.Interval = 1000;
            this.cajero4.Tick += new System.EventHandler(this.cajero4_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tiempo Cajero 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tiempo Cajero 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tiempo Cajero 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tiempo Cajero 4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Atendidos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Atendidos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Atendidos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Atendidos";
            // 
            // tiempocajero1
            // 
            this.tiempocajero1.AutoSize = true;
            this.tiempocajero1.Location = new System.Drawing.Point(33, 177);
            this.tiempocajero1.Name = "tiempocajero1";
            this.tiempocajero1.Size = new System.Drawing.Size(20, 17);
            this.tiempocajero1.TabIndex = 5;
            this.tiempocajero1.Text = "...";
            // 
            // tiempocajero2
            // 
            this.tiempocajero2.AutoSize = true;
            this.tiempocajero2.Location = new System.Drawing.Point(182, 177);
            this.tiempocajero2.Name = "tiempocajero2";
            this.tiempocajero2.Size = new System.Drawing.Size(20, 17);
            this.tiempocajero2.TabIndex = 6;
            this.tiempocajero2.Text = "...";
            // 
            // tiempocajero3
            // 
            this.tiempocajero3.AutoSize = true;
            this.tiempocajero3.Location = new System.Drawing.Point(329, 177);
            this.tiempocajero3.Name = "tiempocajero3";
            this.tiempocajero3.Size = new System.Drawing.Size(20, 17);
            this.tiempocajero3.TabIndex = 7;
            this.tiempocajero3.Text = "...";
            // 
            // tiempocajero4
            // 
            this.tiempocajero4.AutoSize = true;
            this.tiempocajero4.Location = new System.Drawing.Point(459, 177);
            this.tiempocajero4.Name = "tiempocajero4";
            this.tiempocajero4.Size = new System.Drawing.Size(20, 17);
            this.tiempocajero4.TabIndex = 8;
            this.tiempocajero4.Text = "...";
            // 
            // total1
            // 
            this.total1.AutoSize = true;
            this.total1.Location = new System.Drawing.Point(33, 226);
            this.total1.Name = "total1";
            this.total1.Size = new System.Drawing.Size(20, 17);
            this.total1.TabIndex = 5;
            this.total1.Text = "...";
            // 
            // total2
            // 
            this.total2.AutoSize = true;
            this.total2.Location = new System.Drawing.Point(182, 226);
            this.total2.Name = "total2";
            this.total2.Size = new System.Drawing.Size(20, 17);
            this.total2.TabIndex = 5;
            this.total2.Text = "...";
            // 
            // total3
            // 
            this.total3.AutoSize = true;
            this.total3.Location = new System.Drawing.Point(329, 226);
            this.total3.Name = "total3";
            this.total3.Size = new System.Drawing.Size(20, 17);
            this.total3.TabIndex = 5;
            this.total3.Text = "...";
            // 
            // total4
            // 
            this.total4.AutoSize = true;
            this.total4.Location = new System.Drawing.Point(459, 226);
            this.total4.Name = "total4";
            this.total4.Size = new System.Drawing.Size(20, 17);
            this.total4.TabIndex = 5;
            this.total4.Text = "...";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(274, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Ejecutar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // prome4
            // 
            this.prome4.AutoSize = true;
            this.prome4.Location = new System.Drawing.Point(458, 346);
            this.prome4.Name = "prome4";
            this.prome4.Size = new System.Drawing.Size(20, 17);
            this.prome4.TabIndex = 17;
            this.prome4.Text = "...";
            // 
            // prome3
            // 
            this.prome3.AutoSize = true;
            this.prome3.Location = new System.Drawing.Point(328, 346);
            this.prome3.Name = "prome3";
            this.prome3.Size = new System.Drawing.Size(20, 17);
            this.prome3.TabIndex = 16;
            this.prome3.Text = "...";
            // 
            // prome2
            // 
            this.prome2.AutoSize = true;
            this.prome2.Location = new System.Drawing.Point(181, 346);
            this.prome2.Name = "prome2";
            this.prome2.Size = new System.Drawing.Size(20, 17);
            this.prome2.TabIndex = 15;
            this.prome2.Text = "...";
            // 
            // prome1
            // 
            this.prome1.AutoSize = true;
            this.prome1.Location = new System.Drawing.Point(32, 346);
            this.prome1.Name = "prome1";
            this.prome1.Size = new System.Drawing.Size(20, 17);
            this.prome1.TabIndex = 14;
            this.prome1.Text = "...";
            // 
            // segtotal4
            // 
            this.segtotal4.AutoSize = true;
            this.segtotal4.Location = new System.Drawing.Point(459, 290);
            this.segtotal4.Name = "segtotal4";
            this.segtotal4.Size = new System.Drawing.Size(20, 17);
            this.segtotal4.TabIndex = 21;
            this.segtotal4.Text = "...";
            // 
            // segtotal3
            // 
            this.segtotal3.AutoSize = true;
            this.segtotal3.Location = new System.Drawing.Point(329, 290);
            this.segtotal3.Name = "segtotal3";
            this.segtotal3.Size = new System.Drawing.Size(20, 17);
            this.segtotal3.TabIndex = 22;
            this.segtotal3.Text = "...";
            // 
            // segtotal2
            // 
            this.segtotal2.AutoSize = true;
            this.segtotal2.Location = new System.Drawing.Point(182, 290);
            this.segtotal2.Name = "segtotal2";
            this.segtotal2.Size = new System.Drawing.Size(20, 17);
            this.segtotal2.TabIndex = 23;
            this.segtotal2.Text = "...";
            // 
            // segtotal1
            // 
            this.segtotal1.AutoSize = true;
            this.segtotal1.Location = new System.Drawing.Point(36, 290);
            this.segtotal1.Name = "segtotal1";
            this.segtotal1.Size = new System.Drawing.Size(20, 17);
            this.segtotal1.TabIndex = 24;
            this.segtotal1.Text = "...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(226, 257);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 17);
            this.label15.TabIndex = 20;
            this.label15.Text = "Segundos Totales";
            // 
            // validar
            // 
            this.validar.Tick += new System.EventHandler(this.validar_Tick);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(25, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Promedios";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 323);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(220, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "(presionar si falta algun promedio";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(122, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(356, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "[Si no funciona a la primera, porfa intentelo otra vez :) ]";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 392);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.segtotal4);
            this.Controls.Add(this.segtotal3);
            this.Controls.Add(this.segtotal2);
            this.Controls.Add(this.segtotal1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.prome4);
            this.Controls.Add(this.prome3);
            this.Controls.Add(this.prome2);
            this.Controls.Add(this.prome1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tiempocajero4);
            this.Controls.Add(this.tiempocajero3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tiempocajero2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.total4);
            this.Controls.Add(this.total3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.total2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.total1);
            this.Controls.Add(this.tiempocajero1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelcontador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer cajero1;
        public System.Windows.Forms.Timer cajero2;
        public System.Windows.Forms.Timer cajero3;
        public System.Windows.Forms.Timer cajero4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label tiempocajero1;
        public System.Windows.Forms.Label tiempocajero2;
        public System.Windows.Forms.Label tiempocajero3;
        public System.Windows.Forms.Label tiempocajero4;
        public System.Windows.Forms.Label total1;
        public System.Windows.Forms.Label total2;
        public System.Windows.Forms.Label total3;
        public System.Windows.Forms.Label total4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label labelcontador;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label prome4;
        public System.Windows.Forms.Label prome3;
        public System.Windows.Forms.Label prome2;
        public System.Windows.Forms.Label prome1;
        private System.Windows.Forms.Label segtotal4;
        private System.Windows.Forms.Label segtotal3;
        private System.Windows.Forms.Label segtotal2;
        private System.Windows.Forms.Label segtotal1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer validar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

