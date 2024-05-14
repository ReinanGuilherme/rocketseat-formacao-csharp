var builder = WebApplication.CreateBuilder(args);



builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var teste = builder.Configuration.GetSection("Prop2").Value;
var teste2 = builder.Configuration.GetValue<string>("Object:Prop1");

//obriga as rotas ficarem minusculas
builder.Services.AddRouting(option => option.LowercaseUrls = true);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
