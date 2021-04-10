using System;
using CoreLayer.Utilities.Results.Abstruct;

namespace CoreLayer.Utilities.Results.Concrute
{
    public class DataResult<TIp> : Result, IDataResult<TIp>
    {
        public TIp Data { get; }

        public DataResult(TIp data , bool success ,String message):base(success,message)
        {
            Data = data;
        }

        public DataResult(TIp data , bool success):base(success)
        {
            Data = data;
        }
    }
}
