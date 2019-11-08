using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowChallenge
{
    class VideoUploader : IWorkflow
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video!");
        }
    }
}
