using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(Opcoes =>
Opcoes.UseInMemoryDatabase("TarefasDB"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


/*
    pode se usar os metodos: 
    APP.Map.Get();
    APP.Map.Post();
    APP.Map.Put();
    APP.Map.Delete();
 */


app.MapGet("/", () => "ola Mundo");

app.MapGet("frases", async () =>
    await new HttpClient().GetStringAsync("http://ron-swanson-quotes.herokuapp.com/v2/quotes")    
);


app.MapGet("/Buscatarefas", async (AppDbContext db) =>
     await db.Tarefas.ToListAsync());

/* Mesca coisa que a de cima so que quando abre colchetes tem que chamar o return
app.MapGet("/Buscatarefas", async (AppDbContext db) =>
{
    return await db.Tarefas.ToListAsync();
});
*/

app.MapGet("/tarefa/{id}", async (int id, AppDbContext db) =>
    await db.Tarefas.FindAsync(id) is Tarefa tarefa ? Results.Ok(tarefa) : Results.NotFound()
);

app.MapGet("/tarefas/Concluidas", async (AppDbContext db) =>
     await db.Tarefas.Where(x =>  x.IsConcluida).ToListAsync());

app.MapGet("/BuscaCEP/{cep}", async (int cep) =>
{
    dynamic dadosCEP = await new HttpClient().GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");

    var dadosCepJaDescerializados = JsonConvert.DeserializeObject(dadosCEP);

    var endereco = new Endereco
    {
        Cep = dadosCepJaDescerializados.cep,
        Estado = dadosCepJaDescerializados.uf,
        Cidade = dadosCepJaDescerializados.localidade,
        Bairro = dadosCepJaDescerializados.bairro,
        Complemento = dadosCepJaDescerializados.complemento,
        Rua = dadosCepJaDescerializados.logradouro
    };

    return endereco;

});


app.MapPost("/AdicionaTarefas", async (Tarefa tarefa, AppDbContext db) =>
{
    db.Tarefas.Add(tarefa);
    await db.SaveChangesAsync();
    return Results.Created($"/tarefas/{tarefa.Id}", tarefa);
});


app.MapPut("/tarefa/{id}", async (int id, Tarefa inputTarefa, AppDbContext db) =>
{
    var tarefa = await db.Tarefas.FindAsync(id);

    if (tarefa is null) return Results.NotFound();

    tarefa.Nome = inputTarefa.Nome;
    tarefa.IsConcluida = inputTarefa.IsConcluida;

    await db.SaveChangesAsync();

    return Results.NoContent(); // retorna o resultado.
});

app.MapDelete("/tarefa/{id}", async (int id, AppDbContext db) =>
{
    if (await db.Tarefas.FindAsync(id) is Tarefa instanciaTarefa)
    {
        db.Tarefas.Remove(instanciaTarefa);
        await db.SaveChangesAsync();
        return Results.Ok(instanciaTarefa);
    }
    return Results.NotFound(); 
});

app.Run();

class Endereco
{
    public string? Cep { get; set; }
    public string? Estado { get; set; }
    public string? Cidade { get; set; }
    public string? Bairro { get; set; }
    public string? Complemento { get; set; }
    public string? Rua { get; set; }
}

class Tarefa
{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public bool IsConcluida { get; set; }
}

class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<Tarefa> Tarefas => Set<Tarefa>();
}