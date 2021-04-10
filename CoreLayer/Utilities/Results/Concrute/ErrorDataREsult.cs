using System;

namespace CoreLayer.Utilities.Results.Concrute
{
    public class ErrorDataResult<TIp> : DataResult<TIp>
    {
        public  ErrorDataResult(TIp data, String message) : base(data,false,message)
        {
        }

        public ErrorDataResult(TIp data) : base(data,false)
        {

        }

        public ErrorDataResult(String message) : base(default, false, message)
        {
        }

        public ErrorDataResult() : base(default, false)
        {
        }



    }
}
