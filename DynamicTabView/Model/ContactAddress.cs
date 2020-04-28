namespace DynamicTabView.Model
{
    public class ContactAddress
    {
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNo { get; set; }

        public override string ToString()
        {
            return string.Join(", ", new object[] 
            {
                string.Join(" ", new object[]
                {
                    ZipCode,
                    City
                }),
                string.Join(" ", new object[]
                {
                    Street,
                    HouseNo
                }),
            });
        }
    }
}
