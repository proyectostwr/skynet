
namespace PROYECTO_2_DABD_1249321_SKYNET_WAREHOUSE
{
    partial class VentanaAutomatica
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
            this.numericUpDown1A = new System.Windows.Forms.NumericUpDown();
            this.comboBox3A = new System.Windows.Forms.ComboBox();
            this.comboBox2A = new System.Windows.Forms.ComboBox();
            this.label4A = new System.Windows.Forms.Label();
            this.label3A = new System.Windows.Forms.Label();
            this.BTNIniciarAutomatico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1A)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(121, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 86);
            this.label1.TabIndex = 2;
            this.label1.Text = "¡Benvenido!\r\nEscoge la Configuración que deseas:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown1A
            // 
            this.numericUpDown1A.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1A.Location = new System.Drawing.Point(366, 234);
            this.numericUpDown1A.Name = "numericUpDown1A";
            this.numericUpDown1A.Size = new System.Drawing.Size(56, 31);
            this.numericUpDown1A.TabIndex = 16;
            // 
            // comboBox3A
            // 
            this.comboBox3A.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3A.FormattingEnabled = true;
            this.comboBox3A.Location = new System.Drawing.Point(428, 234);
            this.comboBox3A.Name = "comboBox3A";
            this.comboBox3A.Size = new System.Drawing.Size(80, 31);
            this.comboBox3A.TabIndex = 15;
            // 
            // comboBox2A
            // 
            this.comboBox2A.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2A.FormattingEnabled = true;
            this.comboBox2A.Location = new System.Drawing.Point(370, 175);
            this.comboBox2A.Name = "comboBox2A";
            this.comboBox2A.Size = new System.Drawing.Size(362, 31);
            this.comboBox2A.TabIndex = 14;
            // 
            // label4A
            // 
            this.label4A.AutoSize = true;
            this.label4A.BackColor = System.Drawing.Color.Gold;
            this.label4A.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4A.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4A.Location = new System.Drawing.Point(44, 226);
            this.label4A.Name = "label4A";
            this.label4A.Size = new System.Drawing.Size(217, 29);
            this.label4A.TabIndex = 13;
            this.label4A.Text = "Unidades de Material";
            this.label4A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3A
            // 
            this.label3A.AutoSize = true;
            this.label3A.BackColor = System.Drawing.Color.Gold;
            this.label3A.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3A.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3A.Location = new System.Drawing.Point(44, 176);
            this.label3A.Name = "label3A";
            this.label3A.Size = new System.Drawing.Size(172, 29);
            this.label3A.TabIndex = 12;
            this.label3A.Text = "Tipo de Material:";
            this.label3A.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTNIniciarAutomatico
            // 
            this.BTNIniciarAutomatico.BackColor = System.Drawing.Color.DarkOrange;
            this.BTNIniciarAutomatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNIniciarAutomatico.Location = new System.Drawing.Point(354, 316);
            this.BTNIniciarAutomatico.Name = "BTNIniciarAutomatico";
            this.BTNIniciarAutomatico.Size = new System.Drawing.Size(182, 85);
            this.BTNIniciarAutomatico.TabIndex = 17;
            this.BTNIniciarAutomatico.Text = "¡INICIAR!";
            this.BTNIniciarAutomatico.UseVisualStyleBackColor = false;
            // 
            // VentanaAutomatica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYECTO_2_DABD_1249321_SKYNET_WAREHOUSE.Properties.Resources.SKYNET_automatico;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.BTNIniciarAutomatico);
            this.Controls.Add(this.numericUpDown1A);
            this.Controls.Add(this.comboBox3A);
            this.Controls.Add(this.comboBox2A);
            this.Controls.Add(this.label4A);
            this.Controls.Add(this.label3A);
            this.Controls.Add(this.label1);
            this.Name = "VentanaAutomatica";
            this.Text = "VentanaAutomatica";
            this.Load += new System.EventHandler(this.VentanaAutomatica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1A)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1A;
        private System.Windows.Forms.ComboBox comboBox3A;
        private System.Windows.Forms.ComboBox comboBox2A;
        private System.Windows.Forms.Label label4A;
        private System.Windows.Forms.Label label3A;
        private System.Windows.Forms.Button BTNIniciarAutomatico;
    }
}