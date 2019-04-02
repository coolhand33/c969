using System;

namespace ScheduleIt
{
    internal class Reminder
    {
        public int Id { get; internal set; }
        public DateTime ReminderTime { get; internal set; }
        public string CustomerName { get; internal set; }
        public DateTime StartTime { get; internal set; }

        public Reminder(int id, DateTime reminderTime, string custName, DateTime startTime)
        {
            this.Id = id;
            this.ReminderTime = reminderTime;
            this.CustomerName = custName;
            this.StartTime = startTime;
        }
    }
}