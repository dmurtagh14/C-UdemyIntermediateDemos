using System;

namespace PolyMorphismChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var sql = new SqlConnection("Hello");
            sql.OpenConnection();
            sql.CloseConnection();

            var oracle = new Oracle("");
            oracle.OpenConnection(); */

            var command = new DbCommand(new SqlConnection("hello"), "Run this instruction");
            var command2 = new DbCommand(new Oracle(""), "Please run this oracle instruction");

            command.Execute();
            command2.Execute();
        }
    }
}
