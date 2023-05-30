using _2Users.Services.Interfaces;
using _2Users.Services.Services;
using _3Repository.Interfaces;
using _3Repository.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddScoped<IUsersRepository, UsersRepository>();

//builder.Services.AddSingleton<ICorsPolicyService>((container) =>
//{
//    var logger = container.GetRequiredService<ILogger<DefaultCorsPolicyService>>();
//    return new DefaultCorsPolicyService(logger)
//    {
//        AllowedOrigins = { "http://localhost:3000", "https://localhost:3000" }
//    };
//});

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.AllowAnyOrigin()// .WithOrigins("https://localhost:4200", "http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});


var app = builder.Build();
app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed(origin => true) // allow any origin
    .AllowCredentials());
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
