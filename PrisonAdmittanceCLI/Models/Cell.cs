namespace PrisonerAdmittanceApp.Models;

[Table("Cells")]
public partial record Cell(int Id, int PrisonerCount, int CellBlockId) : IDisplayableEntity
{
    public bool IsSelected { get; set; }
    public Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            { nameof(Id), Id },
            { nameof(PrisonerCount), PrisonerCount },
            { nameof(CellBlockId), CellBlockId },
        };
    }
}
