namespace Kreata.Backend.Datas.Entities
{
    public class Passenger
    {
        public Passenger(Guid id, string firstName, string lastName, int trips, int balance, bool isWoman, bool isAdmin)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Trips = trips;
            Balance = balance;
            IsWoman = isWoman;
            IsAdmin = isAdmin;
        }

        public Passenger()
        {
            Id = new Guid();
            FirstName = string.Empty;
            LastName = string.Empty;
            Trips = 0;
            Balance = 0;
            IsWoman= false;
            IsAdmin= false;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Trips {  get; set; }
        public int Balance { get; set; }
        public bool IsWoman { get; set; }
        public bool IsAdmin { get; set; }
    }
}
