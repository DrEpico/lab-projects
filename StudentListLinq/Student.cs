using System;

public class Student
{
	public string Fullname { get; set; }
	public int Age { get; set; }
	public string CourseName { get; set; }
	public int Mark { get; set; }
	public int EnrolmentYear { get; set; }

	public Student()
	{
		Fullname = "Unknown";
		Age = -1;
		CourseName = "Unknown";
		Mark = -1;
		EnrolmentYear = 0000;
	}

	public Student(string fullname, int age, string courseName, int mark, int enrolmentYear)
	{
		Fullname= fullname;
		Age = age;
		CourseName = courseName;
		Mark = mark;
		EnrolmentYear = enrolmentYear;
	}

    //public override string ToString()
    //{
    //    return $"{Id}: {Author} ({PublishedYear}). {Title}. {Publisher}." +
    //        $"\n Pages: {PageCount}, Genre: {Genre}, Classic: {IsClassic}";
    //}
}
