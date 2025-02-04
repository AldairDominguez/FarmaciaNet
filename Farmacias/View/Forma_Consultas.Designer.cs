namespace Farmacias
{
    partial class Forma_Consultas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forma_Consultas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Empleado = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupCEmp = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxEmp = new System.Windows.Forms.TextBox();
            this.cbxEmp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridEmp = new System.Windows.Forms.DataGridView();
            this.groupCInv = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tbxinv = new System.Windows.Forms.TextBox();
            this.cbxinv = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridinv = new System.Windows.Forms.DataGridView();
            this.groupCProd = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbxbusqpd = new System.Windows.Forms.TextBox();
            this.cbxbpd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridpd = new System.Windows.Forms.DataGridView();
            this.groupCProv = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tbxbpv = new System.Windows.Forms.TextBox();
            this.cbxbpv = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridpv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupCEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).BeginInit();
            this.groupCInv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridinv)).BeginInit();
            this.groupCProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpd)).BeginInit();
            this.groupCProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Empleado);
            this.panel1.Controls.Add(this.fecha);
            this.panel1.Controls.Add(this.Hora);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1208, 114);
            this.panel1.TabIndex = 100;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(26, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 73);
            this.pictureBox1.TabIndex = 106;
            this.pictureBox1.TabStop = false;
            // 
            // Empleado
            // 
            this.Empleado.AutoSize = true;
            this.Empleado.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empleado.Location = new System.Drawing.Point(853, 74);
            this.Empleado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Empleado.Name = "Empleado";
            this.Empleado.Size = new System.Drawing.Size(160, 22);
            this.Empleado.TabIndex = 6;
            this.Empleado.Text = "Panfila Malechota";
            // 
            // fecha
            // 
            this.fecha.AutoSize = true;
            this.fecha.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(853, 23);
            this.fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(59, 22);
            this.fecha.TabIndex = 5;
            this.fecha.Text = "label1";
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(853, 49);
            this.Hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(59, 22);
            this.Hora.TabIndex = 4;
            this.Hora.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupCEmp
            // 
            this.groupCEmp.BackColor = System.Drawing.Color.Bisque;
            this.groupCEmp.Controls.Add(this.button1);
            this.groupCEmp.Controls.Add(this.tbxEmp);
            this.groupCEmp.Controls.Add(this.cbxEmp);
            this.groupCEmp.Controls.Add(this.label1);
            this.groupCEmp.Controls.Add(this.dataGridEmp);
            this.groupCEmp.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCEmp.Location = new System.Drawing.Point(11, 139);
            this.groupCEmp.Margin = new System.Windows.Forms.Padding(4);
            this.groupCEmp.Name = "groupCEmp";
            this.groupCEmp.Padding = new System.Windows.Forms.Padding(4);
            this.groupCEmp.Size = new System.Drawing.Size(1187, 431);
            this.groupCEmp.TabIndex = 102;
            this.groupCEmp.TabStop = false;
            this.groupCEmp.Text = "Consulta de empleados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxEmp
            // 
            this.tbxEmp.Location = new System.Drawing.Point(164, 79);
            this.tbxEmp.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEmp.Name = "tbxEmp";
            this.tbxEmp.Size = new System.Drawing.Size(247, 32);
            this.tbxEmp.TabIndex = 2;
            // 
            // cbxEmp
            // 
            this.cbxEmp.FormattingEnabled = true;
            this.cbxEmp.Location = new System.Drawing.Point(320, 37);
            this.cbxEmp.Margin = new System.Windows.Forms.Padding(4);
            this.cbxEmp.Name = "cbxEmp";
            this.cbxEmp.Size = new System.Drawing.Size(160, 32);
            this.cbxEmp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccion el tipo de busqueda";
            // 
            // dataGridEmp
            // 
            this.dataGridEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridEmp.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmp.GridColor = System.Drawing.Color.DimGray;
            this.dataGridEmp.Location = new System.Drawing.Point(97, 129);
            this.dataGridEmp.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridEmp.Name = "dataGridEmp";
            this.dataGridEmp.RowHeadersWidth = 51;
            this.dataGridEmp.Size = new System.Drawing.Size(1036, 266);
            this.dataGridEmp.TabIndex = 5;
            // 
            // groupCInv
            // 
            this.groupCInv.BackColor = System.Drawing.Color.Bisque;
            this.groupCInv.Controls.Add(this.button2);
            this.groupCInv.Controls.Add(this.tbxinv);
            this.groupCInv.Controls.Add(this.cbxinv);
            this.groupCInv.Controls.Add(this.label2);
            this.groupCInv.Controls.Add(this.dataGridinv);
            this.groupCInv.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCInv.Location = new System.Drawing.Point(11, 139);
            this.groupCInv.Margin = new System.Windows.Forms.Padding(4);
            this.groupCInv.Name = "groupCInv";
            this.groupCInv.Padding = new System.Windows.Forms.Padding(4);
            this.groupCInv.Size = new System.Drawing.Size(1187, 431);
            this.groupCInv.TabIndex = 101;
            this.groupCInv.TabStop = false;
            this.groupCInv.Text = "Consulta de inventario";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 75);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxinv
            // 
            this.tbxinv.Location = new System.Drawing.Point(164, 79);
            this.tbxinv.Margin = new System.Windows.Forms.Padding(4);
            this.tbxinv.Name = "tbxinv";
            this.tbxinv.Size = new System.Drawing.Size(247, 32);
            this.tbxinv.TabIndex = 2;
            // 
            // cbxinv
            // 
            this.cbxinv.FormattingEnabled = true;
            this.cbxinv.Location = new System.Drawing.Point(320, 37);
            this.cbxinv.Margin = new System.Windows.Forms.Padding(4);
            this.cbxinv.Name = "cbxinv";
            this.cbxinv.Size = new System.Drawing.Size(160, 32);
            this.cbxinv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Seleccion el tipo de busqueda";
            // 
            // dataGridinv
            // 
            this.dataGridinv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridinv.BackgroundColor = System.Drawing.Color.White;
            this.dataGridinv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridinv.GridColor = System.Drawing.Color.DimGray;
            this.dataGridinv.Location = new System.Drawing.Point(97, 129);
            this.dataGridinv.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridinv.Name = "dataGridinv";
            this.dataGridinv.RowHeadersWidth = 51;
            this.dataGridinv.Size = new System.Drawing.Size(1036, 266);
            this.dataGridinv.TabIndex = 5;
            // 
            // groupCProd
            // 
            this.groupCProd.BackColor = System.Drawing.Color.Bisque;
            this.groupCProd.Controls.Add(this.button3);
            this.groupCProd.Controls.Add(this.tbxbusqpd);
            this.groupCProd.Controls.Add(this.cbxbpd);
            this.groupCProd.Controls.Add(this.label3);
            this.groupCProd.Controls.Add(this.dataGridpd);
            this.groupCProd.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCProd.Location = new System.Drawing.Point(11, 139);
            this.groupCProd.Margin = new System.Windows.Forms.Padding(4);
            this.groupCProd.Name = "groupCProd";
            this.groupCProd.Padding = new System.Windows.Forms.Padding(4);
            this.groupCProd.Size = new System.Drawing.Size(1187, 431);
            this.groupCProd.TabIndex = 101;
            this.groupCProd.TabStop = false;
            this.groupCProd.Text = "Consulta de productos";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 75);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 42);
            this.button3.TabIndex = 3;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbxbusqpd
            // 
            this.tbxbusqpd.Location = new System.Drawing.Point(164, 79);
            this.tbxbusqpd.Margin = new System.Windows.Forms.Padding(4);
            this.tbxbusqpd.Name = "tbxbusqpd";
            this.tbxbusqpd.Size = new System.Drawing.Size(247, 32);
            this.tbxbusqpd.TabIndex = 2;
            // 
            // cbxbpd
            // 
            this.cbxbpd.FormattingEnabled = true;
            this.cbxbpd.Location = new System.Drawing.Point(320, 37);
            this.cbxbpd.Margin = new System.Windows.Forms.Padding(4);
            this.cbxbpd.Name = "cbxbpd";
            this.cbxbpd.Size = new System.Drawing.Size(160, 32);
            this.cbxbpd.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Seleccion el tipo de busqueda";
            // 
            // dataGridpd
            // 
            this.dataGridpd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridpd.BackgroundColor = System.Drawing.Color.White;
            this.dataGridpd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridpd.GridColor = System.Drawing.Color.DimGray;
            this.dataGridpd.Location = new System.Drawing.Point(97, 129);
            this.dataGridpd.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridpd.Name = "dataGridpd";
            this.dataGridpd.RowHeadersWidth = 51;
            this.dataGridpd.Size = new System.Drawing.Size(1036, 266);
            this.dataGridpd.TabIndex = 5;
            // 
            // groupCProv
            // 
            this.groupCProv.BackColor = System.Drawing.Color.Bisque;
            this.groupCProv.Controls.Add(this.button4);
            this.groupCProv.Controls.Add(this.tbxbpv);
            this.groupCProv.Controls.Add(this.cbxbpv);
            this.groupCProv.Controls.Add(this.label4);
            this.groupCProv.Controls.Add(this.dataGridpv);
            this.groupCProv.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCProv.Location = new System.Drawing.Point(11, 139);
            this.groupCProv.Margin = new System.Windows.Forms.Padding(4);
            this.groupCProv.Name = "groupCProv";
            this.groupCProv.Padding = new System.Windows.Forms.Padding(4);
            this.groupCProv.Size = new System.Drawing.Size(1187, 431);
            this.groupCProv.TabIndex = 105;
            this.groupCProv.TabStop = false;
            this.groupCProv.Text = "Consulta de proveedores";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(432, 75);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 42);
            this.button4.TabIndex = 3;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbxbpv
            // 
            this.tbxbpv.Location = new System.Drawing.Point(164, 79);
            this.tbxbpv.Margin = new System.Windows.Forms.Padding(4);
            this.tbxbpv.Name = "tbxbpv";
            this.tbxbpv.Size = new System.Drawing.Size(247, 32);
            this.tbxbpv.TabIndex = 2;
            // 
            // cbxbpv
            // 
            this.cbxbpv.FormattingEnabled = true;
            this.cbxbpv.Location = new System.Drawing.Point(320, 37);
            this.cbxbpv.Margin = new System.Windows.Forms.Padding(4);
            this.cbxbpv.Name = "cbxbpv";
            this.cbxbpv.Size = new System.Drawing.Size(160, 32);
            this.cbxbpv.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seleccion el tipo de busqueda";
            // 
            // dataGridpv
            // 
            this.dataGridpv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridpv.BackgroundColor = System.Drawing.Color.White;
            this.dataGridpv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridpv.GridColor = System.Drawing.Color.DimGray;
            this.dataGridpv.Location = new System.Drawing.Point(97, 129);
            this.dataGridpv.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridpv.Name = "dataGridpv";
            this.dataGridpv.RowHeadersWidth = 51;
            this.dataGridpv.Size = new System.Drawing.Size(1036, 266);
            this.dataGridpv.TabIndex = 5;
            // 
            // Forma_Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1208, 599);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupCProd);
            this.Controls.Add(this.groupCInv);
            this.Controls.Add(this.groupCEmp);
            this.Controls.Add(this.groupCProv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Forma_Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Forma_Consultas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupCEmp.ResumeLayout(false);
            this.groupCEmp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmp)).EndInit();
            this.groupCInv.ResumeLayout(false);
            this.groupCInv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridinv)).EndInit();
            this.groupCProd.ResumeLayout(false);
            this.groupCProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpd)).EndInit();
            this.groupCProv.ResumeLayout(false);
            this.groupCProv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Empleado;
        private System.Windows.Forms.Label fecha;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.GroupBox groupCEmp;
        public System.Windows.Forms.GroupBox groupCInv;
        public System.Windows.Forms.GroupBox groupCProd;
        public System.Windows.Forms.GroupBox groupCProv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbxinv;
        private System.Windows.Forms.ComboBox cbxinv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbxbusqpd;
        private System.Windows.Forms.ComboBox cbxbpd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbxbpv;
        private System.Windows.Forms.ComboBox cbxbpv;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView dataGridEmp;
        public System.Windows.Forms.ComboBox cbxEmp;
        public System.Windows.Forms.DataGridView dataGridpd;
        public System.Windows.Forms.DataGridView dataGridpv;
        public System.Windows.Forms.DataGridView dataGridinv;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}