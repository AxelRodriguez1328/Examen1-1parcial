using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AxelRodriguez
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal precio = Convert.ToDecimal(preciotextBox.Text);
            int cantidad = Convert.ToInt16(cantidadtextBox.Text);
            decimal subtotal = Convert.ToDecimal(subtotaltextBox.Text);
            subtotal = precio * cantidad;
            decimal descuento = await descuentoAsync(subtotal);
            decimal total = Convert.ToDecimal(totaltextBox.Text);
            
        }

        private async Task<decimal> descuentoAsync(decimal subtotal)
        {
            decimal desc = await Task.Run(() =>
                {
                    
                    desc = subtotal*desc;
                    return desc;

                });
        }
    }
}
