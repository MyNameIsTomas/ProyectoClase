using ClasesSQL.Helpers;
using ClasesSQL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoADO {
    public partial class FormPractica : Form {
        HelperClientes helper;
        List<String> clientes;
        string codClientes;
        public FormPractica() {
            InitializeComponent();
            String cadenaConexion = @"Data Source=LOCALHOST;Initial Catalog=PRACTICAADO;Persist Security Info=True;User ID=SA;Password='MCSD2018'";
            this.helper = new HelperClientes(cadenaConexion);
            this.cargarClientes();
        }
        private void cargarClientes() {
            this.cmbclientes.Items.Clear();
            this.clientes = helper.GetClientes();
            this.codClientes = "";
            foreach (String cli in clientes){
                this.cmbclientes.Items.Add(cli);
            }
        }
        private void cmbclientes_SelectedIndexChanged(object sender, EventArgs e) {
            int indice = this.cmbclientes.SelectedIndex;
            if (indice != -1) {
                this.codClientes = "";
                String nomClien = this.cmbclientes.SelectedItem.ToString();
                Cliente clien = this.helper.BuscarCliente(nomClien);
                this.txtempresa.Text = clien.NomEmpresa;
                this.txtcontacto.Text = clien.Contacto;
                this.txtcargo.Text = clien.Cargo;
                this.txtciudad.Text = clien.Ciudad;
                this.txttelefono.Text = clien.Telefono.ToString();
                this.codClientes = clien.CodCliente;
                //Mostrar los pedidos
                this.mostrarPedidos();
            }
        }
        private void mostrarPedidos() {
            this.lstpedidos.Items.Clear();
            Cliente clien = this.helper.BuscarPedidos(codClientes);
            this.lstpedidos.Items.Clear();
            this.txtcodigopedido.Text = "";
            this.txtformaenvio.Text = "";
            this.txtimporte.Text = "";
            this.txtfechaentrega.Text = "";
            if (clien is null) {
                Console.WriteLine("No hay pedidos");
            } else {
                foreach (Pedidos ped in clien.Pedidos)
                {
                    this.lstpedidos.Items.Add(ped.CodPedido);
                }
            }
        }
        private void lstpedidos_SelectedIndexChanged(object sender, EventArgs e) {
            int indice = this.lstpedidos.SelectedIndex;
            if (indice != -1) {
                String codPed = this.lstpedidos.SelectedItem.ToString();
                Pedidos ped = this.helper.BuscarPedido(codPed);
                this.txtcodigopedido.Text = ped.CodPedido;
                this.txtfechaentrega.Text = ped.FechEntrega.ToString();
                this.txtformaenvio.Text = ped.FormaEnvio;
                this.txtimporte.Text = ped.Importe.ToString();
            }
        }

        private void btnmodificarcliente_Click(object sender, EventArgs e) {
            String empresa = this.txtempresa.Text;
            String contacto = this.txtcontacto.Text;
            String cargo = this.txtcargo.Text;
            String ciudad = this.txtciudad.Text;
            int telefono = int.Parse(this.txttelefono.Text);
            this.helper.modificarCliente(codClientes, empresa, contacto, cargo, ciudad, telefono);
            this.cargarClientes();
        }
        private void btnnuevopedido_Click(object sender, EventArgs e) {
            String codPed = this.txtcodigopedido.Text;
            DateTime fecha = DateTime.Parse(this.txtfechaentrega.Text);
            String forma = this.txtformaenvio.Text;
            int impo = int.Parse(this.txtimporte.Text);
            this.helper.insertarPedido(codPed, codClientes, fecha, forma, impo);
            this.mostrarPedidos();
        }
        private void btneliminarpedido_Click(object sender, EventArgs e) {
            String codPed = this.txtcodigopedido.Text;
            this.helper.eliminarPedido(codPed);
            this.mostrarPedidos();
        }
    }
}
