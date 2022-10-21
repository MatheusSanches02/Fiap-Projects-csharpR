using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula01.UI.Models
{
    public class Professor
    {
        //Atributos (Campos/Fields)
        private string _nome;
        private decimal _salario;

        //Propriedades Getters/Setters
        public string Cpf { get; set; }
        public int Idade { get; set; }

        //Criar a propriedade (get/set) nome
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public decimal Salario
        {
            get { return _salario; }
            set 
            { 
                if (_salario > 0)
                    _salario = value; 
            }
        }

    }
}