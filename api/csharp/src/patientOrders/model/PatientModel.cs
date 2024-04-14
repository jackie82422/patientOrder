namespace patientOrders.model;

public class PatientModel
{
    public string Id { get; set; }
    public string? Name { get; set; }
    public string? Creator { get; set; }
    public DateTime BirthDate { get; set; }
    public Gender Gender { get; set; }
    public DateTime CreatedAt { get; set; }
}

public enum Gender
{
    Male,
    Female,
    Others,
}