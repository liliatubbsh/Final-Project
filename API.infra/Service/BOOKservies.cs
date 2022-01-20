using API.core.Data;
using API.core.Repoisitory;
using API.core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.infra.Service
{
    public class BOOKservies : IBOOKservies
    {


        private readonly IBOOKrepoisitory _BOOK;
        public BOOKservies(IBOOKrepoisitory BOOK)
        {

            _BOOK = BOOK;
        }
        public bool Delete(int id)
        {
            return _BOOK.Delete(id);
        }

        public List<BOOK> Getall()
        {
            return _BOOK.Getall();
        }

        public BOOK GetallID(int id)
        {
            return _BOOK.GetallID(id);
        }

        public string Insert(BOOK book)
        {
            return _BOOK.Insert(book);
        }

        public bool Update(BOOK book)
        {
            return _BOOK.Update(book);
        }
    }
}
