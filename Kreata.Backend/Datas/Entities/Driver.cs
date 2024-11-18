namespace Kreata.Backend.Datas.Entities
{
    public class Driver
    {
        public Driver(Guid id, string firstName, string lastName, int trips, double balance, double rating, string accountNumber, bool isWoman, bool isAdmin)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Trips = trips;
            Balance = balance;
            Rating = rating;
            AccountNumber = accountNumber;
            IsAdmin = isAdmin;
            IsWoman = isWoman;
        }
        public Driver()
        {
            Id = new Guid();
            FirstName = string.Empty;
            LastName = string.Empty;
            Trips = 0;
            Balance = 0;
            Rating = 0;
            AccountNumber = string.Empty;
            IsAdmin = false;
            IsWoman = false;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Trips {  get; set; }
        public double Balance { get; set; }
        public double Rating {  get; set; }
        public string AccountNumber {  get; set; }
        public bool IsWoman {  get; set; }
        public bool IsAdmin { get; set; }
    }
}
