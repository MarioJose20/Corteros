
namespace Corteros
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.lblFecha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.Tiempo = new System.Windows.Forms.Timer(this.components);
            this.Mover = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lblHora = new System.Windows.Forms.TextBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnSupervisores = new System.Windows.Forms.Button();
            this.btnDistrito = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDistancia = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(167)))), ((int)(((byte)(84)))));
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblFecha.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(37, 634);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.ReadOnly = true;
            this.lblFecha.ShortcutsEnabled = false;
            this.lblFecha.Size = new System.Drawing.Size(1208, 59);
            this.lblFecha.TabIndex = 90;
            this.lblFecha.Text = "00/00/00";
            this.lblFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(117)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 47);
            this.panel1.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(585, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 32);
            this.label4.TabIndex = 135;
            this.label4.Text = "MENU";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1266, 7);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 82;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1675, 13);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(33, 33);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 81;
            this.btnSalir.TabStop = false;
            // 
            // Tiempo
            // 
            this.Tiempo.Enabled = true;
            this.Tiempo.Tick += new System.EventHandler(this.Tiempo_Tick);
            // 
            // Mover
            // 
            this.Mover.Fixed = true;
            this.Mover.Horizontal = true;
            this.Mover.TargetControl = this.panel1;
            this.Mover.Vertical = true;
            // 
            // lblHora
            // 
            this.lblHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(167)))), ((int)(((byte)(84)))));
            this.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblHora.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(334, 563);
            this.lblHora.Name = "lblHora";
            this.lblHora.ReadOnly = true;
            this.lblHora.ShortcutsEnabled = false;
            this.lblHora.Size = new System.Drawing.Size(613, 59);
            this.lblHora.TabIndex = 91;
            this.lblHora.Text = "00/00/00";
            this.lblHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(-21, 619);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1353, 20);
            this.bunifuSeparator1.TabIndex = 92;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(117)))), ((int)(((byte)(47)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(54, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 194);
            this.button1.TabIndex = 93;
            this.button1.Text = "Finca";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(117)))), ((int)(((byte)(47)))));
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleados.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnEmpleados.Location = new System.Drawing.Point(361, 81);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(218, 194);
            this.btnEmpleados.TabIndex = 94;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnSupervisores
            // 
            this.btnSupervisores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(117)))), ((int)(((byte)(47)))));
            this.btnSupervisores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupervisores.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupervisores.ForeColor = System.Drawing.Color.White;
            this.btnSupervisores.Location = new System.Drawing.Point(974, 81);
            this.btnSupervisores.Name = "btnSupervisores";
            this.btnSupervisores.Size = new System.Drawing.Size(218, 194);
            this.btnSupervisores.TabIndex = 96;
            this.btnSupervisores.Text = "Supervisores";
            this.btnSupervisores.UseVisualStyleBackColor = false;
            this.btnSupervisores.Click += new System.EventHandler(this.btnSupervisores_Click);
            // 
            // btnDistrito
            // 
            this.btnDistrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(117)))), ((int)(((byte)(47)))));
            this.btnDistrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistrito.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistrito.ForeColor = System.Drawing.Color.White;
            this.btnDistrito.Location = new System.Drawing.Point(667, 81);
            this.btnDistrito.Name = "btnDistrito";
            this.btnDistrito.Size = new System.Drawing.Size(218, 194);
            this.btnDistrito.TabIndex = 95;
            this.btnDistrito.Text = "Distrito";
            this.btnDistrito.UseVisualStyleBackColor = false;
            this.btnDistrito.Click += new System.EventHandler(this.btnDistrito_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(117)))), ((int)(((byte)(47)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(54, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 194);
            this.button2.TabIndex = 97;
            this.button2.Text = "Frente";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDistancia
            // 
            this.btnDistancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(117)))), ((int)(((byte)(47)))));
            this.btnDistancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistancia.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDistancia.ForeColor = System.Drawing.Color.White;
            this.btnDistancia.Location = new System.Drawing.Point(361, 338);
            this.btnDistancia.Name = "btnDistancia";
            this.btnDistancia.Size = new System.Drawing.Size(218, 194);
            this.btnDistancia.TabIndex = 98;
            this.btnDistancia.Text = "Distancia Siembra";
            this.btnDistancia.UseVisualStyleBackColor = false;
            this.btnDistancia.Click += new System.EventHandler(this.btnDistancia_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(117)))), ((int)(((byte)(47)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(667, 338);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 194);
            this.button4.TabIndex = 99;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(117)))), ((int)(((byte)(47)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(974, 338);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(218, 194);
            this.button5.TabIndex = 100;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(167)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDistancia);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSupervisores);
            this.Controls.Add(this.btnDistrito);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lblFecha;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Timer Tiempo;
        private Bunifu.Framework.UI.BunifuDragControl Mover;
        private System.Windows.Forms.TextBox lblHora;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnSupervisores;
        private System.Windows.Forms.Button btnDistrito;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDistancia;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}