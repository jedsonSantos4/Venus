using Infrastructure.FakeData;
using Infrastructure.Interface;
using Infrastructure.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfra(this IServiceCollection services,  IConfiguration conf )
        {
            services.AddScoped<IProdutoInfra, ProdutoRepository>();
            #region Conexao
            services.AddTransient<DbSession>(_ =>
                new DbSession(conf.GetConnectionString("MySqlConnection")));
            #endregion


            #region FakeData
            services.AddSingleton<FakeDataStore>();
            #endregion

            return services;

        }
    }
}
