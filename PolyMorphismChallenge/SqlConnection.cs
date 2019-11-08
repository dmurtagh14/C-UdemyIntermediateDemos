using System;
using System.Collections.Generic;
using System.Text;

namespace PolyMorphismChallenge
{
    class SqlConnection : DBConnection
    {
        public SqlConnection(string connection)
            :base(connection)
        {

        }
        public override void CloseConnection()
        {
            Console.WriteLine("sql Connection is closed");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("sql Connection is open");
        }
    }
}
