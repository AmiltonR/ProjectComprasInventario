﻿
namespace ProjectComprasInventario.Views
{
    partial class frmSeleccionarSuministro
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
            this.txtSuministro = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvSuministros = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuministros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suministro";
            // 
            // txtSuministro
            // 
            this.txtSuministro.Location = new System.Drawing.Point(157, 81);
            this.txtSuministro.Name = "txtSuministro";
            this.txtSuministro.Size = new System.Drawing.Size(333, 20);
            this.txtSuministro.TabIndex = 1;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(506, 79);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvSuministros
            // 
            this.dgvSuministros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuministros.Location = new System.Drawing.Point(87, 143);
            this.dgvSuministros.Name = "dgvSuministros";
            this.dgvSuministros.Size = new System.Drawing.Size(678, 443);
            this.dgvSuministros.TabIndex = 3;
            this.dgvSuministros.DoubleClick += new System.EventHandler(this.dgvSuministros_DoubleClick);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(756, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 38);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmSeleccionarSuministro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 628);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvSuministros);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtSuministro);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSeleccionarSuministro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSeleccionarSuministro";
            this.Load += new System.EventHandler(this.frmSeleccionarSuministro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuministros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSuministro;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.DataGridView dgvSuministros;
        private System.Windows.Forms.Button btnCerrar;
    }
}