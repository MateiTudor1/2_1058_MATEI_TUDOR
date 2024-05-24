using _2_1058_MATEI_TUDOR.MainPageForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1058_MATEI_TUDOR
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void filmebutton_Click(object sender, EventArgs e)
        {
            var filmForm=new FilmForm();
            filmForm.ShowDialog();
        }

        private void clientiButton_Click(object sender, EventArgs e)
        {
            var clientForm=new ClientForm();
            clientForm.ShowDialog();
        }

        private void InchirieriButton_Click(object sender, EventArgs e)
        {
            var inchirieriForm=new InchirieriForm();
            inchirieriForm.ShowDialog();
        }
    }
}
