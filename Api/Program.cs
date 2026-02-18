using Api.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. Servicios básicos
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(); 

// 2. Tu servicio de tareas
builder.Services.AddSingleton<ITareaService, TareaService>();

var app = builder.Build();

// 3. Configuración del Pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); 
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// Redirección para que al abrir la raíz vayas directo a Swagger
app.MapGet("/", () => Results.Redirect("/swagger"));

app.Run();