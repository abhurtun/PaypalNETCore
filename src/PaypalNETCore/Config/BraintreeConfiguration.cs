using Braintree;

namespace PaypalNETCore.Config
{
    class BraintreeConfiguration : IBraintreeConfiguration
    {
        private IBraintreeGateway BraintreeGateway { get; set; }

        public IBraintreeGateway CreateGateway()
        {
            return new BraintreeGateway
            {
                Environment = Environment.SANDBOX,
                MerchantId = "pn477kgsg7ntckm8",
                PublicKey = "z3ps56jxhyf87r92",
                PrivateKey = "05961817516fda9185506abdfe8ccfa6"
            };
        }

        public IBraintreeGateway GetGateway()
        {
            if (BraintreeGateway == null)
            {
                BraintreeGateway = CreateGateway();
            }

            return BraintreeGateway;
        }
    }
}
