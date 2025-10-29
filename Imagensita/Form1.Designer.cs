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
            this.lblEnergia = new System.Windows.Forms.Label();
            this.Puertas = new System.Windows.Forms.Timer(this.components);
            this.lblindicacion = new System.Windows.Forms.Label();
            this.lblIndicacion2 = new System.Windows.Forms.Label();
            this.pbxScreamer = new System.Windows.Forms.PictureBox();
            this.pbxTenedor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxScreamer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTenedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLPuerta
            // 
            this.btnLPuerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLPuerta.Location = new System.Drawing.Point(148, 259);
            this.btnLPuerta.Name = "btnLPuerta";
            this.btnLPuerta.Size = new System.Drawing.Size(126, 101);
            this.btnLPuerta.TabIndex = 0;
            this.btnLPuerta.Text = "Abierto";
            this.btnLPuerta.UseVisualStyleBackColor = true;
            this.btnLPuerta.Click += new System.EventHandler(this.btnLPuerta_Click);
            // 
            // btnRPuerta
            // 
            this.btnRPuerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRPuerta.Location = new System.Drawing.Point(1678, 239);
            this.btnRPuerta.Name = "btnRPuerta";
            this.btnRPuerta.Size = new System.Drawing.Size(154, 103);
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
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(912, 25);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(81, 31);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "12am";
            // 
            // lblBonnieDangerLvl
            // 
            this.lblBonnieDangerLvl.AutoSize = true;
            this.lblBonnieDangerLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonnieDangerLvl.Location = new System.Drawing.Point(140, 174);
            this.lblBonnieDangerLvl.Name = "lblBonnieDangerLvl";
            this.lblBonnieDangerLvl.Size = new System.Drawing.Size(42, 46);
            this.lblBonnieDangerLvl.TabIndex = 3;
            this.lblBonnieDangerLvl.Text = "0";
            // 
            // lblChicaDangerLvl
            // 
            this.lblChicaDangerLvl.AutoSize = true;
            this.lblChicaDangerLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChicaDangerLvl.Location = new System.Drawing.Point(1790, 163);
            this.lblChicaDangerLvl.Name = "lblChicaDangerLvl";
            this.lblChicaDangerLvl.Size = new System.Drawing.Size(42, 46);
            this.lblChicaDangerLvl.TabIndex = 4;
            this.lblChicaDangerLvl.Text = "0";
            // 
            // lblEnergia
            // 
            this.lblEnergia.AutoSize = true;
            this.lblEnergia.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergia.Location = new System.Drawing.Point(1756, 973);
            this.lblEnergia.Name = "lblEnergia";
            this.lblEnergia.Size = new System.Drawing.Size(121, 46);
            this.lblEnergia.TabIndex = 5;
            this.lblEnergia.Text = "100%";
            // 
            // Puertas
            // 
            this.Puertas.Tick += new System.EventHandler(this.Puertas_Tick);
            // 
            // lblindicacion
            // 
            this.lblindicacion.AutoSize = true;
            this.lblindicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblindicacion.Location = new System.Drawing.Point(725, 75);
            this.lblindicacion.Name = "lblindicacion";
            this.lblindicacion.Size = new System.Drawing.Size(473, 31);
            this.lblindicacion.TabIndex = 7;
            this.lblindicacion.Text = "No dejes que los numeros lleguen a 6!";
            // 
            // lblIndicacion2
            // 
            this.lblIndicacion2.AutoSize = true;
            this.lblIndicacion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndicacion2.Location = new System.Drawing.Point(844, 123);
            this.lblIndicacion2.Name = "lblIndicacion2";
            this.lblIndicacion2.Size = new System.Drawing.Size(236, 31);
            this.lblIndicacion2.TabIndex = 8;
            this.lblIndicacion2.Text = "Cierra las puertas!";
            // 
            // pbxScreamer
            // 
            this.pbxScreamer.BackgroundImage = global::Imagensita.Properties.Resources.tuff;
            this.pbxScreamer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxScreamer.Location = new System.Drawing.Point(12, 12);
            this.pbxScreamer.Name = "pbxScreamer";
            this.pbxScreamer.Size = new System.Drawing.Size(1880, 994);
            this.pbxScreamer.TabIndex = 6;
            this.pbxScreamer.TabStop = false;
            this.pbxScreamer.Visible = false;
            // 
            // pbxTenedor
            // 
            this.pbxTenedor.BackgroundImage = global::Imagensita.Properties.Resources.tenedor;
            this.pbxTenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxTenedor.Location = new System.Drawing.Point(1342, 351);
            this.pbxTenedor.Name = "pbxTenedor";
            this.pbxTenedor.Size = new System.Drawing.Size(100, 85);
            this.pbxTenedor.TabIndex = 9;
            this.pbxTenedor.TabStop = false;
            this.pbxTenedor.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pbxTenedor);
            this.Controls.Add(this.pbxScreamer);
            this.Controls.Add(this.lblIndicacion2);
            this.Controls.Add(this.lblindicacion);
            this.Controls.Add(this.lblEnergia);
            this.Controls.Add(this.lblChicaDangerLvl);
            this.Controls.Add(this.lblBonnieDangerLvl);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnRPuerta);
            this.Controls.Add(this.btnLPuerta);
            this.Name = "Form1";
            this.Text = "Hola";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbxScreamer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTenedor)).EndInit();
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
        private System.Windows.Forms.Label lblEnergia;
        private System.Windows.Forms.Timer Puertas;
        private System.Windows.Forms.PictureBox pbxScreamer;
        private System.Windows.Forms.Label lblindicacion;
        private System.Windows.Forms.Label lblIndicacion2;
        private System.Windows.Forms.PictureBox pbxTenedor;
    }
}

