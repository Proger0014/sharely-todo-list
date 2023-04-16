using SharelyTodoList;
using SharelyTodoList.Extensions;
using SharelyTodoList.Interfaces.Repositories;
using SharelyTodoList.Interfaces.Services;
using SharelyTodoList.Repositories;
using SharelyTodoList.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IGroupRepository, GroupRepository>();
builder.Services.AddScoped<IGroupService, GroupService>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseGlobalHandlingExceptions();

app.MapControllers();

app.Run();