﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimuladorHorario;

namespace VistasSimuladorHorario
{
    public class LoginController
    {
        LoginForm loginForm;
        public Usuario usuarioActivo = null;
        public LoginController(LoginForm loginForm)
        {
            this.loginForm = loginForm;
            this.loginForm.OnIniciarSesion += VistasLogin_OnIniciarSesion;
            this.loginForm.OnRegistro += VistasRegistro_OnRegistro;
        }

        private void VistasLogin_OnIniciarSesion(object sender, IniciarSesionEventArgs e)
        {
            usuarioActivo = null;
            usuarioActivo = e.usuario;
            if (usuarioActivo is Estudiante)
            {
                //Aplicacion.usuarios.Remove(usuarioActivo);
                PlataformaEstudianteForm plataformaEstudianteForm = new PlataformaEstudianteForm();
                PlataformaEstudianteController plataformaEstudianteController = new PlataformaEstudianteController(plataformaEstudianteForm,usuarioActivo);
                MessageBox.Show("Bienvenido estudiante: " + usuarioActivo.nombre);
                plataformaEstudianteForm.Show();
            }

            else if (e.usuario is Administrador)
            {
                GestorForm gestorForm = new GestorForm();
                GestorController gestorController = new GestorController(gestorForm);
                MessageBox.Show("Bienvenido administrador: "+ usuarioActivo.nombre);
                gestorForm.Show();
            }
            loginForm.Enabled = false;
        }

        private void VistasRegistro_OnRegistro(object sender, EventArgs e)
        {
            RegistrarseForm registrarseForm = new RegistrarseForm();
            RegistrarseController registrarseController = new RegistrarseController(registrarseForm);
            registrarseForm.Show();
            loginForm.Hide();
        }

    }
}
