﻿namespace Fundamentos
{
	partial class Form38Serialize
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
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtApellidos = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnLeer = new System.Windows.Forms.Button();
			this.lblMensaje = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(12, 25);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 1;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(12, 144);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(100, 23);
			this.btnGuardar.TabIndex = 2;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// txtApellidos
			// 
			this.txtApellidos.Location = new System.Drawing.Point(12, 71);
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.Size = new System.Drawing.Size(100, 20);
			this.txtApellidos.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Apellidos";
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(12, 118);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(100, 20);
			this.txtEdad.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Edad";
			// 
			// btnLeer
			// 
			this.btnLeer.Location = new System.Drawing.Point(12, 173);
			this.btnLeer.Name = "btnLeer";
			this.btnLeer.Size = new System.Drawing.Size(100, 23);
			this.btnLeer.TabIndex = 7;
			this.btnLeer.Text = "Leer";
			this.btnLeer.UseVisualStyleBackColor = true;
			this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
			// 
			// lblMensaje
			// 
			this.lblMensaje.AutoSize = true;
			this.lblMensaje.Location = new System.Drawing.Point(12, 200);
			this.lblMensaje.Name = "lblMensaje";
			this.lblMensaje.Size = new System.Drawing.Size(57, 13);
			this.lblMensaje.TabIndex = 8;
			this.lblMensaje.Text = "lblMensaje";
			// 
			// Form38Serialize
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(120, 222);
			this.Controls.Add(this.lblMensaje);
			this.Controls.Add(this.btnLeer);
			this.Controls.Add(this.txtEdad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtApellidos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label1);
			this.Name = "Form38Serialize";
			this.Text = "Form38Serialize";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtApellidos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnLeer;
		private System.Windows.Forms.Label lblMensaje;
	}
}