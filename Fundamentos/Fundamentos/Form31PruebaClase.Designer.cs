namespace Fundamentos
{
	partial class Form31PruebaClase
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
			this.btnCrear = new System.Windows.Forms.Button();
			this.listPerona = new System.Windows.Forms.ListBox();
			this.btnEmpleado = new System.Windows.Forms.Button();
			this.btnCrearEjecutivo = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCrear
			// 
			this.btnCrear.Location = new System.Drawing.Point(12, 12);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(157, 44);
			this.btnCrear.TabIndex = 0;
			this.btnCrear.Text = "Crear persona";
			this.btnCrear.UseVisualStyleBackColor = true;
			this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// listPerona
			// 
			this.listPerona.FormattingEnabled = true;
			this.listPerona.Location = new System.Drawing.Point(12, 62);
			this.listPerona.Name = "listPerona";
			this.listPerona.Size = new System.Drawing.Size(157, 160);
			this.listPerona.TabIndex = 1;
			// 
			// btnEmpleado
			// 
			this.btnEmpleado.Location = new System.Drawing.Point(175, 12);
			this.btnEmpleado.Name = "btnEmpleado";
			this.btnEmpleado.Size = new System.Drawing.Size(106, 44);
			this.btnEmpleado.TabIndex = 2;
			this.btnEmpleado.Text = "Crear empleado";
			this.btnEmpleado.UseVisualStyleBackColor = true;
			this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
			// 
			// btnCrearEjecutivo
			// 
			this.btnCrearEjecutivo.Location = new System.Drawing.Point(175, 62);
			this.btnCrearEjecutivo.Name = "btnCrearEjecutivo";
			this.btnCrearEjecutivo.Size = new System.Drawing.Size(106, 44);
			this.btnCrearEjecutivo.TabIndex = 3;
			this.btnCrearEjecutivo.Text = "Crear Ejecutivo";
			this.btnCrearEjecutivo.UseVisualStyleBackColor = true;
			this.btnCrearEjecutivo.Click += new System.EventHandler(this.btnCrearEjecutivo_Click);
			// 
			// Form31PruebaClase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(293, 240);
			this.Controls.Add(this.btnCrearEjecutivo);
			this.Controls.Add(this.btnEmpleado);
			this.Controls.Add(this.listPerona);
			this.Controls.Add(this.btnCrear);
			this.Name = "Form31PruebaClase";
			this.Text = "Form31PruebaClase";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCrear;
		private System.Windows.Forms.ListBox listPerona;
		private System.Windows.Forms.Button btnEmpleado;
		private System.Windows.Forms.Button btnCrearEjecutivo;
	}
}