using Business;
using Repository;

namespace ApiParaTeste
{
    public static class NativeInjector
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddTransient<IPessoaBusiness, PessoaBusiness>();
            services.AddTransient<IPessoaRepository, PessoaRepository>();
        }
    }
}
