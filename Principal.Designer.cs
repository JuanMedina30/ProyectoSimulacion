namespace ProyectoSimulacionIndividual
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.txtC_M = new System.Windows.Forms.TextBox();
            this.txtC_A = new System.Windows.Forms.TextBox();
            this.txtSem = new System.Windows.Forms.TextBox();
            this.txtMod = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CANTIDAD = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.labelRes = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.BackColor = System.Drawing.Color.Salmon;
            this.BtnGenerar.Location = new System.Drawing.Point(245, 148);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Size = new System.Drawing.Size(84, 34);
            this.BtnGenerar.TabIndex = 0;
            this.BtnGenerar.Text = "GENERAR";
            this.BtnGenerar.UseVisualStyleBackColor = false;
            this.BtnGenerar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtC_M
            // 
            this.txtC_M.Location = new System.Drawing.Point(62, 28);
            this.txtC_M.Multiline = true;
            this.txtC_M.Name = "txtC_M";
            this.txtC_M.Size = new System.Drawing.Size(112, 28);
            this.txtC_M.TabIndex = 1;
            // 
            // txtC_A
            // 
            this.txtC_A.Location = new System.Drawing.Point(255, 25);
            this.txtC_A.Multiline = true;
            this.txtC_A.Name = "txtC_A";
            this.txtC_A.Size = new System.Drawing.Size(115, 31);
            this.txtC_A.TabIndex = 2;
            // 
            // txtSem
            // 
            this.txtSem.Location = new System.Drawing.Point(62, 86);
            this.txtSem.Multiline = true;
            this.txtSem.Name = "txtSem";
            this.txtSem.Size = new System.Drawing.Size(112, 30);
            this.txtSem.TabIndex = 3;
            // 
            // txtMod
            // 
            this.txtMod.Location = new System.Drawing.Point(255, 86);
            this.txtMod.Multiline = true;
            this.txtMod.Name = "txtMod";
            this.txtMod.Size = new System.Drawing.Size(115, 30);
            this.txtMod.TabIndex = 4;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(62, 148);
            this.txtCant.Multiline = true;
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(112, 32);
            this.txtCant.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "CONSTANTE MULTIPLICATIVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "CONSTANTE ADITIVA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS.Location = new System.Drawing.Point(81, 66);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(75, 17);
            this.labelS.TabIndex = 8;
            this.labelS.Text = "SEMILLA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "MODULO";
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.AutoSize = true;
            this.CANTIDAD.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CANTIDAD.Location = new System.Drawing.Point(73, 128);
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Size = new System.Drawing.Size(83, 17);
            this.CANTIDAD.TabIndex = 10;
            this.CANTIDAD.Text = "CANTIDAD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(44, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(292, 248);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "#";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NUM. PSEUDOALEATORIO";
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView2.Location = new System.Drawing.Point(396, 125);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(503, 248);
            this.dataGridView2.TabIndex = 12;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "#";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "NUM. PSEUDOALEATORIO";
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "DURACION CLIMA FRIO";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.BackColor = System.Drawing.Color.Salmon;
            this.BtnCalcular.Location = new System.Drawing.Point(601, 452);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(78, 31);
            this.BtnCalcular.TabIndex = 13;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Modern No. 20", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRes.Location = new System.Drawing.Point(417, 22);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(0, 21);
            this.labelRes.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ProyectoSimulacionIndividual.Properties.Resources.un_boton_de_salir_ilustracion_3d_prestados_aislado_en_blanco_krb0nw;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(814, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 49);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(459, 412);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(113, 29);
            this.txtC.TabIndex = 16;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(684, 412);
            this.txtP.Multiline = true;
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(106, 29);
            this.txtP.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "NUMERO CAJAS MANZANA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(705, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "PRECIO";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ProyectoSimulacionIndividual.Properties.Resources._419660;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(814, 434);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 49);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 21;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(965, 495);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CANTIDAD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtMod);
            this.Controls.Add(this.txtSem);
            this.Controls.Add(this.txtC_A);
            this.Controls.Add(this.txtC_M);
            this.Controls.Add(this.BtnGenerar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "VENTA MANZANAS";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.TextBox txtC_M;
        private System.Windows.Forms.TextBox txtC_A;
        private System.Windows.Forms.TextBox txtSem;
        private System.Windows.Forms.TextBox txtMod;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CANTIDAD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
    }
}