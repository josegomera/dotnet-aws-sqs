using Amazon.SQS.Model;

namespace Customers.Api.Messaging;

public interface ISqsMesseger
{
    Task<SendMessageResponse> SendMessageAsync<T>(T message);
}