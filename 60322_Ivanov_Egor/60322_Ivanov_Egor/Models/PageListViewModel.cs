using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _60322_Ivanov_Egor.Models
{
    public class PageListViewModel<T> : List<T>
    {
        public int TotalPages { get; private set; }
        public int CurrentPage { get; private set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="items">список элементов</param>
        /// <param name="total">общее количество страниц</param>
        /// <param name="current">номер текущей страницы</param>
        private PageListViewModel(List<T> items, int total, int current)
        {
            this.AddRange(items);
            TotalPages = total;
            CurrentPage = current;
        }
        /// <summary>
        /// Создание объекта PageListViewModel
        /// </summary>
        /// <param name="items">Полный список объектов</param>
        /// <param name="current">номер текущей страницы</param>
        /// <param name="pageSize">кол. элементов на странице</param>
        /// <returns></returns>
        public static PageListViewModel<T> CreatePage(IEnumerable<T> items, int currentPage, int pageSize)
        {
            int totalCount = items.Count();
            int pagesCount = (int)Math.Ceiling(totalCount / (double)pageSize); // qty of pages according to the numbr of goods and qty of goods are shown in a page
            var list = items.Skip(pageSize * (currentPage - 1)).Take(pageSize).ToList();
            return new PageListViewModel<T>(list, pagesCount, currentPage);
        }
        
    }
}