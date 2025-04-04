namespace APE1
{
    partial class Programa2cs
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnmecuacio = new System.Windows.Forms.TextBox();
            this.dgvcoefi = new System.Windows.Forms.DataGridView();
            this.btnmatriz = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnresolver = new System.Windows.Forms.Button();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcoefi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Ecuaciones:";
            // 
            // txtnmecuacio
            // 
            this.txtnmecuacio.Location = new System.Drawing.Point(161, 79);
            this.txtnmecuacio.Name = "txtnmecuacio";
            this.txtnmecuacio.Size = new System.Drawing.Size(85, 22);
            this.txtnmecuacio.TabIndex = 1;
            // 
            // dgvcoefi
            // 
            this.dgvcoefi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcoefi.Location = new System.Drawing.Point(157, 124);
            this.dgvcoefi.Name = "dgvcoefi";
            this.dgvcoefi.RowHeadersWidth = 51;
            this.dgvcoefi.RowTemplate.Height = 24;
            this.dgvcoefi.Size = new System.Drawing.Size(497, 187);
            this.dgvcoefi.TabIndex = 2;
            this.dgvcoefi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcoefi_CellContentClick);
            // 
            // btnmatriz
            // 
            this.btnmatriz.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmatriz.Location = new System.Drawing.Point(379, 74);
            this.btnmatriz.Name = "btnmatriz";
            this.btnmatriz.Size = new System.Drawing.Size(117, 27);
            this.btnmatriz.TabIndex = 3;
            this.btnmatriz.Text = "Generar Matriz";
            this.btnmatriz.UseVisualStyleBackColor = true;
            this.btnmatriz.Click += new System.EventHandler(this.btnmatriz_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(261, 403);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(89, 33);
            this.btnlimpiar.TabIndex = 4;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.Location = new System.Drawing.Point(476, 405);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(89, 31);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnresolver
            // 
            this.btnresolver.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresolver.Location = new System.Drawing.Point(537, 74);
            this.btnresolver.Name = "btnresolver";
            this.btnresolver.Size = new System.Drawing.Size(117, 27);
            this.btnresolver.TabIndex = 6;
            this.btnresolver.Text = "Resolver";
            this.btnresolver.UseVisualStyleBackColor = true;
            this.btnresolver.Click += new System.EventHandler(this.btnresolver_Click);
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(261, 356);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(304, 22);
            this.txtresultado.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Respuesta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ecuaciones Lineales";
            // 
            // Programa2cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(809, 490);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.btnresolver);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnmatriz);
            this.Controls.Add(this.dgvcoefi);
            this.Controls.Add(this.txtnmecuacio);
            this.Controls.Add(this.label1);
            this.Name = "Programa2cs";
            this.Text = "Programa2cs";
            ((System.ComponentModel.ISupportInitialize)(this.dgvcoefi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnmecuacio;
        private System.Windows.Forms.DataGridView dgvcoefi;
        private System.Windows.Forms.Button btnmatriz;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnresolver;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}