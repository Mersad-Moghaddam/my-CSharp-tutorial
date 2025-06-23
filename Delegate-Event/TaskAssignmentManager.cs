using System;
namespace Delegate_Event
{
    internal class TaskAssignmentManager
    {
        public delegate void TaskAssignedEventHandler(object sender, OfficeTask task);
        public event TaskAssignedEventHandler TaskAssigned;

        protected virtual void OnTaskAssigned(OfficeTask task)
        {
            TaskAssigned?.Invoke(this, task);
        }
        public void AssignTask(string taskName)
        {
            OfficeTask newTask = new OfficeTask(taskName);
            Console.WriteLine($"Task '{newTask.TaskName}' has been assigned.");
            OnTaskAssigned(newTask);
        }
    }
}