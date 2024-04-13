namespace patientOrders.model;

public class PatientModel
{
    public string Id { get; set; }
    public string? Name { get; set; }
    public int BirthDate { get; set; }
    public Gender Type { get; set; }
    public int CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
}

public enum Gender
{
    Male,
    Female,
    Others,
}