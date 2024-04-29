using Microsoft.EntityFrameworkCore;
using PrisonerAdmittanceApp.Models;

namespace PrisonerAdmittanceApp.Core;

public class FacilitiesContext : DbContext
{
    public DbSet<Cell> Cells { get; set; }
    public DbSet<CellBlock> CellBlocks { get; set; }
    public DbSet<Prison> Prisons { get; set; }

    public FacilitiesContext(DbContextOptions<FacilitiesContext> options) : base(options) { }
}