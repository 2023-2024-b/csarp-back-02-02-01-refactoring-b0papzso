namespace Kreata.Backend.Datas.Entities
{
    public class Admin
    {
        
        public Admin()
        {
            Id = new Guid();
            FirstName = string.Empty;
            LastName = string.Empty;
            Pay = 0;
            IssuesSolved = 0;
            IsWoman = false;
            Age = 0;
        }

        public Admin(Guid id, string firstName, string lastName, decimal pay, int issuesSolved, bool isWoman, int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Pay = pay;
            IssuesSolved = issuesSolved;
            IsWoman = isWoman;
            Age = age;
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Pay {  get; set; }
        public int IssuesSolved {  get; set; }
        public bool IsWoman { get; set; }
        public int Age { get; set; }
    }
}
