namespace Taller1Herencia
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
            this.btnFactorial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroIngresado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultadoFactorial = new System.Windows.Forms.Label();
            this.btnFibonacci = new System.Windows.Forms.Button();
            this.ltbFibonacci = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFactorial
            // 
            this.btnFactorial.Font = new System.Drawing.Font("Arial", 14F);
            this.btnFactorial.Location = new System.Drawing.Point(366, 187);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(120, 39);
            this.btnFactorial.TabIndex = 0;
            this.btnFactorial.Text = "Factorial";
            this.btnFactorial.UseVisualStyleBackColor = true;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cálcular Factorial y serie Fibonacci";
            // 
            // txtNumeroIngresado
            // 
            this.txtNumeroIngresado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtNumeroIngresado.Font = new System.Drawing.Font("Arial", 14F);
            this.txtNumeroIngresado.Location = new System.Drawing.Point(185, 123);
            this.txtNumeroIngresado.Name = "txtNumeroIngresado";
            this.txtNumeroIngresado.Size = new System.Drawing.Size(100, 29);
            this.txtNumeroIngresado.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(79, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese un número y luego seleccione una opción:";
            // 
            // lblResultadoFactorial
            // 
            this.lblResultadoFactorial.AutoSize = true;
            this.lblResultadoFactorial.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblResultadoFactorial.Location = new System.Drawing.Point(362, 252);
            this.lblResultadoFactorial.Name = "lblResultadoFactorial";
            this.lblResultadoFactorial.Size = new System.Drawing.Size(21, 22);
            this.lblResultadoFactorial.TabIndex = 4;
            this.lblResultadoFactorial.Text = "0";
            // 
            // btnFibonacci
            // 
            this.btnFibonacci.Font = new System.Drawing.Font("Arial", 14F);
            this.btnFibonacci.Location = new System.Drawing.Point(67, 187);
            this.btnFibonacci.Name = "btnFibonacci";
            this.btnFibonacci.Size = new System.Drawing.Size(120, 39);
            this.btnFibonacci.TabIndex = 6;
            this.btnFibonacci.Text = "Fibonacci";
            this.btnFibonacci.UseVisualStyleBackColor = true;
            this.btnFibonacci.Click += new System.EventHandler(this.btnFibonacci_Click);
            // 
            // ltbFibonacci
            // 
            this.ltbFibonacci.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ltbFibonacci.FormattingEnabled = true;
            this.ltbFibonacci.Location = new System.Drawing.Point(204, 187);
            this.ltbFibonacci.Name = "ltbFibonacci";
            this.ltbFibonacci.Size = new System.Drawing.Size(122, 212);
            this.ltbFibonacci.TabIndex = 7;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 14F);
            this.btnLimpiar.Location = new System.Drawing.Point(344, 123);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(99, 29);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(645, 420);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.ltbFibonacci);
            this.Controls.Add(this.btnFibonacci);
            this.Controls.Add(this.lblResultadoFactorial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroIngresado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFactorial);
            this.Name = "Form1";
            this.Text = "Taller 1 Herencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroIngresado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultadoFactorial;
        private System.Windows.Forms.Button btnFibonacci;
        private System.Windows.Forms.ListBox ltbFibonacci;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

