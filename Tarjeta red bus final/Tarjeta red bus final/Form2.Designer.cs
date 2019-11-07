namespace Tarjeta_red_bus_final
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
            this.Nombre = new System.Windows.Forms.Label();
            this.TxBNom = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.Label();
            this.TxBApell = new System.Windows.Forms.TextBox();
            this.TxBSex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxBFech = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxBDNI = new System.Windows.Forms.TextBox();
            this.TxBCu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(13, 32);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre:";
            // 
            // TxBNom
            // 
            this.TxBNom.Location = new System.Drawing.Point(67, 32);
            this.TxBNom.Name = "TxBNom";
            this.TxBNom.Size = new System.Drawing.Size(100, 20);
            this.TxBNom.TabIndex = 1;
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(13, 69);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(47, 13);
            this.Apellido.TabIndex = 2;
            this.Apellido.Text = "Apellido:";
            // 
            // TxBApell
            // 
            this.TxBApell.Location = new System.Drawing.Point(67, 66);
            this.TxBApell.Name = "TxBApell";
            this.TxBApell.Size = new System.Drawing.Size(100, 20);
            this.TxBApell.TabIndex = 3;
            // 
            // TxBSex
            // 
            this.TxBSex.Location = new System.Drawing.Point(67, 108);
            this.TxBSex.Name = "TxBSex";
            this.TxBSex.Size = new System.Drawing.Size(100, 20);
            this.TxBSex.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sexo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha de Nacimiento:";
            // 
            // TxBFech
            // 
            this.TxBFech.Location = new System.Drawing.Point(131, 151);
            this.TxBFech.Name = "TxBFech";
            this.TxBFech.Size = new System.Drawing.Size(100, 20);
            this.TxBFech.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cuild:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TxBDNI
            // 
            this.TxBDNI.Location = new System.Drawing.Point(67, 196);
            this.TxBDNI.Name = "TxBDNI";
            this.TxBDNI.Size = new System.Drawing.Size(100, 20);
            this.TxBDNI.TabIndex = 10;
            // 
            // TxBCu
            // 
            this.TxBCu.Location = new System.Drawing.Point(67, 237);
            this.TxBCu.Name = "TxBCu";
            this.TxBCu.Size = new System.Drawing.Size(100, 20);
            this.TxBCu.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cargar Tarjeta Red-bus";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(266, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(693, 252);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 369);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxBCu);
            this.Controls.Add(this.TxBDNI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxBFech);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxBSex);
            this.Controls.Add(this.TxBApell);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.TxBNom);
            this.Controls.Add(this.Nombre);
            this.Name = "Form2";
            this.Text = "Info.Personas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox TxBNom;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.TextBox TxBApell;
        private System.Windows.Forms.TextBox TxBSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxBFech;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxBDNI;
        private System.Windows.Forms.TextBox TxBCu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
    }
}