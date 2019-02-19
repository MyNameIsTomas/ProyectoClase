namespace Fundamentos
{
	partial class Form15TiendaProductos
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
			this.btnInsertar = new System.Windows.Forms.Button();
			this.listTienda = new System.Windows.Forms.ListBox();
			this.txtProducto = new System.Windows.Forms.TextBox();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnLimiarLista = new System.Windows.Forms.Button();
			this.btnSeleccion = new System.Windows.Forms.Button();
			this.btnTodos = new System.Windows.Forms.Button();
			this.listAlmacen = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnBajar = new System.Windows.Forms.Button();
			this.btnSubir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Producto";
			// 
			// btnInsertar
			// 
			this.btnInsertar.Location = new System.Drawing.Point(12, 62);
			this.btnInsertar.Name = "btnInsertar";
			this.btnInsertar.Size = new System.Drawing.Size(137, 23);
			this.btnInsertar.TabIndex = 1;
			this.btnInsertar.Text = "Insertar";
			this.btnInsertar.UseVisualStyleBackColor = true;
			this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
			// 
			// listTienda
			// 
			this.listTienda.FormattingEnabled = true;
			this.listTienda.Location = new System.Drawing.Point(155, 25);
			this.listTienda.Name = "listTienda";
			this.listTienda.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listTienda.Size = new System.Drawing.Size(157, 212);
			this.listTienda.TabIndex = 2;
			// 
			// txtProducto
			// 
			this.txtProducto.Location = new System.Drawing.Point(12, 25);
			this.txtProducto.Name = "txtProducto";
			this.txtProducto.Size = new System.Drawing.Size(137, 20);
			this.txtProducto.TabIndex = 3;
			this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(12, 91);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(137, 23);
			this.btnEliminar.TabIndex = 4;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(12, 120);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(137, 23);
			this.btnModificar.TabIndex = 5;
			this.btnModificar.Text = "Modificar";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnLimiarLista
			// 
			this.btnLimiarLista.Location = new System.Drawing.Point(12, 149);
			this.btnLimiarLista.Name = "btnLimiarLista";
			this.btnLimiarLista.Size = new System.Drawing.Size(137, 23);
			this.btnLimiarLista.TabIndex = 6;
			this.btnLimiarLista.Text = "Limpiar lista";
			this.btnLimiarLista.UseVisualStyleBackColor = true;
			this.btnLimiarLista.Click += new System.EventHandler(this.btnLimiarLista_Click);
			// 
			// btnSeleccion
			// 
			this.btnSeleccion.Location = new System.Drawing.Point(344, 62);
			this.btnSeleccion.Name = "btnSeleccion";
			this.btnSeleccion.Size = new System.Drawing.Size(137, 52);
			this.btnSeleccion.TabIndex = 7;
			this.btnSeleccion.Text = "Selección --->";
			this.btnSeleccion.UseVisualStyleBackColor = true;
			this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
			// 
			// btnTodos
			// 
			this.btnTodos.Location = new System.Drawing.Point(344, 120);
			this.btnTodos.Name = "btnTodos";
			this.btnTodos.Size = new System.Drawing.Size(137, 52);
			this.btnTodos.TabIndex = 8;
			this.btnTodos.Text = "Todos --->";
			this.btnTodos.UseVisualStyleBackColor = true;
			this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
			// 
			// listAlmacen
			// 
			this.listAlmacen.FormattingEnabled = true;
			this.listAlmacen.Location = new System.Drawing.Point(512, 25);
			this.listAlmacen.Name = "listAlmacen";
			this.listAlmacen.Size = new System.Drawing.Size(157, 212);
			this.listAlmacen.TabIndex = 9;
			this.listAlmacen.SelectedIndexChanged += new System.EventHandler(this.listAlmacen_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(152, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 13);
			this.label2.TabIndex = 10;
			this.label2.Text = "Tienda";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(509, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Almacen";
			// 
			// btnBajar
			// 
			this.btnBajar.Enabled = false;
			this.btnBajar.Location = new System.Drawing.Point(675, 120);
			this.btnBajar.Name = "btnBajar";
			this.btnBajar.Size = new System.Drawing.Size(137, 52);
			this.btnBajar.TabIndex = 13;
			this.btnBajar.Text = "Bajar";
			this.btnBajar.UseVisualStyleBackColor = true;
			this.btnBajar.Click += new System.EventHandler(this.btnBajar_Click);
			// 
			// btnSubir
			// 
			this.btnSubir.Enabled = false;
			this.btnSubir.Location = new System.Drawing.Point(675, 62);
			this.btnSubir.Name = "btnSubir";
			this.btnSubir.Size = new System.Drawing.Size(137, 52);
			this.btnSubir.TabIndex = 12;
			this.btnSubir.Text = "Subir";
			this.btnSubir.UseVisualStyleBackColor = true;
			this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
			// 
			// Form15TiendaProductos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 251);
			this.Controls.Add(this.btnBajar);
			this.Controls.Add(this.btnSubir);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listAlmacen);
			this.Controls.Add(this.btnTodos);
			this.Controls.Add(this.btnSeleccion);
			this.Controls.Add(this.btnLimiarLista);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.txtProducto);
			this.Controls.Add(this.listTienda);
			this.Controls.Add(this.btnInsertar);
			this.Controls.Add(this.label1);
			this.Name = "Form15TiendaProductos";
			this.Text = "Form15TiendaProductos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnInsertar;
		private System.Windows.Forms.ListBox listTienda;
		private System.Windows.Forms.TextBox txtProducto;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnLimiarLista;
		private System.Windows.Forms.Button btnSeleccion;
		private System.Windows.Forms.Button btnTodos;
		private System.Windows.Forms.ListBox listAlmacen;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnBajar;
		private System.Windows.Forms.Button btnSubir;
	}
}