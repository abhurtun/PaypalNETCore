using Braintree;

namespace PaypalNETCore.Config
{
    interface IBraintreeConfiguration
    {
        IBraintreeGateway CreateGateway();

        IBraintreeGateway GetGateway();
    }
}
