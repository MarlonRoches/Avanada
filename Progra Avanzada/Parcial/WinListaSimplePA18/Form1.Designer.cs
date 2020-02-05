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
            this.btneliminar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.btncrear2 = new System.Windows.Forms.Button();
            this.btnterminar = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(121, 126);
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
            this.agregar.Location = new System.Drawing.Point(13, 126);
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
            this.label5.Location = new System.Drawing.Point(10, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Agregar En el lugar";
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(63, 96);
            this.txtnumero2.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(109, 22);
            this.txtnumero2.TabIndex = 14;
            // 
            // btncrear2
            // 
            this.btncrear2.Location = new System.Drawing.Point(13, 13);
            this.btncrear2.Margin = new System.Windows.Forms.Padding(4);
            this.btncrear2.Name = "btncrear2";
            this.btncrear2.Size = new System.Drawing.Size(316, 50);
            this.btncrear2.TabIndex = 12;
            this.btncrear2.Text = "Generar Cola";
            this.btncrear2.UseVisualStyleBackColor = true;
            this.btncrear2.Click += new System.EventHandler(this.btncrear2_Click);
            // 
            // btnterminar
            // 
            this.btnterminar.Location = new System.Drawing.Point(229, 126);
            this.btnterminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnterminar.Name = "btnterminar";
            this.btnterminar.Size = new System.Drawing.Size(100, 28);
            this.btnterminar.TabIndex = 19;
            this.btnterminar.Text = "terminar";
            this.btnterminar.UseVisualStyleBackColor = true;
            this.btnterminar.Click += new System.EventHandler(this.btnterminar_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(91, 161);
            this.data.Name = "data";
            this.data.RowTemplate.Height = 24;
            this.data.Size = new System.Drawing.Size(163, 218);
            this.data.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 64);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 22);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "El No.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 391);
            this.Controls.Add(this.data);
            this.Controls.Add(this.btnterminar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.btncrear2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Button btncrear2;
        private System.Windows.Forms.Button btnterminar;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

