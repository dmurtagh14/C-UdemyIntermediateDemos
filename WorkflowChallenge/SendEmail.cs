using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowChallenge
{
    class SendEmail : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email...");
        }
    }
}
