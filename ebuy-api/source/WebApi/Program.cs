using ebuy.Infra.IoC;
using ebuy.Infra.IoC.Configurations;
using ebuy.WebApi.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwagger();

builder.Services.ConfigureDbContext(builder.Configuration);
builder.Services.ConfigureDependencies(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwaggerConfiguration();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
