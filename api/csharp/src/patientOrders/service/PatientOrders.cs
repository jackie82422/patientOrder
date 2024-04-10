using patientOrders.model;
using patientOrders.repository;

namespace patientOrders.service;

public class PatientOrders : IPatientOrders
{
    private readonly IPatientRepository _patientRepository;

    public PatientOrders(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }
    
    public async Task<IEnumerable<Patient>> GetPatientsAsync(int pageNumber, int pageSize)
    {
        return await _patientRepository.GetPatients(pageNumber, pageSize);
    }

    public Task<Patient> GetPatientAsync(int? patientId, string? patientName)
    {
        throw new NotImplementedException();
    }
}