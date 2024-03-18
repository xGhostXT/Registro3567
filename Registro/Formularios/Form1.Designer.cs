namespace Registro
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCONFACT = new System.Windows.Forms.Button();
            this.lblCOL01 = new System.Windows.Forms.Label();
            this.lblCOL02 = new System.Windows.Forms.Label();
            this.lblCOL03 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBuscar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(40, 398);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 49);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLimpiar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(175, 398);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 49);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSalir.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(451, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 49);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Movimiento de Cuenta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Outlook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(36, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "hola2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Outlook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.Location = new System.Drawing.Point(486, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "hola3";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(36, 102);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(133, 20);
            this.lblCliente.TabIndex = 6;
            this.lblCliente.Text = "Cuenta de cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(36, 143);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(175, 104);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(336, 20);
            this.txtBuscar.TabIndex = 10;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtDepartamento_TextChanged);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(40, 183);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(516, 150);
            this.dgv.TabIndex = 14;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnImprimir.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(314, 398);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(105, 49);
            this.btnImprimir.TabIndex = 15;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(449, 20);
            this.label6.TabIndex = 16;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnCONFACT
            // 
            this.btnCONFACT.Location = new System.Drawing.Point(518, 104);
            this.btnCONFACT.Name = "btnCONFACT";
            this.btnCONFACT.Size = new System.Drawing.Size(38, 20);
            this.btnCONFACT.TabIndex = 20;
            this.btnCONFACT.Text = "...";
            this.btnCONFACT.UseVisualStyleBackColor = true;
            this.btnCONFACT.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblCOL01
            // 
            this.lblCOL01.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblCOL01.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCOL01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOL01.Location = new System.Drawing.Point(316, 355);
            this.lblCOL01.Name = "lblCOL01";
            this.lblCOL01.Size = new System.Drawing.Size(120, 20);
            this.lblCOL01.TabIndex = 21;
            this.lblCOL01.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCOL01.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblCOL02
            // 
            this.lblCOL02.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblCOL02.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCOL02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOL02.Location = new System.Drawing.Point(436, 355);
            this.lblCOL02.Name = "lblCOL02";
            this.lblCOL02.Size = new System.Drawing.Size(120, 20);
            this.lblCOL02.TabIndex = 22;
            this.lblCOL02.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCOL02.Click += new System.EventHandler(this.lblCOL02_Click);
            // 
            // lblCOL03
            // 
            this.lblCOL03.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblCOL03.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCOL03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCOL03.Location = new System.Drawing.Point(194, 355);
            this.lblCOL03.Name = "lblCOL03";
            this.lblCOL03.Size = new System.Drawing.Size(122, 20);
            this.lblCOL03.TabIndex = 23;
            this.lblCOL03.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCOL03.Click += new System.EventHandler(this.lblCOL03_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 478);
            this.Controls.Add(this.lblCOL03);
            this.Controls.Add(this.lblCOL02);
            this.Controls.Add(this.lblCOL01);
            this.Controls.Add(this.btnCONFACT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCONFACT;
        private System.Windows.Forms.Label lblCOL01;
        private System.Windows.Forms.Label lblCOL02;
        private System.Windows.Forms.Label lblCOL03;
    }
}

