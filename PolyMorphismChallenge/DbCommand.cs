using System;
using System.Collections.Generic;
using System.Text;

namespace PolyMorphismChallenge
{
    class DbCommand
    {
        private DBConnection _connection { get; set; }
        private string _instruction { get; set; }
        public DbCommand(DBConnection conncetion, string instruction)
        {
           
                _connection = conncetion;
                _instruction = instruction;
            
        }

        private void Run()
        {
            Console.WriteLine(this._instruction);
        }

        public void Execute()
        {
            _connection.OpenConnection();
            Run();
            _connection.CloseConnection();
        }
    }
}
