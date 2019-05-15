namespace Services
{
    public class Message
    {
        public int Userid { get; private set; }
        public int TimezoneOffset { get; private set; }

        public Message(int userid, int timezoneOffset = -120)
        {
            Userid = userid;
            TimezoneOffset = timezoneOffset;
        }
    }
}