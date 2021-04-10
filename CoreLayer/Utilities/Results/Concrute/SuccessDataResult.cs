using System;

namespace CoreLayer.Utilities.Results.Concrute
{
    public class SuccessDataResult<TIp> : DataResult<TIp> 
    {
        public SuccessDataResult(TIp data , String message ):base(data,true,message)
        {
        }

        public SuccessDataResult(TIp data):base(data,true)
        {

        }

        public SuccessDataResult(String message):base(default,true,message)
        {
        }
         
        public SuccessDataResult():base(default,true)
        {
        }



    }
}
