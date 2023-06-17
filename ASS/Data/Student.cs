namespace ASS.Data
{
    public partial class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public virtual ICollection<Enrollment> Enrollments { get; } = new List<Enrollment>();
    }
}
