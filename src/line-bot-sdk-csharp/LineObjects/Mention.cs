namespace LineMessagingAPI
{
    public class Mention
    {
        public Mention(Mentionees[] mentionees)
        {
            Mentionees = mentionees;
        }
        public Mentionees[] Mentionees { get; set; }
    }

    public class Mentionees
    {
        public Mentionees(int index,int length,string userId)
        {
            Index = index;
            Length = length;
            UserId = userId;
        }
        public int Index { get; set; }
        public int Length { get; set; }
        public string UserId { get; set; }
    }

}
