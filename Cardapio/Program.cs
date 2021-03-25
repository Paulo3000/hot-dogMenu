using System;

namespace Cardapio
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] preco = new double[8] { 22.50, 18.00, 19.50, 17.50,18.50,23.50,4.00,9.00 };
            string[] codigo = new string[8] { "p1","p2","p3","p4","p5","p6","p7","p8"};
            string[] porcao = new string[8] {"Frango","Polenta","Fritas","Mandioca",
                "Aneis de Cebola","Frango a passarinho","Refrigerante lata","Refrigerante 2lt"};
            double[] cont_preco = new double[8];
            double num = 0;

            string produto = "";
             // Console.WriteLine("conexão teste!!");
            Console.WriteLine("Frango--------------------22,50   (cod P1)");
            Console.WriteLine("Polenta-------------------18,00   (cod P2)");
            Console.WriteLine("Fritas--------------------19,50   (cod P3)");
            Console.WriteLine("Mandioca------------------17,50   (cod P4)");
            Console.WriteLine("Aneis de Cebola-----------18,50   (cod P5)");// mais produto
            Console.WriteLine("Frango a passarinho-------23,50   (cod P6)");
            Console.WriteLine("------------------BEBIDAS-----------------\n");
            Console.WriteLine("Refrigerante lata----------4,00   (cod P7)");
            Console.WriteLine("Refrigerante 2lt------------9,00   (cod P8)");

            Console.WriteLine("Digite o codigo do produto\n");
            //inicio:
            Console.WriteLine("Informe seu pedido:\npara confirmar pedido para confirmar pedido digite 1:");
            while (true)
            {
                produto = Console.ReadLine();
                for (int i = 0; i < preco.Length; i++)
                {

                    if (produto == codigo[i])
                    {
                        Console.WriteLine("***************************");
                        Console.WriteLine("valor da porção de {0} é {1}", porcao[i], preco[i]);
                        cont_preco[i] += preco[i]; //esta parte preenche o vetor caso acha repetição ele soma a repetição do produto.
                    }
                   
                }
                // saida do programa ainda não calcula os pedidos 
                if (produto == "1")
                {
                    Console.WriteLine("pedido realizado");
                    for (int i = 0; i < preco.Length; i++)
                    {
                       
                        num += cont_preco[i];
                    }

                    Console.WriteLine("Valor a ser pago---------" + num);


                    break;
                }
            }//fim do laço
            Console.ReadLine();
        }
    }
}
