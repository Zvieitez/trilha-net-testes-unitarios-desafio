using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString validacoes = new();

    [Fact]
    public void DeveRetornarQuantidadeCaracteresDeDetrminadaPalavra()
    {
        var texto = "Avanade"; 
        var resultadoEsperado = 7;

        var sut = validacoes.RetornarQuantidadeCaracteres(texto);

        Assert.Equal(resultadoEsperado, sut);
    }

    [Fact]
    public void DeveConterTextoProcurado()
    {
        var texto = "Ajudamos as organizações a conquistar o essencial";
        var textoProcurado = "essencial";

        var sut = validacoes.ContemTexto(texto, textoProcurado);

        Assert.True(sut);
    }

    [Fact]
    public void NaoDeveConterTextoProcurado()
    {
        var texto = "Nós definimos o essencial";
        var textoProcurado = "Avanade";

        var sut = validacoes.ContemTexto(texto, textoProcurado);

        Assert.False(sut);
    }

    [Fact]
    public void DeveTerminarTextoProcurado()
    {
        var texto = "Nós fortalecemos o que é importante";
        var textoProcurado = "importante"; 

        var sut = validacoes.TextoTerminaCom(texto, textoProcurado);

        Assert.True(sut);
    }
    
    [Fact]
    public void NaoDeveTerminarTextoProcurado()
    {
        var texto = "Nós fazemos o essencial";
        var textoProcurado = "Avanade"; 

        var sut = validacoes.TextoTerminaCom(texto, textoProcurado);

        Assert.False(sut);
    }

}

 