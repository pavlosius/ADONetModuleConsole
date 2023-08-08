﻿using System.Data;
using Microsoft.Data.SqlClient;

namespace ADONetLib
{
    public class MainConnector
    {
        readonly SqlConnection connection = new SqlConnection(ConnectionString.MsSqlConnection);

        public async Task<bool> ConnectAsync()
        {
            bool result;
            try
            {
                await connection.OpenAsync();
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public async void DisconnectAsync()
        {
            if (connection.State == ConnectionState.Open)
            {
                await connection.CloseAsync();
            }
        }
        public SqlConnection GetConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                return connection;
            }
            else
            {
                throw new Exception("Подключение уже закрыто!");
            }
        }
    }
}