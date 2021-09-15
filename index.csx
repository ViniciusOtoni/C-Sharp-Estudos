




using System;
using System.Collections.Generic;

public class Retangulo
{
    public double altura { get; set;}
    public double basee {get; set;}
}


public class Notas
{
    public int Nota1 {get; set;}
    public int Nota2 {get; set;}
    public int Nota3 {get; set;}
}

public class TreinoFocadoA
{
    public int SomaImpares (List<int> numeros)
    {
        int soma = 0;
        foreach (int valores  in numeros)
        {
            if(valores % 2 == 1)
            {
                soma = soma + valores;
            }
        }
    return soma;
    }

    public List<int> CalcularCubo (List<int> numeros)
    {
        List<int> conta = new List<int>();
        foreach(int item in numeros)
        {
            conta.Add(Convert.ToInt32(Math.Pow(item, 3)));
        }
    return conta;
    } 

    public List<double> CalcularRaiz(List<double> numeros)
    {
        List<double> raiz = new List<double>();
        foreach(double item  in numeros)
        {
            raiz.Add(Math.Sqrt(item));
        }
    return raiz;
    }

    public int MaiorNumero(List<int> numeros)
    {
        int valores = 0;
        foreach(int item in numeros)
        {
            if(item > valores)

            {
                valores = item;
            }
        }
        return valores;
    }

    public double Media (List<double> numeros)
    {
        double conta = 0;
        foreach(double item in numeros)
        {
            conta += item;
        }
        double media = conta / numeros.Count;
        return media;
    }

    public List<int> CalcularMedia (List<Notas> numeros)
    {
        List<int> Media = new List<int>();
        
        int conta = 0;
        foreach (Notas item in numeros)
        {
         conta = (item.Nota1 + item.Nota2 + item.Nota3) / 3;
         Media.Add(conta);
        }
        return Media;
    }


}

public class Pessoa 
{
    public string Nome { get; set;}
    public DateTime nascimento { get; set; }
    public string Cidade { get; set; }

    public override string ToString()
    {
        return $"{Nome}, {nascimento.ToString("dd/MM/yyyy")} você tem permissão <3";
    }
}

public class TreinoFocadoB
{
    public List<DateTime> UltimoDia (List<DateTime> dias) 
    {
        List<DateTime> Ult = new List<DateTime>();
        foreach (DateTime item in dias)
        {
            DateTime conta = item.AddMonths(1).AddDays(-item.Day);
            Ult.Add(conta);
        }
        return Ult;
    } 

    public DateTime MaiorData(List<DateTime> datas)
    {
        DateTime maior = DateTime.MinValue;
        foreach (DateTime item in datas)
        {
            if (item > maior)
                maior = item;
        }
        return maior;
    }

    public List<Pessoa> Filtrar18(List<Pessoa> pessoas)
    {
        List<Pessoa> filtradas = new List<Pessoa>();
        foreach (Pessoa item in pessoas)
        {
            if (item.nascimento < DateTime.Now.AddYears(-18))
                filtradas.Add(item);
        }
        return filtradas;
    }

} 



public class TreinoFocadoC
{
    public string SepararLetras (string Frase)
    {
        string FraseSeparada = string.Empty;
        foreach (char i in Frase)
        {
            FraseSeparada = FraseSeparada + i + "-";
        }
      return FraseSeparada;  
    }

    public List<int> CodigoASCII (string Frase)
    {
        List<int> ASCII = new List<int> ();
        foreach (char i in Frase)
        {
            ASCII.Add((int) i);
        }
    return ASCII;
    }

   



    public bool TodasVogais (string Frase)
    {
        bool vogais = false;
        foreach (char i in Frase)
        {
            if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u' || 
                i == 'A' || i == 'E' || i == 'I' || i == 'O' || i == 'U')
            {
                vogais = true;
            }
            else 
            {
                break;
            }
            
        }
    return vogais;
    }

    public string Alternar (Pessoa pessoa)
    {
        char x =  ' ';
        string xx = string.Empty;
        foreach (char i in pessoa.Nome)
        {
            if(x == ' ')
            {
                xx += i.ToString().ToUpper();
            }
            else 
            {
                xx += i.ToString().ToLower();
            }
         x = i; 
        }
    
    return xx;
    }

    public string Inverter (string Frase)
    {
        string FraseInvertida = string.Empty;
        foreach(char i in Frase)
        {
            FraseInvertida = i + FraseInvertida;
        }
    return FraseInvertida;
    }

    public bool Palindromo (string Frase)
    {
       bool  x = false;
    if (Inverter(Frase) == Frase)
    {
        x = true;
    }
    return x;
    }


