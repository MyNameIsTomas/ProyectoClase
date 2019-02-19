namespace ProyectoADO.Conectado
{
    partial class Form11InformacionHospitales
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
            this.listEspecialidades = new System.Windows.Forms.ListBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.comboHospital = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.listDoctores = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboEspecialidad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textSalario = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especialidades";
            // 
            // listEspecialidades
            // 
            this.listEspecialidades.FormattingEnabled = true;
            this.listEspecialidades.Location = new System.Drawing.Point(12, 25);
            this.listEspecialidades.Name = "listEspecialidades";
            this.listEspecialidades.Size = new System.Drawing.Size(164, 225);
            this.listEspecialidades.TabIndex = 1;
            this.listEspecialidades.SelectedIndexChanged += new System.EventHandler(this.listEspecialidades_SelectedIndexChanged);
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(352, 25);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(121, 20);
            this.textApellido.TabIndex = 2;
            // 
            // comboHospital
            // 
            this.comboHospital.FormattingEnabled = true;
            this.comboHospital.Location = new System.Drawing.Point(352, 67);
            this.comboHospital.Name = "comboHospital";
            this.comboHospital.Size = new System.Drawing.Size(121, 21);
            this.comboHospital.TabIndex = 3;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(352, 180);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 35);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // listDoctores
            // 
            this.listDoctores.FormattingEnabled = true;
            this.listDoctores.Location = new System.Drawing.Point(182, 25);
            this.listDoctores.Name = "listDoctores";
            this.listDoctores.Size = new System.Drawing.Size(164, 225);
            this.listDoctores.TabIndex = 6;
            this.listDoctores.SelectedIndexChanged += new System.EventHandler(this.listDoctores_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Doctores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hospital";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Especialidad";
            // 
            // comboEspecialidad
            // 
            this.comboEspecialidad.FormattingEnabled = true;
            this.comboEspecialidad.Location = new System.Drawing.Point(352, 111);
            this.comboEspecialidad.Name = "comboEspecialidad";
            this.comboEspecialidad.Size = new System.Drawing.Size(121, 21);
            this.comboEspecialidad.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Salario";
            // 
            // textSalario
            // 
            this.textSalario.Location = new System.Drawing.Point(352, 154);
            this.textSalario.Name = "textSalario";
            this.textSalario.Size = new System.Drawing.Size(121, 20);
            this.textSalario.TabIndex = 12;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(352, 215);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(121, 35);
            this.btnInsertar.TabIndex = 14;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // Form11InformacionHospitales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 265);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textSalario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboEspecialidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listDoctores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.comboHospital);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.listEspecialidades);
            this.Controls.Add(this.label1);
            this.Name = "Form11InformacionHospitales";
            this.Text = "Form11InformacionHospitales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listEspecialidades;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.ComboBox comboHospital;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ListBox listDoctores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboEspecialidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSalario;
        private System.Windows.Forms.Button btnInsertar;
    }
}