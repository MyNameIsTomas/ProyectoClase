namespace ProyectoADO.Conectado
{
	partial class Form07MensajeServidor
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
			this.textNumero = new System.Windows.Forms.TextBox();
			this.textNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textLocalidad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnInsertar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.listDepartamento = new System.Windows.Forms.ListBox();
			this.Departamento = new System.Windows.Forms.Label();
			this.lblMensajes = new System.Windows.Forms.Label();
			this.lblRegistros = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Número:";
			// 
			// textNumero
			// 
			this.textNumero.Location = new System.Drawing.Point(96, 2);
			this.textNumero.Name = "textNumero";
			this.textNumero.Size = new System.Drawing.Size(156, 20);
			this.textNumero.TabIndex = 1;
			// 
			// textNombre
			// 
			this.textNombre.Location = new System.Drawing.Point(96, 28);
			this.textNombre.Name = "textNombre";
			this.textNombre.Size = new System.Drawing.Size(156, 20);
			this.textNombre.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre:";
			// 
			// textLocalidad
			// 
			this.textLocalidad.Location = new System.Drawing.Point(96, 58);
			this.textLocalidad.Name = "textLocalidad";
			this.textLocalidad.Size = new System.Drawing.Size(156, 20);
			this.textLocalidad.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Localidad:";
			// 
			// btnInsertar
			// 
			this.btnInsertar.Location = new System.Drawing.Point(15, 84);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(75, 23);
			this.btnInsertar.TabIndex = 6;
			this.btnInsertar.Text = "Insertar";
			this.btnInsertar.UseVisualStyleBackColor = true;
			this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(96, 84);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(75, 23);
			this.btnModificar.TabIndex = 7;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(177, 84);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(75, 23);
			this.btnEliminar.TabIndex = 8;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// listDepartamento
			// 
			this.listDepartamento.FormattingEnabled = true;
			this.listDepartamento.Location = new System.Drawing.Point(15, 126);
			this.listDepartamento.Name = "listDepartamento";
			this.listDepartamento.Size = new System.Drawing.Size(237, 199);
			this.listDepartamento.TabIndex = 9;
			// 
			// Departamento
			// 
			this.Departamento.AutoSize = true;
			this.Departamento.Location = new System.Drawing.Point(12, 110);
			this.Departamento.Name = "Departamento";
			this.Departamento.Size = new System.Drawing.Size(74, 13);
			this.Departamento.TabIndex = 10;
			this.Departamento.Text = "Departamento";
			// 
			// lblMensajes
			// 
			this.lblMensajes.AutoSize = true;
			this.lblMensajes.Location = new System.Drawing.Point(12, 328);
			this.lblMensajes.Name = "lblMensajes";
			this.lblMensajes.Size = new System.Drawing.Size(62, 13);
			this.lblMensajes.TabIndex = 11;
			this.lblMensajes.Text = "lblMensajes";
			// 
			// lblRegistros
			// 
			this.lblRegistros.AutoSize = true;
			this.lblRegistros.Location = new System.Drawing.Point(12, 360);
			this.lblRegistros.Name = "lblRegistros";
			this.lblRegistros.Size = new System.Drawing.Size(61, 13);
			this.lblRegistros.TabIndex = 12;
			this.lblRegistros.Text = "lblRegistros";
			// 
			// Form07MensajeServidor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(267, 395);
			this.Controls.Add(this.lblRegistros);
			this.Controls.Add(this.lblMensajes);
			this.Controls.Add(this.Departamento);
			this.Controls.Add(this.listDepartamento);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnInsertar);
			this.Controls.Add(this.textLocalidad);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textNombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textNumero);
			this.Controls.Add(this.label1);
			this.Name = "Form07MensajeServidor";
			this.Text = "Form07MensajeServidor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textNumero;
		private System.Windows.Forms.TextBox textNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textLocalidad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnInsertar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.ListBox listDepartamento;
		private System.Windows.Forms.Label Departamento;
		private System.Windows.Forms.Label lblMensajes;
		private System.Windows.Forms.Label lblRegistros;
	}
}