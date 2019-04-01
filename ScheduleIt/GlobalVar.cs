namespace ScheduleIt
{
    public class LoggedInUser
    {
        private static string _Username { get; set; }
        private static int _UserId { get; set; }

        public static string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        public static int UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
    }
}
