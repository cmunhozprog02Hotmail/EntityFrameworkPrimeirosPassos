using Data;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinForms
{
    public partial class Form1 : Form
    {
        private ProductDbContext context;
        public Form1()
        {
            InitializeComponent();
            context = new ProductDbContext();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja()
            {
                Nome = "Loja Teste DevMedia"
            };
            context.Lojas.Add(loja);

            Produto produto = new Produto()
            {
                Nome = "Produto Teste DevMedia",
                Valor = 20,
                Loja = loja
            };
            context.Produtos.Add(produto);
            context.SaveChanges();
        }
    }
}
