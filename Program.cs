using CodewarsBackend.Services;
using CodewarsBackend.Services.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<CohortService>();
builder.Services.AddScoped<CompletedService>();


builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<ReserveService>();

var ConnectionString = builder.Configuration.GetConnectionString("CodewarsString");
builder.Services.AddDbContext<DataContext>(Options => Options.UseSqlServer(ConnectionString));

builder.Services.AddCors(options => {
options.AddPolicy("CodewarsPolicy",
builder => {builder.WithOrigins("http://localhost:3000", "http://localhost:3001", "http://localhost:3002")
    .AllowAnyHeader()
    .AllowAnyMethod();
});
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseCors("CodewarsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
