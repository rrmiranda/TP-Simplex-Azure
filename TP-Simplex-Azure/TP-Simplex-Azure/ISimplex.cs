using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace TP_Simplex_Azure
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISimplex
    {

        [OperationContract]
        string Calcular(string parametro);

        [OperationContract]
        ParametroFase1 CalcularSimplex(string FO, float[] VetProdutos, string[] VetInequacao);

        //[OperationContract]
        //float[,] CriaTabela(string FO, float[] VetProdutos, string[] VetInequacao);

        //[OperationContract]
        //void AnaliseFase1();

        //[OperationContract]
        //void AnaliseFase2();

        //[OperationContract]
        //void AlgoritmoTroca(float[] VetLinhaPermitida, float[] VetColunaPermitida, float EP, int ControleLinha, int ControleColuna);

        //[OperationContract]
        //ParametroFase1 Resultado(bool EstadoAtipico);

        [OperationContract]
        int CalculateDays(int day, int month, int year);

        [OperationContract]
        void SetarTamanhoTabela(int x, int y);

        [OperationContract]
        void SetarValorTabela(float valor, int L, int C);
        
        [OperationContract]
        string RetornarTabela();


        [OperationContract]
        void SetarTamanhoValorVariaveis(int x, int y);

        [OperationContract]
        void SetarValorVariaveis(string valor, int L, int C);
        
        [OperationContract]
        string RetornarValorVariaveis();

        [OperationContract]
        void SetarTamanhoMatRestricoes(int x, int y);

        [OperationContract]
        void SetarMatRestricoes(float valor, int L, int C);

        [OperationContract]
        string RetornarMatRestricoes();

        [OperationContract]
        float RetornarValorMatRestricoes(int L, int C);

        [OperationContract]
        int RetornarTamMatRestricoes();
        
    }


    [DataContract]
    public class ParametroFase1
    {
        [DataMember]
        public string result { get; set; }

        [DataMember]
        public string resultvalores { get; set; }

        
    }

    [DataContract]
    public class ParametroFase2
    {
        [DataMember]
        public float[,] Tabela { get; set; }
     
    }

    [DataContract]
    public class Valor
    {
        [DataMember]
        public string[,] ValorVariaveis { get; set; }
    }

    [DataContract]
    public class Valor2
    {
        [DataMember]
        public float[,] MatRestricoes { get; set; }
    }


    [DataContract]
    public class ParametroSimplex
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
