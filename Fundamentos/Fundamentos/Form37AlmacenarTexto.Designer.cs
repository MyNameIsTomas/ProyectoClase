namespace Fundamentos
{
	partial class Form37AlmacenarTexto
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
			this.btnInsertar = new System.Windows.Forms.Button();
			this.listPersonas = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtApellidos = new System.Windows.Forms.TextBox();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnLeer = new System.Windows.Forms.Button();
			this.lblMensaje = new System.Windows.Forms.Label();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(72, 6);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(131, 20);
			this.txtNombre.TabIndex = 1;
			// 
			// btnInsertar
			// 
			this.btnInsertar.Location = new System.Drawing.Point(15, 106);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(188, 51);
			this.btnInsertar.TabIndex = 2;
			this.btnInsertar.Text = "Insertar persona";
			this.btnInsertar.UseVisualStyleBackColor = true;
			this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
			// 
			// listPersonas
			// 
			this.listPersonas.FormattingEnabled = true;
			this.listPersonas.Location = new System.Drawing.Point(209, 5);
			this.listPersonas.Name = "listPersonas";
			this.listPersonas.Size = new System.Drawing.Size(203, 303);
			this.listPersonas.TabIndex = 3;
			this.listPersonas.SelectedIndexChanged += new System.EventHandler(this.listPersonas_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Apellidos:";
			// 
			// txtApellidos
			// 
			this.txtApellidos.Location = new System.Drawing.Point(72, 44);
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.Size = new System.Drawing.Size(131, 20);
			this.txtApellidos.TabIndex = 5;
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(72, 80);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(131, 20);
			this.txtEdad.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Edad:";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(15, 163);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(188, 51);
			this.btnGuardar.TabIndex = 8;
			this.btnGuardar.Text = "Guardar personas";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnLeer
			// 
			this.btnLeer.Location = new System.Drawing.Point(15, 220);
			this.btnLeer.Name = "btnLeer";
			this.btnLeer.Size = new System.Drawing.Size(188, 51);
			this.btnLeer.TabIndex = 9;
			this.btnLeer.Text = "Leer personas";
			this.btnLeer.UseVisualStyleBackColor = true;
			this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
			// 
			// lblMensaje
			// 
			this.lblMensaje.AutoSize = true;
			this.lblMensaje.Location = new System.Drawing.Point(12, 295);
			this.lblMensaje.Name = "lblMensaje";
			this.lblMensaje.Size = new System.Drawing.Size(57, 13);
			this.lblMensaje.TabIndex = 10;
			this.lblMensaje.Text = "lblMensaje";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form37AlmacenarTexto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(422, 316);
			this.Controls.Add(this.lblMensaje);
			this.Controls.Add(this.btnLeer);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.txtEdad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtApellidos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listPersonas);
			this.Controls.Add(this.btnInsertar);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label1);
			this.Name = "Form37AlmacenarTexto";
			this.Text = "Form37AlmacenarTexto";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnInsertar;
		private System.Windows.Forms.ListBox listPersonas;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtApellidos;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnLeer;
		private System.Windows.Forms.Label lblMensaje;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}