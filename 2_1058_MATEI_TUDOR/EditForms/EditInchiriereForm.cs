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

namespace _2_1058_MATEI_TUDOR.EditForms
{
    public partial class EditInchiriereForm : Form
    {
        private InchiriereRepository _inchiriereRepository = new InchiriereRepository();
        private Inchiriere _inchiriere;

        public EditInchiriereForm(Inchiriere inchiriere)
        {
            InitializeComponent();
            _inchiriere = inchiriere;
            idClientTextBox.Text = _inchiriere.IdClient.ToString();
            idFilmTextBox.Text = _inchiriere.IdFilm.ToString();
            pretTextBox.Text = _inchiriere.Pret.ToString();
            dataInchiriereDateTimePicker.Value = _inchiriere.DataInchiriere;
            dataReturnareDateTimePicker.Value = _inchiriere.DataReturnare;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _inchiriere.IdClient = int.Parse(idClientTextBox.Text);
            _inchiriere.IdFilm = int.Parse(idFilmTextBox.Text);
            _inchiriere.Pret = float.Parse(pretTextBox.Text);
            _inchiriere.DataInchiriere = dataInchiriereDateTimePicker.Value;
            _inchiriere.DataReturnare = dataReturnareDateTimePicker.Value;
            _inchiriereRepository.EditInchiriere(_inchiriere);

            Close();
        }
    }
}
