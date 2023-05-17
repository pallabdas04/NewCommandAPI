using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CommandAPI.Data;
using CommandAPI.Models;

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandAPIRepo _repository;
        public CommandsController(ICommandAPIRepo repository)
        {
            _repository=repository;
        }
        // [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] {"This","is","hard","coded"};
        // }
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems=_repository.GetAllCommands();
            return Ok(commandItems);
        }
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<Command>> GetCommandById(int id)
        {
            var commandItem=_repository.GetCommandById(id);
            if (ReferenceEquals(commandItem, null))
            {
                return NotFound();
            }
            return Ok(commandItem);
        }
    }
}