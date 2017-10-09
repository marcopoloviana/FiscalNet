FiscalNet
=================

Framework gratuito para para cálculos de Icms, Ipi, Pis e Cofins a serem utilizados na emissão de NF-e, NFC-e, SAT, e CT-e

A biblioteca foi desenvolvida com o Visual Studio Community 2015 e é compatível com o Visual Studio Community 2017.
Está licenciada sobre a LGPL.

**Instruções para compilar a solução**
- No visual studio, abra o arquivo "Fiscal.sln" e compile;

**Projetos na Solução**
- FiscalNet: Biblioteca de tributações;
- Testes Tributação: Projeto de teste unitário pelo Visual Studio;
- TestesTributos: Projeto de testes de tributos via console;

**Exemplo de utilização via console:**

    static void Main(string[] args)
    {
    BaseValorST_201_202_203();
    }
    
    private static void BaseValorST_201_202_203()
    {
    IIcms icms202 = new Icms201_202_203(12, 18, 400, 1565, 35, 39, 8000, 0);
    
    decimal baseIcms = icms202.ValorIcms();
    
    decimal baseSt = icms202.BaseIcmsST();
    decimal valorSt = icms202.ValorIcmsST();
    
    Console.WriteLine($"Base ST: {baseSt.ToString("N2")}");
    Console.WriteLine($"Valor ST: {valorSt.ToString("N2")}");
    
    Console.ReadKey();
    }


**Suporte:**

O uso dessa biblioteca não lhe dá quaisquer garantias de suporte. No entanto se tiver dúvidas a respeito do uso desta biblioteca, abra um novo Issue aqui mesmo no github.

**Apoio:**

A criação dessa biblioteca possui o suporte técnico do colega Marcos Vinícius.

A criação dessa biblioteca possui o suporte fiscal do SAC FISCAL & Automação www.sacfiscal.com.br.

