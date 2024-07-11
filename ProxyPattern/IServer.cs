﻿namespace ProxyPattern
{
    /// <summary>
    /// The Subject interface which both the RealSubject and proxy will need to implement
    /// </summary>
    public interface IServer
    {
        void TakeOrder(string order);
        string DeliverOrder();
        void ProcessPayment(string payment);
    }
}
