namespace Fundamentos
{
	partial class Form36ProductosFile
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
			this.textNombreProducto = new System.Windows.Forms.TextBox();
			this.textPrecio = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.listProductos = new System.Windows.Forms.ListBox();
			this.buttonNuevoPro = new System.Windows.Forms.Button();
			this.buttonCargarPro = new System.Windows.Forms.Button();
			this.buttonGuardarList = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre producto";
			// 
			// textNombreProducto
			// 
			this.textNombreProducto.Location = new System.Drawing.Point(15, 25);
			this.textNombreProducto.Name = "textNombreProducto";
			this.textNombreProducto.Size = new System.Drawing.Size(162, 20);
			this.textNombreProducto.TabIndex = 1;
			// 
			// textPrecio
			// 
			this.textPrecio.Location = new System.Drawing.Point(15, 74);
			this.textPrecio.Name = "textPrecio";
			this.textPrecio.Size = new System.Drawing.Size(162, 20);
			this.textPrecio.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Precio";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(197, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Productos";
			// 
			// listProductos
			// 
			this.listProductos.FormattingEnabled = true;
			this.listProductos.Location = new System.Drawing.Point(200, 25);
			this.listProductos.Name = "listProductos";
			this.listProductos.Size = new System.Drawing.Size(132, 251);
			this.listProductos.TabIndex = 5;
			this.listProductos.SelectedIndexChanged += new System.EventHandler(this.listProductos_SelectedIndexChanged);
			// 
			// buttonNuevoPro
			// 
			this.buttonNuevoPro.Location = new System.Drawing.Point(15, 100);
			this.buttonNuevoPro.Name = "buttonNuevoPro";
			this.buttonNuevoPro.Size = new System.Drawing.Size(162, 54);
			this.buttonNuevoPro.TabIndex = 6;
			this.buttonNuevoPro.Text = "Nuevo productos";
			this.buttonNuevoPro.UseVisualStyleBackColor = true;
			this.buttonNuevoPro.Click += new System.EventHandler(this.buttonNuevoPro_Click);
			// 
			// buttonCargarPro
			// 
			this.buttonCargarPro.Location = new System.Drawing.Point(15, 160);
			this.buttonCargarPro.Name = "buttonCargarPro";
			this.buttonCargarPro.Size = new System.Drawing.Size(162, 54);
			this.buttonCargarPro.TabIndex = 7;
			this.buttonCargarPro.Text = "Cargar producto";
			this.buttonCargarPro.UseVisualStyleBackColor = true;
			this.buttonCargarPro.Click += new System.EventHandler(this.buttonCargarPro_Click_1);
			// 
			// buttonGuardarList
			// 
			this.buttonGuardarList.Location = new System.Drawing.Point(15, 220);
			this.buttonGuardarList.Name = "buttonGuardarList";
			this.buttonGuardarList.Size = new System.Drawing.Size(162, 56);
			this.buttonGuardarList.TabIndex = 8;
			this.buttonGuardarList.Text = "Guardar lista productos";
			this.buttonGuardarList.UseVisualStyleBackColor = true;
			this.buttonGuardarList.Click += new System.EventHandler(this.buttonGuardarList_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form36ProductosFile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 285);
			this.Controls.Add(this.buttonGuardarList);
			this.Controls.Add(this.buttonCargarPro);
			this.Controls.Add(this.buttonNuevoPro);
			this.Controls.Add(this.listProductos);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textPrecio);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textNombreProducto);
			this.Controls.Add(this.label1);
			this.Name = "Form36ProductosFile";
			this.Text = "Form36ProductosFile";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textNombreProducto;
		private System.Windows.Forms.TextBox textPrecio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListBox listProductos;
		private System.Windows.Forms.Button buttonNuevoPro;
		private System.Windows.Forms.Button buttonCargarPro;
		private System.Windows.Forms.Button buttonGuardarList;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}