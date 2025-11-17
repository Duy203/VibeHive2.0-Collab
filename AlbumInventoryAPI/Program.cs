using AlbumInventoryAPI;
using AlbumInventoryAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddGrpc();
builder.Services.AddSingleton<InventoryAPI>();


var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGrpcService<InventoryAPI>();
app.Run();
