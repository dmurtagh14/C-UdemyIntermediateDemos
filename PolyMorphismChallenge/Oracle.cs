using System;
using System.Collections.Generic;
using System.Text;

namespace PolyMorphismChallenge
{
    class Oracle : DBConnection
    {
        public Oracle(string connection)
            :base(connection)
        {

        }
        public override void CloseConnection()
        {
            Console.WriteLine("oracle Connection is closed");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("oracle Connection is open");
        }
    }
}
