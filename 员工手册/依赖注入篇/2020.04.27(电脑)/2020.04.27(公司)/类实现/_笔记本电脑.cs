﻿using System;
using System.Collections.Generic;
using System.Text;
using _2020._04._27_公司_.接口;

namespace _2020._04._27_公司_.类实现
{
    class _笔记本电脑 : _电脑,带触摸板的电脑, 带键盘的电脑,笔记本电脑
    {
        protected 带触摸板的电脑 _触摸板;
        protected 带键盘的电脑 _键盘;

        public _笔记本电脑(带触摸板的电脑 触摸板, 带键盘的电脑 键盘)
        {
            _触摸板 = 触摸板;
            _键盘 = 键盘;
        }

        public override string 名字()
        {
            return "笔记本电脑";
        }
        public override string 显示()
        {
            return _触摸板.显示();
        }

        public void 射击游戏(射击游戏 game)
        {
            Console.WriteLine(game);
        }

        public void 工作(工作内容 work)
        {
            Console.WriteLine(work);
        }

        public void 点击(点 d)
        {
            _触摸板.点击(d);
        }

        public void 输入文字(string text)
        {
            _键盘.输入文字(text);
        }
    }
}
