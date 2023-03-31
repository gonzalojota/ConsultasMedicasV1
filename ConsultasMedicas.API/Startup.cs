using ConsultasMedicas.Core.Interfaces;
using ConsultasMedicas.Core.Repositories;
using ConsultasMedicas.Core.Services;
using ConsultasMedicas.Data.Context;
using ConsultasMedicas.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace ConsultasMedicas.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            // Configurar la base de datos
            services.AddDbContext<ConsultasMedicasDbContext>(options =>
    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
    b => b.MigrationsAssembly("ConsultasMedicas.API")));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ConsultasMedicas.API", Version = "v1" });

                // Añadir servidor HTTP
                c.AddServer(new OpenApiServer
                {
                    Url = "http://10.18.19.57:5000",
                    Description = "Production server (HTTP)"
                });

                // Añadir servidor HTTPS
                c.AddServer(new OpenApiServer
                {
                    Url = "https://10.18.19.57:5001",
                    Description = "Production server (HTTPS)"
                });
            });


            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
            });

            // Configurar AutoMapper
            object value = services.AddAutoMapper(typeof(Startup));

            // Registrar los servicios y repositorios
            services.AddScoped<IConsultaService, ConsultaService>();
            services.AddScoped<IPacienteService, PacienteService>();
            services.AddScoped<IMedicoService, MedicoService>();
            services.AddScoped<INotificacionService, NotificacionService>();

            services.AddScoped<IConsultaRepository, ConsultaRepository>();
            services.AddScoped<IPacienteRepository, PacienteRepository>();
            services.AddScoped<IMedicoRepository, MedicoRepository>();
            services.AddScoped<INotificacionRepository, NotificacionRepository>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseCors("AllowAll");

            app.UseRouting();

            app.UseAuthorization();

            // Habilita el middleware de Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ConsultasMedicas.API v1");
                // No uses c.RoutePrefix = string.Empty si quieres mantener la ruta predeterminada de Swagger (/swagger)
                // Usa la siguiente línea si deseas que Swagger sea la página de inicio de tu aplicación:
                c.RoutePrefix = string.Empty;
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
