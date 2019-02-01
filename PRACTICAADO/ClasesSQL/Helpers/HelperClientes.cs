using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ClasesSQL.Models;

namespace ClasesSQL.Helpers {
    #region Propiedades
    /*
     select * from clientes;
select * from pedidos;
create procedure MostrarClientes
as
	select * from clientes;
go
exec MostrarClientes;
create procedure BuscarCliente(@nom nvarchar(50))
as
	select * from clientes where Empresa = @nom;
go
exec BuscarCliente 'Bloter'
select * from pedidos;
create procedure BuscarPedidos(@codcli nvarchar(50))
as
	select * from pedidos where CodigoCliente = @codcli;
go
exec BuscarPedidos 'Mas'
create procedure BuscarPedido(@codped nvarchar(50))
as
	select * from pedidos where CodigoPedido = @codped;
go
exec BuscarPedido 'Diciembre-02-2018'
alter procedure modificarCliente(@codcli nvarchar(50),@empre nvarchar(50), @contac nvarchar(50), @cargo nvarchar(50), @ciud nvarchar(50), @tel int)
as
	update clientes set 
	Empresa = @empre, Contacto = @contac, Cargo = @cargo, 
	Ciudad = @ciud, Telefono = @tel
	where CodigoCliente = @codcli;
go
exec modificarCliente 'BLO', 'Madrid', 'Benito Camela', 'Jefe', 'Talavera', 967878999

create procedure insertarPedido(@codped nvarchar(50), @codcli nvarchar(50), @fecha datetime, @formenv nvarchar(50), @impor int)
as
	insert into pedidos values (@codped, @codcli, @fecha, @formenv, @impor);
go
exec insertarPedido 'Diciembre-04-2018', 'PRY', '2018-01-26 00:00:00.000', 'Nosotros', 44000
create procedure eliminarPedido(@codped nvarchar(50))
as
	delete from pedidos where CodigoPedido = @codped;
go 
exec eliminarPedido 'Diciembre-02-2018'
         */
    #endregion
    public class HelperClientes {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public HelperClientes(String cadenaConexion) {
            this.cn = new SqlConnection(cadenaConexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        public List<String> GetClientes() {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "MostrarClientes";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<String> clientes = new List<string>();
            while (this.reader.Read()) {
                String emp = this.reader["EMPRESA"].ToString();
                clientes.Add(emp);
            }
            this.reader.Close();
            this.cn.Close();
            return clientes;
        }
        public Cliente BuscarCliente(String nombre) {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "BuscarCliente";
            this.cn.Open();
            SqlParameter pamnom = new SqlParameter("@nom", nombre);
            this.com.Parameters.Add(pamnom);
            this.reader = this.com.ExecuteReader();
            Cliente cli = new Cliente();
            this.reader.Read();
            cli.CodCliente = this.reader["CodigoCliente"].ToString();
            cli.NomEmpresa = this.reader["Empresa"].ToString();
            cli.Contacto = this.reader["Contacto"].ToString();
            cli.Cargo = this.reader["Cargo"].ToString();
            cli.Ciudad = this.reader["Ciudad"].ToString();
            cli.Telefono = int.Parse(this.reader["Telefono"].ToString());
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return cli;
        }
        public Cliente BuscarPedidos(String codigo) {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "BuscarPedidos";
            SqlParameter pamcod = new SqlParameter("@codcli", codigo);
            this.com.Parameters.Add(pamcod);
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            Cliente cli = new Cliente();
            if (this.reader.HasRows)
            {
                cli.Pedidos = new List<Pedidos>();
                while (this.reader.Read())
                {
                    Pedidos ped = new Pedidos();
                    ped.CodPedido = this.reader["CodigoPedido"].ToString();
                    ped.CodCliente = this.reader["CodigoCliente"].ToString();
                    ped.FechEntrega = DateTime.Parse(this.reader["FechaEntrega"].ToString());
                    ped.FormaEnvio = this.reader["FormaEnvio"].ToString();
                    ped.Importe = int.Parse(this.reader["Importe"].ToString());
                    cli.Pedidos.Add(ped);
                }
                this.reader.Close();
                this.com.Parameters.Clear();
                this.cn.Close();
                return cli;
            } else {
                this.cn.Close();
                this.com.Parameters.Clear();
                return null;
            }
        }
        public Pedidos BuscarPedido(String codigo) {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "BuscarPedido";
            this.cn.Open();
            SqlParameter pamcod = new SqlParameter("@codped", codigo);
            this.com.Parameters.Add(pamcod);
            this.reader = this.com.ExecuteReader();
            Pedidos ped = new Pedidos();
            this.reader.Read();
            ped.CodPedido = this.reader["CodigoPedido"].ToString();
            ped.CodCliente = this.reader["CodigoCliente"].ToString();
            ped.FechEntrega = DateTime.Parse(this.reader["FechaEntrega"].ToString());
            ped.FormaEnvio = this.reader["FormaEnvio"].ToString();
            ped.Importe = int.Parse(this.reader["Importe"].ToString());
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return ped;
        }
        public void modificarCliente(String codcli, String empresa, String contacto, String cargo, String ciudad, int telefono) {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "modificarCliente";
            SqlParameter pamcod = new SqlParameter("@codcli", codcli);
            this.com.Parameters.Add(pamcod);
            SqlParameter pamemp = new SqlParameter("@empre", empresa);
            this.com.Parameters.Add(pamemp);
            SqlParameter pamcon = new SqlParameter("@contac", contacto);
            this.com.Parameters.Add(pamcon);
            SqlParameter pamcar = new SqlParameter("@cargo", cargo);
            this.com.Parameters.Add(pamcar);
            SqlParameter pamciu = new SqlParameter("@ciud", ciudad);
            this.com.Parameters.Add(pamciu);
            SqlParameter pamtel = new SqlParameter("@tel", telefono);
            this.com.Parameters.Add(pamtel);
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
        public void insertarPedido(String codPed, String codcli, DateTime fecha, String forma, int impo) {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "insertarPedido";
            SqlParameter pamcod = new SqlParameter("@codped", codPed);
            this.com.Parameters.Add(pamcod);
            SqlParameter pamcodcli = new SqlParameter("@codcli", codcli);
            this.com.Parameters.Add(pamcodcli);
            SqlParameter pamfec = new SqlParameter("@fecha", fecha);
            this.com.Parameters.Add(pamfec);
            SqlParameter pamfor = new SqlParameter("@formenv", forma);
            this.com.Parameters.Add(pamfor);
            SqlParameter pamimp = new SqlParameter("@impor", impo);
            this.com.Parameters.Add(pamimp);
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
        public void eliminarPedido(String codPed) {
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "eliminarPedido";
            SqlParameter pamcod = new SqlParameter("@codped", codPed);
            this.com.Parameters.Add(pamcod);
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
