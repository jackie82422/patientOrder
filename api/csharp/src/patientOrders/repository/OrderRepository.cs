using Dapper;
using patientOrders.model;

namespace patientOrders.repository;

public class OrderRepository : IOrderRepository
{
    private readonly IUnitOfWork _unitOfWork;

    public OrderRepository(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<OrderModel>?> GetOrdersByPatient(string patientId)
    {
       var sql = @"
    SELECT id, patient_id as PatientId, order_text as OrderText, created_by as Creator, created_at as CreatedAt
    FROM orders
    WHERE patient_id = @PatientId and is_deleted=0";
        var orders = await _unitOfWork.Connection.QueryAsync<OrderModel>(sql, new { PatientId = patientId });
        return orders;
    }
    
    public async Task<OrderModel?> GetOrderById(string orderId)
    {
        var sql = @"
     SELECT id, patient_id as PatientId, order_text as OrderText, created_by as Creator, created_at as CreatedAt
    FROM orders
    WHERE id = @OrderId and is_deleted=0";
        var order = await _unitOfWork.Connection.QuerySingleOrDefaultAsync<OrderModel>(sql, new { OrderId = orderId });
        return order;
    }
    
    public async Task<int> AddOrder(string patientId, string orderText, string doctorName)
    {
        using var connection = _unitOfWork.Connection;
        var sql = @"
            INSERT INTO orders (id,patient_id, order_text, created_by, created_at)
            VALUES (UUID(),@PatientId, @Order, @DoctorName, UTC_TIMESTAMP())";

        var affectedRows = await connection.ExecuteAsync(sql, new
        {
            PatientId = patientId,
            Order = orderText,
            DoctorName = doctorName
        });

        return affectedRows;
    }

    public async Task<int> DeleteOrder(string orderId)
    {
        using var connection = _unitOfWork.Connection;
        var affectedRows = await connection.ExecuteAsync(
            "UPDATE orders SET is_deleted = true WHERE id = @OrderId",
            new { OrderId = orderId });

        return affectedRows;
    }
}