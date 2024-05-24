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
    public partial class AddClientForm : Form
    {
        private ClientRepository _clientRepository = new ClientRepository();

        public AddClientForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var client = new Client
            {
                Nume = numeTextBox.Text,
                Email = emailTextBox.Text,
                Telefon = telefonTextBox.Text
            };
            _clientRepository.AddClient(client);

            Close();
        }
    }
}
