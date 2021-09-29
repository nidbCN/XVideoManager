using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace XVideoManager.Common.Extensions
{
    public static class DbContextExtension
    {
        public static void RemoveAll<T>(this DbSet<T> set, Predicate<T> predicate) where T : class
        {
            var collection = set.Where(x => predicate(x)).ToList();

            collection.Clear();
        }
    }
}
