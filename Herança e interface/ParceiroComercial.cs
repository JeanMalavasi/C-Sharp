using System;
using Herança_e_interface.Sistemas;
namespace Herança_e_interface
{
    public class ParceiroComercial : Autenticavel 
    {   public string senha { get; set; }
        public bool Autenticar (string senha)
        {
            return this.senha == senha;
        }
    }
}