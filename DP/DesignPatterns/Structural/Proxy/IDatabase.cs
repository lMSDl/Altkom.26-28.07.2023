namespace DP.DesignPatterns.Structural.Proxy
{
    internal interface IDatabase
    {
        Task RequestAsync(int @int);
    }
}