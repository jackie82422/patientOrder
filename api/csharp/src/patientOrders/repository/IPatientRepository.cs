using patientOrders.model;

namespace patientOrders.repository;

public interface IPatientRepository
{
    public Task<IEnumerable<Patient>> GetPatients(int pageNumber,int pageSize);
}