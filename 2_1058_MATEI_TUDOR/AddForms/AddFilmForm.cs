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
    public partial class AddFilmForm : Form
    {

        private FilmRepository _filmRepository = new FilmRepository();
        public AddFilmForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Setare valori minime și maxime pentru anLansareNumericUpDown
            anLansareNumericUpDown.Minimum = 0; // Exemplu de valoare minimă
            anLansareNumericUpDown.Maximum = DateTime.Now.Year; // Exemplu de valoare maximă (anul curent)
            anLansareNumericUpDown.Value = anLansareNumericUpDown.Maximum; // Setează valoarea implicită la anul curent
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var film = new Film
            {
                Titlu = titluTextBox.Text,
                Gen = genTextBox.Text,
                AnLansare = (int)anLansareNumericUpDown.Value
            };
            _filmRepository.AddFilm(film);

            Close();
        }
    }
}
