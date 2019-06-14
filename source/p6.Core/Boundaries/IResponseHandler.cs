namespace p6.Core.Boundaries
{
    public interface IResponseHandler<in TResponse>
    {
        void Handle(TResponse response);
    }
}