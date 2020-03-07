using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class MovieController : Controller
    {
        MovieDAL movieDAL = new MovieDAL();
        public IActionResult Index()
        {
            List<MovieInfo> movieList = new List<MovieInfo>();
            movieList = movieDAL.GetAllMovieTitle().ToList();
            return View(movieList);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] MovieInfo objMovie)
        {
            if (ModelState.IsValid)
            {
                movieDAL.AddMovie(objMovie);
                return RedirectToAction("Index");
            }
            return View(objMovie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MovieInfo movie = movieDAL.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, [Bind] MovieInfo objMovie)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                movieDAL.UpdateMovie(objMovie);
                return RedirectToAction("Index");
            }
            return View(movieDAL);
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MovieInfo movie = movieDAL.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MovieInfo movie = movieDAL.GetMovieById(id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMovie(int? id)
        {
            movieDAL.DeleteMovie(id);
            return RedirectToAction("Index");
        }

    }
}
