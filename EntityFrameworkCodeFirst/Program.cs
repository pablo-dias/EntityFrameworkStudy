using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ClienteContext())
            {
                var quantidade_clientes = context.Clientes.Count();
                //context.Clientes.Add(new Cliente() { Nome = "Pablo Dias", Telefone = "9999-0000", CPF="09160603496" });
                //context.Produtos.Add(new Produto() { Nome = "GTX 3080", Descricao = "Placa de vídeo de última geração" });

                //context.SaveChanges();

                var query = context.Clientes.Where(c => c.Nome.Contains("Pablo")).ToString();
                var clientes = context.Clientes.Where(c => c.Nome.Contains("Pablo")).ToList();
            }
        }
    }
}
