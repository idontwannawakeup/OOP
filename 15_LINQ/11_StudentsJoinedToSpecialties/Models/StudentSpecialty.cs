namespace _11_StudentsJoinedToSpecialties.Models
{
    class StudentSpecialty
    {
        public string SpecialtyName { get; }
        public int FacultyNumber { get; }

        public static StudentSpecialty Parse(string input)
        {
            string[] info = input.Split(' ');
            return new StudentSpecialty(info[0] + " " + info[1], info[2]);
        }

        public StudentSpecialty(string specialtyName, string facultyNumber)
            : this(specialtyName, int.Parse(facultyNumber))
        { }

        public StudentSpecialty(string specialtyName, int facultyNumber)
        {
            SpecialtyName = specialtyName;
            FacultyNumber = facultyNumber;
        }
    }
}
