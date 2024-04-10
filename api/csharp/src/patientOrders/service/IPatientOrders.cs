using patientOrders.model;

namespace patientOrders.service;

public interface IPatientOrders
{
     Task<IEnumerable<Patient>> GetPatientsAsync(int pageNumber = 1, int pageSize = 10);

     Task<Patient> GetPatientAsync(int? patientId, string? patientName);
}