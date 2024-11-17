using System;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public int? Id {
            get { return Id; }
            set
            {
                if (value is null or < 0)
                {
                    Random random = new Random();
                    this.Id = random.Next();
                }
            }
        }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; } = false;
    }
}