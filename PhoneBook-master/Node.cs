namespace PhoneBook
{
    public class Node
    {
        public Contato data;
        public Node next;
        public Node prev;

        public Node(Contato c) //Construtor com passagem de um Contato
        {
            data = c;
            next = null;
            prev = null;
        }
    }
}