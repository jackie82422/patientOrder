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
        // services.AddTransient<IDbConnection>(provider => new MySqlConnection(Configuration.GetConnectionString("DefaultConnection")));
        services.AddTransient<IDbConnection>(provider => new MySqlConnection("Server=localhost;Port=3306;Database=patients_db;Uid=app_user;Pwd=app_password;"));

        services.AddSingleton<ExceptionMiddleware>();

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddTransient<IPatientRepository, PatientRepository>();
        
        services.AddScoped<IPatientOrders, PatientOrders>();
    }
}