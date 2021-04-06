
namespace ProjectComprasInventario.Views
{
    partial class frmCreearSolicitud
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSuministro = new System.Windows.Forms.TextBox();
            this.txtxCantidad = new System.Windows.Forms.TextBox();
            this.btnSeleccionarSuministro = new System.Windows.Forms.Button();
            this.btnGuardarSolicitud = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suministro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // txtSuministro
            // 
            this.txtSuministro.Location = new System.Drawing.Point(235, 200);
            this.txtSuministro.Name = "txtSuministro";
            this.txtSuministro.Size = new System.Drawing.Size(227, 20);
            this.txtSuministro.TabIndex = 2;
            // 
            // txtxCantidad
            // 
            this.txtxCantidad.Location = new System.Drawing.Point(235, 242);
            this.txtxCantidad.Name = "txtxCantidad";
            this.txtxCantidad.Size = new System.Drawing.Size(227, 20);
            this.txtxCantidad.TabIndex = 3;
            // 
            // btnSeleccionarSuministro
            // 
            this.btnSeleccionarSuministro.Location = new System.Drawing.Point(493, 197);
            this.btnSeleccionarSuministro.Name = "btnSeleccionarSuministro";
            this.btnSeleccionarSuministro.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionarSuministro.TabIndex = 4;
            this.btnSeleccionarSuministro.Text = "...";
            this.btnSeleccionarSuministro.UseVisualStyleBackColor = true;
            // 
            // btnGuardarSolicitud
            // 
            this.btnGuardarSolicitud.Location = new System.Drawing.Point(493, 314);
            this.btnGuardarSolicitud.Name = "btnGuardarSolicitud";
            this.btnGuardarSolicitud.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarSolicitud.TabIndex = 5;
            this.btnGuardarSolicitud.Text = "Solicitar";
            this.btnGuardarSolicitud.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Crear Solicitud";
            // 
            // frmCreearSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 696);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardarSolicitud);
            this.Controls.Add(this.btnSeleccionarSuministro);
            this.Controls.Add(this.txtxCantidad);
            this.Controls.Add(this.txtSuministro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreearSolicitud";
            this.Text = "frmCreearSolicitud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSuministro;
        private System.Windows.Forms.TextBox txtxCantidad;
        private System.Windows.Forms.Button btnSeleccionarSuministro;
        private System.Windows.Forms.Button btnGuardarSolicitud;
        private System.Windows.Forms.Label label3;
    }
}