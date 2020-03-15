using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using StudentskiServis.Models.Requests;
using StudentskiServis.WebAPI.Database;
using StudentskiServis.WebAPI.Filters;
using StudentskiServis.WebAPI.Services;

namespace StudentskiServis.WebAPI
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

            services.AddMvc(x=>x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

            //services.AddAuthentication("BasicAuthentication")
            //    .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<IAdministracijaService, AdministracijaService>();
            services.AddScoped<IProfesorService, ProfesorService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<IPROFService, PROFService>();
            services.AddScoped<IKURS_Service, KURS_Service>();
            services.AddScoped<IADMINService, ADMINService>();
            services.AddScoped<ISTUDService, STUDService>();
            services.AddScoped<IPohadjaService, PohadjaService>();
            services.AddScoped<IUplataService, UplataService>();
            services.AddScoped<IKursService, KursService>();
            services.AddScoped<IPredavanjaService, PredavanjaService>();
            services.AddScoped<IObavijestService, ObavijestService>();
            services.AddScoped<IIspitService, IspitService>();
            services.AddScoped<IUloga, ULOGA>();
            services.AddScoped<IAuth, Auth>();
            services.AddScoped<IRasporedService, RasporedService>();
            services.AddScoped<ITragajService, TragajService>();
            
            //services.AddScoped<ICheckUsername, CheckUsername>();
            //services.AddScoped<IService<Models.ispiti,object>,BaseService<Models.ispiti, object, Ispit>>();
            //services.AddScoped<IService<Models.obavijesti, object>, BaseService<Models.obavijesti, object, Database.Obavijest>>();
            //services.AddScoped<IService<Models.predavanja, PredavanjaSearchRequest>, PredajeService>();
            //services.AddScoped<IService<Models.ADMIN,object>, BaseService<Models.ADMIN,object,Database.Administracija>>();
            //services.AddScoped<IService<Models.KURS_,object>, BaseService<Models.KURS_,object,Database.Kurs>>();
            //services.AddScoped<IService<Models.uplate,object>,BaseService<Models.uplate, object, Database.Uplata>>();
            //services.AddScoped<IService<Models.STUD,object>, BaseService<Models.STUD,object,Database.Student>>();
            //services.AddScoped<IService<Models.pohadjanja,PohadjanjaSearchRequest>, PohadjaService>();
            //services.AddScoped<IService<Models.StudentAdmin,StudentSearchRequest>,BaseService<Models.StudentAdmin, StudentSearchRequest, Database.Student>>();
            //services.AddScoped<IService<Models.PROF,object>, BaseService<Models.PROF,object,Database.Profesor>>();
            //services.AddScoped<IService<Models.ProfesorAdmin, ProfesorSearchRequest>, BaseService<Models.ProfesorAdmin, ProfesorSearchRequest, Database.Profesor>>();
            //services.AddScoped<IService<Models.predavanja,PredavanjaSearchRequest>, BaseService<Models.predavanja, PredavanjaSearchRequest, Database.Predaje>>();
            //services.AddScoped<IService<Models.izvrsenaUplata,object>,BaseService<Models.izvrsenaUplata, object, Database.Uplata>>();
            //services.AddScoped<IService<Models.ProfesorAll, ProfesorSearchRequest>, BaseService<Models.ProfesorAll, ProfesorSearchRequest, Database.Profesor>>();
            //services.AddScoped<IService<Models.StudentDetalji,StudentSearchRequest>, BaseService<Models.StudentDetalji, StudentSearchRequest, Database.Student>>();
            //services.AddScoped<IService<Models.AdministracijaAdmin, AdministracijaSearchRequest>, BaseService<Models.AdministracijaAdmin, AdministracijaSearchRequest, Database.Administracija>>();
            //services.AddScoped<IService<Models.AdministracijaAdmin,AdministracijaSearchRequest>, BaseService<Models.AdministracijaAdmin, AdministracijaSearchRequest, Database.Administracija>>();
            //services.AddScoped<IService<Models.AdministracijaAdmin, AdministracijaSearchRequest>, AdministracijaService>();



            var connection = @"Server=.;Database=Studentski servis;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<StudentskiservisContext>(options => options.UseSqlServer(connection));

            services.AddAutoMapper();

            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseAuthentication();

            //app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
