﻿namespace Compilador2
{
    partial class Form1
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
            this.FlowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Cargar = new System.Windows.Forms.Button();
            this.Compilar = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.ListBox7 = new System.Windows.Forms.ListBox();
            this.ListBox6 = new System.Windows.Forms.ListBox();
            this.ListBox5 = new System.Windows.Forms.ListBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ListBox4 = new System.Windows.Forms.ListBox();
            this.ListBox3 = new System.Windows.Forms.ListBox();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.ListBox2 = new System.Windows.Forms.ListBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowLayoutPanel1
            // 
            this.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FlowLayoutPanel1.Controls.Add(this.Cargar);
            this.FlowLayoutPanel1.Controls.Add(this.Compilar);
            this.FlowLayoutPanel1.Controls.Add(this.Button1);
            this.FlowLayoutPanel1.Controls.Add(this.button2);
            this.FlowLayoutPanel1.Location = new System.Drawing.Point(711, 59);
            this.FlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            this.FlowLayoutPanel1.Size = new System.Drawing.Size(68, 211);
            this.FlowLayoutPanel1.TabIndex = 36;
            // 
            // Cargar
            // 
            this.Cargar.BackColor = System.Drawing.Color.Black;
            this.Cargar.BackgroundImage = global::Compilador2.Properties.Resources.cargar;
            this.Cargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cargar.ForeColor = System.Drawing.Color.Black;
            this.Cargar.Location = new System.Drawing.Point(3, 3);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(52, 46);
            this.Cargar.TabIndex = 7;
            this.Cargar.UseVisualStyleBackColor = false;
            this.Cargar.Click += new System.EventHandler(this.Cargar_Click);
            // 
            // Compilar
            // 
            this.Compilar.BackColor = System.Drawing.Color.Black;
            this.Compilar.BackgroundImage = global::Compilador2.Properties.Resources.compilar;
            this.Compilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Compilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Compilar.Location = new System.Drawing.Point(3, 55);
            this.Compilar.Name = "Compilar";
            this.Compilar.Size = new System.Drawing.Size(52, 48);
            this.Compilar.TabIndex = 8;
            this.Compilar.UseVisualStyleBackColor = false;
            this.Compilar.Click += new System.EventHandler(this.Compilar_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.BackgroundImage = global::Compilador2.Properties.Resources.basura;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Location = new System.Drawing.Point(2, 108);
            this.Button1.Margin = new System.Windows.Forms.Padding(2);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(64, 48);
            this.Button1.TabIndex = 21;
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(2, 160);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 48);
            this.button2.TabIndex = 38;
            this.button2.Text = "Log";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.White;
            this.Label9.Location = new System.Drawing.Point(58, 335);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(103, 14);
            this.Label9.TabIndex = 35;
            this.Label9.Text = "Archivo de Salida";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(654, 335);
            this.Label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(79, 14);
            this.Label7.TabIndex = 34;
            this.Label7.Text = "Cntes. Reales";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(507, 335);
            this.Label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(78, 14);
            this.Label6.TabIndex = 33;
            this.Label6.Text = "Ctes. Enteras";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Location = new System.Drawing.Point(207, 335);
            this.Label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(46, 14);
            this.Label5.TabIndex = 32;
            this.Label5.Text = "Strings";
            // 
            // ListBox7
            // 
            this.ListBox7.FormattingEnabled = true;
            this.ListBox7.Location = new System.Drawing.Point(657, 367);
            this.ListBox7.Name = "ListBox7";
            this.ListBox7.Size = new System.Drawing.Size(120, 238);
            this.ListBox7.TabIndex = 31;
            // 
            // ListBox6
            // 
            this.ListBox6.FormattingEnabled = true;
            this.ListBox6.Location = new System.Drawing.Point(503, 367);
            this.ListBox6.Name = "ListBox6";
            this.ListBox6.Size = new System.Drawing.Size(120, 238);
            this.ListBox6.TabIndex = 30;
            // 
            // ListBox5
            // 
            this.ListBox5.FormattingEnabled = true;
            this.ListBox5.Location = new System.Drawing.Point(206, 367);
            this.ListBox5.Name = "ListBox5";
            this.ListBox5.Size = new System.Drawing.Size(120, 238);
            this.ListBox5.TabIndex = 29;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(353, 335);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(91, 14);
            this.Label2.TabIndex = 28;
            this.Label2.Text = "Identificadores";
            // 
            // ListBox4
            // 
            this.ListBox4.FormattingEnabled = true;
            this.ListBox4.Location = new System.Drawing.Point(356, 367);
            this.ListBox4.Name = "ListBox4";
            this.ListBox4.Size = new System.Drawing.Size(120, 238);
            this.ListBox4.TabIndex = 27;
            // 
            // ListBox3
            // 
            this.ListBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox3.FormattingEnabled = true;
            this.ListBox3.Location = new System.Drawing.Point(472, 59);
            this.ListBox3.Name = "ListBox3";
            this.ListBox3.Size = new System.Drawing.Size(177, 238);
            this.ListBox3.TabIndex = 26;
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.HorizontalScrollbar = true;
            this.ListBox1.Location = new System.Drawing.Point(52, 59);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(351, 238);
            this.ListBox1.TabIndex = 25;
            // 
            // ListBox2
            // 
            this.ListBox2.FormattingEnabled = true;
            this.ListBox2.Location = new System.Drawing.Point(56, 367);
            this.ListBox2.Name = "ListBox2";
            this.ListBox2.Size = new System.Drawing.Size(120, 238);
            this.ListBox2.TabIndex = 24;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(187, 9);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(243, 37);
            this.Label8.TabIndex = 37;
            this.Label8.Text = "COMPILADOR:  ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Compilador2.Properties.Resources.Negro;
            this.ClientSize = new System.Drawing.Size(831, 664);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.FlowLayoutPanel1);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.ListBox7);
            this.Controls.Add(this.ListBox6);
            this.Controls.Add(this.ListBox5);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.ListBox4);
            this.Controls.Add(this.ListBox3);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.ListBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FlowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel1;
        internal System.Windows.Forms.Button Cargar;
        internal System.Windows.Forms.Button Compilar;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ListBox ListBox7;
        internal System.Windows.Forms.ListBox ListBox6;
        internal System.Windows.Forms.ListBox ListBox5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ListBox ListBox4;
        internal System.Windows.Forms.ListBox ListBox3;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.ListBox ListBox2;
        internal System.Windows.Forms.Label Label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Button button2;
    }
}

