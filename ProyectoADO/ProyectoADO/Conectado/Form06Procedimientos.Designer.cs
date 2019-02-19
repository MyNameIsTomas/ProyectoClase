namespace ProyectoADO.Conectado
{
	partial class Form06Procedimientos
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
			this.textEnfermo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listEnfermos = new System.Windows.Forms.ListBox();
			this.btnEliminarElemento = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enfermo:";
			// 
			// textEnfermo
			// 
			this.textEnfermo.Location = new System.Drawing.Point(67, 6);
			this.textEnfermo.Name = "textEnfermo";
			this.textEnfermo.Size = new System.Drawing.Size(150, 20);
			this.textEnfermo.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Lista de enfermos";
			// 
			// listEnfermos
			// 
			this.listEnfermos.FormattingEnabled = true;
			this.listEnfermos.Location = new System.Drawing.Point(15, 86);
			this.listEnfermos.Name = "listEnfermos";
			this.listEnfermos.Size = new System.Drawing.Size(202, 212);
			this.listEnfermos.TabIndex = 3;
			// 
			// btnEliminarElemento
			// 
			this.btnEliminarElemento.Location = new System.Drawing.Point(15, 32);
			this.btnEliminarElemento.Name = "btnEliminarElemento";
			this.btnEliminarElemento.Size = new System.Drawing.Size(202, 32);
			this.btnEliminarElemento.TabIndex = 4;
			this.btnEliminarElemento.Text = "Eliminar elemento";
			this.btnEliminarElemento.UseVisualStyleBackColor = true;
			this.btnEliminarElemento.Click += new System.EventHandler(this.btnEliminarElemento_Click);
			// 
			// Form06Procedimientos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(235, 309);
			this.Controls.Add(this.btnEliminarElemento);
			this.Controls.Add(this.listEnfermos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textEnfermo);
			this.Controls.Add(this.label1);
			this.Name = "Form06Procedimientos";
			this.Text = "Form06Procedimientos";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textEnfermo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listEnfermos;
		private System.Windows.Forms.Button btnEliminarElemento;
	}
}