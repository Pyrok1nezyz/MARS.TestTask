﻿using System.Reflection.Metadata;
using MARS.TestTask.ClassLibrary;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace MARS.TestTask.DBContext;

public class SqlServerMethods
{
    public static List<Table> GetTableNames()
    {
        var connectionString =
            $"Server=localhost;Database=MARS.TestTask;Trusted_Connection=True;TrustServerCertificate=True";
        var query = $"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
        List<Table> listTables = new List<Table>() ;

        var connection = new SqlConnection(connectionString);
        connection.Open();
        var cmd = new SqlCommand(query, connection);
        var reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                //var table = new Table() { Name = string.Concat(reader.GetString(1), '.', reader.GetString(2)) };
                var table = new Table() { Название_таблицы = reader.GetString(0) };
                listTables.Add(table);
            }
        }
        connection.Close();
        return listTables;
    }

    public static List<string> GetColumns(string tableName)
    {
        var connectionString =
            $"Server=localhost;Database=MARS.TestTask;Trusted_Connection=True;TrustServerCertificate=True";
        var query = $"SELECT COLUMN_NAME,DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME=@TableName";

        List<string> listTables = new List<string>();

        var connection = new SqlConnection(connectionString);
        connection.Open();
        var cmd = new SqlCommand(query, connection);
        SqlParameter parameter = new SqlParameter("@TableName", tableName);
        cmd.Parameters.Add(parameter);

        var reader = cmd.ExecuteReader();

        if (reader.HasRows)
        {
            while (reader.Read())
            {
                var i = 0;
                try
                {
                    do
                    {
                        listTables.Add(reader.GetString(i));
                        i++;
                    } while (!reader.IsDBNull(i));
                }
                catch
                {

                }

            }
        }
        connection.Close();

        return listTables;
    }

    public static bool TryConnectToDB()
    {
        try
        {
            using (var db = new MsSqlContext())
            {
                return true;
            }
        }
        catch
        {
            return false;
        }
    }
}