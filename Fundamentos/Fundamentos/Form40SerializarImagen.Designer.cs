namespace Fundamentos
{
	partial class Form40SerializarImagen
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
			this.btnCarImagen = new System.Windows.Forms.Button();
			this.btnSubImagen = new System.Windows.Forms.Button();
			this.btnEliImagen = new System.Windows.Forms.Button();
			this.pictBoxImagen = new System.Windows.Forms.PictureBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.pictBoxImagen)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCarImagen
			// 
			this.btnCarImagen.Location = new System.Drawing.Point(12, 12);
			this.btnCarImagen.Name = "btnCarImagen";
			this.btnCarImagen.Size = new System.Drawing.Size(102, 63);
			this.btnCarImagen.TabIndex = 0;
			this.btnCarImagen.Text = "Cargar imagen";
			this.btnCarImagen.UseVisualStyleBackColor = true;
			this.btnCarImagen.Click += new System.EventHandler(this.btnCarImagen_Click);
			// 
			// btnSubImagen
			// 
			this.btnSubImagen.Location = new System.Drawing.Point(12, 81);
			this.btnSubImagen.Name = "btnSubImagen";
			this.btnSubImagen.Size = new System.Drawing.Size(102, 63);
			this.btnSubImagen.TabIndex = 2;
			this.btnSubImagen.Text = "Subir imagen";
			this.btnSubImagen.UseVisualStyleBackColor = true;
			// 
			// btnEliImagen
			// 
			this.btnEliImagen.Location = new System.Drawing.Point(12, 150);
			this.btnEliImagen.Name = "btnEliImagen";
			this.btnEliImagen.Size = new System.Drawing.Size(102, 63);
			this.btnEliImagen.TabIndex = 3;
			this.btnEliImagen.Text = "Eliminar imagen";
			this.btnEliImagen.UseVisualStyleBackColor = true;
			// 
			// pictBoxImagen
			// 
			this.pictBoxImagen.Location = new System.Drawing.Point(120, 12);
			this.pictBoxImagen.Name = "pictBoxImagen";
			this.pictBoxImagen.Size = new System.Drawing.Size(210, 333);
			this.pictBoxImagen.TabIndex = 4;
			this.pictBoxImagen.TabStop = false;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// Form40SerializarImagen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(342, 357);
			this.Controls.Add(this.pictBoxImagen);
			this.Controls.Add(this.btnEliImagen);
			this.Controls.Add(this.btnSubImagen);
			this.Controls.Add(this.btnCarImagen);
			this.Name = "Form40SerializarImagen";
			this.Text = "Form40SerializarImagen";
			((System.ComponentModel.ISupportInitialize)(this.pictBoxImagen)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCarImagen;
		private System.Windows.Forms.Button btnSubImagen;
		private System.Windows.Forms.Button btnEliImagen;
		private System.Windows.Forms.PictureBox pictBoxImagen;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}