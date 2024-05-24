using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_1058_MATEI_TUDOR.Tables;

namespace _2_1058_MATEI_TUDOR.Repositories
{
    public class FilmRepository
    {
        public List<Film> GetFilms()
        {
            var films = new List<Film>();

            using (var connection = new OracleConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                var query = "SELECT idfilm, titlu, gen, anlansare FROM FILM ORDER BY idfilm";

                using (var command = new OracleCommand(query, connection))
                {
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        var film = new Film
                        {
                            IdFilm = Convert.ToInt32(dataReader["idfilm"]),
                            Titlu = dataReader["titlu"].ToString(),
                            Gen = dataReader["gen"].ToString(),
                            AnLansare = Convert.ToInt32(dataReader["anlansare"])
                        };
                        films.Add(film);
                    }
                }

                connection.Close();
            }

            return films;
        }

        public void AddFilm(Film film)
        {
            int nextFilmID;

            using (var connection = new OracleConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();

                var idQuery = "SELECT MAX(idfilm) + 1 FROM FILM";
                using (var command = new OracleCommand(idQuery, connection))
                {
                    var result = command.ExecuteScalar();
                    nextFilmID = (result == DBNull.Value) ? 1 : Convert.ToInt32(result);
                }

                var insertQuery = @"INSERT INTO FILM (idfilm, titlu, gen, anlansare)
                                    VALUES (:idFilm, :titlu, :gen, :anLansare)";

                using (var command = new OracleCommand(insertQuery, connection))
                {
                    command.Parameters.Add("idFilm", OracleDbType.Int32).Value = nextFilmID;
                    command.Parameters.Add("titlu", OracleDbType.Varchar2).Value = film.Titlu;
                    command.Parameters.Add("gen", OracleDbType.Varchar2).Value = film.Gen;
                    command.Parameters.Add("anLansare", OracleDbType.Int32).Value = film.AnLansare;

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void DeleteFilm(int filmId)
        {
            using (var connection = new OracleConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();
                var query = "DELETE FROM FILM WHERE idfilm = :id";

                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add("id", OracleDbType.Int32).Value = filmId;
                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }

        public void EditFilm(Film film)
        {
            using (var connection = new OracleConnection(DatabaseConnection.ConnectionString))
            {
                connection.Open();

                var updateQuery = @"UPDATE FILM
                                    SET titlu = :titlu,
                                        gen = :gen,
                                        anlansare = :anLansare
                                    WHERE idfilm = :filmId";

                using (var command = new OracleCommand(updateQuery, connection))
                {
                    command.Parameters.Add("titlu", OracleDbType.Varchar2).Value = film.Titlu;
                    command.Parameters.Add("gen", OracleDbType.Varchar2).Value = film.Gen;
                    command.Parameters.Add("anLansare", OracleDbType.Int32).Value = film.AnLansare;
                    command.Parameters.Add("filmId", OracleDbType.Int32).Value = film.IdFilm;

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }
        }
    }
}
