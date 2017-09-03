using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using BookStore.Domain.Abstract;
using BookStore.Domain.Entities;
using BookStore.WebUI.Controllers;

namespace BookStore.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Paginate()
        {
            // Организация (arrange)
            Mock<IBookRepository> mock = new Mock<IBookRepository>();
            mock.Setup(m => m.Books).Returns(new List<Book>
            {
                new Book { BookId = 1, Name = "Книга1"},
                new Book { BookId = 2, Name = "Книга2"},
                new Book { BookId = 3, Name = "Книга3"},
                new Book { BookId = 4, Name = "Книга4"},
                new Book { BookId = 5, Name = "Книга5"}
            });
            BookController controller = new BookController(mock.Object);
            controller.pageSize = 3;

            // Действие (act)
            IEnumerable<Book> result = (IEnumerable<Book>)controller.List(2).Model;

            // Утверждение (assert)
            List<Book> books = result.ToList();
            Assert.IsTrue(books.Count == 2);
            Assert.AreEqual(books[0].Name, "Книга4");
            Assert.AreEqual(books[1].Name, "Книга5");
        }
    }
}