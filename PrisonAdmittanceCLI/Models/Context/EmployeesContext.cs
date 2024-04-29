using Microsoft.EntityFrameworkCore;
using PrisonerAdmittanceApp.Models;

namespace PrisonerAdmittanceApp.Core;

public class EmployeesContext : DbContext
{
    public DbSet<Guard> Guards { get; set; }
    public DbSet<Warden> Wardens { get; set; }

    public EmployeesContext(DbContextOptions<EmployeesContext> options) : base(options) { }
}