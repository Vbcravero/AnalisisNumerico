﻿namespace AnalisisNumerico
{
    partial class Inicio
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
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.BotonAchicar = new System.Windows.Forms.PictureBox();
            this.BotonMinimizar = new System.Windows.Forms.PictureBox();
            this.BotonAgrandar = new System.Windows.Forms.PictureBox();
            this.BotonCerrar = new System.Windows.Forms.PictureBox();
            this.BarraIzquierda = new System.Windows.Forms.Panel();
            this.PanelCerrados = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BotonReglaFalsa = new System.Windows.Forms.Button();
            this.BotonBiseccion = new System.Windows.Forms.Button();
            this.PanelAbiertos = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BotonSecante = new System.Windows.Forms.Button();
            this.BotonTg = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotonCerrados = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotonAbiertos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAchicar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAgrandar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).BeginInit();
            this.BarraIzquierda.SuspendLayout();
            this.PanelCerrados.SuspendLayout();
            this.PanelAbiertos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BarraTitulo.Controls.Add(this.BotonAchicar);
            this.BarraTitulo.Controls.Add(this.BotonMinimizar);
            this.BarraTitulo.Controls.Add(this.BotonAgrandar);
            this.BarraTitulo.Controls.Add(this.BotonCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1733, 47);
            this.BarraTitulo.TabIndex = 0;
            // 
            // BotonAchicar
            // 
            this.BotonAchicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonAchicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAchicar.Location = new System.Drawing.Point(1572, 9);
            this.BotonAchicar.Margin = new System.Windows.Forms.Padding(4);
            this.BotonAchicar.Name = "BotonAchicar";
            this.BotonAchicar.Size = new System.Drawing.Size(33, 31);
            this.BotonAchicar.TabIndex = 3;
            this.BotonAchicar.TabStop = false;
            this.BotonAchicar.Visible = false;
            this.BotonAchicar.Click += new System.EventHandler(this.BotonAchicar_Click);
            // 
            // BotonMinimizar
            // 
            this.BotonMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonMinimizar.Location = new System.Drawing.Point(1613, 9);
            this.BotonMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.BotonMinimizar.Name = "BotonMinimizar";
            this.BotonMinimizar.Size = new System.Drawing.Size(33, 31);
            this.BotonMinimizar.TabIndex = 2;
            this.BotonMinimizar.TabStop = false;
            this.BotonMinimizar.Click += new System.EventHandler(this.BotonMinimizar_Click);
            // 
            // BotonAgrandar
            // 
            this.BotonAgrandar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonAgrandar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonAgrandar.Location = new System.Drawing.Point(1655, 9);
            this.BotonAgrandar.Margin = new System.Windows.Forms.Padding(4);
            this.BotonAgrandar.Name = "BotonAgrandar";
            this.BotonAgrandar.Size = new System.Drawing.Size(33, 31);
            this.BotonAgrandar.TabIndex = 1;
            this.BotonAgrandar.TabStop = false;
            this.BotonAgrandar.Click += new System.EventHandler(this.BotonAgrandar_Click);
            // 
            // BotonCerrar
            // 
            this.BotonCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotonCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonCerrar.Location = new System.Drawing.Point(1696, 9);
            this.BotonCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.BotonCerrar.Name = "BotonCerrar";
            this.BotonCerrar.Size = new System.Drawing.Size(33, 31);
            this.BotonCerrar.TabIndex = 0;
            this.BotonCerrar.TabStop = false;
            this.BotonCerrar.Click += new System.EventHandler(this.BotonCerrar_Click);
            // 
            // BarraIzquierda
            // 
            this.BarraIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraIzquierda.Controls.Add(this.PanelCerrados);
            this.BarraIzquierda.Controls.Add(this.PanelAbiertos);
            this.BarraIzquierda.Controls.Add(this.panel2);
            this.BarraIzquierda.Controls.Add(this.BotonCerrados);
            this.BarraIzquierda.Controls.Add(this.panel1);
            this.BarraIzquierda.Controls.Add(this.BotonAbiertos);
            this.BarraIzquierda.Controls.Add(this.pictureBox1);
            this.BarraIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraIzquierda.Location = new System.Drawing.Point(0, 47);
            this.BarraIzquierda.Margin = new System.Windows.Forms.Padding(4);
            this.BarraIzquierda.Name = "BarraIzquierda";
            this.BarraIzquierda.Size = new System.Drawing.Size(293, 753);
            this.BarraIzquierda.TabIndex = 1;
            // 
            // PanelCerrados
            // 
            this.PanelCerrados.Controls.Add(this.panel6);
            this.PanelCerrados.Controls.Add(this.panel5);
            this.PanelCerrados.Controls.Add(this.BotonReglaFalsa);
            this.PanelCerrados.Controls.Add(this.BotonBiseccion);
            this.PanelCerrados.Location = new System.Drawing.Point(15, 489);
            this.PanelCerrados.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCerrados.Name = "PanelCerrados";
            this.PanelCerrados.Size = new System.Drawing.Size(277, 172);
            this.PanelCerrados.TabIndex = 6;
            this.PanelCerrados.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(5, 82);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(7, 62);
            this.panel6.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(5, 14);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(7, 62);
            this.panel5.TabIndex = 3;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // BotonReglaFalsa
            // 
            this.BotonReglaFalsa.FlatAppearance.BorderSize = 0;
            this.BotonReglaFalsa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BotonReglaFalsa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonReglaFalsa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonReglaFalsa.ForeColor = System.Drawing.Color.White;
            this.BotonReglaFalsa.Location = new System.Drawing.Point(5, 82);
            this.BotonReglaFalsa.Margin = new System.Windows.Forms.Padding(4);
            this.BotonReglaFalsa.Name = "BotonReglaFalsa";
            this.BotonReglaFalsa.Size = new System.Drawing.Size(273, 62);
            this.BotonReglaFalsa.TabIndex = 5;
            this.BotonReglaFalsa.Text = "Regla falsa";
            this.BotonReglaFalsa.UseVisualStyleBackColor = true;
            this.BotonReglaFalsa.Click += new System.EventHandler(this.Boton4_Click);
            // 
            // BotonBiseccion
            // 
            this.BotonBiseccion.FlatAppearance.BorderSize = 0;
            this.BotonBiseccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BotonBiseccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonBiseccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonBiseccion.ForeColor = System.Drawing.Color.White;
            this.BotonBiseccion.Location = new System.Drawing.Point(4, 14);
            this.BotonBiseccion.Margin = new System.Windows.Forms.Padding(4);
            this.BotonBiseccion.Name = "BotonBiseccion";
            this.BotonBiseccion.Size = new System.Drawing.Size(273, 62);
            this.BotonBiseccion.TabIndex = 4;
            this.BotonBiseccion.Text = "Bisección";
            this.BotonBiseccion.UseVisualStyleBackColor = true;
            this.BotonBiseccion.Click += new System.EventHandler(this.Boton3_Click);
            // 
            // PanelAbiertos
            // 
            this.PanelAbiertos.Controls.Add(this.panel4);
            this.PanelAbiertos.Controls.Add(this.panel3);
            this.PanelAbiertos.Controls.Add(this.BotonSecante);
            this.PanelAbiertos.Controls.Add(this.BotonTg);
            this.PanelAbiertos.Location = new System.Drawing.Point(16, 214);
            this.PanelAbiertos.Margin = new System.Windows.Forms.Padding(4);
            this.PanelAbiertos.Name = "PanelAbiertos";
            this.PanelAbiertos.Size = new System.Drawing.Size(277, 162);
            this.PanelAbiertos.TabIndex = 3;
            this.PanelAbiertos.Visible = false;
            this.PanelAbiertos.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(4, 73);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(7, 62);
            this.panel4.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(7, 62);
            this.panel3.TabIndex = 2;
            // 
            // BotonSecante
            // 
            this.BotonSecante.FlatAppearance.BorderSize = 0;
            this.BotonSecante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BotonSecante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonSecante.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonSecante.ForeColor = System.Drawing.Color.White;
            this.BotonSecante.Location = new System.Drawing.Point(4, 73);
            this.BotonSecante.Margin = new System.Windows.Forms.Padding(4);
            this.BotonSecante.Name = "BotonSecante";
            this.BotonSecante.Size = new System.Drawing.Size(273, 62);
            this.BotonSecante.TabIndex = 5;
            this.BotonSecante.Text = "Secante";
            this.BotonSecante.UseVisualStyleBackColor = true;
            this.BotonSecante.Click += new System.EventHandler(this.Boton2_Click);
            // 
            // BotonTg
            // 
            this.BotonTg.FlatAppearance.BorderSize = 0;
            this.BotonTg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BotonTg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonTg.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonTg.ForeColor = System.Drawing.Color.White;
            this.BotonTg.Location = new System.Drawing.Point(4, 4);
            this.BotonTg.Margin = new System.Windows.Forms.Padding(4);
            this.BotonTg.Name = "BotonTg";
            this.BotonTg.Size = new System.Drawing.Size(273, 62);
            this.BotonTg.TabIndex = 4;
            this.BotonTg.Text = "Tangente";
            this.BotonTg.UseVisualStyleBackColor = true;
            this.BotonTg.Click += new System.EventHandler(this.Tg_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(5, 420);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(7, 62);
            this.panel2.TabIndex = 2;
            // 
            // BotonCerrados
            // 
            this.BotonCerrados.FlatAppearance.BorderSize = 0;
            this.BotonCerrados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BotonCerrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonCerrados.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonCerrados.ForeColor = System.Drawing.Color.White;
            this.BotonCerrados.Location = new System.Drawing.Point(4, 420);
            this.BotonCerrados.Margin = new System.Windows.Forms.Padding(4);
            this.BotonCerrados.Name = "BotonCerrados";
            this.BotonCerrados.Size = new System.Drawing.Size(289, 62);
            this.BotonCerrados.TabIndex = 2;
            this.BotonCerrados.Text = "Cerrados";
            this.BotonCerrados.UseVisualStyleBackColor = true;
            this.BotonCerrados.Click += new System.EventHandler(this.BotonCerrados_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 139);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(7, 62);
            this.panel1.TabIndex = 1;
            // 
            // BotonAbiertos
            // 
            this.BotonAbiertos.FlatAppearance.BorderSize = 0;
            this.BotonAbiertos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BotonAbiertos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotonAbiertos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonAbiertos.ForeColor = System.Drawing.Color.White;
            this.BotonAbiertos.Location = new System.Drawing.Point(3, 139);
            this.BotonAbiertos.Margin = new System.Windows.Forms.Padding(4);
            this.BotonAbiertos.Name = "BotonAbiertos";
            this.BotonAbiertos.Size = new System.Drawing.Size(289, 62);
            this.BotonAbiertos.TabIndex = 0;
            this.BotonAbiertos.Text = "Abiertos";
            this.BotonAbiertos.UseVisualStyleBackColor = true;
            this.BotonAbiertos.Click += new System.EventHandler(this.BotonAbiertos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(293, 47);
            this.PanelCentral.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(1440, 753);
            this.PanelCentral.TabIndex = 2;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 800);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.BarraIzquierda);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.Text = "Form1";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotonAchicar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonAgrandar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotonCerrar)).EndInit();
            this.BarraIzquierda.ResumeLayout(false);
            this.PanelCerrados.ResumeLayout(false);
            this.PanelAbiertos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox BotonMinimizar;
        private System.Windows.Forms.PictureBox BotonAgrandar;
        private System.Windows.Forms.PictureBox BotonCerrar;
        private System.Windows.Forms.Panel BarraIzquierda;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.PictureBox BotonAchicar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BotonAbiertos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BotonCerrados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelAbiertos;
        private System.Windows.Forms.Button BotonSecante;
        private System.Windows.Forms.Button BotonTg;
        private System.Windows.Forms.Panel PanelCerrados;
        private System.Windows.Forms.Button BotonReglaFalsa;
        private System.Windows.Forms.Button BotonBiseccion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
    }
}