public List<char>  CodigoASCIIrerverso (List<int> numerosASCII)
{
    List<char> tabela = new List<char> ();
    foreach (int i in numerosASCII)
        tabela.Add((char) i);
    return tabela;   

}


}


TreinoFocadoA tA = new TreinoFocadoA();


List<int> L1 = new List<int> { 1, 3 , 5 , 6, 9 };

double x1 = tA.SomaImpares(L1);
Console.WriteLine(x1);

List<int> L2 = new List<int> { 2, 6, 10};


List<double> L3 = new List<double> { 2, 6, 10};

List<int> x2 = tA.CalcularCubo(L2);
Console.WriteLine(string.Join(", ", x2));

List<double> x3 = tA.CalcularRaiz(L3);
Console.WriteLine(string.Join(", " ,x3));




int x4 = tA.MaiorNumero(L2);
Console.WriteLine(x4);

double x5 = tA.Media(L3);
Console.WriteLine(x5);

Notas valoresN = new Notas();
valoresN.Nota1 = 10;
valoresN.Nota2 = 10;
valoresN.Nota3 = 9;

List<Notas> L4 = new List<Notas> { valoresN };


List<int> x6 = tA.CalcularMedia(L4);
Console.WriteLine(string.Join(", ",x6)); 



TreinoFocadoB tB = new TreinoFocadoB();


List<DateTime> L11 = new List<DateTime> { new DateTime(2001,04,04) , new DateTime(2019,05,05) }; 

List<DateTime> Xb1 = tB.UltimoDia(L11);
Console.WriteLine(String.Join(", ", Xb1));

DateTime Xb2 = tB.MaiorData(L11);
Console.WriteLine(Xb2);


Pessoa valoresP = new Pessoa();
valoresP.Nome = "Vinícius";
valoresP.nascimento = new DateTime (2000,12,18);

List<Pessoa> Lista1 = new List<Pessoa>();
Lista1.Add(valoresP);



List<Pessoa> Xb3 = tB.Filtrar18(Lista1);
Console.WriteLine(String.Join(", ", Xb3));



Pessoa ValoresP1 = new Pessoa();
ValoresP1.Nome = "Vinícius";
ValoresP1.nascimento = new DateTime (2005,12,18);
ValoresP1.Cidade = "São Paulo";

TreinoFocadoC tC = new TreinoFocadoC();

string xC1 = tC.SepararLetras("Oie tudo bem?");
Console.WriteLine(xC1);

List<int> xC2 = tC.CodigoASCII("Vinicius Gostoso");
Console.WriteLine(string.Join(", ",xC2));

bool xC3 = tC.TodasVogais("AaAo");
Console.WriteLine(xC3);

string xC4 = tC.Alternar(ValoresP1);
Console.WriteLine(xC4);

string xC5 = tC.Inverter("Vinicius Gostoso");
Console.WriteLine(xC5);


bool xC6 = tC.Palindromo("ovo");
Console.WriteLine(xC6);


List<int> ASCII = new List<int> () {
   83, 105, 109, 32, 105, 114, 109, 227, 111, 44, 32, 105, 115, 115, 111, 32, 97, 113, 117, 105, 32, 233, 32, 109, 117, 105, 116, 111, 32, 108, 111, 117, 99, 111, 32, 110, 97, 109, 111, 114, 97, 108, 44, 32, 111, 115, 32, 99, 97, 114, 97, 115, 32, 110, 227, 111, 32, 118, 227, 111, 32, 99, 111, 110, 115, 101, 103, 117, 105, 114, 32, 101, 110, 116, 101, 110, 100, 101, 114, 32, 101, 115, 115, 97, 32, 99, 114, 105, 112, 116, 111, 103, 114, 97, 102, 105, 97
};

List<int> Funcao2TreinoC = tC.CodigoASCII(" So as lendas vao entender isso aq, os caras vao achar q mt numero aleatorio kkkk");
Console.WriteLine("Texto para ASCII " + String.Join(", ", Funcao2TreinoC));
List<char> Funcao10TreinoC = tC.CodigoASCIIrerverso(ASCII);
Console.WriteLine("ASCII pra texto = " + String.Join("", Funcao10TreinoC) );



