using BlazingPizzaApp.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddScoped<IPizzaSpecials, PizzaSpecialsDAL>();
builder.Services.AddSqlite<PizzaStoreContext>("Data Source=pizza.db");

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

// PERBAIKAN: Matikan pemaksaan HTTPS agar koneksi HTTP di port 7219 tidak terputus
// app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

// Inisialisasi Database dan SeedData
var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PizzaStoreContext>();

    // Hapus database lama jika ada, lalu buat baru dengan skema tabel lengkap dan seed data
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();
    SeedData.Initialize(db);
}

app.Run();