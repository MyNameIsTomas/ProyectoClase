namespace Fundamentos
{
	partial class Form06DateTime
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
			this.lblfechaactual = new System.Windows.Forms.Label();
			this.txtactual = new System.Windows.Forms.TextBox();
			this.cambiarformato = new System.Windows.Forms.CheckBox();
			this.dias = new System.Windows.Forms.RadioButton();
			this.meses = new System.Windows.Forms.RadioButton();
			this.anyos = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.lblincremento = new System.Windows.Forms.Label();
			this.txtincremento = new System.Windows.Forms.TextBox();
			this.incrementa = new System.Windows.Forms.Button();
			this.lblreslutado = new System.Windows.Forms.Label();
			this.fecharesultado = new System.Windows.Forms.TextBox();
			this.incremento = new System.Windows.Forms.GroupBox();
			this.txtdiasdiferencia = new System.Windows.Forms.TextBox();
			this.txthorasdiferencia = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.diferencia = new System.Windows.Forms.Button();
			this.incremento.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblfechaactual
			// 
			this.lblfechaactual.AutoSize = true;
			this.lblfechaactual.Location = new System.Drawing.Point(24, 21);
			this.lblfechaactual.Name = "lblfechaactual";
			this.lblfechaactual.Size = new System.Drawing.Size(125, 13);
			this.lblfechaactual.TabIndex = 0;
			this.lblfechaactual.Text = "Introduce la fecha actual";
			// 
			// txtactual
			// 
			this.txtactual.Location = new System.Drawing.Point(27, 47);
			this.txtactual.Name = "txtactual";
			this.txtactual.Size = new System.Drawing.Size(255, 20);
			this.txtactual.TabIndex = 1;
			// 
			// cambiarformato
			// 
			this.cambiarformato.AutoSize = true;
			this.cambiarformato.Location = new System.Drawing.Point(27, 90);
			this.cambiarformato.Name = "cambiarformato";
			this.cambiarformato.Size = new System.Drawing.Size(102, 17);
			this.cambiarformato.TabIndex = 2;
			this.cambiarformato.Text = "Cambiar formato";
			this.cambiarformato.UseVisualStyleBackColor = true;
			this.cambiarformato.CheckedChanged += new System.EventHandler(this.cambiarformato_CheckedChanged);
			// 
			// dias
			// 
			this.dias.AutoSize = true;
			this.dias.Location = new System.Drawing.Point(8, 19);
			this.dias.Name = "dias";
			this.dias.Size = new System.Drawing.Size(48, 17);
			this.dias.TabIndex = 3;
			this.dias.TabStop = true;
			this.dias.Text = "Días";
			this.dias.UseVisualStyleBackColor = true;
			// 
			// meses
			// 
			this.meses.AutoSize = true;
			this.meses.Location = new System.Drawing.Point(8, 42);
			this.meses.Name = "meses";
			this.meses.Size = new System.Drawing.Size(56, 17);
			this.meses.TabIndex = 4;
			this.meses.TabStop = true;
			this.meses.Text = "Meses";
			this.meses.UseVisualStyleBackColor = true;
			// 
			// anyos
			// 
			this.anyos.AutoSize = true;
			this.anyos.Checked = true;
			this.anyos.Location = new System.Drawing.Point(6, 65);
			this.anyos.Name = "anyos";
			this.anyos.Size = new System.Drawing.Size(49, 17);
			this.anyos.TabIndex = 5;
			this.anyos.TabStop = true;
			this.anyos.Text = "Años";
			this.anyos.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 159);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 13);
			this.label2.TabIndex = 6;
			// 
			// lblincremento
			// 
			this.lblincremento.AutoSize = true;
			this.lblincremento.Location = new System.Drawing.Point(179, 123);
			this.lblincremento.Name = "lblincremento";
			this.lblincremento.Size = new System.Drawing.Size(60, 13);
			this.lblincremento.TabIndex = 7;
			this.lblincremento.Text = "Incremento";
			// 
			// txtincremento
			// 
			this.txtincremento.Location = new System.Drawing.Point(182, 142);
			this.txtincremento.Name = "txtincremento";
			this.txtincremento.Size = new System.Drawing.Size(100, 20);
			this.txtincremento.TabIndex = 8;
			// 
			// incrementa
			// 
			this.incrementa.Location = new System.Drawing.Point(182, 168);
			this.incrementa.Name = "incrementa";
			this.incrementa.Size = new System.Drawing.Size(75, 23);
			this.incrementa.TabIndex = 9;
			this.incrementa.Text = "Incrementa";
			this.incrementa.UseVisualStyleBackColor = true;
			this.incrementa.Click += new System.EventHandler(this.incrementa_Click);
			// 
			// lblreslutado
			// 
			this.lblreslutado.AutoSize = true;
			this.lblreslutado.Location = new System.Drawing.Point(24, 240);
			this.lblreslutado.Name = "lblreslutado";
			this.lblreslutado.Size = new System.Drawing.Size(83, 13);
			this.lblreslutado.TabIndex = 10;
			this.lblreslutado.Text = "Fecha resultado";
			// 
			// fecharesultado
			// 
			this.fecharesultado.Location = new System.Drawing.Point(27, 265);
			this.fecharesultado.Name = "fecharesultado";
			this.fecharesultado.Size = new System.Drawing.Size(255, 20);
			this.fecharesultado.TabIndex = 11;
			// 
			// incremento
			// 
			this.incremento.Controls.Add(this.dias);
			this.incremento.Controls.Add(this.meses);
			this.incremento.Controls.Add(this.anyos);
			this.incremento.Location = new System.Drawing.Point(27, 123);
			this.incremento.Name = "incremento";
			this.incremento.Size = new System.Drawing.Size(102, 89);
			this.incremento.TabIndex = 12;
			this.incremento.TabStop = false;
			this.incremento.Text = "Incremento";
			// 
			// txtdiasdiferencia
			// 
			this.txtdiasdiferencia.Location = new System.Drawing.Point(340, 116);
			this.txtdiasdiferencia.Name = "txtdiasdiferencia";
			this.txtdiasdiferencia.Size = new System.Drawing.Size(100, 20);
			this.txtdiasdiferencia.TabIndex = 13;
			// 
			// txthorasdiferencia
			// 
			this.txthorasdiferencia.Location = new System.Drawing.Point(340, 171);
			this.txthorasdiferencia.Name = "txthorasdiferencia";
			this.txthorasdiferencia.Size = new System.Drawing.Size(100, 20);
			this.txthorasdiferencia.TabIndex = 14;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(337, 149);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "Horas";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(337, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 16;
			this.label3.Text = "Días";
			// 
			// diferencia
			// 
			this.diferencia.Location = new System.Drawing.Point(340, 197);
			this.diferencia.Name = "diferencia";
			this.diferencia.Size = new System.Drawing.Size(75, 23);
			this.diferencia.TabIndex = 17;
			this.diferencia.Text = "Diferencia";
			this.diferencia.UseVisualStyleBackColor = true;
			this.diferencia.Click += new System.EventHandler(this.diferencia_Click);
			// 
			// Form06DateTime
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 303);
			this.Controls.Add(this.diferencia);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txthorasdiferencia);
			this.Controls.Add(this.txtdiasdiferencia);
			this.Controls.Add(this.incremento);
			this.Controls.Add(this.fecharesultado);
			this.Controls.Add(this.lblreslutado);
			this.Controls.Add(this.incrementa);
			this.Controls.Add(this.txtincremento);
			this.Controls.Add(this.lblincremento);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cambiarformato);
			this.Controls.Add(this.txtactual);
			this.Controls.Add(this.lblfechaactual);
			this.Name = "Form06DateTime";
			this.Text = "Form06DateTime";
			this.incremento.ResumeLayout(false);
			this.incremento.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblfechaactual;
		private System.Windows.Forms.TextBox txtactual;
		private System.Windows.Forms.CheckBox cambiarformato;
		private System.Windows.Forms.RadioButton dias;
		private System.Windows.Forms.RadioButton meses;
		private System.Windows.Forms.RadioButton anyos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblincremento;
		private System.Windows.Forms.TextBox txtincremento;
		private System.Windows.Forms.Button incrementa;
		private System.Windows.Forms.Label lblreslutado;
		private System.Windows.Forms.TextBox fecharesultado;
		private System.Windows.Forms.GroupBox incremento;
		private System.Windows.Forms.TextBox txtdiasdiferencia;
		private System.Windows.Forms.TextBox txthorasdiferencia;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button diferencia;
	}
}