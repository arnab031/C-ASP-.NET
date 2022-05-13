using System;
namespace WebApp01
{
    public class EmpModel
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public string Job { get; set; }
        public int Salary { get; set; }
    }
    public interface IEmployeeRepository
    {
        List<EmpModel> GetEmployees();
        string Category();
    }
    public class HrEmployeesRepository:IEmployeeRepository
    {
        private List<EmpModel> employees;
        public HrEmployeesRepository()
        {
            employees = new List<EmpModel>()
            {
                new EmpModel{Id=1001,EName="Harish",Job="HR Manager",Salary=12500},
                new EmpModel{Id=1002,EName="Hemanth",Job="HR Recruiter",Salary=10500},
                new EmpModel{Id=1003,EName="Hanuman",Job="HR Admin",Salary=11500}
            };
        }
        public List<EmpModel> GetEmployees()
        {
            return employees;
        }
        public string Category()
        {
            return "HR";
        }
    }
    public class TechnicalEmployeesRepository:IEmployeeRepository
    {
        private List<EmpModel> employees;
        public TechnicalEmployeesRepository()
        {
            employees = new List<EmpModel>()
            {
                new EmpModel{Id=2001,EName="Tarun",Job="Programmer",Salary=22500},
                new EmpModel{Id=2001,EName="Trinath",Job="Developer",Salary=20500},
            };
        }
        public List<EmpModel> GetEmployees()
        {
            return employees;
        }
        public string Category()
        {
            return "Techincal";
        }
    }
    //public class EmpContext
    //{
    //    public IEmployeeRepository _empRepository;
    //    public EmpContext(IEmployeeRepository employeeRepository)
    //    {
    //        this._empRepository = employeeRepository;
    //    }
    //}
}

