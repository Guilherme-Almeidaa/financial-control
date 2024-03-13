using financial_control_plataform.Contexts;
using financial_control_utils.Contexts.Interfaces;
using Microsoft.OpenApi.Models;
using financial_control_utils.Extensions;
using financial_control_plataform.Repositories.Interfaces;
using financial_control_plataform.Entities;
using financial_control_plataform.Repositories;
using financial_control_plataform.Services.Interfaces;
using financial_control_plataform.Services;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();



builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc(builder.Configuration["Swagger:Version"],
        new OpenApiInfo
        {
            Title = builder.Configuration["Swagger:Title"],
            Version = builder.Configuration["Swagger:Version"],
            Description = builder.Configuration["Swagger:Description"]
        });
});

builder.Services.AddDbContextDependencies<IDatabaseContext, FinancialControlContext>(
    builder.Configuration.GetConnectionString("Database") ?? string.Empty);

builder.Services.AddControllers();

//ExpensesIncomeType
builder.Services.AddScoped<IRepository<ExpensesIncomeType>, Repository<ExpensesIncomeType>>();

builder.Services.AddScoped<IDomainService<ExpensesIncomeType>, DomainService<ExpensesIncomeType>>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseHttpsRedirection();
app.MapControllers();
app.UseRouting();


app.Run();

