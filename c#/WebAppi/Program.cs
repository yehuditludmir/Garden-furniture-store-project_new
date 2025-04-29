using Bll_Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDal_Repository.IDal_buy<DTO_Commom.new_model.Buy>, Dal_Repository.func_buy>();

builder.Services.AddScoped<IDal_Repository.IDal_buydetails<DTO_Commom.new_model.Buy_Details>, Dal_Repository.func_buydetails>();

builder.Services.AddScoped<IDal_Repository.IDal_category<DTO_Commom.new_model.Category>, Dal_Repository.func_category>();

builder.Services.AddScoped<IDal_Repository.IDal_company<DTO_Commom.new_model.Company>, Dal_Repository.func_company>();

builder.Services.AddScoped<IDal_Repository.IDal_product1<DTO_Commom.new_model.Product>, Dal_Repository.func_product>();

builder.Services.AddScoped<IDal_Repository.IDal_user<DTO_Commom.new_model.User>, Dal_Repository.func_user>();

builder.Services.AddScoped<IBll_Services.IBll_buydetails<DTO_Commom.new_model.Buy_Details>, Bll_Services.Bll_buydetails>();

builder.Services.AddScoped<IBll_Services.IBll_user<DTO_Commom.new_model.User>, Bll_Services.Bll_user>();

builder.Services.AddScoped<IBll_Services.IBll_buy<DTO_Commom.new_model.Buy>, Bll_Services.Bll_buy>();
builder.Services.AddScoped<IBll_Services.IBll_company<DTO_Commom.new_model.Company>, Bll_Services.Bll_company>();
builder.Services.AddScoped<IBll_Services.IBll_product<DTO_Commom.new_model.Product>, Bll_Services.Bll_product>();
builder.Services.AddScoped<IBll_Services.IBll_category<DTO_Commom.new_model.Category>, Bll_Services.Bll_category>();

builder.Services.AddCors(opotion => opotion.AddPolicy("AllowAll",
    p => p.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()));
builder.Services.AddControllers()
           .AddJsonOptions(opts => opts.JsonSerializerOptions.PropertyNamingPolicy = null);


var app = builder.Build();
app.UseCors("AllowAll");

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
