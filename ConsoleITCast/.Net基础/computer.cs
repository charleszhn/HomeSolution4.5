﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleITCast.Net基础
{
    public class computer
    {
        public neicun Disk { get; set; }
        public void read()
        {
            Disk.read();
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public int digui(int x)
        {
            if (x < 2) return x;
            return digui(x - 2) + digui(x - 1);
        }
        public void write()
        {
            try
            {
                string s1 = "as";
                string s2 = "as";
                string s3 = s1 + s2;
                string.Intern(s2 + s3);//对字符串刘勇
                //拘留池作用

                //stack上分配的内存不一致，堆上的内存是一样的，因为留用了intern
                string.IsInterned(s2 + s3);
            }
            catch (NullReferenceException e)
            {
                //只能处理空引用异常
                throw e.InnerException;
                Path.GetPathRoot("");
            }
            Disk.write();
        }
        public List<int> number()
        {
            List<int> x = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                bool y = false;
                for (int j = 0; j < 5; j++)
                {
                    if (j == i)
                    {
                        y = true;
                    }
                }
                if (y)
                {
                    x.Add(i);
                }
            }
            return x;
        }

    }
}
