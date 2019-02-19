namespace Fundamentos
{
	partial class Form13ColeccionListBox
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
			this.listBoxelementos = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtelementos = new System.Windows.Forms.TextBox();
			this.btnnuevoelm = new System.Windows.Forms.Button();
			this.btnborrarelm = new System.Windows.Forms.Button();
			this.btnlimpiarlis = new System.Windows.Forms.Button();
			this.btnmostrar = new System.Windows.Forms.Button();
			this.lblseleccionados = new System.Windows.Forms.Label();
			this.lbltodos = new System.Windows.Forms.Label();
			this.btnmostrarsel = new System.Windows.Forms.Button();
			this.btnborrarsel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Elementos";
			// 
			// listBoxelementos
			// 
			this.listBoxelementos.FormattingEnabled = true;
			this.listBoxelementos.Location = new System.Drawing.Point(12, 27);
			this.listBoxelementos.Name = "listBoxelementos";
			this.listBoxelementos.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.listBoxelementos.Size = new System.Drawing.Size(120, 290);
			this.listBoxelementos.TabIndex = 1;
			this.listBoxelementos.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(158, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Elementos";
			// 
			// txtelementos
			// 
			this.txtelementos.Location = new System.Drawing.Point(161, 27);
			this.txtelementos.Name = "txtelementos";
			this.txtelementos.Size = new System.Drawing.Size(100, 20);
			this.txtelementos.TabIndex = 3;
			// 
			// btnnuevoelm
			// 
			this.btnnuevoelm.Location = new System.Drawing.Point(161, 53);
			this.btnnuevoelm.Name = "btnnuevoelm";
			this.btnnuevoelm.Size = new System.Drawing.Size(100, 23);
			this.btnnuevoelm.TabIndex = 4;
			this.btnnuevoelm.Text = "Nuevo elemento";
			this.btnnuevoelm.UseVisualStyleBackColor = true;
			this.btnnuevoelm.Click += new System.EventHandler(this.btnnuevoelm_Click);
			// 
			// btnborrarelm
			// 
			this.btnborrarelm.Location = new System.Drawing.Point(278, 53);
			this.btnborrarelm.Name = "btnborrarelm";
			this.btnborrarelm.Size = new System.Drawing.Size(116, 23);
			this.btnborrarelm.TabIndex = 5;
			this.btnborrarelm.Text = "Borrar elemento";
			this.btnborrarelm.UseVisualStyleBackColor = true;
			this.btnborrarelm.Click += new System.EventHandler(this.btnborrarelm_Click);
			// 
			// btnlimpiarlis
			// 
			this.btnlimpiarlis.Location = new System.Drawing.Point(161, 100);
			this.btnlimpiarlis.Name = "btnlimpiarlis";
			this.btnlimpiarlis.Size = new System.Drawing.Size(100, 23);
			this.btnlimpiarlis.TabIndex = 6;
			this.btnlimpiarlis.Text = "Limpiar lista";
			this.btnlimpiarlis.UseVisualStyleBackColor = true;
			this.btnlimpiarlis.Click += new System.EventHandler(this.btnlimpiarlis_Click);
			// 
			// btnmostrar
			// 
			this.btnmostrar.Location = new System.Drawing.Point(278, 139);
			this.btnmostrar.Name = "btnmostrar";
			this.btnmostrar.Size = new System.Drawing.Size(114, 40);
			this.btnmostrar.TabIndex = 7;
			this.btnmostrar.Text = "Mostrar todos";
			this.btnmostrar.UseVisualStyleBackColor = true;
			this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
			// 
			// lblseleccionados
			// 
			this.lblseleccionados.AutoSize = true;
			this.lblseleccionados.Location = new System.Drawing.Point(158, 232);
			this.lblseleccionados.Name = "lblseleccionados";
			this.lblseleccionados.Size = new System.Drawing.Size(0, 13);
			this.lblseleccionados.TabIndex = 8;
			// 
			// lbltodos
			// 
			this.lbltodos.AutoSize = true;
			this.lbltodos.Location = new System.Drawing.Point(158, 178);
			this.lbltodos.Name = "lbltodos";
			this.lbltodos.Size = new System.Drawing.Size(0, 13);
			this.lbltodos.TabIndex = 9;
			// 
			// btnmostrarsel
			// 
			this.btnmostrarsel.Location = new System.Drawing.Point(161, 139);
			this.btnmostrarsel.Name = "btnmostrarsel";
			this.btnmostrarsel.Size = new System.Drawing.Size(100, 40);
			this.btnmostrarsel.TabIndex = 10;
			this.btnmostrarsel.Text = "Mostrar seleccionados";
			this.btnmostrarsel.UseVisualStyleBackColor = true;
			this.btnmostrarsel.Click += new System.EventHandler(this.btnmostrarsel_Click);
			// 
			// btnborrarsel
			// 
			this.btnborrarsel.Location = new System.Drawing.Point(278, 100);
			this.btnborrarsel.Name = "btnborrarsel";
			this.btnborrarsel.Size = new System.Drawing.Size(116, 23);
			this.btnborrarsel.TabIndex = 11;
			this.btnborrarsel.Text = "Borrar seleccionados";
			this.btnborrarsel.UseVisualStyleBackColor = true;
			this.btnborrarsel.Click += new System.EventHandler(this.btnborrarsel_Click);
			// 
			// Form13ColeccionListBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(406, 327);
			this.Controls.Add(this.btnborrarsel);
			this.Controls.Add(this.btnmostrarsel);
			this.Controls.Add(this.lbltodos);
			this.Controls.Add(this.lblseleccionados);
			this.Controls.Add(this.btnmostrar);
			this.Controls.Add(this.btnlimpiarlis);
			this.Controls.Add(this.btnborrarelm);
			this.Controls.Add(this.btnnuevoelm);
			this.Controls.Add(this.txtelementos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listBoxelementos);
			this.Controls.Add(this.label1);
			this.Name = "Form13ColeccionListBox";
			this.Text = "Form13ColeccionListBox";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBoxelementos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtelementos;
		private System.Windows.Forms.Button btnnuevoelm;
		private System.Windows.Forms.Button btnborrarelm;
		private System.Windows.Forms.Button btnlimpiarlis;
		private System.Windows.Forms.Button btnmostrar;
		private System.Windows.Forms.Label lblseleccionados;
		private System.Windows.Forms.Label lbltodos;
		private System.Windows.Forms.Button btnmostrarsel;
		private System.Windows.Forms.Button btnborrarsel;
	}
}