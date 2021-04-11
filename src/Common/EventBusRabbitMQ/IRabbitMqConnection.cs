using RabbitMQ.Client;
using System;

namespace EventBusRabbitMQ
{
    //Using IDisposable the kill the connection 
    public interface IRabbitMqConnection :IDisposable
    {
        bool IsConnected { get; }
        bool TryConnect();
        IModel CreateModel();
    }
}
