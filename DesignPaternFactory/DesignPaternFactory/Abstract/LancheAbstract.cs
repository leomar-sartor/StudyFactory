using System.Collections;

namespace DesignPaternFactory.Abstract
{
    public abstract class LancheAbstract
    {
        public abstract string Nome { get; }
        public ArrayList Ingredientes = new ArrayList();
    }
}
