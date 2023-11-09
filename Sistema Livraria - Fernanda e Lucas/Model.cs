using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Livraria___Fernanda_e_Lucas
{
    class ModelSistema
    {
        //declarar vetores/variaveis
        public string[] titulos;
        public int[] qtLivro;
        public double[] valorLivro;
        public int i;
        string nome;
        string endereco;
        string telefone;
        string dtNasc;
        string login;
        string senha;
        string validarLogin;
        string validarSenha;
        string login2;
        string senha2;

        public ModelSistema()
        {
            //instanciando vetor/variavel
            titulos = new string[2];
            qtLivro = new int[2];
            valorLivro = new double[2];
            i = 0;

        }// fim do metodo construtor

        //metodo para cadastrar os livros
        public void CadastrarLivro()
        {
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("Insira o nome do " + (i + 1) + "° livro");
                titulos[i] = Console.ReadLine();

                Console.WriteLine("Insira a quantidade: ");
                qtLivro[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Insira o valor: ");
                valorLivro[i] = Convert.ToDouble(Console.ReadLine());
            }//fim do for
        }//fim do metodo cadastrar livros

        //metodo para exibir livros cadastrados

        public void ExibirLivros()
        {
            Console.WriteLine("CATÁLOGO:");

            Console.WriteLine("");//pula linha

            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("Livro " + (i + 1) + " : " + titulos[i]);

                Console.WriteLine("Quantidade: " + qtLivro[i]);

                Console.WriteLine("Valor: " + valorLivro[i]);

                Console.WriteLine("");//pula linha
            }//fim do for
        }//fim do metodo exibir livros

        //metodo para efetuar compra

        public void Compra(int idLivro)
        {
            int escolha;
            int idCartao;

            if (qtLivro[idLivro - 1] == 0)
            {
                Console.WriteLine("LIVRO INDISPONIVEL");
                Console.WriteLine("");//pular linha
                Console.WriteLine("Deseja fazer uma reserva?\n" +
                                  "\n1. Sim\n" +
                                  "2. Nao\n");
                escolha = Convert.ToInt32(Console.ReadLine());
                if (escolha == 1)
                {
                    Console.WriteLine("Livro Reservado!");
                }//fim do if
                else
                {
                    Console.WriteLine("Obrigado, volte sempre! :)");
                }//fim do else
            }//fim do if
            else
            {
                Console.WriteLine("\nResumo da Compra\n");
                Console.WriteLine("Livro: " + titulos[idLivro] + "\n" +
                                  "Quantidade: 1\n" +
                                  "Valor: " + valorLivro[idLivro]);

                Console.WriteLine("\n Insira o numero do cartão: ");
                idCartao = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nCompra Efetuada!\n" +
                                  "Agradecemos a Preferência! :)");
            }//fim do else

        }//fim do metodo compra

        //LUCAS//

        //metodo para cadastar usuario

        public void CadastrarUsuario()
        {
            //declarando variaveis locais

            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual seu endereco?");
            endereco = Console.ReadLine();

            Console.WriteLine("Qual seu telefone?");
            telefone = Console.ReadLine();

            Console.WriteLine("Qual a data de nascimento?");
            dtNasc = Console.ReadLine();

            Console.WriteLine("Qual seu login?");
            login = Console.ReadLine();
            validarLogin = login;


            if (validarLogin == login2)
            {
                Console.WriteLine("Você já está cadastrado! Faca login");

            }


            Console.WriteLine("Qual sua senha?");
            senha = Console.ReadLine();

            validarSenha = senha;

            if (validarSenha == senha2)
            {
                Console.WriteLine("Você já está cadastrado! Faca login");

            }


        }//fim do metodo cadastrar usuario

        //metodo para fazer login

        public void LoginUsuario()
        {
            do
            {
                Console.WriteLine("Qual é o seu login? ");
                login2 = Console.ReadLine();

                if (login2 != validarLogin)
                {
                    Console.WriteLine("Você não se cadastrou!");
                }
            } while (login2 != validarLogin);

            do
            {
                Console.WriteLine("Qual sua senha?");
                senha2 = Console.ReadLine();
                if (senha2 != validarSenha)
                {
                    Console.WriteLine("Você não se cadastrou!");
                }

            } while (senha2 != validarSenha);


        }//fim da classe model
    }
}
