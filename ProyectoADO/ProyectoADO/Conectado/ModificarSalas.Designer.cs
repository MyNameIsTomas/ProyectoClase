namespace ProyectoADO.Conectado
{
	partial class ModificarSalas
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
			this.listSalas = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textNuevoNombre = new System.Windows.Forms.TextBox();
			this.buttonModificar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Salas";
			// 
			// listSalas
			// 
			this.listSalas.FormattingEnabled = true;
			this.listSalas.Location = new System.Drawing.Point(12, 25);
			this.listSalas.Name = "listSalas";
			this.listSalas.Size = new System.Drawing.Size(120, 134);
			this.listSalas.TabIndex = 1;
			this.listSalas.SelectedIndexChanged += new System.EventHandler(this.listSalas_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(138, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nuevo nombre;";
			// 
			// textNuevoNombre
			// 
			this.textNuevoNombre.Location = new System.Drawing.Point(224, 22);
			this.textNuevoNombre.Name = "textNuevoNombre";
			this.textNuevoNombre.Size = new System.Drawing.Size(100, 20);
			this.textNuevoNombre.TabIndex = 3;
			// 
			// buttonModificar
			// 
			this.buttonModificar.Location = new System.Drawing.Point(141, 48);
			this.buttonModificar.Name = "buttonModificar";
			this.buttonModificar.Size = new System.Drawing.Size(183, 41);
			this.buttonModificar.TabIndex = 4;
			this.buttonModificar.Text = "Modificar";
			this.buttonModificar.UseVisualStyleBackColor = true;
			this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
			// 
			// ModificarSalas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 168);
			this.Controls.Add(this.buttonModificar);
			this.Controls.Add(this.textNuevoNombre);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listSalas);
			this.Controls.Add(this.label1);
			this.Name = "ModificarSalas";
			this.Text = "ModificarSalas";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listSalas;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textNuevoNombre;
		private System.Windows.Forms.Button buttonModificar;
	}
}