using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX_1_LISTA_1_V2
{
    public partial class Form1 : Form
    {
        private Retangulo retangulo=new Retangulo();
        public Form1()
        {
            InitializeComponent();
            txt_altura.Text = retangulo.getAltura().ToString();
            txt_base.Text = retangulo.getBase().ToString();
            txt_area.Text = retangulo.getArea().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            retangulo.setAltura(double.Parse(txt_altura.Text));
            retangulo.setBase(double.Parse(txt_base.Text));
            retangulo.calcularArea();
            txt_area.Text = retangulo.getArea().ToString();
        }
    }
}
