using Joben_BLL.IServices.RATING;
using Joben_BLL.IServices.USER;
using Joben_BLL.Services.RATING;
using Joben_BLL.Services.USER;
using Joben_DAL;
using Joben_DAL.Repositories.GenericRepository;
using Joben_DAL.UnitOfWorks;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<JobenDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("JobenDB"))
           .UseLazyLoadingProxies()
);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IRatingService, RatingService>();

// Add Repositories
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

// Add Unit of Works
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

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
