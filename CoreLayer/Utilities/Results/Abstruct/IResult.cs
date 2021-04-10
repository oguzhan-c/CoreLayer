namespace CoreLayer.Utilities.Results.Abstruct
{
    //Void içeren class IREsult 
    public interface IResult
    {
        bool Succcess { get; }
        string Message { get; }
    }
}
