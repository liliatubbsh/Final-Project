using API.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.core.Service
{
    public interface IBOOKservies
    {
        public string Insert(BOOK book);
        public bool Update(BOOK book);
        public bool Delete(int id);
        public List<BOOK> Getall();
        public BOOK GetallID(int id);
    }
}
