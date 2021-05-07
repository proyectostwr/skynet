
namespace PROYECTO_2_DABD_1249321_SKYNET_WAREHOUSE
{
    partial class EscogerConfiguracion
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
            this.IrAManual = new System.Windows.Forms.Button();
            this.IrAautomatico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Benvenido!\r\nEscoge la Configuración que deseas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IrAManual
            // 
            this.IrAManual.BackColor = System.Drawing.Color.Orange;
            this.IrAManual.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IrAManual.Location = new System.Drawing.Point(78, 213);
            this.IrAManual.Name = "IrAManual";
            this.IrAManual.Size = new System.Drawing.Size(171, 50);
            this.IrAManual.TabIndex = 1;
            this.IrAManual.Text = "Manual";
            this.IrAManual.UseVisualStyleBackColor = false;
            this.IrAManual.Click += new System.EventHandler(this.IrAManual_Click);
            // 
            // IrAautomatico
            // 
            this.IrAautomatico.BackColor = System.Drawing.Color.LightSkyBlue;
            this.IrAautomatico.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IrAautomatico.Location = new System.Drawing.Point(311, 213);
            this.IrAautomatico.Name = "IrAautomatico";
            this.IrAautomatico.Size = new System.Drawing.Size(205, 50);
            this.IrAautomatico.TabIndex = 2;
            this.IrAautomatico.Text = "Automático";
            this.IrAautomatico.UseVisualStyleBackColor = false;
            this.IrAautomatico.Click += new System.EventHandler(this.IrAautomatico_Click);
            // 
            // EscogerConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO_2_DABD_1249321_SKYNET_WAREHOUSE.Properties.Resources.SKYNET_sleccion;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 305);
            this.Controls.Add(this.IrAautomatico);
            this.Controls.Add(this.IrAManual);
            this.Controls.Add(this.label1);
            this.Name = "EscogerConfiguracion";
            this.Text = "Escoger la Configuración";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button IrAManual;
        private System.Windows.Forms.Button IrAautomatico;
    }
}