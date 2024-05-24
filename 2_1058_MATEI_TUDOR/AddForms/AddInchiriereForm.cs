using _2_1058_MATEI_TUDOR.Repositories;
using _2_1058_MATEI_TUDOR.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_1058_MATEI_TUDOR.AddForms
{
    public partial class AddInchiriereForm : Form
    {
        private InchiriereRepository _inchiriereRepository = new InchiriereRepository();

        public AddInchiriereForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var inchiriere = new Inchiriere
            {
                IdClient = int.Parse(idClientTextBox.Text),
                IdFilm = int.Parse(idFilmTextBox.Text),
                Pret = float.Parse(pretTextBox.Text),
                DataInchiriere = dataInchiriereDateTimePicker.Value,
                DataReturnare = dataReturnareDateTimePicker.Value
            };
            _inchiriereRepository.AddInchiriere(inchiriere);

            Close();
        }
    }
}
