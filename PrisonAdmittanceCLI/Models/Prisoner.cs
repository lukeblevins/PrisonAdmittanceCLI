namespace PrisonerAdmittanceApp.Models;

[Table("Prisoners")]
public partial record Prisoner(int Id, string FirstName, string LastName, int Age, string Gender, DateTime BookingDate, DateTime ReleaseDate, int CellId) : IDisplayableEntity
{
    public bool IsSelected { get; set; }

    public Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            { nameof(Id), Id },
            { nameof(FirstName), FirstName },
            { nameof(LastName), LastName },
            { nameof(Age), Age },
            { nameof(Gender), Gender },
            { nameof(BookingDate), BookingDate },
            { nameof(ReleaseDate), ReleaseDate },
            { nameof(CellId), CellId }
        };
    }
}