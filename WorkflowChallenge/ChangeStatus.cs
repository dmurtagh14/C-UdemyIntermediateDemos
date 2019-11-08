using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowChallenge
{
    class ChangeStatus : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Status changed...");
        }
    }
}
