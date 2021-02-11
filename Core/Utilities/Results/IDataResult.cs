using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult
    {
        //IResult'taki değişkenlerin yanında döndüreceğimiz değeri buraya yazıyoruz.
        T Data { get; }
    }
}
