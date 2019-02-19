namespace ProyectoADO.Conectado
{
	partial class Form05ModificarDoctor
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
			this.listDoctores = new System.Windows.Forms.ListBox();
			this.btnModificar = new System.Windows.Forms.Button();
			this.textApellido = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textEspecialidad = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textSalario = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Doctores";
			// 
			// listDoctores
			// 
			this.listDoctores.FormattingEnabled = true;
			this.listDoctores.Location = new System.Drawing.Point(12, 25);
			this.listDoctores.Name = "listDoctores";
			this.listDoctores.Size = new System.Drawing.Size(168, 199);
			this.listDoctores.TabIndex = 1;
			this.listDoctores.SelectedIndexChanged += new System.EventHandler(this.listDoctores_SelectedIndexChanged);
			// 
			// btnModificar
			// 
			this.btnModificar.Location = new System.Drawing.Point(186, 152);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(100, 72);
			this.btnModificar.TabIndex = 2;
			this.btnModificar.Text = "Modificar datos";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// textApellido
			// 
			this.textApellido.Location = new System.Drawing.Point(186, 41);
			this.textApellido.Name = "textApellido";
			this.textApellido.Size = new System.Drawing.Size(100, 20);
			this.textApellido.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(183, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Apellido";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(183, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Especialidad";
			// 
			// textEspecialidad
			// 
			this.textEspecialidad.Location = new System.Drawing.Point(186, 82);
			this.textEspecialidad.Name = "textEspecialidad";
			this.textEspecialidad.Size = new System.Drawing.Size(100, 20);
			this.textEspecialidad.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(183, 110);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Salario";
			// 
			// textSalario
			// 
			this.textSalario.Location = new System.Drawing.Point(186, 126);
			this.textSalario.Name = "textSalario";
			this.textSalario.Size = new System.Drawing.Size(100, 20);
			this.textSalario.TabIndex = 7;
			// 
			// Form05ModificarDoctor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 232);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textSalario);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textEspecialidad);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textApellido);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.listDoctores);
			this.Controls.Add(this.label1);
			this.Name = "Form05ModificarDoctor";
			this.Text = "Form05ModificarDoctor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listDoctores;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.TextBox textApellido;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textEspecialidad;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textSalario;
	}
}