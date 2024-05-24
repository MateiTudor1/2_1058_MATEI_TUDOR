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
    public partial class EditClientForm : Form
    {
        private ClientRepository _clientRepository = new ClientRepository();
        private Client _client;

        public EditClientForm(Client client)
        {
            InitializeComponent();
            _client = client;
            numeTextBox.Text = _client.Nume;
            emailTextBox.Text = _client.Email;
            telefonTextBox.Text = _client.Telefon;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _client.Nume = numeTextBox.Text;
            _client.Email = emailTextBox.Text;
            _client.Telefon = telefonTextBox.Text;
            _clientRepository.EditClient(_client);

            Close();
        }
    }

}
