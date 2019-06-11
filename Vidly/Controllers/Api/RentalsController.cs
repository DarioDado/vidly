using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;
using AutoMapper;

namespace Vidly.Controllers.Api
{
    public class RentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpPost]
        public IHttpActionResult CreateRental(NewRentalDto newRentalDto)
        {
            var customer = _context.Customers.Single(c => c.ID == newRentalDto.CustomerId);

            var movies = _context.Movies.Where(m => newRentalDto.MovieIds.Contains(m.ID)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available.");
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);

                movie.NumberAvailable--;
            }

            _context.SaveChanges();

            return Ok();
        }

        // GET /api/customers
        public IHttpActionResult GetRentals()
        {
            var rentalsQuery = _context.Rentals
            .Include("Customer")
            .Include("Movie");

            var rentalsDtos = rentalsQuery
                .ToList()
                .Select(Mapper.Map<Rental, RentalDto>);

            return Ok(rentalsDtos);
        }

        //PUT /api/rentals/1
        [HttpPut]
        public IHttpActionResult UpdateRental(int id)
        {
            var rental = _context.Rentals.Include("Movie").SingleOrDefault(r => r.ID == id);
            var movie = _context.Movies.SingleOrDefault(m => m.ID == rental.Movie.ID);

            if (rental == null)
                return NotFound();

            rental.DateReturned = DateTime.Now;

            movie.NumberAvailable++;

            _context.SaveChanges();

            return Ok();
        }
    }
}
