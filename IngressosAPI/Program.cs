using IngressosAPI.Profiles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// add dbContext in the program.cs
//builder.Services.AddDbContext<AppContext>(options => options

// mappers
builder.Services.AddAutoMapper(
    cfg => { },
    typeof(UserProfile).Assembly
);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
