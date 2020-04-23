namespace Manager
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using EmployeeModel;

    /// <summary>
    /// This is an interface of Manager class
    /// </summary>
    public interface IEmployeeManager
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        Task<int> AddEmployee(Employee employee);

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>object</returns>
        Employee GetEmployee(int id);

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Employee> GetALLEmployee();

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeChanges">The employee changes.</param>
        /// <returns></returns>        
        Task<int> UpdateEmployee(Employee employeeChanges);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Employee DeleteEmployee(int id);
    }
}