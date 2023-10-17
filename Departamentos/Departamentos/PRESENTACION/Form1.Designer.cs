namespace PRESENTACION
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdDepar = new System.Windows.Forms.TextBox();
            this.txtNombreDepar = new System.Windows.Forms.TextBox();
            this.txtIdMuni = new System.Windows.Forms.TextBox();
            this.txtNombreMuni = new System.Windows.Forms.TextBox();
            this.cmbDepar = new System.Windows.Forms.ComboBox();
            this.btnCrearDepar = new System.Windows.Forms.Button();
            this.btnCrearMuni = new System.Windows.Forms.Button();
            this.tblDepar = new System.Windows.Forms.DataGridView();
            this.tblMuni = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMuni)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tblDepar);
            this.groupBox1.Controls.Add(this.btnCrearDepar);
            this.groupBox1.Controls.Add(this.txtNombreDepar);
            this.groupBox1.Controls.Add(this.txtIdDepar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(39, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 382);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Departamentos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tblMuni);
            this.groupBox2.Controls.Add(this.btnCrearMuni);
            this.groupBox2.Controls.Add(this.cmbDepar);
            this.groupBox2.Controls.Add(this.txtNombreMuni);
            this.groupBox2.Controls.Add(this.txtIdMuni);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(409, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 373);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Municipios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(10, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(19, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(19, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Departamento";
            // 
            // txtIdDepar
            // 
            this.txtIdDepar.Location = new System.Drawing.Point(87, 34);
            this.txtIdDepar.Name = "txtIdDepar";
            this.txtIdDepar.Size = new System.Drawing.Size(133, 20);
            this.txtIdDepar.TabIndex = 2;
            // 
            // txtNombreDepar
            // 
            this.txtNombreDepar.Location = new System.Drawing.Point(87, 69);
            this.txtNombreDepar.Name = "txtNombreDepar";
            this.txtNombreDepar.Size = new System.Drawing.Size(133, 20);
            this.txtNombreDepar.TabIndex = 3;
            // 
            // txtIdMuni
            // 
            this.txtIdMuni.Location = new System.Drawing.Point(119, 32);
            this.txtIdMuni.Name = "txtIdMuni";
            this.txtIdMuni.Size = new System.Drawing.Size(122, 20);
            this.txtIdMuni.TabIndex = 4;
            // 
            // txtNombreMuni
            // 
            this.txtNombreMuni.Location = new System.Drawing.Point(119, 60);
            this.txtNombreMuni.Name = "txtNombreMuni";
            this.txtNombreMuni.Size = new System.Drawing.Size(122, 20);
            this.txtNombreMuni.TabIndex = 5;
            // 
            // cmbDepar
            // 
            this.cmbDepar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbDepar.FormattingEnabled = true;
            this.cmbDepar.Items.AddRange(new object[] {
            "colombia"});
            this.cmbDepar.Location = new System.Drawing.Point(119, 87);
            this.cmbDepar.Name = "cmbDepar";
            this.cmbDepar.Size = new System.Drawing.Size(121, 24);
            this.cmbDepar.TabIndex = 6;
            this.cmbDepar.Text = " Seleccionar";
            // 
            // btnCrearDepar
            // 
            this.btnCrearDepar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCrearDepar.Location = new System.Drawing.Point(87, 158);
            this.btnCrearDepar.Name = "btnCrearDepar";
            this.btnCrearDepar.Size = new System.Drawing.Size(75, 23);
            this.btnCrearDepar.TabIndex = 4;
            this.btnCrearDepar.Text = "Crear";
            this.btnCrearDepar.UseVisualStyleBackColor = true;
            this.btnCrearDepar.Click += new System.EventHandler(this.btnCrearDepar_Click);
            // 
            // btnCrearMuni
            // 
            this.btnCrearMuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCrearMuni.Location = new System.Drawing.Point(89, 149);
            this.btnCrearMuni.Name = "btnCrearMuni";
            this.btnCrearMuni.Size = new System.Drawing.Size(75, 23);
            this.btnCrearMuni.TabIndex = 7;
            this.btnCrearMuni.Text = "Crear";
            this.btnCrearMuni.UseVisualStyleBackColor = true;
            this.btnCrearMuni.Click += new System.EventHandler(this.btnCrearMuni_Click);
            // 
            // tblDepar
            // 
            this.tblDepar.AllowUserToAddRows = false;
            this.tblDepar.AllowUserToDeleteRows = false;
            this.tblDepar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDepar.Location = new System.Drawing.Point(30, 200);
            this.tblDepar.Name = "tblDepar";
            this.tblDepar.ReadOnly = true;
            this.tblDepar.Size = new System.Drawing.Size(280, 159);
            this.tblDepar.TabIndex = 5;
            // 
            // tblMuni
            // 
            this.tblMuni.AllowUserToAddRows = false;
            this.tblMuni.AllowUserToDeleteRows = false;
            this.tblMuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMuni.Location = new System.Drawing.Point(22, 191);
            this.tblMuni.Name = "tblMuni";
            this.tblMuni.ReadOnly = true;
            this.tblMuni.Size = new System.Drawing.Size(312, 159);
            this.tblMuni.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMuni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreDepar;
        private System.Windows.Forms.TextBox txtIdDepar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtIdMuni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDepar;
        private System.Windows.Forms.TextBox txtNombreMuni;
        private System.Windows.Forms.Button btnCrearDepar;
        private System.Windows.Forms.Button btnCrearMuni;
        private System.Windows.Forms.DataGridView tblDepar;
        private System.Windows.Forms.DataGridView tblMuni;
    }
}

