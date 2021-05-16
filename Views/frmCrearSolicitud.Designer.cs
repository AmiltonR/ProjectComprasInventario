
namespace ProjectComprasInventario.Views
{
    partial class frmCrearSolicitud
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
            this.btnSeleccionarSuministro = new System.Windows.Forms.Button();
            this.btnGuardarSolicitud = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numupdownCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnMisSolicitudes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(55, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suministro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(56, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // txtSuministro
            // 
            this.txtSuministro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuministro.Enabled = false;
            this.txtSuministro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuministro.Location = new System.Drawing.Point(168, 102);
            this.txtSuministro.Name = "txtSuministro";
            this.txtSuministro.Size = new System.Drawing.Size(227, 22);
            this.txtSuministro.TabIndex = 2;
            // 
            // btnSeleccionarSuministro
            // 
            this.btnSeleccionarSuministro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.btnSeleccionarSuministro.FlatAppearance.BorderSize = 0;
            this.btnSeleccionarSuministro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarSuministro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarSuministro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSeleccionarSuministro.Location = new System.Drawing.Point(417, 101);
            this.btnSeleccionarSuministro.Name = "btnSeleccionarSuministro";
            this.btnSeleccionarSuministro.Size = new System.Drawing.Size(105, 23);
            this.btnSeleccionarSuministro.TabIndex = 4;
            this.btnSeleccionarSuministro.Text = "Seleccionar";
            this.btnSeleccionarSuministro.UseVisualStyleBackColor = false;
            this.btnSeleccionarSuministro.Click += new System.EventHandler(this.btnSeleccionarSuministro_Click);
            // 
            // btnGuardarSolicitud
            // 
            this.btnGuardarSolicitud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.btnGuardarSolicitud.FlatAppearance.BorderSize = 0;
            this.btnGuardarSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarSolicitud.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarSolicitud.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarSolicitud.Location = new System.Drawing.Point(738, 600);
            this.btnGuardarSolicitud.Name = "btnGuardarSolicitud";
            this.btnGuardarSolicitud.Size = new System.Drawing.Size(118, 46);
            this.btnGuardarSolicitud.TabIndex = 5;
            this.btnGuardarSolicitud.Text = "Solicitar";
            this.btnGuardarSolicitud.UseVisualStyleBackColor = false;
            this.btnGuardarSolicitud.Click += new System.EventHandler(this.btnGuardarSolicitud_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(48)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(55, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Crear Solicitud";
            // 
            // numupdownCantidad
            // 
            this.numupdownCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numupdownCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numupdownCantidad.Location = new System.Drawing.Point(168, 151);
            this.numupdownCantidad.Name = "numupdownCantidad";
            this.numupdownCantidad.Size = new System.Drawing.Size(227, 24);
            this.numupdownCantidad.TabIndex = 7;
            // 
            // btnMisSolicitudes
            // 
            this.btnMisSolicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(181)))), ((int)(((byte)(207)))));
            this.btnMisSolicitudes.FlatAppearance.BorderSize = 0;
            this.btnMisSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMisSolicitudes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMisSolicitudes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMisSolicitudes.Location = new System.Drawing.Point(874, 600);
            this.btnMisSolicitudes.Name = "btnMisSolicitudes";
            this.btnMisSolicitudes.Size = new System.Drawing.Size(149, 46);
            this.btnMisSolicitudes.TabIndex = 8;
            this.btnMisSolicitudes.Text = "Ver Mis Solicitudes";
            this.btnMisSolicitudes.UseVisualStyleBackColor = false;
            this.btnMisSolicitudes.Click += new System.EventHandler(this.btnMisSolicitudes_Click);
            // 
            // frmCrearSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1090, 696);
            this.Controls.Add(this.btnMisSolicitudes);
            this.Controls.Add(this.numupdownCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGuardarSolicitud);
            this.Controls.Add(this.btnSeleccionarSuministro);
            this.Controls.Add(this.txtSuministro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCrearSolicitud";
            this.Text = "frmCreearSolicitud";
            this.Load += new System.EventHandler(this.frmCrearSolicitud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numupdownCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeleccionarSuministro;
        private System.Windows.Forms.Button btnGuardarSolicitud;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtSuministro;
        private System.Windows.Forms.NumericUpDown numupdownCantidad;
        private System.Windows.Forms.Button btnMisSolicitudes;
    }
}