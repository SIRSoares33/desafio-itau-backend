using DesafioItau.Models;
using DesafioItau.Repository;
using DesafioItau.Services.Statistic.StatisticManager;
using Microsoft.AspNetCore.Mvc;

namespace DesafioItau.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItauController(ITransacaoRepository repository, IStatisticServiceManager statisticService) : ControllerBase
    {
        [HttpPost("transacao")]
        public IActionResult PostTransacao([FromBody]Transacao transacao)
        {
            repository.AddTransacao(transacao);
            return Created();
        }
        [HttpDelete("transacao")]
        public IActionResult DeleteTransacao()
        {
            repository.ClearTransacoes();
            return Ok();
        }
        [HttpGet("estatistica")]
        public IActionResult GetStatistic()
        {
            var listTransacao1Min = repository.GetTransacaosIn60Seconds();

            var statisticModel = listTransacao1Min is null ? new StatisticModel() : statisticService.GetStatisticModel(listTransacao1Min);

            return Ok(statisticModel);
        }
    }
}