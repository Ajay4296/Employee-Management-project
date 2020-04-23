using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using EmployeeModel;
using Repository;
using Repository.Context;

/// <summary>
/// This is Repository class where InterfaceRepository parts are implemented.
/// </summary>
/// <seealso cref="Repository.EmployeeRepository" />
public class EmployeeRepository : IEmployeeRepository
{
    /// <summary>
    /// The user database context
    /// </summary>
    private readonly UserDBContext userDBContext;

    /// <summary>
    /// Initializes a new instance of the <see cref="ImpRepo"/> class.
    /// </summary>
    /// <param name="userDBContext">The user database context.</param>
    public EmployeeRepository(UserDBContext userDBContext)
    {
        this.userDBContext = userDBContext;
    }

    /// <summary>
    /// Adds the employee.
    /// </summary>
    /// <param name="employee">The employee.</param>
    /// <returns>
    /// int
    /// </returns>
    public Task<int> AddEmployee(Employee employee)
    {
        userDBContext.Employees.Add(employee);
        var result = userDBContext.SaveChangesAsync();
        return result;
    }

    /// <summary>
    /// Deletes the employee.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>
    /// Object
    /// </returns>
    public Employee DeleteEmployee(int id)
    {
        Employee employee = userDBContext.Employees.Find(id);
        if (employee != null)
        {
            userDBContext.Employees.Remove(employee);
            userDBContext.SaveChanges();
        }
        return employee;
    }

    /// <summary>
    /// Gets all employee.
    /// </summary>
    /// <returns>
    /// IEnuberable
    /// </returns>
    public IEnumerable<Employee> GetALLEmployee()
    {
        return userDBContext.Employees;
    }

    /// <summary>
    /// Gets the employee.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns></returns>
    public Employee GetEmployee(int id)
    {
        return userDBContext.Employees.Find(id);
    }

    /// <summary>
    /// Updates the employee.
    /// </summary>
    /// <param name="NewEmployee">The new employee.</param>
    /// <returns></returns>
    public Task<int> UpdateEmployee(Employee NewEmployee)
    {
        var employee = userDBContext.Employees.Attach(NewEmployee);
        employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        var result = userDBContext.SaveChangesAsync();
        return result;
    }
}
