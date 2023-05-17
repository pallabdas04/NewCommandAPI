using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class SqlCommandAPIRepo : ICommandAPIRepo
    {
        private readonly CommandContext _context;
        public SqlCommandAPIRepo(CommandContext context)
        {
            _context = context;
        }
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.CommandItems.ToList();
        }

        public Command GetCommandById(int Id)
        {
            var c = _context.CommandItems.FirstOrDefault(p => p.Id == Id);
            return c;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateColmmand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}