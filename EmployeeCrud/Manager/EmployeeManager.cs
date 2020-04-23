namespace Manager
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using EmployeeModel;
    using Repository;

    /// <summary>
    /// The Implementation of the InterfaceManager is done in this class
    /// </summary>
    /// <seealso cref="Manager.IEmployeeManager" />
    public class EmployeeManager : IEmployeeManager
    {
        /// <summary>
        /// The repo
        /// </summary>
        private readonly IEmployeeRepository repo;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeManager"/> class.
        /// </summary>
        /// <param name="repo">The repo.</param>
        public EmployeeManager(IEmployeeRepository repo)
        {
            this.repo = repo;
        }

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns>intezer</returns>
        public Task<int> AddEmployee(Employee employee)
        {
            return this.repo.AddEmployee(employee);
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Employee Object</returns>
        public Employee DeleteEmployee(int id)
        {
            return this.repo.DeleteEmployee(id);
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employeeChanges">The employee changes.</param>
        /// <returns></returns>        
        public Task<int> UpdateEmployee(Employee employeeChanges)
        {
            return this.repo.UpdateEmployee(employeeChanges);
        }

        /// <summary>
        /// Gets all employee.
        /// </summary>
        /// <returns>IENUMERABLE</returns>
        public IEnumerable<Employee> GetALLEmployee()
        {
            return this.repo.GetALLEmployee();
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>
        /// object
        /// </returns>
        public Employee GetEmployee(int id)
        {
            return this.repo.GetEmployee(id);
        }
    }
}