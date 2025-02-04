namespace Farmacias
{
    partial class ConsultaVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVentas));
            this.groupCProd = new System.Windows.Forms.GroupBox();
            this.btnBP = new System.Windows.Forms.Button();
            this.tbxbusqpd = new System.Windows.Forms.TextBox();
            this.cbxbpd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridpd = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupCProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCProd
            // 
            this.groupCProd.BackColor = System.Drawing.Color.Bisque;
            this.groupCProd.Controls.Add(this.pictureBox1);
            this.groupCProd.Controls.Add(this.btnBP);
            this.groupCProd.Controls.Add(this.tbxbusqpd);
            this.groupCProd.Controls.Add(this.cbxbpd);
            this.groupCProd.Controls.Add(this.label3);
            this.groupCProd.Controls.Add(this.dataGridpd);
            this.groupCProd.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCProd.Location = new System.Drawing.Point(16, 15);
            this.groupCProd.Margin = new System.Windows.Forms.Padding(4);
            this.groupCProd.Name = "groupCProd";
            this.groupCProd.Padding = new System.Windows.Forms.Padding(4);
            this.groupCProd.Size = new System.Drawing.Size(1049, 427);
            this.groupCProd.TabIndex = 5;
            this.groupCProd.TabStop = false;
            this.groupCProd.Text = "Consulta de productos";
            // 
            // btnBP
            // 
            this.btnBP.Location = new System.Drawing.Point(432, 75);
            this.btnBP.Margin = new System.Windows.Forms.Padding(4);
            this.btnBP.Name = "btnBP";
            this.btnBP.Size = new System.Drawing.Size(120, 42);
            this.btnBP.TabIndex = 3;
            this.btnBP.Text = "Buscar";
            this.btnBP.UseVisualStyleBackColor = true;
            this.btnBP.Click += new System.EventHandler(this.btnBP_Click);
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
            this.dataGridpd.AllowUserToAddRows = false;
            this.dataGridpd.AllowUserToDeleteRows = false;
            this.dataGridpd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridpd.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridpd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridpd.GridColor = System.Drawing.Color.DimGray;
            this.dataGridpd.Location = new System.Drawing.Point(0, 124);
            this.dataGridpd.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridpd.Name = "dataGridpd";
            this.dataGridpd.ReadOnly = true;
            this.dataGridpd.RowHeadersWidth = 51;
            this.dataGridpd.Size = new System.Drawing.Size(1036, 266);
            this.dataGridpd.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(778, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 55);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1065, 442);
            this.Controls.Add(this.groupCProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ConsultaVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultaVentas";
            this.Load += new System.EventHandler(this.ConsultaVentas_Load);
            this.groupCProd.ResumeLayout(false);
            this.groupCProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupCProd;
        private System.Windows.Forms.Button btnBP;
        private System.Windows.Forms.TextBox tbxbusqpd;
        private System.Windows.Forms.ComboBox cbxbpd;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.DataGridView dataGridpd;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}