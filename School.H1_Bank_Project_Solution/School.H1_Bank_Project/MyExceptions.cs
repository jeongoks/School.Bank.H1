using System;
using System.Collections.Generic;
using System.Text;

namespace School.H1_Bank_Project
{
    public class OverdraftException : Exception
    {
        public OverdraftException(string desc) :base(desc)
        {

        }
    }
}
