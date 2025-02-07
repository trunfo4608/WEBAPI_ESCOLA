using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SmartSchoolAPI.Helpers
{
    public class PageList<T> : List<T>
    {
        public int CurrentPage { get; set; }
        public int TotalPages { get; set;}
        public int PageSize { get; set; }
        public int TotalCount { get; set; }

        public PageList(List<T> items, int count, int pageNumber, int pageSize)
        {
            this.AddRange(items);
            TotalCount = count;
            CurrentPage = pageNumber;
            PageSize = pageSize;
            TotalPages = (int) Math.Ceiling(count/(double)pageSize);
            
        }

        public static async Task<PageList<T>> CreateAsync(
             IQueryable<T> source, int pageNumber, int pageSize
            )
        {
            var count = await source.CountAsync();
            var items = await source.Skip( (pageNumber-1) * pageSize)
                         .Take(pageSize)
                         .ToListAsync();
            return new PageList<T>(items, count, pageNumber,pageSize);
        }


      

    }
}
