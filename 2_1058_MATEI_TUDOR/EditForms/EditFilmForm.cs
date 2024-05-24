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
    public partial class EditFilmForm : Form
    {
        private FilmRepository _filmRepository = new FilmRepository();
        private Film _film;

        public EditFilmForm(Film film)
        {
            InitializeComponent();
            _film = film;

            anLansareNumericUpDown.Minimum = 0; 
            anLansareNumericUpDown.Maximum = DateTime.Now.Year; 

            titluTextBox.Text = _film.Titlu;
            genTextBox.Text = _film.Gen;
            anLansareNumericUpDown.Value = _film.AnLansare >= anLansareNumericUpDown.Minimum && _film.AnLansare <= anLansareNumericUpDown.Maximum
                ? _film.AnLansare
                : anLansareNumericUpDown.Minimum;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _film.Titlu = titluTextBox.Text;
            _film.Gen = genTextBox.Text;
            _film.AnLansare = (int)anLansareNumericUpDown.Value;
            _filmRepository.EditFilm(_film);

            Close();
        }
    }
}
