using System;
using System.Collections.Generic;
using MVC_Console.Models;

namespace MVC_Console.Views
{
    public class ProdutoView
    {
        
        public void ListarTodos(List<Produto> produtos){

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            System.Console.WriteLine("---Lista dos Produtos---");
            System.Console.WriteLine();

           
            foreach (Produto item in produtos)
            {
                System.Console.WriteLine($"Código: {item.Codigo}");
                System.Console.WriteLine($"Nome: {item.Nome}");
                System.Console.WriteLine($"Preço: R$ {item.Preco}");
                System.Console.WriteLine();
            }
            
            Console.ResetColor();
        }

        
        public Produto CadastrarProduto(){

            Produto produto = new Produto();

            System.Console.Write($"Código do Produto: ");
            produto.Codigo = int.Parse(Console.ReadLine());

            System.Console.Write($"Descrição do Produto: ");
            produto.Nome = Console.ReadLine();
            
            System.Console.Write($"Preço do Produto: R$ ");
            produto.Preco = float.Parse(Console.ReadLine());

            return produto;
        }
    }
}