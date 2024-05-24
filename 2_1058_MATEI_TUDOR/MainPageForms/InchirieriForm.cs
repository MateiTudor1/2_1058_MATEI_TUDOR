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
    public partial class InchirieriForm : Form
    {
        private InchiriereRepository _inchiriereRepository = new InchiriereRepository();

        public InchirieriForm()
        {
            InitializeComponent();
            LoadInchirieri();
            AddButtonColumn("", "Edit", "EditInchiriere");
            AddButtonColumn("", "Delete", "DeleteInchiriere");
        }

        private void LoadInchirieri()
        {
            inchirieriDataGridView.AutoGenerateColumns = true;
            inchirieriDataGridView.DataSource = _inchiriereRepository.GetInchirieri();
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

            inchirieriDataGridView.Columns.Add(column);
        }

        private void inchirieriDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var columnName = grid.Columns[e.ColumnIndex].Name;
            var inchiriere = (Inchiriere)grid.Rows[e.RowIndex].DataBoundItem;

            if (columnName == "EditInchiriere")
            {
                var editInchiriereForm = new EditInchiriereForm(inchiriere);
                editInchiriereForm.ShowDialog();
                LoadInchirieri();
            }
            else if (columnName == "DeleteInchiriere")
            {
                var result = MessageBox.Show($"Esti sigur ca vrei sa stergi inchirierea {inchiriere.IdInchiriere}?",
                    "Confirmare Stergere",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    _inchiriereRepository.DeleteInchiriere(inchiriere.IdInchiriere);
                    LoadInchirieri();
                }
            }
        }

        private void addInchiriereButton_Click(object sender, EventArgs e)
        {
            var addInchiriereForm = new AddInchiriereForm();
            addInchiriereForm.ShowDialog();
            LoadInchirieri();
        }
    }
}
