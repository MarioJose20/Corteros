﻿namespace Corteros
{
    partial class FrmFinca
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
            this.txtBuscarFinca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvFinca = new System.Windows.Forms.DataGridView();
            this.txtNombreFinca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizarEstado = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbDistrito = new System.Windows.Forms.ComboBox();
            this.cmbTipoFinca = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinca)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarFinca
            // 
            this.txtBuscarFinca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarFinca.Location = new System.Drawing.Point(311, 51);
            this.txtBuscarFinca.Name = "txtBuscarFinca";
            this.txtBuscarFinca.Size = new System.Drawing.Size(201, 20);
            this.txtBuscarFinca.TabIndex = 26;
            this.txtBuscarFinca.TextChanged += new System.EventHandler(this.txtBuscarFinca_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Buscar";
            // 
            // dgvFinca
            // 
            this.dgvFinca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFinca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvFinca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinca.Location = new System.Drawing.Point(235, 78);
            this.dgvFinca.Name = "dgvFinca";
            this.dgvFinca.Size = new System.Drawing.Size(938, 455);
            this.dgvFinca.TabIndex = 24;
            this.dgvFinca.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFinca_CellClick);
            // 
            // txtNombreFinca
            // 
            this.txtNombreFinca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreFinca.Location = new System.Drawing.Point(12, 78);
            this.txtNombreFinca.Name = "txtNombreFinca";
            this.txtNombreFinca.Size = new System.Drawing.Size(201, 20);
            this.txtNombreFinca.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Distrito";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Finca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(569, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fincas";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(1009, 594);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(158, 23);
            this.btnBorrar.TabIndex = 45;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizarEstado
            // 
            this.btnActualizarEstado.Location = new System.Drawing.Point(728, 594);
            this.btnActualizarEstado.Name = "btnActualizarEstado";
            this.btnActualizarEstado.Size = new System.Drawing.Size(158, 23);
            this.btnActualizarEstado.TabIndex = 44;
            this.btnActualizarEstado.Text = "Eliminar";
            this.btnActualizarEstado.UseVisualStyleBackColor = true;
            this.btnActualizarEstado.Click += new System.EventHandler(this.btnActualizarEstado_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(468, 594);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(158, 23);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(236, 594);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(158, 23);
            this.btnAgregar.TabIndex = 42;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbDistrito
            // 
            this.cmbDistrito.FormattingEnabled = true;
            this.cmbDistrito.Location = new System.Drawing.Point(12, 139);
            this.cmbDistrito.Name = "cmbDistrito";
            this.cmbDistrito.Size = new System.Drawing.Size(201, 21);
            this.cmbDistrito.TabIndex = 46;
            // 
            // cmbTipoFinca
            // 
            this.cmbTipoFinca.FormattingEnabled = true;
            this.cmbTipoFinca.Location = new System.Drawing.Point(12, 200);
            this.cmbTipoFinca.Name = "cmbTipoFinca";
            this.cmbTipoFinca.Size = new System.Drawing.Size(201, 21);
            this.cmbTipoFinca.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Tipo de finca";
            // 
            // FrmFinca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.cmbTipoFinca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDistrito);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnActualizarEstado);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtBuscarFinca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvFinca);
            this.Controls.Add(this.txtNombreFinca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmFinca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFinca";
            this.Load += new System.EventHandler(this.FrmFinca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtBuscarFinca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvFinca;
        public System.Windows.Forms.TextBox txtNombreFinca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizarEstado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbDistrito;
        private System.Windows.Forms.ComboBox cmbTipoFinca;
        private System.Windows.Forms.Label label5;
    }
}