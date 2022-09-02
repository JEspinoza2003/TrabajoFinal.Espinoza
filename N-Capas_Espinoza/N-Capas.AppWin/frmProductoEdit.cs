using N_Capas.Dominio;
using N_Capas.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_Capas.AppWin
{
    public partial class frmProductoEdit : Form
    {
        Producto producto;
        public frmProductoEdit(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            producto.Nombre = txtNombreP.Text;
            producto.Marca = txtMarca.Text;
            producto.Precio = decimal.Parse(txtPrecio.Text.ToString());
            producto.Stock = int.Parse(txtStock.Text.ToString());
            if (producto.Precio > 2500 || producto.Stock <= 5)
            {
                MessageBox.Show("Lo siento el precio maximo para los productos solo es 2500 y El Stock tiene que se mayor a 5", "Parcial", MessageBoxButtons.OK);
                return;
            }
            else
            {

                this.DialogResult = DialogResult.OK;
            }
        }

        private void frmProductoEdit_Load(object sender, EventArgs e)
        {
            cargarDatos();
            if (producto.IdProducto > 0)
            {
                txtNombreP.Text = producto.Nombre;
                txtMarca.Text = producto.Marca;
                decimal.Parse(txtPrecio.Text = producto.Precio.ToString());
                int.Parse(txtStock.Text = producto.Stock.ToString());
            }
        }
        private void cargarDatos()
        {
            cboCategoria.DataSource = CategoriaBL.Listar();
            cboCategoria.DisplayMember = "Nombre";
            cboCategoria.ValueMember = "IdCategoria";

            cboNombreU.DataSource = UsuarioBL.Listar();
            cboNombreU.DisplayMember = "NombreCompleto";
            cboNombreU.ValueMember = "IdUsuario";
        }
    }
}
