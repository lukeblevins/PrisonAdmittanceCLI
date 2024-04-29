namespace PrisonerAdmittanceApp.Models;

[Table("Wardens")]
public partial record Warden(int Id, string FirstName, string LastName, int Age, string Gender, string Race) : Employee(Id, FirstName, LastName, Age, Gender, Race), IDisplayableEntity
{
    public bool IsSelected { get; set; }

    public override Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            { nameof(Id), Id },
            { nameof(FirstName), FirstName },
            { nameof(LastName), LastName },
            { nameof(Age), Age },
            { nameof(Gender), Gender },
            { nameof(Race), Race }
        };
    }
}