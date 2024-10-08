var students = new List<Student>
{
    new Student("John Smith", 20, "Computer Science", 85, 2022),
    new Student("Emma Johnson", 22, "Mechanical Engineering", 90, 2021),
    new Student("Michael Brown", 21, "Civil Engineering", 75, 2023),
    new Student("Olivia Williams", 19, "Business Management", 88, 2022),
    new Student("James Jones", 23, "Electrical Engineering", 95, 2021),
    new Student("Sophia Miller", 20, "Architecture", 80, 2022),
    new Student("Liam Davis", 22, "Economics", 78, 2023),
    new Student("Isabella Garcia", 21, "Law", 92, 2022),
    new Student("Lucas Martinez", 20, "Physics", 84, 2023),
    new Student("Ava Rodriguez", 19, "Chemistry", 77, 2022),
    new Student("Benjamin Wilson", 23, "Mathematics", 91, 2021),
    new Student("Mia Anderson", 20, "Biology", 89, 2022),
    new Student("Elijah Thomas", 21, "Mechanical Engineering", 86, 2023),
    new Student("Charlotte Lee", 19, "Psychology", 79, 2022),
    new Student("Henry White", 22, "History", 88, 2021),
    new Student("Amelia Harris", 20, "Geography", 82, 2023),
    new Student("Ethan Clark", 21, "Political Science", 85, 2022),
    new Student("Harper Lewis", 19, "Philosophy", 87, 2023),
    new Student("Alexander Walker", 23, "Sociology", 90, 2021),
    new Student("Evelyn Hall", 20, "English Literature", 83, 2022)
};

static void DisplayStudentList(List<Student> studentList)
{
    foreach (Student student in studentList)
    {
        Console.WriteLine(student);
    }
}
