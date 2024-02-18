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

    [TestMethod]
    public void ValidateEmployee_ShouldFailForEmail()
    {
        Employee employee = new Employee();
        employee.Name = "Tyrone Bigggums";
        employee.Email = "tBiggumsemail.com";
        
        try
        {
            Assert.IsNotNull(employee.Name);
            Assert.IsNotNull(employee.Email);
        }
        catch (Exception ex)
        {
            Assert.AreEqual("Invalid Email Format", ex.Message);
            throw;
        }
    }
}