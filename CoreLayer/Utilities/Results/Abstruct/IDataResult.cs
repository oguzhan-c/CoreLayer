namespace CoreLayer.Utilities.Results.Abstruct
{
    //interface interface yi implemente ederse 
    //implemente edilen interfacenin içindekileri yazmaya gerek yok 
    //çünkü implemente edilen interface direk içi yazılmış gibi gelir
    public interface IDataResult<TIp> : IResult 
    {
        //car/cars
        TIp Data { get; }
    }
}
