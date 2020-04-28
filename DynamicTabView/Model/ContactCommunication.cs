namespace DynamicTabView.Model
{
    public class ContactCommunication
    {
        public CommunicationType CommunicationType { get; set; }
        public string Access { get; set; }

        public override string ToString()
        {
            return string.Join(" ", new object[]
            {
                Access,
                $"({CommunicationType})"
            });
        }
    }
}
