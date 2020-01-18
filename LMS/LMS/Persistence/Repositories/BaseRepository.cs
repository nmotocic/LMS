using System;
using LMS.Persistence.Context;

namespace LMS.Persistence.Repositories {

    public abstract class BaseRepository
    {
        protected readonly LibraryContext _context;

	    public BaseRepository(LibraryContext context)
	    {
            _context = context;
	    }
    }
}
