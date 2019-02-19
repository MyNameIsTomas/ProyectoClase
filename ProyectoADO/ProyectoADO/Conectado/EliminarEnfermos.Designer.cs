namespace ProyectoADO.Conectado
{
	partial class EliminarEnfermos
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
			this.txtInscripcion = new System.Windows.Forms.TextBox();
			this.btnEliminarEnf = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.listIncripciones = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Inscripción";
			// 
			// txtInscripcion
			// 
			this.txtInscripcion.Location = new System.Drawing.Point(76, 6);
			this.txtInscripcion.Name = "txtInscripcion";
			this.txtInscripcion.Size = new System.Drawing.Size(100, 20);
			this.txtInscripcion.TabIndex = 1;
			// 
			// btnEliminarEnf
			// 
			this.btnEliminarEnf.Location = new System.Drawing.Point(182, 47);
			this.btnEliminarEnf.Name = "btnEliminarEnf";
			this.btnEliminarEnf.Size = new System.Drawing.Size(108, 40);
			this.btnEliminarEnf.TabIndex = 2;
			this.btnEliminarEnf.Text = "Eliminar enfermo";
			this.btnEliminarEnf.UseVisualStyleBackColor = true;
			this.btnEliminarEnf.Click += new System.EventHandler(this.btnEliminarEnf_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Inscripciones";
			// 
			// listIncripciones
			// 
			this.listIncripciones.FormattingEnabled = true;
			this.listIncripciones.Location = new System.Drawing.Point(12, 47);
			this.listIncripciones.Name = "listIncripciones";
			this.listIncripciones.Size = new System.Drawing.Size(164, 173);
			this.listIncripciones.TabIndex = 4;
			this.listIncripciones.SelectedIndexChanged += new System.EventHandler(this.listIncripciones_SelectedIndexChanged);
			// 
			// EliminarEnfermos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(297, 236);
			this.Controls.Add(this.listIncripciones);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnEliminarEnf);
			this.Controls.Add(this.txtInscripcion);
			this.Controls.Add(this.label1);
			this.Name = "EliminarEnfermos";
			this.Text = "EliminarEnfermos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtInscripcion;
		private System.Windows.Forms.Button btnEliminarEnf;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listIncripciones;
	}
}