﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectComprasInventario.Controllers;

namespace ProjectComprasInventario.Views
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e){
            int confirmacion;
            String user = txtUsuario.Text;
            String pass = txtContra.Text;

            LoginController login = new LoginController();
            confirmacion = login.Login(user,pass);

            if (confirmacion==1)
            {
                lblInfo.Text = "Ingreso con éxito";
                frmMainMenu menu = new frmMainMenu();
                this.Hide();
                menu.Show();
            }
            else
            {
                lblInfo.Text = "Credenciales incorrectas";
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblInfo.Text = String.Empty;
            txtContra.PasswordChar='*';
        }
    }
}
