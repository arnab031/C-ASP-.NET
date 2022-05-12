using System;
namespace WebApp01
{
	public class StudentModel1
	{
		public int Id { get; set; }
		public string SName { get; set; }
		public string Course { get; set; }
		public int Fee { get; set; }


	}
	public interface IStudentRepository
    {
		List<StudentModel1> GetAllStudents();
		string Category();
    }
	class DotNetStudentRepository : IStudentRepository
    {
		public string Category()
        {
			return ".NET";
        }
		public List<StudentModel1> GetAllStudents()
        {
			return new List<StudentModel1>
			{
				new StudentModel1{Id=1001,SName="Dev",Course="MVC.NET",Fee=25000},
				new StudentModel1{Id=1002,SName="Dhanush",Course="ASP.NET Core",Fee=22000},
				new StudentModel1{Id=1003,SName="Devender",Course="EF Core",Fee=21000},
				new StudentModel1{Id=1001,SName="Dayman",Course=".NET",Fee=20000}
			};
        }
    }
	class JavaStudentRepository : IStudentRepository
	{
		public string Category()
		{
			return "Java";
		}
		public List<StudentModel1> GetAllStudents()
		{
			return new List<StudentModel1>
			{
				new StudentModel1{Id=2001,SName="Jaya",Course="Spring",Fee=25000},
				new StudentModel1{Id=2002,SName="Joyita",Course="Springboot",Fee=22000},
				new StudentModel1{Id=2003,SName="Javed",Course="Core Java",Fee=21000},
				new StudentModel1{Id=2004,SName="Jiya",Course="Java",Fee=20000}
			};
		}
	}
	public class StudentContext
    {
		IStudentRepository _repository;
		public StudentContext(IStudentRepository repository)
        {
			this._repository = repository;
        }
		public List<StudentModel1> GetAllStudents()
		{
			return this._repository.GetAllStudents();
		}
		public string GetCategory()
		{
			return this._repository.Category();
		}
	}
}

