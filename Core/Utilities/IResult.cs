using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    //Temel voidler için
    public interface IResult
    {
        bool Success { get; }

        string Message { get; }


    }
}
