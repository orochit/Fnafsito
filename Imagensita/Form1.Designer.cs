namespace Imagensita
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
            this.components = new System.ComponentModel.Container();
            this.btnLPuerta = new System.Windows.Forms.Button();
            this.btnRPuerta = new System.Windows.Forms.Button();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.Tick = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblBonnieDangerLvl = new System.Windows.Forms.Label();
            this.lblChicaDangerLvl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLPuerta
            // 
            this.btnLPuerta.Location = new System.Drawing.Point(140, 221);
            this.btnLPuerta.Name = "btnLPuerta";
            this.btnLPuerta.Size = new System.Drawing.Size(75, 23);
            this.btnLPuerta.TabIndex = 0;
            this.btnLPuerta.Text = "Abierto";
            this.btnLPuerta.UseVisualStyleBackColor = true;
            this.btnLPuerta.Click += new System.EventHandler(this.btnLPuerta_Click);
            // 
            // btnRPuerta
            // 
            this.btnRPuerta.Location = new System.Drawing.Point(530, 221);
            this.btnRPuerta.Name = "btnRPuerta";
            this.btnRPuerta.Size = new System.Drawing.Size(75, 23);
            this.btnRPuerta.TabIndex = 1;
            this.btnRPuerta.Text = "Abierto";
            this.btnRPuerta.UseVisualStyleBackColor = true;
            this.btnRPuerta.Click += new System.EventHandler(this.btnRPuerta_Click);
            // 
            // Hora
            // 
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // Tick
            // 
            this.Tick.Tick += new System.EventHandler(this.Tick_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(294, 67);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(33, 13);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "12am";
            // 
            // lblBonnieDangerLvl
            // 
            this.lblBonnieDangerLvl.AutoSize = true;
            this.lblBonnieDangerLvl.Location = new System.Drawing.Point(140, 174);
            this.lblBonnieDangerLvl.Name = "lblBonnieDangerLvl";
            this.lblBonnieDangerLvl.Size = new System.Drawing.Size(13, 13);
            this.lblBonnieDangerLvl.TabIndex = 3;
            this.lblBonnieDangerLvl.Text = "0";
            // 
            // lblChicaDangerLvl
            // 
            this.lblChicaDangerLvl.AutoSize = true;
            this.lblChicaDangerLvl.Location = new System.Drawing.Point(592, 174);
            this.lblChicaDangerLvl.Name = "lblChicaDangerLvl";
            this.lblChicaDangerLvl.Size = new System.Drawing.Size(13, 13);
            this.lblChicaDangerLvl.TabIndex = 4;
            this.lblChicaDangerLvl.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChicaDangerLvl);
            this.Controls.Add(this.lblBonnieDangerLvl);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnRPuerta);
            this.Controls.Add(this.btnLPuerta);
            this.Name = "Form1";
            this.Text = "Hola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLPuerta;
        private System.Windows.Forms.Button btnRPuerta;
        private System.Windows.Forms.Timer Hora;
        private System.Windows.Forms.Timer Tick;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblBonnieDangerLvl;
        private System.Windows.Forms.Label lblChicaDangerLvl;
    }
}

