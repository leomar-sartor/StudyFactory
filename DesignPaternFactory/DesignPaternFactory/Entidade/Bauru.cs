using DesignPaternFactory.Abstract;

namespace DesignPaternFactory.Entidade
{
    public class Bauru : LancheAbstract
    {
        public readonly string _nomeLanche;
        public Bauru()
        {
            _nomeLanche = "Lanche Bauru";
            Ingredientes.Add("Pão Francês");
            Ingredientes.Add("Presunto");
            Ingredientes.Add("Mussarela");
            Ingredientes.Add("Tomate");
            Ingredientes.Add("Maionese");
        }

        public override string Nome { get => _nomeLanche; }
    }
}
