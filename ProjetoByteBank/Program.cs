using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoByteBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            var listagemDeUsuarios = new List<Usuario>()
            {
                new Usuario{Id =1, Nome ="Brayan", Cpf = 123456789, idade = 27 },
                new Usuario{Id =2, Nome="Larissa", Cpf= 789456123, idade= 32},
                new Usuario{Id= 3, Nome="Joao", Cpf= 456123786, idade = 33},
                new Usuario{Id=4, Nome="Luiza", Cpf= 963258741, idade = 30}

            };

            var listagemDeTransação = new List<Transação>()
            {
                new Transação{Id=2, Valor=5000, Tipo = "TED", Data = 14/11/2022, Devedor= "Lariisa", Credor="Brayan" },
                new Transação{Id=1, Valor=100, Tipo = "DOC", Data= 14/11/2022, Devedor= "Brayan", Credor = "Joao"},
                new Transação{Id=3, Valor= 1500, Tipo="TED", Data= 15/11/2022, Devedor= "Joao", Credor = "Luiza"},

            }; 

            // CRIAR CONSULTA LINQ 

            var resultado = from Id in listagemDeTransação select Id ;

            //Executar a Consulta.  

            foreach (var result in resultado)
            {
                Console.WriteLine($"{result.Id}| {result.Valor} | {result.Devedor } | { result.Credor}");
            }

        } 

    } 
    class Usuario
    {
        public int Id { get; set; } 
        public string Nome { get; set; } 
        public long Cpf { get; set; } 
        public int idade { get; set; } 
    } 

    class Transação
    {   
        public int Id { get; set; }
        public int Valor { get; set; } 
        public string Tipo { get; set; } 
        public long Data { get; set; } 
        public string Devedor { get; set; }
        public string Credor { get; set; }


    }

    
}
