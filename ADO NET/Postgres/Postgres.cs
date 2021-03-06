﻿using Npgsql;

namespace Postgres
{
    class Postgres : IPostgres
    {
        public string Host { get; }

        public string Username { get; }

        public string Password { get; }

        public string Database { get; }

        public NpgsqlConnection con { get; }

        public Postgres(string host, string username, string password, string database)
        {
            Host = $"Host={host};";
            Username = $"Username={username};";
            Password = $"Password={password};";
            Database = $"Database={database};";

            con = new NpgsqlConnection(Host + Username + Password + Database);
        }

        public bool IsAvailable()
        {
            try
            {
                con.Open();
                con.Close();
                return true;
            }
            catch (NpgsqlException)
            {
                return false;
            }
        }
    }
}
