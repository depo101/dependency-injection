namespace lib.dependency.inject.constructor;

public interface IConnectionResult
{
    IConnectionResult Connected(Func<bool> f);
    string ConnectionStatus { get; }
}