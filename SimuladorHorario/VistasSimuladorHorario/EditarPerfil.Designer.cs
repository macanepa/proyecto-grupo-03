﻿namespace VistasSimuladorHorario
{
    partial class eliminarCursoButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eliminarCursoButton));
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.NEstudianteActivoTB = new System.Windows.Forms.TextBox();
            this.CEstudianteActivoTB = new System.Windows.Forms.TextBox();
            this.contraseñaLabel = new System.Windows.Forms.Label();
            this.cursosInscritosComboBox = new System.Windows.Forms.ComboBox();
            this.cursosInscritosLabel = new System.Windows.Forms.Label();
            this.avanceMallaLabel = new System.Windows.Forms.Label();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.limpiarCursosButton = new System.Windows.Forms.Button();
            this.AvanceMallaLB = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Location = new System.Drawing.Point(75, 37);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(46, 13);
            this.usuarioLabel.TabIndex = 0;
            this.usuarioLabel.Text = "Usuario:";
            this.usuarioLabel.Click += new System.EventHandler(this.usuarioLabel_Click);
            // 
            // textBox1
            // 
            this.NEstudianteActivoTB.Location = new System.Drawing.Point(78, 53);
            this.NEstudianteActivoTB.Name = "textBox1";
            this.NEstudianteActivoTB.Size = new System.Drawing.Size(141, 20);
            this.NEstudianteActivoTB.TabIndex = 1;
            // 
            // textBox2
            // 
            this.CEstudianteActivoTB.Location = new System.Drawing.Point(78, 109);
            this.CEstudianteActivoTB.Name = "textBox2";
            this.CEstudianteActivoTB.Size = new System.Drawing.Size(141, 20);
            this.CEstudianteActivoTB.TabIndex = 3;
            this.CEstudianteActivoTB.UseSystemPasswordChar = true;
            // 
            // contraseñaLabel
            // 
            this.contraseñaLabel.AutoSize = true;
            this.contraseñaLabel.Location = new System.Drawing.Point(75, 93);
            this.contraseñaLabel.Name = "contraseñaLabel";
            this.contraseñaLabel.Size = new System.Drawing.Size(64, 13);
            this.contraseñaLabel.TabIndex = 2;
            this.contraseñaLabel.Text = "Contraseña:";
            // 
            // cursosInscritosComboBox
            // 
            this.cursosInscritosComboBox.FormattingEnabled = true;
            this.cursosInscritosComboBox.Location = new System.Drawing.Point(78, 176);
            this.cursosInscritosComboBox.Name = "cursosInscritosComboBox";
            this.cursosInscritosComboBox.Size = new System.Drawing.Size(250, 21);
            this.cursosInscritosComboBox.TabIndex = 5;
            this.cursosInscritosComboBox.SelectedIndexChanged += new System.EventHandler(this.cursosInscritosComboBox_SelectedIndexChanged);
            // 
            // cursosInscritosLabel
            // 
            this.cursosInscritosLabel.AutoSize = true;
            this.cursosInscritosLabel.Location = new System.Drawing.Point(75, 160);
            this.cursosInscritosLabel.Name = "cursosInscritosLabel";
            this.cursosInscritosLabel.Size = new System.Drawing.Size(84, 13);
            this.cursosInscritosLabel.TabIndex = 6;
            this.cursosInscritosLabel.Text = "Cursos Inscritos:";
            this.cursosInscritosLabel.Click += new System.EventHandler(this.cursosInscritosLabel_Click);
            // 
            // avanceMallaLabel
            // 
            this.avanceMallaLabel.AutoSize = true;
            this.avanceMallaLabel.Location = new System.Drawing.Point(395, 36);
            this.avanceMallaLabel.Name = "avanceMallaLabel";
            this.avanceMallaLabel.Size = new System.Drawing.Size(75, 13);
            this.avanceMallaLabel.TabIndex = 7;
            this.avanceMallaLabel.Text = "Avance Malla:";
            // 
            // GuardarButton
            // 
            this.GuardarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GuardarButton.Location = new System.Drawing.Point(591, 224);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 8;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // limpiarCursosButton
            // 
            this.limpiarCursosButton.Location = new System.Drawing.Point(78, 203);
            this.limpiarCursosButton.Name = "limpiarCursosButton";
            this.limpiarCursosButton.Size = new System.Drawing.Size(169, 23);
            this.limpiarCursosButton.TabIndex = 11;
            this.limpiarCursosButton.Text = "Limpiar Cursos";
            this.limpiarCursosButton.UseVisualStyleBackColor = true;
            this.limpiarCursosButton.Click += new System.EventHandler(this.limpiarCursosButton_Click);
            // 
            // listBox1
            // 
            this.AvanceMallaLB.FormattingEnabled = true;
            this.AvanceMallaLB.Location = new System.Drawing.Point(398, 53);
            this.AvanceMallaLB.Name = "listBox1";
            this.AvanceMallaLB.Size = new System.Drawing.Size(233, 134);
            this.AvanceMallaLB.TabIndex = 12;
            this.AvanceMallaLB.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(225, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 20);
            this.button2.TabIndex = 13;
            this.button2.Text = "Editar Nombre";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(225, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 20);
            this.button3.TabIndex = 14;
            this.button3.Text = "Editar Contraseña";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // eliminarCursoButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 259);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AvanceMallaLB);
            this.Controls.Add(this.limpiarCursosButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.avanceMallaLabel);
            this.Controls.Add(this.cursosInscritosLabel);
            this.Controls.Add(this.cursosInscritosComboBox);
            this.Controls.Add(this.CEstudianteActivoTB);
            this.Controls.Add(this.contraseñaLabel);
            this.Controls.Add(this.NEstudianteActivoTB);
            this.Controls.Add(this.usuarioLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "eliminarCursoButton";
            this.Text = "Mi Perfil";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditarPerfil_FormClosing);
            this.Load += new System.EventHandler(this.eliminarCursoButton_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.TextBox NEstudianteActivoTB;
        private System.Windows.Forms.TextBox CEstudianteActivoTB;
        private System.Windows.Forms.Label contraseñaLabel;
        private System.Windows.Forms.ComboBox cursosInscritosComboBox;
        private System.Windows.Forms.Label cursosInscritosLabel;
        private System.Windows.Forms.Label avanceMallaLabel;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button limpiarCursosButton;
        private System.Windows.Forms.ListBox AvanceMallaLB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}