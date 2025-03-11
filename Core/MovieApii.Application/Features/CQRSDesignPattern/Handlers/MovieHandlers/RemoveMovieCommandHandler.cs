using MovieApii.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApii.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApii.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class RemoveMovieCommandHandler
    {
        private readonly MovieContext _context;

        public RemoveMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handle(RemoveMovieCommand command)
        {
            var value = await _context.Movies.FindAsync(command.MovieId);
            _context.Movies.Remove(value);
            await _context.SaveChangesAsync();

        }
    }
}
