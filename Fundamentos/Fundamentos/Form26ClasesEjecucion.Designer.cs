namespace Fundamentos
{
	partial class Form26ClasesEjecucion
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.btnCrear = new System.Windows.Forms.Button();
			this.btnCambiarColor = new System.Windows.Forms.Button();
			this.btnSeleccionarImagen = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(216, 477);
			this.panel1.TabIndex = 0;
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(216, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 477);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// btnCrear
			// 
			this.btnCrear.Location = new System.Drawing.Point(226, 12);
			this.btnCrear.Name = "btnCrear";
			this.btnCrear.Size = new System.Drawing.Size(200, 67);
			this.btnCrear.TabIndex = 2;
			this.btnCrear.Text = "Crear botones";
			this.btnCrear.UseVisualStyleBackColor = true;
			this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
			// 
			// btnCambiarColor
			// 
			this.btnCambiarColor.Location = new System.Drawing.Point(226, 85);
			this.btnCambiarColor.Name = "btnCambiarColor";
			this.btnCambiarColor.Size = new System.Drawing.Size(200, 67);
			this.btnCambiarColor.TabIndex = 3;
			this.btnCambiarColor.Text = "Cambiar color";
			this.btnCambiarColor.UseVisualStyleBackColor = true;
			this.btnCambiarColor.Click += new System.EventHandler(this.btnCambiarColor_Click);
			// 
			// btnSeleccionarImagen
			// 
			this.btnSeleccionarImagen.Location = new System.Drawing.Point(226, 158);
			this.btnSeleccionarImagen.Name = "btnSeleccionarImagen";
			this.btnSeleccionarImagen.Size = new System.Drawing.Size(200, 67);
			this.btnSeleccionarImagen.TabIndex = 4;
			this.btnSeleccionarImagen.Text = "Seleccionar imagen";
			this.btnSeleccionarImagen.UseVisualStyleBackColor = true;
			this.btnSeleccionarImagen.Click += new System.EventHandler(this.btnSeleccionarImagen_Click);
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.panel2.Location = new System.Drawing.Point(225, 231);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 200);
			this.panel2.TabIndex = 5;
			// 
			// Form26ClasesEjecucion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 477);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnSeleccionarImagen);
			this.Controls.Add(this.btnCambiarColor);
			this.Controls.Add(this.btnCrear);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.panel1);
			this.Name = "Form26ClasesEjecucion";
			this.Text = "Form26ClasesEjecucion";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Button btnCrear;
		private System.Windows.Forms.Button btnCambiarColor;
		private System.Windows.Forms.Button btnSeleccionarImagen;
		private System.Windows.Forms.Panel panel2;
	}
}