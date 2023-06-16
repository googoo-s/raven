using Microsoft.OpenApi.Models;

using Raven.Application;
using Raven.EntityFrameworkCore;
using Raven.HttpApi;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Serilog;
using Volo.Abp.Modularity;
using Volo.Abp.Swashbuckle;

namespace Raven;

[DependsOn(
    typeof(RavenApplicationModule),
    typeof(RavenEntityFrameworkCoreModule),
    typeof(RavenHttpApiModule),
    typeof(AbpAspNetCoreSerilogModule),
    typeof(AbpSwashbuckleModule)
)]
public class RavenHttpApiHostModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        base.ConfigureServices(context);
        var configuration = context.Services.GetConfiguration();
        var hostingEnvironment = context.Services.GetHostingEnvironment();

        Configure<AbpAspNetCoreMvcOptions>(options =>
            options.ConventionalControllers.Create(typeof(RavenHttpApiModule).Assembly)
            );
        context.Services.AddAbpSwaggerGen(
               options =>
               {
                   options.SwaggerDoc("v1", new OpenApiInfo { Title = "BookStore API", Version = "v1" });
                   options.DocInclusionPredicate((docName, description) => true);
                   options.CustomSchemaIds(schemaIdSelector: type => type.FullName);
               });
        if (hostingEnvironment.IsDevelopment())
        {
            Console.WriteLine("this is development environment");
        }
        else if (hostingEnvironment.IsProduction())
        {
            Console.WriteLine("this is production environment");
        }
    }
    public override void OnApplicationInitialization(ApplicationInitializationContext context)
    {
        base.OnApplicationInitialization(context);
        var app = context.GetApplicationBuilder();
        var env = context.GetEnvironment();

        // Configure the HTTP request pipeline.
        if (env.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseConfiguredEndpoints();
    }
}
