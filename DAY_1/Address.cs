namespace DAY_1
{
    class Address
    {
        public string City;
        public string Street;
        public uint Number;
        public Address() { }
        public Address(string City, string Street, uint Number)
        {
            this.City = City;
            this.Street = Street;
            this.Number = Number;
        }
    }
}