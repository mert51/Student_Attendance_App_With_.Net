namespace WEBHW1.Models
{
    public static class Repository
    {
        private static List<StudentAllList> Student = new();
        static Repository()
        {


            Student.Add(new StudentAllList { StudentId = "b261202001", Name = "Zeynep", Surname = "Yalcin", Signed = true, });
            Student.Add(new StudentAllList { StudentId = "b261202002", Name = "Mehmet", Surname = "Yildirim", Signed = true, });
            Student.Add(new StudentAllList { StudentId = "b261202003", Name = "İpek", Surname = "Yasman ", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202004", Name = "Onur", Surname = "Karaoglu", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202005", Name = "Emir", Surname = "Kaya", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202006", Name = "Hacer", Surname = "Deniz", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202007", Name = "Ezgi ", Surname = "Yildiz", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202008", Name = "Gamze", Surname = "Polat", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202009", Name = "Emir", Surname = "Yilmaz", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202010", Name = "Berk", Surname = "Çetin", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202011", Name = "Melisa", Surname = "Arslan", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202012", Name = "Sude", Surname = "Uslu ", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202013", Name = "Lina", Surname = "Collins", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202014", Name = "Maria", Surname = "Duret", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202015", Name = "Hanife", Surname = "Dahl", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202016", Name = "Freya", Surname = "Lindström", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202017", Name = "Yousef", Surname = "Khalil", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202018", Name = "Murad", Surname = "Abbasov ", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202019", Name = "Elchin", Surname = "Rasulov", Signed = false, });
            Student.Add(new StudentAllList { StudentId = "b261202020", Name = "Layla", Surname = "Karim", Signed = false, });

        }

        public static List<StudentAllList> GetGuests()
        { return Student; }

        public static void CreateGuest(StudentAllList student)
        {
            Student.Add(student);
        }

        public static void UpdateSigned(string StudentId)
        {
            foreach (var student in Student)
                if (student.StudentId == StudentId)
                {
                    student.Signed = true;
                    break;
                }

        }
        public static StudentAllList? LastSigned(string StudentId)
        {
            foreach (var student in Student)
            {
                if (student.StudentId == StudentId)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
