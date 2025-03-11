﻿using Microsoft.EntityFrameworkCore;
using MovieApii.Application.Features.CQRSDesignPattern.Results.MovieResults;
using MovieApii.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApii.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
   public  class GetMovieQueryHandler
    {
        private readonly MovieContext _context;

        public GetMovieQueryHandler(MovieContext context)
        {
            _context = context;
        }
        public async Task<List<GetMovieQueryResult>> Handle()
        {
            var values = await _context.Movies.ToListAsync();
            return values.Select(x => new GetMovieQueryResult
            {
                MovieId = x.MovieId,
                CoverImageUrl = x.CoverImageUrl,
                CreatedYear = x.CreatedYear,
                Description = x.Description,
                Duration = x.Duration,
                Rating = x.Rating,
                ReleaseDate = x.ReleaseDate,
                Status = x.Status,
                Title = x.Title
            }).ToList();
        }
    }
}
