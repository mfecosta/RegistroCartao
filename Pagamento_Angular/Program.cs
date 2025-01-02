using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pagamento_Angular.BusinessLogic;
using Pagamento_Angular.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));
builder.Services.AddScoped<IPagamentoDetail, PagamentoDetailBll>();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .WithOrigins("http://localhost:4200")
                        .AllowAnyHeader());
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseCors(options => 
//options.WithOrigins("http://localhost:4200")
//.AllowAnyMethod()
//.AllowAnyHeader());
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
