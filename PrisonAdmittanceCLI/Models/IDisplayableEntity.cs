namespace PrisonerAdmittanceApp.Models;

public interface IDisplayableEntity : IEntity
{
    Dictionary<string, object> ToDictionary();
    bool IsSelected { get; set; }
}

public interface IEntity
{
    int Id { get; }
}