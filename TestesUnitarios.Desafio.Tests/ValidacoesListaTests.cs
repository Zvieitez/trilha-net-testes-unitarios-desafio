using System.ComponentModel;
using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesListaTests
{
    private ValidacoesLista validacoes = new();

    [Fact]
    public void ValidarListaVazia()
    {
        var lista = new List<int> {};

        var sut = validacoes.VerificarListaVazia(lista);

        Assert.True(sut);
    }

    [Fact]
    public void ValidarListaNula()
    {
        List<int> lista = null;

        var sut = validacoes.VerificarListaNula(lista);

        Assert.True(sut);
    }

    [Fact] 
    public void RemoveNumerosNegativosDeUmaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 }; 
        var resultadoEsperado = new List<int> {5, 9}; 

        var sut = validacoes.RemoverNumerosNegativos(lista);
        
        Assert.Equal(resultadoEsperado, sut);
    }

    [Fact]
    public void ContemONumeroNaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };
        var numeroParaProcurar = 9;

        var sut = validacoes.ListaContemDeterminadoNumero(lista, numeroParaProcurar);

        Assert.True(sut);
    }
    
    [Fact]
    public void NaoContemONumeroNaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9, 13};
        var numeroParaProcurar = 7;

        var sut = validacoes.ListaContemDeterminadoNumero(lista,numeroParaProcurar);

        Assert.False(sut);
    }
    
    [Fact]
    public void DeveMultiplicarOsElementosDaListaPor2()
    {
        var lista = new List<int> { 5, 7, 8, 9 };
        var resultadoEsperado = new List<int> { 10, 14, 16, 18 };

        var sut = validacoes.MultiplicarNumerosLista(lista, 2);

        Assert.Equal(resultadoEsperado, sut);
    }

    [Fact]
    public void DeveRetornarOMaiorNumeroDaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };
 
        var sut = validacoes.RetornarMaiorNumeroLista(lista);
        
        Assert.Equal(9, sut);
    }

    [Fact]
    public void DeveRetornarOMenorNUmeroNegativoDaLista()
    {
        var lista = new List<int> { 5, -1, -8, 9 };

        var sut = validacoes.RetornarMenorNumeroLista(lista);

        Assert.Equal(-8, sut);
    }

}
