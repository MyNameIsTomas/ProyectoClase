namespace ProyectoADO.Conectado
{
	partial class BuscarEmpleado
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
			this.buttonBuscar = new System.Windows.Forms.Button();
			this.textBuscarApellido = new System.Windows.Forms.TextBox();
			this.listBusqueda = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Buscador de empleados";
			// 
			// buttonBuscar
			// 
			this.buttonBuscar.Location = new System.Drawing.Point(15, 55);
			this.buttonBuscar.Name = "buttonBuscar";
			this.buttonBuscar.Size = new System.Drawing.Size(230, 23);
			this.buttonBuscar.TabIndex = 1;
			this.buttonBuscar.Text = "Buscar";
			this.buttonBuscar.UseVisualStyleBackColor = true;
			this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
			// 
			// textBuscarApellido
			// 
			this.textBuscarApellido.Location = new System.Drawing.Point(65, 29);
			this.textBuscarApellido.Name = "textBuscarApellido";
			this.textBuscarApellido.Size = new System.Drawing.Size(180, 20);
			this.textBuscarApellido.TabIndex = 2;
			this.textBuscarApellido.TextChanged += new System.EventHandler(this.textBuscarApellido_TextChanged);
			// 
			// listBusqueda
			// 
			this.listBusqueda.FormattingEnabled = true;
			this.listBusqueda.Location = new System.Drawing.Point(15, 84);
			this.listBusqueda.Name = "listBusqueda";
			this.listBusqueda.Size = new System.Drawing.Size(230, 199);
			this.listBusqueda.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Apellido";
			// 
			// BuscarEmpleado
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 298);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBusqueda);
			this.Controls.Add(this.textBuscarApellido);
			this.Controls.Add(this.buttonBuscar);
			this.Controls.Add(this.label1);
			this.Name = "BuscarEmpleado";
			this.Text = "BuscarEmpleado";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonBuscar;
		private System.Windows.Forms.TextBox textBuscarApellido;
		private System.Windows.Forms.ListBox listBusqueda;
		private System.Windows.Forms.Label label2;
	}
}