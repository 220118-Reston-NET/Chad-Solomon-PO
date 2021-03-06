using PokeBL;
using PokeDL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRepository>(repo => new SQLRepository(builder.Configuration.GetConnectionString("Reference2DB")));
builder.Services.AddScoped<IStoreFrontRepo>(repo => new SQLStoreFrontRepo(builder.Configuration.GetConnectionString("Reference2DB")));
builder.Services.AddScoped<IInventoryRepo>(repo => new SQLInventory(builder.Configuration.GetConnectionString("Reference2DB")));
builder.Services.AddScoped<IPokemonBL, CustomerBL>();
builder.Services.AddScoped<IStoreFrontBL, StoreFrontBL>();
builder.Services.AddScoped<IInventoryBL, InventoryBL>();
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
