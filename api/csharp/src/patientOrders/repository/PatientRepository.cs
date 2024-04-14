using Dapper;
using patientOrders.model;

namespace patientOrders.repository;

public class PatientRepository:IPatientRepository
{
    private readonly IUnitOfWork _unitOfWork;

    public PatientRepository(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public async Task<IEnumerable<PatientModel>> GetPatients(int pageNumber, int pageSize)
    {
        var offset = (pageNumber - 1) * pageSize;
        var sql = $"SELECT id, name, birth_date as birthDate, created_by as creator,gender,created_at as createdAt FROM patients where is_deleted = false LIMIT {pageSize} OFFSET {offset} ";
        var patients = await _unitOfWork.Connection.QueryAsync<PatientModel>(sql);
        return patients;
    }
}