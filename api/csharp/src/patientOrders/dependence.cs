using System.Data;
using MySqlConnector;
using patientOrders.repository;
using patientOrders.service;

namespace patientOrders;

public static class Dependence
{
    public static void AddCustomServices(this IServiceCollection services)
    {
        // get config by env, aws vault .. etc.
        services.AddTransient<IDbConnection>(provider => new MySqlConnection(Environment.GetEnvironmentVariable("SQL_CONNECTION_STRING")));
        services.AddSingleton<ExceptionMiddleware>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddTransient<IPatientRepository, PatientRepository>();
        services.AddTransient<IOrderRepository, OrderRepository>();
        
        services.AddScoped<IPatientOrders, PatientOrders>();
    }
}