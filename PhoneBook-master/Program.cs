using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularList list = new CircularList();

            list.Recuperar();
            int op;
            bool sair = false;
            do
            {
                Console.Clear();
                Console.WriteLine("O que deseja fazer?");
                Console.WriteLine("1- Adicionar.");
                Console.WriteLine("2- Listar.");
                Console.WriteLine("3- Navegar.");
                Console.WriteLine("4- Sair.");
                op =  Convert.ToInt32(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        Console.Clear();
                        list.Cadastrar();                                              
                        break;
                    case 2:
                        break;
                    case 3:
                        Node no = list.head; 
                        bool empty = list.IsEmpty();

                        ConsoleKeyInfo key;
                        Console.Clear();
                        if (no != null)
                        {
                            CircularList.Print(no.data);
                        } else
                        {
                            Console.Clear();
                            Console.WriteLine("Lista vazia, aperte ESC.");
                        }
                        key = Console.ReadKey();
                        while(key.Key != ConsoleKey.Escape)
                        {
                            if (empty)
                            {   Console.Clear();
                                Console.WriteLine("Lista vazia, aperte ESC.");
                                
                            } else {
                                switch(key.Key)
                                {
                                    case ConsoleKey.UpArrow :
                                        no = no.prev;
                                        Console.Clear();
                                        CircularList.Print(no.data);
                                        
                                        break;

                                    case ConsoleKey.DownArrow:
                                        no = no.next;
                                        Console.Clear();
                                        CircularList.Print(no.data);
                                        
                                        break;
                                    case ConsoleKey.Insert:
                                        Console.Clear();
                                        Console.WriteLine("Atualizar contato.");
                                        list.Atualizar(no);
                                        Console.Clear();
                                        Console.WriteLine("Contato atualizado.");
                                        CircularList.Print(no.data);
                                        break;
                                    case ConsoleKey.Delete:
                                        no = list.Deletar(no);
                                        if (no != null)
                                        {
                                        Console.Clear();
                                        Console.WriteLine("Contato Deletado.");
                                        CircularList.Print(no.data);
                                        } else {
                                            Console.Clear();
                                            Console.WriteLine("Lista vazia, aperte ESC.");
                                            empty = true;
                                        }
                                        break;
                                }
                            }
                            
                            key = Console.ReadKey();
                        }
                        break;
                    case 4:
                        list.SalvarLista();
                        sair = true;
                        break;
                }
            }while (!sair);     
        }
    }
}