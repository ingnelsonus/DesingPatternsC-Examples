/**
 * @author Oscar Javier Blancarte Iturralde.
 * @see http://oscarblancarteblog.com
 */
namespace facade.impl{
    public interface IPaymentFacade {
        PaymentResponse Pay(PaymentRequest paymentRequest);
    }
}


