using MovieApii.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApii.Domain.Entities;
using MovieApii.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApii.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public CreateCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handle(CreateCategoryCommand command)
        {
            _context.Categories.Add(new Category
            { 
                
                CategoryName = command.CategoryName
            });
            await _context.SaveChangesAsync();
        }
    }
}
