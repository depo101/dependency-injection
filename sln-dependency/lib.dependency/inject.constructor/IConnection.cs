namespace lib.dependency.inject.constructor;

public interface IConnection<out TResult>
{
    TResult Connect();
}