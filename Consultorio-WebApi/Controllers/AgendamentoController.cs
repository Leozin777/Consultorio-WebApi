using Consultorio.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendamentoController : ControllerBase
    {
        List<Agendamento> agendamentos = new List<Agendamento>();

        public AgendamentoController()
        {
            agendamentos.Add(new Agendamento
            {
                Id = 1,
                NomePaciente = "Leo",
                Horario = new DateTime(2022, 07, 18)
            });
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(agendamentos);
        }

        [HttpGet("{Id}")]
        public IActionResult GetById(int id)
        {
            var agendamentoSelecionado = agendamentos.FirstOrDefault(x => x.Id == id);

            if (agendamentoSelecionado != null)
                return Ok(agendamentoSelecionado);
            else
                return BadRequest("não existe");
        }

       
    }
}

