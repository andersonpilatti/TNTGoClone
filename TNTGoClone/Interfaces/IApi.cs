﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using TNTGoClone.Models;

namespace TNTGoClone.Interfaces
{
	public interface IApi
	{
		[Get("/live")]
		Task<IList<Live>> GetLives();

		[Get("/movie")]
		Task<IList<Movie>> GetMovies();

		[Get("/show")]
		Task<IList<Show>> GetShows();

		[Get("/extra")]
		Task<IList<Extra>> GetExtras();
	}
}
