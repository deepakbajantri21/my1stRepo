using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CrudAPI.Model
{
    public class EmployeeDetailModel
    {
        [Required]
        public int Id { get; set; }
        public string Employee_Id { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_DOB { get; set; }
        public string Employee_MobileNumber { get; set; }
        public int Employee_Age { get; set; }
        public float Employee_Salary { get; set; }
        public Employee_Dept Employee_Dept { get; set; }
        public string Employee_EMail { get; set; }
        public string Employee_Image_URL { get; set; }
        
    }
    public enum Employee_Dept
    {
        Azure_Support,Azure_Implementation,Azure_Development,Devops
    }
}
