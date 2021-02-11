using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //:this(success) ile tek parametreli constructor'ı da çalıştırıyoruz.
        //Aynı kodu tekrarlamamak için.
        //getter read only'dir ve read only'ler constructor'da set edilebilir.
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
