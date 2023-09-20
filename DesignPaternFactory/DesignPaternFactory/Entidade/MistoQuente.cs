using DesignPaternFactory.Abstract;

namespace DesignPaternFactory.Entidade
{
    public class MistoQuente : LancheAbstract
    {
        public readonly string _nomeLanche;

        public MistoQuente()
        {
            _nomeLanche = "Lanche Misto Quente";
            Ingredientes.Add("Pão Francês");
            Ingredientes.Add("Presunto");
            Ingredientes.Add("Mussarela");
        }

        public override string Nome { get => _nomeLanche; }
    }
}
