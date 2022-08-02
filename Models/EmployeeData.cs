namespace EmployeeApi.Controllers.Models
{
    public class EmployeeData
    {

        public List<EmployeeClass> employeesList { get; set; }

        public EmployeeData()
        {
            employeesList = new List<EmployeeClass>()
            {
                 new EmployeeClass()
        {
            Id =001,
            Name="Nakshatra" ,
            phonenumber=984826,
            Email ="nakshatra@gmail.com",
            city ="Hyderabad",
            age=21 ,

    },
  new EmployeeClass()
        {
             Id =002,
            Name="Ravi" ,
            phonenumber=630318,
            Email ="ravi@gmail.com",
            city ="secunderabad",
            age=25 ,
                },
                new EmployeeClass()
        {
             Id =003,
            Name="Prav" ,
            phonenumber=925524,
            Email ="prav@gmail.com",
            city ="kukatpally",
            age=21 ,
                },
                new EmployeeClass()
                {
                    Id  =004,
                    Name="Manisha",
                    phonenumber=725436,
                    Email ="manisha@gmail.com",
                    city ="vishakapatnam"
                },
                 new EmployeeClass()
                {
                    Id  =005,
                    Name="Prashant",
                    phonenumber=952634,
                    Email ="prashant@gmail.com",
                    city ="UP"
                 }

    };
        }
    }
}
    
