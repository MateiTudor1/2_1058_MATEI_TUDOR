using _2_1058_MATEI_TUDOR.AddForms;
using _2_1058_MATEI_TUDOR.EditForms;
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

namespace _2_1058_MATEI_TUDOR.MainPageForms
{
    public partial class FilmForm : Form
    {
        private FilmRepository _filmRepository = new FilmRepository();

        public FilmForm()
        {
            InitializeComponent();
            LoadFilms();
            AddButtonColumn("", "Edit", "EditFilm");
            AddButtonColumn("", "Delete", "DeleteFilm");
        }

        private void LoadFilms()
        {
            filmDataGridView.AutoGenerateColumns = true;
            filmDataGridView.DataSource = _filmRepository.GetFilms();

            
        }
        private void AddButtonColumn(string headerText, string buttonText, string columnName)
        {
            DataGridViewButtonColumn column = new DataGridViewButtonColumn
            {
                HeaderText = headerText,
                Text = buttonText,
                UseColumnTextForButtonValue = true,
                Name = columnName
            };

            filmDataGridView.Columns.Add(column);
        }

        private void filmDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var columnName = grid.Columns[e.ColumnIndex].Name;
            var film = (Film)grid.Rows[e.RowIndex].DataBoundItem;

            if (columnName == "EditFilm")
            {
                var editFilmForm = new EditFilmForm(film);
                editFilmForm.ShowDialog();
                LoadFilms();
            }
            else if (columnName == "DeleteFilm")
            {
                var result = MessageBox.Show($"Esti sigur ca vrei sa stergi filmul {film.IdFilm}?",
                    "Confirmare Stergere",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    _filmRepository.DeleteFilm(film.IdFilm);
                    LoadFilms();
                }
            }

        }

        private void addFilmButton_Click_1(object sender, EventArgs e)
        {
            var addFilmForm = new AddFilmForm();
            addFilmForm.ShowDialog();
            LoadFilms();
        }
    }
    
}
