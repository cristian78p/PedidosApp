using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidosApp
{
    public partial class HistorialForm : Form
    {
        public HistorialForm()
        {
            InitializeComponent();
            CargarTiposEntrega();
            CargarPedidos();
        }
        private void CargarTiposEntrega()
        {
            var tipos = RegistroPedidos.Instancia.Pedidos
                .Select(p => p.MetodoEntrega.TipoEntrega())
                .Distinct()
                .ToList();
            tipos.Insert(0, "Todos");
            cmbFiltroEntrega.DataSource = tipos;
        }
        private void CargarPedidos(string filtro = "Todos")
        {
            var pedidos = RegistroPedidos.Instancia.Pedidos;

            if (filtro != "Todos")
                pedidos = pedidos.Where(p => p.MetodoEntrega.TipoEntrega() == filtro).ToList();

            dgvHistorial.DataSource = pedidos.Select(p => new
            {
                p.Cliente,
                p.Producto,
                p.Urgente,
                p.Peso,
                p.Distancia,
                Metodo = p.MetodoEntrega.TipoEntrega(),
                Costo = p.ObtenerCosto()
            }).ToList();
        }

        private void cmbFiltroEntrega_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarPedidos(cmbFiltroEntrega.SelectedItem.ToString());
        }
    }
}
