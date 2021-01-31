using System;
using BookNook.MemoryBasedDAL;
using BookNook.DomainModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BookNook.Tests
{
    [TestClass]
    public class ReadRepositoryTests
    {
        [TestMethod]
        public void Test_AddBookRead()
        {
            ReadRepository readRep = ReadRepository.getInstance();

            BookRead readBook = new BookRead("Carrie", "Stephen King", "Hodder", DateTime.Now, 242, "horror", DateTime.Now, 2);

            readRep.AddBookRead(readBook);

            Assert.AreEqual(4, readRep.getReadBooksNum());
        }
    }
}
