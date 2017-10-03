using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Utils
{
    public class Util
    {
        public static List<KeyValuePair<int, string>> ICMS_CSOSN()
        {
            List<KeyValuePair<int, string>> result = new List<KeyValuePair<int, string>>();

            result.Add(new KeyValuePair<int, string>(101, "101 - Tributada pelo Simples Nacional com permissão de crédito"));
            result.Add(new KeyValuePair<int, string>(102, "102 - Tributada pelo Simples Nacional sem permissão de crédito"));
            result.Add(new KeyValuePair<int, string>(103, "103 - Isenção do ICMS no Simples Nacional para faixa de receita bruta"));
            result.Add(new KeyValuePair<int, string>(201, "201 - Tributada pelo Simples Nacional com permissão de crédito e com cobrança do ICMS por substituição tributária"));
            result.Add(new KeyValuePair<int, string>(202, "202 - Tributada pelo Simples Nacional sem permissão de crédito e com cobrança do ICMS por substituição tributária"));
            result.Add(new KeyValuePair<int, string>(203, "203 - Isenção do ICMS no Simples Nacional para faixa de receita bruta e com cobrança do ICMS por substituição tributária"));
            result.Add(new KeyValuePair<int, string>(300, "300 - Imune"));
            result.Add(new KeyValuePair<int, string>(400, "400 - Não tributada pelo Simples Nacional"));
            result.Add(new KeyValuePair<int, string>(500, "500 - ICMS cobrado anteriormente por substituição tributária (substituído) ou por antecipação"));
            result.Add(new KeyValuePair<int, string>(900, "900 - Outros"));

            return result;
        }

        public static List<KeyValuePair<int, string>> ICMS_CST()
        {
            List<KeyValuePair<int, string>> result = new List<KeyValuePair<int, string>>();

            result.Add(new KeyValuePair<int, string>(00, "00 - Tributada integralmente."));
            result.Add(new KeyValuePair<int, string>(10, "10 - Tributada e com cobrança do ICMS por substituição tributária."));
            result.Add(new KeyValuePair<int, string>(20, "20 - Com redução de Base de Cálculo."));
            result.Add(new KeyValuePair<int, string>(30, "30 - Isenta ou não tributada e com cobrança do ICMS por substituição tributária."));
            result.Add(new KeyValuePair<int, string>(40, "40 - Isenta."));
            result.Add(new KeyValuePair<int, string>(41, "41 - Não tributada."));
            result.Add(new KeyValuePair<int, string>(50, "50 - Com suspensão."));
            result.Add(new KeyValuePair<int, string>(51, "51 - Com diferimento."));
            result.Add(new KeyValuePair<int, string>(60, "60 - ICMS cobrado anteriormente por substituição tributária."));
            result.Add(new KeyValuePair<int, string>(70, "70 - Com redução da Base de Cálculo e cobrança do ICMS por substituição tributária."));
            result.Add(new KeyValuePair<int, string>(90, "90 - Outras"));

            return result;
        }

        public static List<KeyValuePair<int, string>> PIS_COFINS_CST_SAIDA()
        {
            List<KeyValuePair<int, string>> result = new List<KeyValuePair<int, string>>();

            result.Add(new KeyValuePair<int, string>(01, "01 - Operação Tributável com Alíquota Básica."));
            result.Add(new KeyValuePair<int, string>(02, "02 - Operação Tributável com Alíquota Diferenciada."));
            result.Add(new KeyValuePair<int, string>(03, "03 - Operação Tributável com Alíquota por Unidade de Medida de Produto."));
            result.Add(new KeyValuePair<int, string>(04, "04 - Operação Tributável Monofásica - Revenda a Alíquota Zero."));
            result.Add(new KeyValuePair<int, string>(05, "05 - Operação Tributável por Substituição Tributária."));
            result.Add(new KeyValuePair<int, string>(06, "06 - Operação Tributável a Alíquota Zero."));
            result.Add(new KeyValuePair<int, string>(07, "07 - Operação Isenta da Contribuição."));
            result.Add(new KeyValuePair<int, string>(08, "08 - Operação sem Incidência da Contribuição."));
            result.Add(new KeyValuePair<int, string>(09, "09 - Operação com Suspensão da Contribuição."));
            result.Add(new KeyValuePair<int, string>(49, "49 - Outras Operações de Saída."));

            return result;

        }

        public static List<KeyValuePair<int, string>> PIS_COFINS_CST_ENTRADA()
        {
            List<KeyValuePair<int, string>> result = new List<KeyValuePair<int, string>>();

            result.Add(new KeyValuePair<int, string>(50, "50 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita Tributada no Mercado Interno."));
            result.Add(new KeyValuePair<int, string>(51, "51 - Operação com Direito a Crédito – Vinculada Exclusivamente a Receita Não Tributada no Mercado Interno."));
            result.Add(new KeyValuePair<int, string>(52, "52 - Operação com Direito a Crédito - Vinculada Exclusivamente a Receita de Exportação."));
            result.Add(new KeyValuePair<int, string>(53, "53 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno."));
            result.Add(new KeyValuePair<int, string>(54, "54 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas no Mercado Interno e de Exportação."));
            result.Add(new KeyValuePair<int, string>(55, "55 - Operação com Direito a Crédito - Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação."));
            result.Add(new KeyValuePair<int, string>(56, "56 - Operação com Direito a Crédito - Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação."));
            result.Add(new KeyValuePair<int, string>(60, "60 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Tributada no Mercado Interno."));
            result.Add(new KeyValuePair<int, string>(61, "61 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita Não-Tributada no Mercado Interno."));
            result.Add(new KeyValuePair<int, string>(62, "62 - Crédito Presumido - Operação de Aquisição Vinculada Exclusivamente a Receita de Exportação."));
            result.Add(new KeyValuePair<int, string>(63, "63 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno."));
            result.Add(new KeyValuePair<int, string>(64, "64 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas no Mercado Interno e de Exportação."));
            result.Add(new KeyValuePair<int, string>(65, "65 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Não-Tributadas no Mercado Interno e de Exportação."));
            result.Add(new KeyValuePair<int, string>(66, "66 - Crédito Presumido - Operação de Aquisição Vinculada a Receitas Tributadas e Não-Tributadas no Mercado Interno, e de Exportação."));
            result.Add(new KeyValuePair<int, string>(67, "67 - Crédito Presumido - Outras Operações."));
            result.Add(new KeyValuePair<int, string>(70, "70 - Operação de Aquisição sem Direito a Crédito."));
            result.Add(new KeyValuePair<int, string>(71, "71 - Operação de Aquisição com Isenção."));
            result.Add(new KeyValuePair<int, string>(72, "72 - Operação de Aquisição com Suspensão."));
            result.Add(new KeyValuePair<int, string>(73, "73 - Operação de Aquisição a Alíquota Zero."));
            result.Add(new KeyValuePair<int, string>(74, "74 - Operação de Aquisição sem Incidência da Contribuição."));
            result.Add(new KeyValuePair<int, string>(75, "75 - Operação de Aquisição por Substituição Tributária."));
            result.Add(new KeyValuePair<int, string>(98, "98 - Outras Operações de Entrada."));
            result.Add(new KeyValuePair<int, string>(99, "99 - Outros"));

            return result;
        }

        public static List<KeyValuePair<int, string>> IPI_CST_ENTRADA()
        {
            List<KeyValuePair<int, string>> result = new List<KeyValuePair<int, string>>();

            result.Add(new KeyValuePair<int, string>(00, "00 - Entrada com recuperação de crédito"));
            result.Add(new KeyValuePair<int, string>(01, "01 - Entrada tributada com alíquota zero"));
            result.Add(new KeyValuePair<int, string>(02, "02 - Entrada isenta"));
            result.Add(new KeyValuePair<int, string>(03, "03 - Entrada não tributada"));
            result.Add(new KeyValuePair<int, string>(04, "04 - Entrada imune"));
            result.Add(new KeyValuePair<int, string>(05, "05 - Entrada com suspensão"));
            result.Add(new KeyValuePair<int, string>(49, "49 - Outras Entradas"));

            return result;
        }

        public static List<KeyValuePair<int, string>> IPI_CST_SAIDA()
        {
            List<KeyValuePair<int, string>> result = new List<KeyValuePair<int, string>>();

            result.Add(new KeyValuePair<int, string>(50, "50 - Saída tributada"));
            result.Add(new KeyValuePair<int, string>(51, "51 - Saída tributável com alíquota zero"));
            result.Add(new KeyValuePair<int, string>(52, "52 - Saída isenta"));
            result.Add(new KeyValuePair<int, string>(53, "53 - Saída não tributada"));
            result.Add(new KeyValuePair<int, string>(54, "54 - Saída imune"));
            result.Add(new KeyValuePair<int, string>(55, "55 - Saída com suspensão"));
            result.Add(new KeyValuePair<int, string>(99, "99 - Outras saídas"));

            return result;
        }

        public static List<KeyValuePair<int, string>> OrigensProduto()
        {
            List<KeyValuePair<int, string>> result = new List<KeyValuePair<int, string>>();
            
            result.Add(new KeyValuePair<int, string>(0, "0 - Nacional, exceto as indicadas nos códigos 3 a 5"));
            result.Add(new KeyValuePair<int, string>(1, "1 - Estrangeira: Importação direta, exceto a indicada no código 6"));
            result.Add(new KeyValuePair<int, string>(2, "2 - Estrangeira: Adquirida no mercado interno, exceto a indicada no código 7"));
            result.Add(new KeyValuePair<int, string>(3, "3  Nacional, mercadoria ou bem com Conteúdo de Importação superior a 40% (quarenta por cento)"));
            result.Add(new KeyValuePair<int, string>(4, "4 - Nacional, cuja produção tenha sido feita em conformidade com os processos produtivos básicos de que tratam o Decreto-Lei nº 288/67, e as Leis nºs 8.248/91, 8.387/91, 10.176/01 e 11 . 4 8 4 / 0 7"));
            result.Add(new KeyValuePair<int, string>(5, "5 - Nacional, mercadoria ou bem com Conteúdo de Importação inferior ou igual a 40% (quarenta por cento)"));
            result.Add(new KeyValuePair<int, string>(6, "6 - Estrangeira: Importação direta, sem similar nacional, constante em lista de Resolução CAMEX"));
            result.Add(new KeyValuePair<int, string>(7, "7 - Estrangeira: Adquirida no mercado interno, sem similar nacional, constante em lista de Resolução CAMEX"));
            
            return result;
        }
    }
}
