using System;
using Herança_e_interface.Funcionarios; 

namespace Herança_e_interface.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            
            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            } else {
                Console.WriteLine("Senha incorreta");
                return false;
            }

        }
    }
}