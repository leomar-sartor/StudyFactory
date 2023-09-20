using DesignPaternFactory.Abstract;

namespace DesignPaternFactory.Entidade
{
    public class Vegetariano : LancheAbstract
    {
        public readonly string _nomeLanche;

        public Vegetariano()
        {
            _nomeLanche = "Lanche Vegetariano";
            Ingredientes.Add("Alface");
            Ingredientes.Add("Rúcula");
            Ingredientes.Add("Ervilha");
            Ingredientes.Add("Tomate");
        }

        public override string Nome { get => _nomeLanche; }
    }
}
