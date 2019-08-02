using CSharpCorner.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpCorner.Repository.Contract
{
    public interface ILibraryRepository
    {
        IEnumerable<Author> GetAllAuthor();
    }
}
