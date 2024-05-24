using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_1058_MATEI_TUDOR.Tables;

namespace _2_1058_MATEI_TUDOR.Repositories
{
    public class InchiriereRepository
    {
        public List<Inchiriere> GetInchirieri()
        {
            var inchirieri = new List<Inchiriere>();

            using (var connection = new OracleConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                var query = "SELECT * FROM INCHIRIERE ORDER BY idinchiriere";

                using (var command = new OracleCommand(query, connection))
                {
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var inchiriere = new Inchiriere
                        {
                            IdInchiriere = Convert.ToInt32(dataReader["idinchiriere"]),
                            IdClient = Convert.ToInt32(dataReader["idclient"]),
                            IdFilm = Convert.ToInt32(dataReader["idfilm"]),
                            Pret = Convert.ToSingle(dataReader["pret"]),
                            DataInchiriere = Convert.ToDateTime(dataReader["datainchiriere"]),
                            DataReturnare = Convert.ToDateTime(dataReader["datareturnare"])
                        };
                        inchirieri.Add(inchiriere);
                    }
                }

                connection.Close();
            }

            return inchirieri;
        }

        public void AddInchiriere(Inchiriere inchiriere)
        {
            int nextInchiriereID;

            using (var connection = new OracleConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();

                var idQuery = "SELECT MAX(idinchiriere) + 1 FROM INCHIRIERE";
                using (var command = new OracleCommand(idQuery, connection))
                {
                    var result = command.ExecuteScalar();
                    nextInchiriereID = (result == DBNull.Value) ? 1 : Convert.ToInt32(result);
                }

                var insertQuery = @"INSERT INTO INCHIRIERE (idinchiriere, idclient, idfilm, pret, datainchiriere, datareturnare)
                                    VALUES (:idInchiriere, :idClient, :idFilm, :pret, :dataInchiriere, :dataReturnare)";

                using (var command = new OracleCommand(insertQuery, connection))
                {
                    command.Parameters.Add("idInchiriere", OracleDbType.Int32).Value = nextInchiriereID;
                    command.Parameters.Add("idClient", OracleDbType.Int32).Value = inchiriere.IdClient;
                    command.Parameters.Add("idFilm", OracleDbType.Int32).Value = inchiriere.IdFilm;
                    command.Parameters.Add("pret", OracleDbType.Single).Value = inchiriere.Pret;
                    command.Parameters.Add("dataInchiriere", OracleDbType.Date).Value = inchiriere.DataInchiriere;
                    command.Parameters.Add("dataReturnare", OracleDbType.Date).Value = inchiriere.DataReturnare;

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void DeleteInchiriere(int inchiriereId)
        {
            using (var connection = new OracleConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                var query = "DELETE FROM INCHIRIERE WHERE idinchiriere = :id";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("id", OracleDbType.Int32).Value = inchiriereId;
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void EditInchiriere(Inchiriere inchiriere)
        {
            using (var connection = new OracleConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();

                var updateQuery = @"UPDATE INCHIRIERE
                                    SET idclient = :idClient,
                                        idfilm = :idFilm,
                                        pret = :pret,
                                        datainchiriere = :dataInchiriere,
                                        datareturnare = :dataReturnare
                                    WHERE idinchiriere = :inchiriereId";

                using (var command = new OracleCommand(updateQuery, connection))
                {
                    command.Parameters.Add("idClient", OracleDbType.Int32).Value = inchiriere.IdClient;
                    command.Parameters.Add("idFilm", OracleDbType.Int32).Value = inchiriere.IdFilm;
                    command.Parameters.Add("pret", OracleDbType.Single).Value = inchiriere.Pret;
                    command.Parameters.Add("dataInchiriere", OracleDbType.Date).Value = inchiriere.DataInchiriere;
                    command.Parameters.Add("dataReturnare", OracleDbType.Date).Value = inchiriere.DataReturnare;
                    command.Parameters.Add("inchiriereId", OracleDbType.Int32).Value = inchiriere.IdInchiriere;

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
