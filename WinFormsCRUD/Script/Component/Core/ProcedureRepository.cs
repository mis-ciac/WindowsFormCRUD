using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using System.Data;
namespace WinFormsCRUD.Script.Component.Core;

public class ProcedureRepository : BaseRepository
{
    protected readonly string ConnectionString;

    protected ProcedureRepository() => ConnectionString = Globals.ConnectionConfig.ConnectionString;

    protected List<T> ExecuteStoredProcedure<T>(string storedProcedure, Func<SqlDataReader, T> mapFunction, params SqlParameter[] parameters)

    {
        var resultList = new List<T>();

        using (var connection = new SqlConnection(ConnectionString))
        {
            connection.Open();

            using (var command = new SqlCommand(storedProcedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        resultList.Add(mapFunction(reader));
                    }
                }
            }
        }

        return resultList;
    }

    protected void ExecuteStoredProcedure(string storedProcedure, Action onSuccess = null, Action onFailure = null, params SqlParameter[] parameters)
    {
        using (var connection = new SqlConnection(ConnectionString))
        {
            connection.Open();
            using (var command = new SqlCommand(storedProcedure, connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                try
                {
                    int affectedRows = command.ExecuteNonQuery();

                    if ((affectedRows > 0) || (affectedRows == -1))
                    {
                        onSuccess?.Invoke();
                    }
                    else
                    {
                        onFailure?.Invoke();
                    }
                }
                catch (Exception ex)
                {
                    // Log if needed
                    Console.WriteLine($"Stored procedure error: {ex.Message}");
                    onFailure?.Invoke();
                }
            }
        }
    }
}
