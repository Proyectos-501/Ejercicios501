using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
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

        private void nombre_Click(object sender, EventArgs e)
        {

        }

        private void Boton_Click(object sender, EventArgs e)
        {
            ListViewItem lista = new ListViewItem(TextBoxnombre1.Text);
            lista.SubItems.Add(TextBoxapellido2.Text);
            lista.SubItems.Add(TextBoxnumero3.Text);
            lista.SubItems.Add(TextBoxestado4.Text);
            listViewGuardaTodo.Items.Add(lista);
        }
    }
}
