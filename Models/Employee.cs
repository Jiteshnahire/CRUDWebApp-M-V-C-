namespace PracticalTestMVC.Models
{
	public class Employee
	{
        public int ID { get; set; }
        public int DeptID { get; set; }
        public String? FirstName { get; set; }
		public String? LastName { get; set; }
		public DateTime BirthDate   { get; set; }
		public String? Gender { get; set; }
		public String? Coutnry { get; set; }
        public int Salary { get; set; }



    }
}
