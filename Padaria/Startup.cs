using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Padaria.Data;
using Padaria.Data.Interface;
using Padaria.Data.Repository;
using System;
using System.Text;
using Swashbuckle.AspNetCore.Swagger;
using System.Collections.Generic;

namespace Padaria
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
            #region DB
            services.AddDbContext<Contexto>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("ConexaoAzure")));

            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IPerfilUsuarioRepository, PerfilUsuarioRepository>();
            services.AddScoped<ICaixaRepository, CaixaRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IUnidadeMedidaRepository, UnidadeMedidaRepository>();
            services.AddScoped<ITipoProducaoRepository, TipoProducaoRepository>();
            services.AddScoped<IReceitaRepository, ReceitaRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IMateriaPrimaReceitaRepository, MateriaPrimaReceitaRepository>();
            services.AddScoped<IMateriaPrimaRepository, MateriaPrimaRepository>();
            #endregion


            services.AddControllers()
            #region Não Serializar nulos
                .AddJsonOptions(options => {
                    options.JsonSerializerOptions.IgnoreNullValues = true;
                });
            #endregion

            // Swagger configs
            #region Swagger
            services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo { 
                    Version = "v1",
                    Title = "Padaria Grupo 3",
                    Description = "API para uso no sistema da padaria do curso de C# Campinas Tech Talents",
                    TermsOfService = new Uri("https://microsoft.com"),
                    Contact = new OpenApiContact
                    {
                        Name = "Grupo 3",
                        Email = "tcc@ctt.com",
                        Url = new Uri("https://microsoft.com")
                    }
                });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme {
                    Description = "Formato 'Bearer {token}'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                    }
                });
            });
            #endregion

            // Token configs
            #region Configurações do Token
            var key = Encoding.ASCII.GetBytes(Configuracoes.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(b =>
            {
                b.RequireHttpsMetadata = false;
                b.SaveToken = true;
                b.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            // Use swagger
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("v1/swagger.json", "Padaria Grupo 3 - Swagger");
            });

            app.UseRouting();

            app.UseAuthentication(); // Tem que ser nessa ordem!!
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
