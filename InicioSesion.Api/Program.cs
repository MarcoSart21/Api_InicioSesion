var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inyeccion de Dependecias
//builder.Services.AddTransient<Ilogin, LoginService>();

builder.Services.AddTransient<Iusuarios, UsuarioService>();
builder.Services.AddTransient<ITipo, TipoService>();
builder.Services.AddTransient<IRango, RangoService>();
builder.Services.AddTransient<IHistorial, HistorialService>();
builder.Services.AddTransient<IPuntuaciones, PuntuacionesService>();


builder.Services.AddTransient<GatoFractalDBContext>();

//Obtener CadenaConexion
ValoresEstaticos.ConexionDB=builder.Configuration.GetConnectionString("CadenaConexion")??"";

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
