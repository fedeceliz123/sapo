
namespace sapo
{
    partial class Sapo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sapo));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tbAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pbSapo = new System.Windows.Forms.PictureBox();
            this.pbAlto = new System.Windows.Forms.PictureBox();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lblMetros = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsubio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSapo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(86, 127);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(89, 30);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(181, 127);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 30);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tbAltura
            // 
            this.tbAltura.Location = new System.Drawing.Point(86, 86);
            this.tbAltura.Name = "tbAltura";
            this.tbAltura.Size = new System.Drawing.Size(197, 20);
            this.tbAltura.TabIndex = 0;
            this.tbAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAltura_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Introduzca los metros del pozo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total de dias en subir: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(203, 178);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(10, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "-";
            // 
            // pbSapo
            // 
            this.pbSapo.Image = ((System.Drawing.Image)(resources.GetObject("pbSapo.Image")));
            this.pbSapo.Location = new System.Drawing.Point(4, 410);
            this.pbSapo.Name = "pbSapo";
            this.pbSapo.Size = new System.Drawing.Size(85, 45);
            this.pbSapo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSapo.TabIndex = 6;
            this.pbSapo.TabStop = false;
            // 
            // pbAlto
            // 
            this.pbAlto.BackColor = System.Drawing.Color.Transparent;
            this.pbAlto.Image = ((System.Drawing.Image)(resources.GetObject("pbAlto.Image")));
            this.pbAlto.Location = new System.Drawing.Point(139, 36);
            this.pbAlto.Name = "pbAlto";
            this.pbAlto.Size = new System.Drawing.Size(71, 400);
            this.pbAlto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlto.TabIndex = 7;
            this.pbAlto.TabStop = false;
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Location = new System.Drawing.Point(109, 423);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(24, 13);
            this.lbl0.TabIndex = 8;
            this.lbl0.Text = "0 m";
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.Location = new System.Drawing.Point(109, 36);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(10, 13);
            this.lblMetros.TabIndex = 9;
            this.lblMetros.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblMetros);
            this.panel1.Controls.Add(this.lbl0);
            this.panel1.Controls.Add(this.pbSapo);
            this.panel1.Controls.Add(this.pbAlto);
            this.panel1.Location = new System.Drawing.Point(536, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 493);
            this.panel1.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "___Dia 0";
            // 
            // lblsubio
            // 
            this.lblsubio.AutoSize = true;
            this.lblsubio.Font = new System.Drawing.Font("Arial Narrow", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubio.ForeColor = System.Drawing.Color.Red;
            this.lblsubio.Location = new System.Drawing.Point(373, 40);
            this.lblsubio.Name = "lblsubio";
            this.lblsubio.Size = new System.Drawing.Size(157, 33);
            this.lblsubio.TabIndex = 11;
            this.lblsubio.Text = "Logro subir ";
            this.lblsubio.Visible = false;
            // 
            // Sapo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 576);
            this.Controls.Add(this.lblsubio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAltura);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Sapo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sapo";
            ((System.ComponentModel.ISupportInitialize)(this.pbSapo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox tbAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox pbSapo;
        private System.Windows.Forms.PictureBox pbAlto;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsubio;
    }
}

