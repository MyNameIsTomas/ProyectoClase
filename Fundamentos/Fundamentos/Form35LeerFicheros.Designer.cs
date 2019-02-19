namespace Fundamentos
{
	partial class Form35LeerFicheros
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
			this.txtcontenido = new System.Windows.Forms.RichTextBox();
			this.buttonLeer = new System.Windows.Forms.Button();
			this.buttonGuardar = new System.Windows.Forms.Button();
			this.labelAccion = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Contenido fichero:";
			// 
			// txtcontenido
			// 
			this.txtcontenido.Location = new System.Drawing.Point(15, 25);
			this.txtcontenido.Name = "txtcontenido";
			this.txtcontenido.Size = new System.Drawing.Size(172, 206);
			this.txtcontenido.TabIndex = 1;
			this.txtcontenido.Text = "";
			// 
			// buttonLeer
			// 
			this.buttonLeer.Location = new System.Drawing.Point(193, 25);
			this.buttonLeer.Name = "buttonLeer";
			this.buttonLeer.Size = new System.Drawing.Size(180, 102);
			this.buttonLeer.TabIndex = 2;
			this.buttonLeer.Text = "Leer Fichero";
			this.buttonLeer.UseVisualStyleBackColor = true;
			this.buttonLeer.Click += new System.EventHandler(this.buttonLeer_Click);
			// 
			// buttonGuardar
			// 
			this.buttonGuardar.Location = new System.Drawing.Point(193, 129);
			this.buttonGuardar.Name = "buttonGuardar";
			this.buttonGuardar.Size = new System.Drawing.Size(180, 102);
			this.buttonGuardar.TabIndex = 3;
			this.buttonGuardar.Text = "Guardar Ficheros";
			this.buttonGuardar.UseVisualStyleBackColor = true;
			this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
			// 
			// labelAccion
			// 
			this.labelAccion.AutoSize = true;
			this.labelAccion.Location = new System.Drawing.Point(12, 234);
			this.labelAccion.Name = "labelAccion";
			this.labelAccion.Size = new System.Drawing.Size(50, 13);
			this.labelAccion.TabIndex = 4;
			this.labelAccion.Text = "lblAccion";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form35LeerFicheros
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 261);
			this.Controls.Add(this.labelAccion);
			this.Controls.Add(this.buttonGuardar);
			this.Controls.Add(this.buttonLeer);
			this.Controls.Add(this.txtcontenido);
			this.Controls.Add(this.label1);
			this.Name = "Form35LeerFicheros";
			this.Text = "Form31LeerFicheros";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox txtcontenido;
		private System.Windows.Forms.Button buttonLeer;
		private System.Windows.Forms.Button buttonGuardar;
		private System.Windows.Forms.Label labelAccion;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}