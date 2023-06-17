namespace ASS.Data
{
    public partial class Lecturer
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public virtual ICollection<Class> Classes { get; } = new List<Class>();
    }
}
