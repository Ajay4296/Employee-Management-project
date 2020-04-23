using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EmployeeModel;


namespace Repository.Context
{

   public class UserDBContext :DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDBContext"/> class.
        /// This Carries the configuration information 
        /// </summary>
        /// <param name="options">The options.</param>
        public UserDBContext(DbContextOptions<UserDBContext> options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the employees.
        /// This property is used to query and save instance of the Employee class
        /// </summary>
        /// <value>
        /// The employees.
        /// </value>
        public DbSet<Employee> Employees
        {
            get; set;
        }
    }
}
