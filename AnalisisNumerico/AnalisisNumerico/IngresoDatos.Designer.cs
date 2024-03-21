namespace AnalisisNumerico
{
    partial class IngresoDatos
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
            this.labelFuncion = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textFuncion = new System.Windows.Forms.TextBox();
            this.textIteracion = new System.Windows.Forms.TextBox();
            this.textTolerancia = new System.Windows.Forms.TextBox();
            this.xi = new System.Windows.Forms.TextBox();
            this.labelIteracion = new System.Windows.Forms.Label();
            this.labelTolerancia = new System.Windows.Forms.Label();
            this.labelXi = new System.Windows.Forms.Label();
            this.labelXd = new System.Windows.Forms.Label();
            this.xd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFuncion
            // 
            this.labelFuncion.AutoSize = true;
            this.labelFuncion.Location = new System.Drawing.Point(22, 65);
            this.labelFuncion.Name = "labelFuncion";
            this.labelFuncion.Size = new System.Drawing.Size(57, 16);
            this.labelFuncion.TabIndex = 0;
            this.labelFuncion.Text = "Función:";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(695, 403);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(75, 23);
            this.buttonCalcular.TabIndex = 1;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // textFuncion
            // 
            this.textFuncion.Location = new System.Drawing.Point(85, 62);
            this.textFuncion.Name = "textFuncion";
            this.textFuncion.Size = new System.Drawing.Size(100, 22);
            this.textFuncion.TabIndex = 2;
            // 
            // textIteracion
            // 
            this.textIteracion.Location = new System.Drawing.Point(104, 109);
            this.textIteracion.Name = "textIteracion";
            this.textIteracion.Size = new System.Drawing.Size(100, 22);
            this.textIteracion.TabIndex = 3;
            // 
            // textTolerancia
            // 
            this.textTolerancia.Location = new System.Drawing.Point(104, 162);
            this.textTolerancia.Name = "textTolerancia";
            this.textTolerancia.Size = new System.Drawing.Size(100, 22);
            this.textTolerancia.TabIndex = 4;
            // 
            // xi
            // 
            this.xi.Location = new System.Drawing.Point(104, 206);
            this.xi.Name = "xi";
            this.xi.Size = new System.Drawing.Size(100, 22);
            this.xi.TabIndex = 5;
            // 
            // labelIteracion
            // 
            this.labelIteracion.AutoSize = true;
            this.labelIteracion.Location = new System.Drawing.Point(22, 109);
            this.labelIteracion.Name = "labelIteracion";
            this.labelIteracion.Size = new System.Drawing.Size(76, 16);
            this.labelIteracion.TabIndex = 6;
            this.labelIteracion.Text = "Iteraciones:";
            // 
            // labelTolerancia
            // 
            this.labelTolerancia.AutoSize = true;
            this.labelTolerancia.Location = new System.Drawing.Point(23, 165);
            this.labelTolerancia.Name = "labelTolerancia";
            this.labelTolerancia.Size = new System.Drawing.Size(75, 16);
            this.labelTolerancia.TabIndex = 7;
            this.labelTolerancia.Text = "Tolerancia:";
            // 
            // labelXi
            // 
            this.labelXi.AutoSize = true;
            this.labelXi.Location = new System.Drawing.Point(23, 212);
            this.labelXi.Name = "labelXi";
            this.labelXi.Size = new System.Drawing.Size(21, 16);
            this.labelXi.TabIndex = 8;
            this.labelXi.Text = "Xi:";
            // 
            // labelXd
            // 
            this.labelXd.AutoSize = true;
            this.labelXd.Location = new System.Drawing.Point(23, 242);
            this.labelXd.Name = "labelXd";
            this.labelXd.Size = new System.Drawing.Size(26, 16);
            this.labelXd.TabIndex = 9;
            this.labelXd.Text = "Xd:";
            // 
            // xd
            // 
            this.xd.Location = new System.Drawing.Point(104, 242);
            this.xd.Name = "xd";
            this.xd.Size = new System.Drawing.Size(100, 22);
            this.xd.TabIndex = 10;
            // 
            // IngresoDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xd);
            this.Controls.Add(this.labelXd);
            this.Controls.Add(this.labelXi);
            this.Controls.Add(this.labelTolerancia);
            this.Controls.Add(this.labelIteracion);
            this.Controls.Add(this.xi);
            this.Controls.Add(this.textTolerancia);
            this.Controls.Add(this.textIteracion);
            this.Controls.Add(this.textFuncion);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelFuncion);
            this.Name = "IngresoDatos";
            this.Text = "IngresoDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFuncion;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.TextBox textFuncion;
        private System.Windows.Forms.TextBox textIteracion;
        private System.Windows.Forms.TextBox textTolerancia;
        private System.Windows.Forms.TextBox xi;
        private System.Windows.Forms.Label labelIteracion;
        private System.Windows.Forms.Label labelTolerancia;
        private System.Windows.Forms.Label labelXi;
        private System.Windows.Forms.Label labelXd;
        private System.Windows.Forms.TextBox xd;
    }
}