using Employees;

namespace TestProject1;

[TestClass]
public class EmployeesTests
{
    [TestMethod]
    public void ValidateEmployee_ShouldPass()
    {
        Employee employee = new Employee();
        employee.Name = "Tyrone Bigggums";
        employee.Email = "tBiggums@email.com";
        
        Assert.IsNotNull(employee.Name);
        Assert.IsNotNull(employee.Email);
    }
}