namespace LogicLayer
{
    public interface IPerson : ICloneable
    {
        string Address { get; set; }
        string FirstName { get; set; }
        GenderType Gender { get; set; }
        string Identity { get; }
        string LastName { get; set; }
        string Phone { get; set; }

        bool Equals(object? obj);
        void Copy(IPerson person);
    }
}