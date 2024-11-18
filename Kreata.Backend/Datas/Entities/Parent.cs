namespace Kreata.Backend.Datas.Entities
{
    public class Parent
    {
        

        public Parent(Guid id, string firstName, string lastName, bool isWoman, string residence)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            IsWoman = isWoman;
            Residence = residence;
        }

        public Parent()
        {
            Id = Guid.NewGuid();
            FirstName = string.Empty;
            LastName = string.Empty;
            IsWoman = false;
            Residence = string.Empty;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsWoman { get; set; }
        public string Residence { get; set; }
    }
}
