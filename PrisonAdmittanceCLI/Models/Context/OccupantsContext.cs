using Microsoft.EntityFrameworkCore;
using PrisonerAdmittanceApp.Models;

namespace PrisonerAdmittanceApp.Core;

public class OccupantsContext : DbContext
{
    public DbSet<Prisoner> Prisoners { get; set; }

    public OccupantsContext(DbContextOptions<FacilitiesContext> options) : base(options) { }
}