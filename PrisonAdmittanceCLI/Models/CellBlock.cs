using System.ComponentModel.DataAnnotations.Schema;

namespace PrisonerAdmittanceApp.Models;

[Table("CellBlocks")]
public partial record CellBlock(int Id, string CrimeCategory, string Gender, int PrisonId) : IDisplayableEntity
{
    public bool IsSelected { get; set; }
    public Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            { nameof(Id), Id },
            { nameof(CrimeCategory), CrimeCategory },
        };
    }
}
