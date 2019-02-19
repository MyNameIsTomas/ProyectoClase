namespace ProyectoADO.Conectado
{
	partial class d
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
			this.btnConectar = new System.Windows.Forms.Button();
			this.btnDesconectar = new System.Windows.Forms.Button();
			this.btnLeerRegistros = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.listApellido = new System.Windows.Forms.ListBox();
			this.listSalarios = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lblEstado = new System.Windows.Forms.Label();
			this.listComandos = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnConectar
			// 
			this.btnConectar.Location = new System.Drawing.Point(12, 12);
			this.btnConectar.Name = "btnConectar";
			this.btnConectar.Size = new System.Drawing.Size(114, 62);
			this.btnConectar.TabIndex = 0;
			this.btnConectar.Text = "Conectar";
			this.btnConectar.UseVisualStyleBackColor = true;
			this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
			// 
			// btnDesconectar
			// 
			this.btnDesconectar.Location = new System.Drawing.Point(12, 80);
			this.btnDesconectar.Name = "btnDesconectar";
			this.btnDesconectar.Size = new System.Drawing.Size(114, 62);
			this.btnDesconectar.TabIndex = 1;
			this.btnDesconectar.Text = "Desconectar";
			this.btnDesconectar.UseVisualStyleBackColor = true;
			this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
			// 
			// btnLeerRegistros
			// 
			this.btnLeerRegistros.Location = new System.Drawing.Point(12, 148);
			this.btnLeerRegistros.Name = "btnLeerRegistros";
			this.btnLeerRegistros.Size = new System.Drawing.Size(114, 62);
			this.btnLeerRegistros.TabIndex = 2;
			this.btnLeerRegistros.Text = "Leer Registros";
			this.btnLeerRegistros.UseVisualStyleBackColor = true;
			this.btnLeerRegistros.Click += new System.EventHandler(this.btnLeerRegistros_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(272, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Apellidos";
			// 
			// listApellido
			// 
			this.listApellido.FormattingEnabled = true;
			this.listApellido.Location = new System.Drawing.Point(275, 24);
			this.listApellido.Name = "listApellido";
			this.listApellido.Size = new System.Drawing.Size(137, 186);
			this.listApellido.TabIndex = 4;
			// 
			// listSalarios
			// 
			this.listSalarios.FormattingEnabled = true;
			this.listSalarios.Location = new System.Drawing.Point(418, 24);
			this.listSalarios.Name = "listSalarios";
			this.listSalarios.Size = new System.Drawing.Size(137, 186);
			this.listSalarios.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(415, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Salarios";
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Location = new System.Drawing.Point(12, 213);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(50, 13);
			this.lblEstado.TabIndex = 7;
			this.lblEstado.Text = "lblEstado";
			// 
			// listComandos
			// 
			this.listComandos.FormattingEnabled = true;
			this.listComandos.Location = new System.Drawing.Point(132, 24);
			this.listComandos.Name = "listComandos";
			this.listComandos.Size = new System.Drawing.Size(137, 186);
			this.listComandos.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(129, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Columnas";
			// 
			// d
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(567, 237);
			this.Controls.Add(this.listComandos);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.listSalarios);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listApellido);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLeerRegistros);
			this.Controls.Add(this.btnDesconectar);
			this.Controls.Add(this.btnConectar);
			this.Name = "d";
			this.Text = "Form01PrimerAdo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnConectar;
		private System.Windows.Forms.Button btnDesconectar;
		private System.Windows.Forms.Button btnLeerRegistros;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listApellido;
		private System.Windows.Forms.ListBox listSalarios;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.ListBox listComandos;
		private System.Windows.Forms.Label label3;
	}
}