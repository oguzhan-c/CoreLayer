using System;
using System.Transactions;
using Castle.DynamicProxy;
using CoreLayer.Utilities.Interceptors;

namespace CoreLayer.Aspects.Autofac.Transaction
{
    public class TransactionScopeAspect : MethodInterception
    {
        public override void Intercept(IInvocation invocation)
        {
            using (TransactionScope transactionScope = new TransactionScope())
            {
                try
                {
                    invocation.Proceed();//Invocation : Metot
                    //metotta yazdığın kodu çalıştır eğer hata yoksa devam eğer hata varsa zaten catch e gidecek
                    transactionScope.Complete();
                }
                catch (Exception e)
                {
                    transactionScope.Dispose();
                    Console.WriteLine(e.Message);
                    throw;
                }
            }
        }
    }
}
