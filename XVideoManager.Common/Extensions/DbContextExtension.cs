using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace XVideoManager.Common.Extensions
{
    public static class DbContextExtension
    {
        public static bool RemoveAll<T>(this DbSet<T> set, Predicate<T> predicate) where T : class
        {
            if(set is null)
                throw new ArgumentNullException(nameof(set));
            if (predicate is null)
                throw new ArgumentNullException(nameof(predicate));

            var collection = set.Where(predicate.Invoke).ToList();

            collection.Clear();

            if (collection.Count == 0)
                return false;

            return true;
        }
    }
}
