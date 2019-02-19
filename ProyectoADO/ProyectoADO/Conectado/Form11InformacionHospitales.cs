using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesSQL.Helpers;
using ClasesSQL.Models;

namespace ProyectoADO.Conectado {
    public partial class Form11InformacionHospitales : Form
    {
        HelperDoctores helper;
        List<String> espe;
        List<String> hospi;
        List<Hospitales> hospitales;
        List<int> codigodocotres;
        public Form11InformacionHospitales()
        {
            InitializeComponent();
            String cadenaConexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password='MCSD2018'";
            this.helper = new HelperDoctores(cadenaConexion);
            this.espe = helper.GetEspecialidades();
            this.hospi = helper.GetHospitales();
            this.codigodocotres = new List<int>();
            foreach (String esp in espe)
            {
                this.listEspecialidades.Items.Add(esp);
                this.comboEspecialidad.Items.Add(esp);
            }
            foreach (String hos in hospi)
            {
                this.comboHospital.Items.Add(hos);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.listDoctores.SelectedIndex;
            int docno = this.codigodocotres[indice];
            int salario = int.Parse(this.textSalario.Text);
            String nomHosp = this.comboHospital.SelectedItem.ToString();
            String apellido = this.textApellido.Text;
            String especialidad = this.comboEspecialidad.SelectedItem.ToString();
            this.helper.modificaDoctor(nomHosp, docno, salario, apellido, especialidad);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            String nomHosp = this.comboHospital.SelectedItem.ToString();
            int salario = int.Parse(this.textSalario.Text);
            String apellido = this.textApellido.Text;
            String especialidad = this.comboEspecialidad.SelectedItem.ToString();
            this.helper.insertarDoctor(nomHosp, apellido, especialidad, salario);
        }

        private void listEspecialidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.listEspecialidades.SelectedIndex;
            if (indice != -1)
            {
                String espe = this.listEspecialidades.SelectedItem.ToString();
                Hospitales hospit = this.helper.BuscarDoctores(espe);
                this.listDoctores.Items.Clear();
                this.codigodocotres.Clear();
                if (espe is null)
                {
                    Console.WriteLine("No hay doctores");
                }
                else
                {
                    foreach (Doctor doc in hospit.Doctor)
                    {
                        this.listDoctores.Items.Add(doc.Apellido);
                        this.codigodocotres.Add(doc.NumeroDoctor);
                    }
                }
            }
        }
        private void listDoctores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.listDoctores.SelectedIndex;
            if (indice != -1)
            {
                int docno = this.codigodocotres[indice];
                Doctor doc = this.helper.BuscarDoctor(docno);
                this.textSalario.Text = doc.Salario.ToString();
                this.textApellido.Text = doc.Apellido;
                this.comboHospital.SelectedItem = doc.NomHospital;
                this.comboEspecialidad.SelectedIndex = this.listEspecialidades.SelectedIndex;
            }
        }
    }
}

