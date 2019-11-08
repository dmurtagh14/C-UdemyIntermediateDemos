using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowChallenge
{
    class CallWebService : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service...");
        }
    }
}
