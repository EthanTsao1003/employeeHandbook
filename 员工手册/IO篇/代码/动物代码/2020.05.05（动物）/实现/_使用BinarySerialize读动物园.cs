﻿using _2020._05._05_动物_.接口;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace _2020._05._05_动物_
{
    class _使用BinarySerialize读动物园:_动物园,可以从地方读取对象的
    {
        protected IFormatter _binayFormat;
        
        public _使用BinarySerialize读动物园(IEnumerable<会叫的> 动物们, IFormatter binayFormat,可以显示的 可以显示的) : base(动物们,可以显示的)
        {
            _binayFormat = binayFormat;
            读();
        }
        public void 读()
        {
            FileStream fs = new FileStream("C:\\Users\\pp\\Desktop\\pp.txt", FileMode.Open, FileAccess.ReadWrite);
            //_动物们 = (IEnumerable<会叫的>)_binayFormat.Deserialize(_可以创建文件的);
            fs.Close();

        }
    }
}
