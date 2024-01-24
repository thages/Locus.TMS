using Autofac;
using Autofac.Extensions.DependencyInjection;
using Locus.TMS.Application;
using System.Text.Json.Serialization;

var locusCors = "_locusFront";
var builder = WebApplication.CreateBuilder(args);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

builder.Host.ConfigureContainer<ContainerBuilder>(
   container => container.RegisterModule(new AutofacModule(builder.Configuration)));

builder.Services.AddControllers()
    .AddJsonOptions(options =>
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: locusCors,
        policy  =>
        {
            policy.WithOrigins("http://localhost:3000")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(locusCors);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
