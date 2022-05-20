using DesignPaternFactory.Abstract;

namespace DesignPaternFactory.Entidade
{
    public class Frango : LancheAbstract
    {
        public readonly string _nomeLanche;

        public Frango()
        {
            _nomeLanche = "Lanche de Frango";
            Ingredientes.Add("Peito de Frango");
            Ingredientes.Add("Tomate");
            Ingredientes.Add("Maionese");
        }

        public override string Nome { get => _nomeLanche; }
    }
}
