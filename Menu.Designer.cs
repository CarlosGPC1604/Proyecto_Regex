﻿namespace Proyecto_Regex
{
    partial class Menu
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
            this.bttLimpiar = new System.Windows.Forms.Button();
            this.comboBoxEjercicios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txbCadenaAEvaluar = new System.Windows.Forms.TextBox();
            this.rbValido = new System.Windows.Forms.RadioButton();
            this.bttCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttLimpiar
            // 
            this.bttLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.bttLimpiar.FlatAppearance.BorderSize = 2;
            this.bttLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLimpiar.ForeColor = System.Drawing.Color.White;
            this.bttLimpiar.Location = new System.Drawing.Point(90, 395);
            this.bttLimpiar.Name = "bttLimpiar";
            this.bttLimpiar.Size = new System.Drawing.Size(202, 49);
            this.bttLimpiar.TabIndex = 0;
            this.bttLimpiar.Text = "Limpiar";
            this.bttLimpiar.UseVisualStyleBackColor = true;
            this.bttLimpiar.Click += new System.EventHandler(this.bttLimpiar_Click);
            // 
            // comboBoxEjercicios
            // 
            this.comboBoxEjercicios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEjercicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEjercicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.comboBoxEjercicios.FormattingEnabled = true;
            this.comboBoxEjercicios.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.comboBoxEjercicios.Location = new System.Drawing.Point(86, 109);
            this.comboBoxEjercicios.Name = "comboBoxEjercicios";
            this.comboBoxEjercicios.Size = new System.Drawing.Size(287, 30);
            this.comboBoxEjercicios.TabIndex = 1;
            this.comboBoxEjercicios.SelectedIndexChanged += new System.EventHandler(this.comboBoxEjercicios_SelectedIndexChanged);
            this.comboBoxEjercicios.SelectedValueChanged += new System.EventHandler(this.comboBoxEjercicios_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(86, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ejercicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(86, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.lblDescripcion.Location = new System.Drawing.Point(86, 199);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(649, 88);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Esperando selección...";
            // 
            // txbCadenaAEvaluar
            // 
            this.txbCadenaAEvaluar.Enabled = false;
            this.txbCadenaAEvaluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txbCadenaAEvaluar.Location = new System.Drawing.Point(90, 330);
            this.txbCadenaAEvaluar.Name = "txbCadenaAEvaluar";
            this.txbCadenaAEvaluar.Size = new System.Drawing.Size(435, 28);
            this.txbCadenaAEvaluar.TabIndex = 3;
            this.txbCadenaAEvaluar.TextChanged += new System.EventHandler(this.txbCadenaAEvaluar_TextChanged);
            // 
            // rbValido
            // 
            this.rbValido.AutoCheck = false;
            this.rbValido.AutoSize = true;
            this.rbValido.Checked = true;
            this.rbValido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.rbValido.ForeColor = System.Drawing.Color.Yellow;
            this.rbValido.Location = new System.Drawing.Point(559, 330);
            this.rbValido.Name = "rbValido";
            this.rbValido.Size = new System.Drawing.Size(199, 29);
            this.rbValido.TabIndex = 4;
            this.rbValido.TabStop = true;
            this.rbValido.Text = "Esperando entrada";
            this.rbValido.UseVisualStyleBackColor = true;
            // 
            // bttCerrar
            // 
            this.bttCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(63)))), ((int)(((byte)(102)))));
            this.bttCerrar.FlatAppearance.BorderSize = 2;
            this.bttCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCerrar.ForeColor = System.Drawing.Color.White;
            this.bttCerrar.Location = new System.Drawing.Point(759, 22);
            this.bttCerrar.Name = "bttCerrar";
            this.bttCerrar.Size = new System.Drawing.Size(49, 49);
            this.bttCerrar.TabIndex = 0;
            this.bttCerrar.Text = "X";
            this.bttCerrar.UseVisualStyleBackColor = true;
            this.bttCerrar.Click += new System.EventHandler(this.bttCerrar_Click);
            // 
            // Menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(820, 490);
            this.ControlBox = false;
            this.Controls.Add(this.rbValido);
            this.Controls.Add(this.txbCadenaAEvaluar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEjercicios);
            this.Controls.Add(this.bttCerrar);
            this.Controls.Add(this.bttLimpiar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Inicial";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttLimpiar;
        private System.Windows.Forms.ComboBox comboBoxEjercicios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txbCadenaAEvaluar;
        private System.Windows.Forms.RadioButton rbValido;
        private System.Windows.Forms.Button bttCerrar;
    }
}

