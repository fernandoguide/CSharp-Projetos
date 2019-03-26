using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Trabalho_c_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando as variáveis
            int CodCadastro = 0;
            string nome, cpf, endereco, bairro, cidade, estado, cep, fone;
            //inicio do laço de repetição "Faça" para todo o programa
            do
            {
                Console.WriteLine("Informe o código para cadastro da pessoa, ou 0 para sair do programa");
                CodCadastro = Convert.ToInt32(Console.ReadLine());
                //se o cadastro for igual a 0 vai direto para o final do programa caso contrário executa o "senão" else
                if (CodCadastro == 0)
                {
                    Console.WriteLine("Você optou por sair, pressione qualquer tecla para confirmar!");
                    Console.ReadKey();
                }
                //se cadastro for diferente de 0 executa o restante do programa
                else
                {
                    Console.WriteLine("Informe o nome");
                    nome = Console.ReadLine();
                    Console.WriteLine("Informe o CPF");
                    cpf = Console.ReadLine();
                    //remove espaço e branco no inicio e no fim do cpf
                    cpf = cpf.Trim();
                    //remove .(ponto), (barra) e (virgula) de cpf, poderia ir além, remover todos esses caracteres !@#$%¨¨&*()_+ e etc.
                    cpf = cpf.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");
                    //Enquanto cpf não contenha 11 caracteres entra em outro laço até que o usuário digite 11 caracteres.
                    while (cpf.Length != 11)
                    {
                        Console.WriteLine("CPF Inválido, Favor informar CPF com 11 digitos!");
                        cpf = Console.ReadLine();
                    }
                    Console.WriteLine("Informe o endereço");
                    endereco = Console.ReadLine();
                    Console.WriteLine("Informe o bairro");
                    bairro = Console.ReadLine();
                    Console.WriteLine("Informe a cidade");
                    cidade = Console.ReadLine();
                    Console.WriteLine("Informe o estado. (Informe apenas 2 caracteres para estado Ex.: BA");
                    estado = Console.ReadLine();
                    //remove espaço e branco no inicio e no fim
                    estado = estado.Trim();
                    //Enquanto estado não possuir 2 caracteres entra em outro laço até que o usuário digite 2 caracteres
                    estado = estado.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");
                    while (estado.Length != 2)
                    {
                        Console.WriteLine("Estado Inválido, Favor informar estado com 2 digitos!");
                        estado = Console.ReadLine();
                    }
                    Console.WriteLine("Informe o CEP com 8 digitos");
                    cep = Console.ReadLine();
                    //removendo espaço em branco no início e no fim
                    cep = cep.Trim();
                    //removendo outros caracteres (comando semelhante comentado anteriormente)
                    cep = cep.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");
                    //Enquanto cep não contenha 8 caracteres entra em outro laço até que o usuário digite 8 caracteres
                    while (cep.Length != 8)
                    {
                        Console.WriteLine("CEP Inválido, Favor informar CEP com 8 digitos!");
                        cep = Console.ReadLine();
                    }
                    Console.WriteLine("Informe o número de telefone");
                    fone = Console.ReadLine();

                    //criando um diretório (pasta) para armazenar o arquivos com os dados
                    //instancindo
                    DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Guide\Desktop\CadastroFuncionario");
                    //verificando de a pasta ja existe
                    if (!dir.Exists)
                        try
                        {
                            //caso NÃO exista cria a pasta trabalhorey em c:\
                            dir.Create();
                            Console.WriteLine("Diretório criado com sucesso.");
                        }
                        //Caso ocorra erro
                        catch (Exception e)
                        {
                            Console.WriteLine("Não foi possível criar o diretório: {0}", e.ToString());
                        }
                        finally { }
                    //instanciando, caso o arquivo não exita é criado, caso exista é adicionando as novas informações no final do arqivo
                    FileStream CriaArquivo = new FileStream(@"C:\Users\Guide\Desktop\CadastroFuncionario\cadastrados.txt", FileMode.Append);
                    //Chamando a classe q cria arquivo e escreve dentro do arquivo
                    StreamWriter Arquivo = new StreamWriter(CriaArquivo, Encoding.ASCII);
                    Arquivo.WriteLine("");
                    Arquivo.WriteLine("---------------novo registro-------------------");
                    Arquivo.WriteLine("");
                    Arquivo.WriteLine(Convert.ToString(CodCadastro));
                    Arquivo.WriteLine(nome);
                    Arquivo.WriteLine(cpf);
                    Arquivo.WriteLine(endereco);
                    Arquivo.WriteLine(bairro);
                    Arquivo.WriteLine(cidade);
                    Arquivo.WriteLine(estado);
                    Arquivo.WriteLine(cep);
                    Arquivo.WriteLine(fone);
                    //fechando
                    Arquivo.Flush();
                    Arquivo.Close();
                    CriaArquivo.Close();
                    Console.Clear();
                }
            }
            // condição do comando do (faça), caso diferente de 99999 continua o programa
            while (CodCadastro !=0);        
        }
    }
}
