using API.core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.core.Repoisitory
{
   public interface ITEACHER_COURSErepoisitory
    {
        public string Insert(TEACHER_COURSE book);
        public bool Update(TEACHER_COURSE book);
        public bool Delete(int id);
        public List<TEACHER_COURSE> Getall();
        public TEACHER_COURSE GetallID(int id);


    }
}
