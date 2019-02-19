namespace Fundamentos
{
	partial class Form29SortePrimitiva2
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
			this.panelSorteo = new System.Windows.Forms.Panel();
			this.btnIniciar = new System.Windows.Forms.Button();
			this.btnSortear = new System.Windows.Forms.Button();
			this.listNumeros = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// panelSorteo
			// 
			this.panelSorteo.AutoSize = true;
			this.panelSorteo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.panelSorteo.Location = new System.Drawing.Point(0, 0);
			this.panelSorteo.Name = "panelSorteo";
			this.panelSorteo.Size = new System.Drawing.Size(240, 420);
			this.panelSorteo.TabIndex = 0;
			// 
			// btnIniciar
			// 
			this.btnIniciar.Location = new System.Drawing.Point(246, 157);
			this.btnIniciar.Name = "btnIniciar";
			this.btnIniciar.Size = new System.Drawing.Size(80, 40);
			this.btnIniciar.TabIndex = 0;
			this.btnIniciar.Text = "Iniciar";
			this.btnIniciar.UseVisualStyleBackColor = true;
			this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
			// 
			// btnSortear
			// 
			this.btnSortear.Location = new System.Drawing.Point(246, 234);
			this.btnSortear.Name = "btnSortear";
			this.btnSortear.Size = new System.Drawing.Size(80, 40);
			this.btnSortear.TabIndex = 1;
			this.btnSortear.Text = "Sortear";
			this.btnSortear.UseVisualStyleBackColor = true;
			this.btnSortear.Click += new System.EventHandler(this.btnSortear_Click);
			// 
			// listNumeros
			// 
			this.listNumeros.FormattingEnabled = true;
			this.listNumeros.ImeMode = System.Windows.Forms.ImeMode.On;
			this.listNumeros.Location = new System.Drawing.Point(332, 0);
			this.listNumeros.Name = "listNumeros";
			this.listNumeros.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listNumeros.Size = new System.Drawing.Size(240, 420);
			this.listNumeros.TabIndex = 2;
			// 
			// Form29SortePrimitiva2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 420);
			this.Controls.Add(this.listNumeros);
			this.Controls.Add(this.btnSortear);
			this.Controls.Add(this.btnIniciar);
			this.Controls.Add(this.panelSorteo);
			this.Name = "Form29SortePrimitiva2";
			this.Text = "Form29SortePrimitiva2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelSorteo;
		private System.Windows.Forms.Button btnIniciar;
		private System.Windows.Forms.Button btnSortear;
		private System.Windows.Forms.ListBox listNumeros;
	}
}