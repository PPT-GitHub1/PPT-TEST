﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Class1
    {
        public string GetDate()
        {
            DateTime date = DateTime.Now
            string ret = date.ToShortDateString();
            return (ret);
        }

        public string GetTime()
        {
            DateTime time = DateTime.Now;
            string ret = time.ToShortTimeString();
            return (ret);
        }
        
        public string GetDate2()
        {
            DateTime date = DateTime.Now;
            string ret = date.ToShortDateString();
            return (ret);
        }

        public string GetTime2()
        {
            DateTime time = DateTime.Now;
            string ret = time.ToShortTimeString();
            return (ret);
        }
        public string GetDate3()
        {
            DateTime date = DateTime.Now;
            string ret = date.ToShortDateString();
            return (ret);
        }

        public string GetTime3()
        {
            DateTime time = DateTime.Now;
            string ret = time.ToShortTimeString();
            return (ret);
        }

    }
}
