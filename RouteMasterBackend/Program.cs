using Microsoft.EntityFrameworkCore;
using RouteMasterBackend.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the DI container.
string RouteMasterConnectString = builder.Configuration.GetConnectionString("RouteMaster");
builder.Services.AddDbContext<RouteMasterContext>(options =>
{
	options.UseSqlServer(RouteMasterConnectString);
});


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle




//�]�w�q�LCORS�A�γW�h
string MyAllowOrigns = "AllowAny";
builder.Services.AddCors(
	options =>
	{
		options.AddPolicy(
		name: MyAllowOrigns, policy => policy
		.WithOrigins("*")
		.WithHeaders("*")
		.WithMethods("*")
			);
	}
);



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}





//�ҥ�Cors�A�����ѫ��򪺱���ۦ���O���w
app.UseCors();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
