using System;
using System.Collections.Generic;
using System.Text;

namespace PolyMorphismChallenge
{
    public abstract class DBConnection
    {
        private string ConnectionString { get; set; }
        private TimeSpan Timeout { get; set; }

        public DBConnection(string connection)
        {
            if (String.IsNullOrWhiteSpace(connection))
            {
                throw new NullReferenceException("This is not a valid connection");
            }

        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
