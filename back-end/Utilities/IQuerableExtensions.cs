using System.Linq;
using back_end.DTOs;

namespace  back_end.Utilities
{
    public static class QuerableExtensions
    {
        public static IQueryable<T> Page<T>(this IQueryable<T> queryable, PaginationDTO paginationDTO) { 
            return queryable
            .Skip((paginationDTO.Page-1) * paginationDTO.RecordsPerPage)
            .Take(paginationDTO.RecordsPerPage);
        }
    }
}