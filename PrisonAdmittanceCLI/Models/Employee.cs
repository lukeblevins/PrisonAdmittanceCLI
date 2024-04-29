
namespace PrisonerAdmittanceApp.Models;

public abstract partial record Employee(int Id, string FirstName, string LastName, int Age, string Gender, string Race) : IDisplayableEntity
{
    public bool IsSelected { get; set; }
    public abstract Dictionary<string, object> ToDictionary();
}
