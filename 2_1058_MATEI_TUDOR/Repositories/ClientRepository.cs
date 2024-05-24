using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_1058_MATEI_TUDOR.Tables;

namespace _2_1058_MATEI_TUDOR.Repositories
{
    public class ClientRepository
    {
        public List<Client> GetClients()
        {
            var clients = new List<Client>();

            using (var connection = new OracleConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                var query = "SELECT * FROM CLIENT ORDER BY idclient";

                using (var command = new OracleCommand(query, connection))
                {
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var client = new Client
                        {
                            IdClient = Convert.ToInt32(dataReader["idclient"]),
                            Nume = dataReader["nume"].ToString(),
                            Email = dataReader["email"].ToString(),
                            Telefon = dataReader["telefon"].ToString()
                        };
                        clients.Add(client);
                    }
                }

                connection.Close();
            }

            return clients;
        }

        public void AddClient(Client client)
        {
            int nextClientID;

            using (var connection = new OracleConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();

                var idQuery = "SELECT MAX(idclient) + 1 FROM CLIENT";
                using (var command = new OracleCommand(idQuery, connection))
                {
                    var result = command.ExecuteScalar();
                    nextClientID = (result == DBNull.Value) ? 1 : Convert.ToInt32(result);
                }

                var insertQuery = @"INSERT INTO CLIENT (idclient, nume, email, telefon)
                                    VALUES (:idClient, :nume, :email, :telefon)";

                using (var command = new OracleCommand(insertQuery, connection))
                {
                    command.Parameters.Add("idClient", OracleDbType.Int32).Value = nextClientID;
                    command.Parameters.Add("nume", OracleDbType.Varchar2).Value = client.Nume;
                    command.Parameters.Add("email", OracleDbType.Varchar2).Value = client.Email;
                    command.Parameters.Add("telefon", OracleDbType.Varchar2).Value = client.Telefon;

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void DeleteClient(int clientId)
        {
            using (var connection = new OracleConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                var query = "DELETE FROM CLIENT WHERE idclient = :id";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("id", OracleDbType.Int32).Value = clientId;
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void EditClient(Client client)
        {
            using (var connection = new OracleConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();

                var updateQuery = @"UPDATE CLIENT
                                    SET nume = :nume,
                                        email = :email,
                                        telefon = :telefon
                                    WHERE idclient = :clientId";

                using (var command = new OracleCommand(updateQuery, connection))
                {
                    command.Parameters.Add("nume", OracleDbType.Varchar2).Value = client.Nume;
                    command.Parameters.Add("email", OracleDbType.Varchar2).Value = client.Email;
                    command.Parameters.Add("telefon", OracleDbType.Varchar2).Value = client.Telefon;
                    command.Parameters.Add("clientId", OracleDbType.Int32).Value = client.IdClient;

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
