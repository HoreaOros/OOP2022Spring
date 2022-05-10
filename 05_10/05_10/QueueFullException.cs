// See https://aka.ms/new-console-template for more information
using System.Runtime.Serialization;

[Serializable]
internal class QueueFullException : Exception
{
    public QueueFullException()
    {
    }

    public QueueFullException(string? message) : base(message)
    {
    }

    public QueueFullException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected QueueFullException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}