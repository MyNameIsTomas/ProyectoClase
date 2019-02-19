namespace Fundamentos
{
	partial class Form39SerializacionPersonaje
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
			this.lblMensaje = new System.Windows.Forms.Label();
			this.btnLeer = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.txtEdad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtApellidos = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listPersonas = new System.Windows.Forms.ListBox();
			this.btnInsertar = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLimpiarColeccion = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.pictBoxImagen = new System.Windows.Forms.PictureBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictBoxImagen)).BeginInit();
			this.SuspendLayout();
			// 
			// lblMensaje
			// 
			this.lblMensaje.AutoSize = true;
			this.lblMensaje.Location = new System.Drawing.Point(210, 322);
			this.lblMensaje.Name = "lblMensaje";
			this.lblMensaje.Size = new System.Drawing.Size(57, 13);
			this.lblMensaje.TabIndex = 21;
			this.lblMensaje.Text = "lblMensaje";
			// 
			// btnLeer
			// 
			this.btnLeer.Location = new System.Drawing.Point(16, 227);
			this.btnLeer.Name = "btnLeer";
			this.btnLeer.Size = new System.Drawing.Size(188, 51);
			this.btnLeer.TabIndex = 20;
			this.btnLeer.Text = "Leer personas";
			this.btnLeer.UseVisualStyleBackColor = true;
			this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(16, 170);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(188, 51);
			this.btnGuardar.TabIndex = 19;
			this.btnGuardar.Text = "Guardar personas";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// txtEdad
			// 
			this.txtEdad.Location = new System.Drawing.Point(73, 87);
			this.txtEdad.Name = "txtEdad";
			this.txtEdad.Size = new System.Drawing.Size(131, 20);
			this.txtEdad.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 17;
			this.label3.Text = "Edad:";
			// 
			// txtApellidos
			// 
			this.txtApellidos.Location = new System.Drawing.Point(73, 51);
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.Size = new System.Drawing.Size(131, 20);
			this.txtApellidos.TabIndex = 16;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 15;
			this.label2.Text = "Apellidos:";
			// 
			// listPersonas
			// 
			this.listPersonas.FormattingEnabled = true;
			this.listPersonas.Location = new System.Drawing.Point(210, 12);
			this.listPersonas.Name = "listPersonas";
			this.listPersonas.Size = new System.Drawing.Size(203, 303);
			this.listPersonas.TabIndex = 14;
			this.listPersonas.SelectedIndexChanged += new System.EventHandler(this.listPersonas_SelectedIndexChanged);
			// 
			// btnInsertar
			// 
			this.btnInsertar.Location = new System.Drawing.Point(16, 113);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(188, 51);
			this.btnInsertar.TabIndex = 13;
			this.btnInsertar.Text = "Insertar persona";
			this.btnInsertar.UseVisualStyleBackColor = true;
			this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(73, 13);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(131, 20);
			this.txtNombre.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Nombre:";
			// 
			// btnLimpiarColeccion
			// 
			this.btnLimpiarColeccion.Location = new System.Drawing.Point(213, 348);
			this.btnLimpiarColeccion.Name = "btnLimpiarColeccion";
			this.btnLimpiarColeccion.Size = new System.Drawing.Size(200, 30);
			this.btnLimpiarColeccion.TabIndex = 22;
			this.btnLimpiarColeccion.Text = "Limpiar coleccion";
			this.btnLimpiarColeccion.UseVisualStyleBackColor = true;
			this.btnLimpiarColeccion.Click += new System.EventHandler(this.btnLimpiarColeccion_Click);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(16, 348);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(188, 30);
			this.btnEliminar.TabIndex = 23;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(16, 284);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(188, 51);
			this.btnModificar.TabIndex = 24;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// pictBoxImagen
			// 
			this.pictBoxImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.pictBoxImagen.Location = new System.Drawing.Point(419, 12);
			this.pictBoxImagen.Name = "pictBoxImagen";
			this.pictBoxImagen.Size = new System.Drawing.Size(210, 366);
			this.pictBoxImagen.TabIndex = 25;
			this.pictBoxImagen.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form39SerializacionPersonaje
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 399);
			this.Controls.Add(this.pictBoxImagen);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnLimpiarColeccion);
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
			this.Name = "Form39SerializacionPersonaje";
			this.Text = "Form39Personaje";
			((System.ComponentModel.ISupportInitialize)(this.pictBoxImagen)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMensaje;
		private System.Windows.Forms.Button btnLeer;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.TextBox txtEdad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtApellidos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listPersonas;
		private System.Windows.Forms.Button btnInsertar;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLimpiarColeccion;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.PictureBox pictBoxImagen;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}