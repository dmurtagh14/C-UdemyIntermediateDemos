using System;
using System.Collections.Generic;
using System.Text;

namespace WorkflowChallenge
{
    class WorkflowEngine
    {
        private List<IWorkflow> workFlow; //make a list of interfaces

        public WorkflowEngine()
        {
            workFlow = new List<IWorkflow>(); //generate generic list in constructor
        }

        public void AddWorkFlowObject(IWorkflow iObject)
        {
            workFlow.Add(iObject);
        }

        public void RemoveWorkFlowObject(IWorkflow iObject)
            //loose coupling here, doesnt directly talk to classes
        {
            workFlow.Remove(iObject);
        }

        public void Run()
        {
            foreach(IWorkflow I in workFlow)
            {
                I.Execute();
            }
        }

    }
}
