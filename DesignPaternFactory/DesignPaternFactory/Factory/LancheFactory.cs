using DesignPaternFactory.Abstract;
using DesignPaternFactory.Entidade;

namespace DesignPaternFactory.Factory
{
    internal class LancheFactory : LancheFactoryMethodAbstract
    {
        public override LancheAbstract CriarLanche(int tipo)
        {
            if (tipo == 1)
            {
                return new Bauru();
            }
            else if (tipo == 2)
            {
                return new Frango();
            }
            else if (tipo == 3)
            {
                return new MistoQuente();
            }
            else if (tipo == 4)
            {
                return new Vegetariano();
            }
            else
            {
                throw new System.ArgumentException("Lanche não encontrada");
            }
        }
    }
}
