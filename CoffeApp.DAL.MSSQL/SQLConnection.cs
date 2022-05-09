using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;

namespace CoffeApp.DAL.MSSQL
{
    class SQLConnection
    {
        private readonly SqlConnection connection;

        public string Error { get; private set; }

        public SQLConnection()
        {
            connection = new SqlConnection(@"Data Source=RUDY;Initial Catalog=CoffeApp;Persist Security Info=True;User ID=sa;Password=123456");
            conectar();
        }

        private bool conectar()
        {
            try
            {
                connection.Open();
                Error = "";
                return true;
            }
            catch (Exception e)
            {
                Error = e.Message.ToString();
                return false;
                throw;
                
            }
        }
        /// <summary>
        /// Ejecuta un comando sql sobre la base de datos (insert,update,delect)
        /// </summary>
        /// <param name="command">Comando sql a Ejecutar</param>
        /// <returns>El Numero de filas afectadas, -1 cuando ha ocurrido un error.</returns>
        public int Comando(string command)
        {
            try
            {
                Debug.Print($"=====>{command}");
                SqlCommand cmd = new SqlCommand(command, connection);
                int r = cmd.ExecuteNonQuery();
                Error = "";
                return r;


            }
            catch (Exception e)
            {
                Error = e.Message;
                return -1;
                throw;
            }
        }
        /// <summary>
        /// Ejecuta una Consulta sql sobre la base de datos (select)
        /// </summary>
        /// <param name="consulta">Consulta sql</param>
        /// <returns>Registros resultantes de la consulta.</returns>
        public SqlDataReader Consulta(string consulta)
        {
            try
            {
                Debug.Print($"===>{consulta}");
                SqlCommand cmd = new SqlCommand(consulta, connection);
                SqlDataReader dataReader = cmd.ExecuteReader();
                Error = "";
                return dataReader;
            }
            catch (Exception e)
            {
                Error = e.Message;
                return null;
                throw;
            }
        }
        ~SQLConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                }
                catch (Exception e)
                {
                    Error = e.Message;
                    
                }

            }
        }
    }
}
