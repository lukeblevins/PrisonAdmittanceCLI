namespace PrisonerAdmittanceApp.Models;

[Table("Prisons")]
public partial record Prison(int Id, string Name) : IDisplayableEntity
{
        public bool IsSelected { get; set; }

    public Dictionary<string, object> ToDictionary()
    {
        return new Dictionary<string, object>
        {
            { nameof(Id), Id },
            { nameof(Name), Name },
        };
    }
}