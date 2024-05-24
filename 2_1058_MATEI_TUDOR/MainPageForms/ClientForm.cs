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
    public partial class ClientForm : Form
    {
        private ClientRepository _clientRepository = new ClientRepository();

        public ClientForm()
        {
            InitializeComponent();
            LoadClients();
            AddButtonColumn("", "Edit", "EditClient");
            AddButtonColumn("", "Delete", "DeleteClient");
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

            clientDataGridView.Columns.Add(column);
        }

        private void LoadClients()
        {
            clientDataGridView.AutoGenerateColumns = true;
            clientDataGridView.DataSource = _clientRepository.GetClients();
        }

        private void clientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var columnName = grid.Columns[e.ColumnIndex].Name;
            var client = (Client)grid.Rows[e.RowIndex].DataBoundItem;

            if (columnName == "EditClient")
            {
                var editClientForm = new EditClientForm(client);
                editClientForm.ShowDialog();
                LoadClients();
            }
            else if (columnName == "DeleteClient")
            {
                var result = MessageBox.Show($"Esti sigur ca vrei sa stergi clientul {client.IdClient}?",
                    "Confirmare Stergere",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    _clientRepository.DeleteClient(client.IdClient);
                    LoadClients();
                }
            }
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            var addClientForm = new AddClientForm();
            addClientForm.ShowDialog();
            LoadClients();
        }
    }
}
