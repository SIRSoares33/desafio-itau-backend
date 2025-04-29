using DesafioItau.Factory.Statistic;
using DesafioItau.Repository;
using DesafioItau.Services;
using DesafioItau.Services.AverageStatisticService;
using DesafioItau.Services.OrderValueStatisticService;
using DesafioItau.Services.Statistic.StatisticManager;
using DesafioItau.Services.SumStatisticService;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

#region Repository
builder.Services.AddControllers();
builder.Services.AddSingleton<ITransacaoRepository, TransacaoInMemoryRepository>();
#endregion

#region Statistics Services
builder.Services.AddSingleton<ISumStatisticService, SumStatisticService>();
builder.Services.AddSingleton<IAverageStatisticService, AverageStatisticService>();
builder.Services.AddSingleton<IOrderMaxStatisticService, OrderMaxStatisticService>();
builder.Services.AddSingleton<IOrderMinStatisticService, OrderMinStatisticService>();
#endregion

#region Statistic Factory
builder.Services.AddSingleton<IStatisticFactory, StatisticFactory>();
builder.Services.AddSingleton<IStatisticServiceManager, StatisticServiceManager>();
#endregion

#region Config
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.InvalidModelStateResponseFactory = context =>
    {
        return new UnprocessableEntityResult();
    };
});
#endregion

var app = builder.Build();

app.MapControllers();

app.Run();
