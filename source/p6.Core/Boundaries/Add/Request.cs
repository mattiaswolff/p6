namespace p6.Core.Boundaries.Add
{
    public sealed class Request : IRequest
    {
        public string Name { get; }

        public Request (string name)
        {
            Name = name;
        }
    }
}