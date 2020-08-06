using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecao;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {" Comentarios - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritméticos - Fundamentos ", OperadoresAritmeticos.Executar },
                {"Operadores Relacinais - Fundamentos ", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos ", OperadoresLogicos.Executar },
                {"Operadores de Atribuição - Fundamentos ", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos ", OperadoresUnarios.Executar },
                {"Operador Ternário - Fundamentos ", OperadorTernario.Executar },
                
                //Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura DoWhile - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar },
                
                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar },
                {"Construtores - Classes e Métodos", Construtores.Executar },
                {"Métodos Com Retorno  - Classes e Métodos", MetodosComRetorno.Executar },
                {"Métodos Estáticos  - Classes e Métodos", MetodosEstaticos.Executar },
                {"Atributos EStáticos - Classes e Métodos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Métodos", DesafioAtributo.Executar },
                {"Params - Classes e Métodos", Params.Executar },
                {"Parâmetros Nomeados - Classes e Métodos", ParametrosNomeados.Executar },
                {"Get Set - Classes e Métodos", GetSet.Executar },
                {"Props - Classes e Métodos", Props.Executar },
                {"Readonly - Classes e Métodos", Readonly.Executar },
                {"Enum - Classes e Métodos", ExemploEnum.Executar },
                {"Struct - Classes e Métodos", ExemploStruct.Executar },
                {"Struct Vs Classe - Classes e Métodos", StructVsClasse.Executar },
                {"Valor Vs Referência - Classes e Métodos", ValorVsReferencia.Executar },
                {"Parâmetros Por Referência - Classes e Métodos", ParametrosPorReferencia.Executar },
                {"Parâmetro com Valor Padrão - Classes e Métodos", ParametroPadrao.Executar },
                
                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar },
                {"List - Coleções", ColecoesList.Executar },
                {"Array List - Coleções", ColecoesArrayList.Executar },
                {"Set - Coleções", ColecoesSet.Executar },
                {"Queue - Coleções", ColecoesQueue.Executar },
                {"Igualdade - Coleções", Igualdade.Executar },
                {"Stack - Coleções", ColecoesStack.Executar },
                {"Dictionary - Coleções", ColecoesDictionary.Executar },
                
                //OO - Orientação a Objetos
                {"Herança - OO", Heranca.Executar },
                {"Construtor This - OO", ConstrutorThis.Executar },
                {"Encapsulamento - OO", Encapsulamento.Executar },
                {"Polimorfismo - OO", Polimorfismo.Executar },
                {"Abstract (Revisar) - OO", Abstract.Executar },
                {"Interface (Revisar) - OO", Interface.Executar },
                {"Selead - OO", Sealed.Executar },
                
                //Métodos & Funções
                {"Exemplo Lambda (Revisar) - Métodos & Funções", ExemploLambda.Executar },
                {"Lambdas Como Delegates (Revisar) - Métodos & Funções", LambdasDelegate.Executar },
                {"Usando Delegates (Revisar) - Métodos & Funções", UsandoDelegates.Executar },
                {"Delegates Como Função Anônima (Revisar) - Métodos & Funções", DelegateFunAnonima.Executar },
                {"Delegates Como Parâmetros (Revisar) - Métodos & Funções", DelegatesComoParametros.Executar },
                {"Métodos de Extensão (Revisar) - Métodos & Funções", MetodosDeExtensao.Executar },
               
                //Exceções
                {"Primeira Exceção (Revisar) - Exceções", PrimeiraExcecao.Executar },
                {"Excecoes Personalizadas (Revisar) - Exceções", ExcecoesPersonalizadas.Executar },
                
                // Api
                {"Primeiro Arquivo (Estudar um Pouco) - Usando API", PrimeiroArquivo.Executar },
                {"Lendo Arquivos - Usando API", LendoArquivos.Executar },
                {"Exemplo FileInfo - Usando API", ExemploFileInfo.Executar },
                {"Diretórios - Usando API", Diretorios.Executar },
                {"Exemplo DirectoryInfo - Usando API", ExemploDirectoryInfo.Executar },
                {"Exemplo Path - Usando API", ExemploPath.Executar },
                {"Exemplo DateTime - Usando API", ExemploDateTime.Executar },
                {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar },
                
                // Tópicos Avançados
                {"LINQ #01 - Tópicos Avançados", LINQ1.Executar },
                {"LINQ #02 - Tópicos Avançados", LINQ2.Executar },
                {"Nullables - Tópicos Avançados", Nullables.Executar },
                {"Dynamics - Tópicos Avançados", Dynamics.Executar },
                {"Genéricos - Tópicos Avançados", Genericos.Executar },
                
                
               









            });

            central.SelecionarEExecutar();
        }
    }
}