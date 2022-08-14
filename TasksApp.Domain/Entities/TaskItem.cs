using System;


namespace tasksapp.domain.Entities
{
    public class TaskItem : Entity
    {
        
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool Done { get; private set; } 
        public DateTime Date { get; private set; }
        public string User { get; private set; }

        public TaskItem(string title, string description, bool done, DateTime date, string user)
        {
            Title = title;
            Description = description;
            Done = false;
            Date = date;
            User = user;
        }

        public void MarkAsDone() { Done = true; }
        public void MarkAsUndone() { Done = false; }
        public void UpdateTitle(string title) { Title = title; }
        public void UpdateDescription(string description) { Description = description; }
    }
}
