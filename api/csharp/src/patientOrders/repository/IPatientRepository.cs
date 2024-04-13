using patientOrders.model;

namespace patientOrders.repository;

public interface IPatientRepository
{
    public Task<IEnumerable<PatientModel>> GetPatients(int pageNumber,int pageSize);
}