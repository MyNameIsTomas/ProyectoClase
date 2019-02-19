namespace Fundamentos
{
	partial class Form38Serializacion
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
			this.textNombre = new System.Windows.Forms.TextBox();
			this.textApellidos = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textEdad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnLeer = new System.Windows.Forms.Button();
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
			// textNombre
			// 
			this.textNombre.Location = new System.Drawing.Point(15, 25);
			this.textNombre.Name = "textNombre";
			this.textNombre.Size = new System.Drawing.Size(100, 20);
			this.textNombre.TabIndex = 1;
			// 
			// textApellidos
			// 
			this.textApellidos.Location = new System.Drawing.Point(15, 68);
			this.textApellidos.Name = "textApellidos";
			this.textApellidos.Size = new System.Drawing.Size(100, 20);
			this.textApellidos.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Apellidos";
			// 
			// textEdad
			// 
			this.textEdad.Location = new System.Drawing.Point(15, 111);
			this.textEdad.Name = "textEdad";
			this.textEdad.Size = new System.Drawing.Size(100, 20);
			this.textEdad.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Edad";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(15, 137);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(100, 23);
			this.btnGuardar.TabIndex = 6;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			// 
			// btnLeer
			// 
			this.btnLeer.Location = new System.Drawing.Point(15, 166);
			this.btnLeer.Name = "btnLeer";
			this.btnLeer.Size = new System.Drawing.Size(100, 23);
			this.btnLeer.TabIndex = 7;
			this.btnLeer.Text = "Leer";
			this.btnLeer.UseVisualStyleBackColor = true;
			// 
			// Form38Serializacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(130, 206);
			this.Controls.Add(this.btnLeer);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.textEdad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textApellidos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textNombre);
			this.Controls.Add(this.label1);
			this.Name = "Form38Serializacion";
			this.Text = "Form38Serializacion";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textNombre;
		private System.Windows.Forms.TextBox textApellidos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textEdad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnLeer;
	}
}