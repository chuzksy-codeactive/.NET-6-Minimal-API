namespace Shared.DateTransferObjects
{
    public record EmployeeDto(Guid Id, string Name, int Age, string Position);
    public record EmployeeForCreationDto(string Name, int Age, string Position);
}
