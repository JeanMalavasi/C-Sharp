using System;


namespace PhoneBook
{
    public class CircularList
    {
        public Node head;
        
        public CircularList() //Construtor
        {
            head = null;
        }
        public void Cadastrar() //Cria um objeto e chama o metodo para adicionar a lista
        {   
            Console.WriteLine("Menu 1 - Adicionar\n");
            Contato contato = new Contato();
            Console.Write("Nome: ");
            contato.nome = Console.ReadLine();
            Console.Write("Email: ");
            contato.email = Console.ReadLine();
            Console.Write("Numero: ");
            contato.numero = Convert.ToInt32(Console.ReadLine());
            this.Add(contato);
        }
        public void Add(Contato contato) //Adiciona  o objeto a lista
        {     
            Node aux = head;
            var newNode = new Node(contato);
            if (head != null)
            {
                            
                aux = aux.prev;
                aux.next = newNode;
                newNode.prev = aux;
                newNode.next = head;
                head.prev = newNode;
            }
            else
            {               
                aux = newNode;
                aux.prev = aux;
                aux.next = aux;
                head = aux;
            }
        }
        public void SalvarLista() //Realiza a persistencia dos dados ao sair do programa
        {
            Console.WriteLine("Fechando aplicação.");
            if (!this.IsEmpty())
            {
            Node no = head;
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\4ºperíodo\EstruturaDeDados1\PhoneBook\contatos\Contatos.txt", false);
            do
            {
                file.WriteLine($"{no.data.nome}|{no.data.email}|{no.data.numero}");
                no = no.next; 
            }while (no != head);
            file.Close();
            } else {
                System.IO.StreamWriter file = new System.IO.StreamWriter(@"D:\4ºperíodo\EstruturaDeDados1\PhoneBook\contatos\Contatos.txt", false);
                file.Close();
            }
        }
        public static void Print(Contato contato) //Exibe os dados do contato
        {
            Console.WriteLine("Menu 3 - Navegação");
            Console.WriteLine("CIMA/BAIXO - navegar | INSERT - Atualizar | DELETE - Apagar | ESC - Sair da navegação\n");
            
            Console.WriteLine($"Nome: {contato.nome}");
            Console.WriteLine($"E-mail: {contato.email}");
            Console.WriteLine($"Numero: {contato.numero}");       
        }
        public void Atualizar(Node no) //Atualiza os dados do contato
        {   
            string[] att = new string[3];
            Console.Write("Nome: ");
            att[0] = Console.ReadLine();
            Console.Write("Email: ");
            att[1] = Console.ReadLine();
            Console.Write("Numero: ");
            att[2] = Console.ReadLine();

            if (att[0] != "")
            {
                no.data.nome = att[0];
            }
            if (att[1] != "")
            {
                no.data.email = att[1];
            }
            if (att[2] != "")
            {
                no.data.numero = Convert.ToInt32(att[2]);
            }
        }
        public Node Deletar(Node no) //Deleta o contato
        {   
            if (no == head && no.next == head)
            {
                head = null;
                return null;
            }

            bool flag = false;
            if (no == head)
            {
                flag = true;
            }
            Node prev = no.prev;
            Node next = no.next;

            prev.next = next;
            next.prev = prev;
            
            if (flag)
            {
                head = next;
            }

            return next;
        }
        public void Recuperar() //Recupera os dados do arquivo
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(@"D:\4ºperíodo\EstruturaDeDados1\PhoneBook\contatos\Contatos.txt");
            
                int i = 0;

                while (i < lines.Length)
                { 
                    Contato contato = new Contato();

                    string[] auxiliar = lines[i].Split("|");
                    contato.nome = auxiliar[0];
                    contato.email = auxiliar[1];
                    contato.numero = Convert.ToInt32(auxiliar[2]); 
                    this.Add(contato);
                i++;
                }
            } 
            catch (System.IO.FileNotFoundException e)
            {     
            }
        }
        public bool IsEmpty() //Verifica se a lista está vazia
        {
            return (head == null);
        }
        public void OrdenarNome(Node no) //Ordena a lista pelo nome
        {
        }
    }
}