using System.Data;

namespace patientOrders;

public interface IUnitOfWork
{
    IDbConnection Connection { get; }
    IDbTransaction Transaction { get; }
    void BeginTransaction();
    void Commit();
    void Rollback();
    void Dispose();
}

public class UnitOfWork : IUnitOfWork
{
    private readonly IDbConnection _connection;
    private IDbTransaction _transaction;

    public IDbConnection Connection => _connection;
    public IDbTransaction Transaction => _transaction;

    public UnitOfWork(IDbConnection connection)
    {
        _connection = connection;
    }

    public void BeginTransaction()
    {
        _connection.Open();
        _transaction = _connection.BeginTransaction();
    }

    public void Commit()
    {
        _transaction.Commit();
        _connection.Close();
    }

    public void Rollback()
    {
        _transaction.Rollback();
        _connection.Close();
    }

    public void Dispose()
    {
        _transaction?.Dispose();
        _connection?.Dispose();
    }
}