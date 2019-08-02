using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpCorner.Entities;
using CSharpCorner.Repository.Contract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CSharpCorner.Controllers
{
    [Route("api/Libraries")]
    [ApiController]
    public class LibrariesController : ControllerBase
    {
        private readonly ILibraryRepository _libraryRepository;

        public LibrariesController(ILibraryRepository libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

        //Get: api/Libraries/GetAllAuthor
        [HttpGet]
        [Route("GetAllAuthor")]
        public IActionResult GetAllAuthor()
        {
            var authors = _libraryRepository.GetAllAuthor();

            return Ok(authors);
        }
    }
}