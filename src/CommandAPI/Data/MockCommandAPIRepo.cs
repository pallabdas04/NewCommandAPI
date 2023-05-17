using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandAPI.Models;

namespace CommandAPI.Data
{
    public class MockCommandAPIRepo : ICommandAPIRepo
    {
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
            var commands=new List<Command>
            {
                new Command{
                    Id=0, HowTo="How to generate a migration",
                    CommandLine = "dotnet ef migrations add <Name of Migration>",
                    Platform=".Net Core EF"
                },
                new Command{
                    Id=1, HowTo="Run Migrations",
                    CommandLine = "dotnet ef database update",
                    Platform=".Net Core EF"
                },
                new Command{
                    Id=1, HowTo="List of active Migrations",
                    CommandLine = "dotnet ef database update",
                    Platform=".Net Core EF"
                }
            };
            return commands;
        }

        public Command GetCommandById(int Id)
        {
            var command=new Command {
                Id=0, HowTo="How to generate a migration",
                    CommandLine = "dotnet ef migrations add <Name of Migration>",
                    Platform=".Net Core EF"
            };
            return command;
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