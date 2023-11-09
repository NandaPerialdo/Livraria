using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Livraria___Fernanda_e_Lucas
{
    class ControlLivraria
    {   //declarando variaveis
        ModelSistema acao;
        private int opcao;
        int idLivro;


        public ControlLivraria()
        {   //instanciando
            acao = new ModelSistema();//Conecta a classe model com a control
            ConsultarOpcao = -1;
        }//Fim do método construtor

        public int ConsultarOpcao //get set do primeiro menu
        {
            get { return opcao; }
            set { opcao = value; }
        }//Fim do método


        public void Menu() //primeiro menu
        {
            Console.WriteLine("\n\n ---- menu ----\n\n" +
                              "0.Sair\n" +
                              "1.Cadastrar 2 Livros\n" +
                              "2.Cadastrar Usuario\n" +
                              "3.Fazer Login\n" +                          
                              "4.Fazer uma Compra");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//mostrar menu

        public void Operacao()
        {
            do
            {
                Menu();
                Console.Clear();
                switch (ConsultarOpcao)
                {
                    case 0://FECHAR PROGRAMA   
                        Console.WriteLine("Voce fechou o programa :(");
                        break;
                    case 1://CADASTRAR LIVROS
                        Console.WriteLine("Escolha uma opcao:");
                        acao.CadastrarLivro();                    
                        break;
                    case 2://CADASTRAR USUARIO
                        acao.CadastrarUsuario();
                        break;
                    case 3://LOGIN USUARIO
                        acao.LoginUsuario();
                        break;
                    case 4://EFETUAR COMPRA                    
                        acao.ExibirLivros();//exibir livros cadastrados que foram guardados nos vetores
                        
                        Console.WriteLine("Digite o codigo do livro que deseja:");
                        idLivro = Convert.ToInt32(Console.ReadLine());//coletar id do livro desejado

                        acao.Compra(idLivro);
                        break;  
                }//Fim escolha
            } while (ConsultarOpcao != 0);//Fim do while
        }//Fim operacao

    }//Fim da classe
}//Fim do projeto
