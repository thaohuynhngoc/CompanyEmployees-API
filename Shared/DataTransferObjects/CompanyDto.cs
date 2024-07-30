namespace Shared.DataTransferObjects;

// [Serializable]
public record CompanyDto
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? FullAdress { get; set; }
}