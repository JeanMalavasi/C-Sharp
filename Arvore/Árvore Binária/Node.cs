namespace Árvore_Binária
{
    public class Node
    {
        public int data;
        public Node SAE;
        public Node SAD;

        //Construtor de nó com filhos vazios
        public Node (int value)
        {
            data = value;
            SAE = null;
            SAD = null;
        }

        //Construtor  de nó com filhos
        public Node (int value, Node esq, Node dir)
        {
            data = value;
            SAE = esq;
            SAD = dir;
        }
    }
}