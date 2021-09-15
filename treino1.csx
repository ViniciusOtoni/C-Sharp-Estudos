using System;
using System.Collections.Generic;		




public class Notas
{
	public double Nota1 { get; set; }
	public double Nota2 { get; set; }
	public double Nota3 { get; set; }
}

public class Retangulo
{
	public double Base   { get; set; }
	public double Altura { get; set; }
}



public class TreinoFocadoA
{
	public List<int> GerarSequencia(int fim)
	{
		List<int> l = new List<int>();
		for (int i = 0; i <= fim; i++)
		{
			l.Add(i);
		}
		return l;
	}
	
	public List<int> GerarSequencia(int inicio, int fim)
	{
		List<int> l = new List<int>();
		for (int i = inicio; i <= fim; i++)
		{
			l.Add(i);
		}
		return l;
	}
	
	public List<int> GerarSequenciaPares(int inicio, int fim)
	{
		List<int> l = new List<int>();
		for (int i = inicio; i <= fim; i++)
		{
			if (i % 2 == 0)
				l.Add(i);
		}
		return l;
	}
	
	public int SomarAte(int fim)
	{
		int soma = 0;
		for (int i = 1; i <= fim; i++)
		{
			soma += i;	
		}
		return soma;
	}
	
	public double CalcularMedias(List<double> notas)
	{
		double soma = 0;
		for (int i = 0; i < notas.Count; i++)
		{
			double n = notas[i];
			soma = soma + n;
		}
		
		double media = soma / notas.Count;
		return media;
	}
	
	public List<double> CalcularMedias(List<Notas> notas)
	{
		List<double> mediasAlunos = new List<double>();
		
		for (int i = 0; i < notas.Count; i++)
		{
			Notas notasAluno = notas[i];
			double media = (notasAluno.Nota1 + notasAluno.Nota2 + notasAluno.Nota3) / 3;
			mediasAlunos.Add(media);
		}

		return mediasAlunos;
	}
	
	public List<double> Quadrados (List<double> numeros)
	{
		List<double> quads = new List<double>();
		for (int i = 0; i < numeros.Count; i++)
		{
			double n = numeros[i];
			double q = Math.Pow(n, 2);
			
			quads.Add(q);
		}
		return quads;
	}
	
	private double AreaRetangulo(Retangulo r)
	{
		return r.Base * r.Altura;	
	}
	
	public List<double> AreaRetangulos(List<Retangulo> retangulos)
	{
		List<double> areas = new List<double>();
		for (int i = 0; i < retangulos.Count; i++)
		{
			Retangulo r = retangulos[i];
			double area = AreaRetangulo(r);
			
			areas.Add(area);
		}
		
		return areas;
	}
	
}








TreinoFocadoA treinoA = new TreinoFocadoA();

//
List<int> x1 = treinoA.GerarSequencia(0);
Console.WriteLine(string.Join("-", x1));

//
List<int> x2 = treinoA.GerarSequencia(2, 4);
Console.WriteLine(string.Join("-", x2));

//
List<int> x3 = treinoA.GerarSequenciaPares(2, 4);
Console.WriteLine(string.Join("-", x3));

//
int x4 = treinoA.SomarAte(3);
Console.WriteLine(x4);

//
List<double> lx5 = new List<double>() { 4, 6, 8, 10 };
double x5 = treinoA.CalcularMedias(lx5);
Console.WriteLine(x5);

//
Notas n1 = new Notas();
n1.Nota1 = 5;
n1.Nota2 = 5;
n1.Nota3 = 5;

Notas n2 = new Notas();
n2.Nota1 = 10;
n2.Nota2 = 8;
n2.Nota3 = 6;

Notas n3 = new Notas();
n3.Nota1 = 2;
n3.Nota2 = 4;
n3.Nota3 = 0;


List<Notas> notas = new List<Notas>() { n1, n2, n3 };

List<double> x6 = treinoA.CalcularMedias(notas);
Console.WriteLine(string.Join("-", x6));

//
List<double> n7 = new List<double>() { 2,3,4,5 };
List<double> x7 = treinoA.Quadrados(n7);
Console.WriteLine(string.Join("-", x7));


// 
List<Retangulo> retangs = new List<Retangulo>() 
{
	new Retangulo() { Base = 5, Altura = 4 },
	new Retangulo() { Base = 3, Altura = 3 },
	new Retangulo() { Base = 10, Altura = 2 }
};

List<double> areas = treinoA.AreaRetangulos(retangs);
Console.WriteLine(string.Join("-", areas));


public class TreinoFocadoB 
{ 

public class Pessoa 
{
	string Nome{get;set;}
	DateTime Nascimento {get;set;}
}

public List<DateTime> GerarSequencia (int qtd)
{
	DateTime x = DateTime.Now;
	
	List<DateTime> l = new List<DateTime>();
	
	for(int i = 0; i <= qtd; i++)
	{
		DateTime sequencia = x.AddDays(i); 
		l.Add(sequencia);
	}
	return l;
}

public List<DateTime> GerarSequencia1(int qtd, DateTime Data)
{
	
	
	List<DateTime> l = new List<DateTime>();
	
	for(int i = 0; i <= qtd; i++)
	{
		DateTime sequencia = Data.AddDays(i); 
		l.Add(sequencia);
	}
	return l;

}			

public List<DateTime> GerarSequencia2(int qtd)
{
	DateTime x = DateTime.Now;
	
	List<DateTime> l = new List<DateTime>();
	
	for(int i = 0; i <= qtd; i++)
	{
		if(i % 2 == 0)
		{
		DateTime sequencia = x.AddDays(i); 
		l.Add(sequencia);
		}
		
	}
	return l;
}
	private string QualSigno(DateTime nascimento)
    {
        string Signo = string.Empty;
	
	    if (nascimento.Day >= 21 && nascimento.Month     == 1   || nascimento.Day <= 18 && nascimento.Month == 2)
		    Signo = "Aquário";
	    else if (nascimento.Day >= 19 && nascimento.Month == 2   || nascimento.Day <= 20 && nascimento.Month == 3)
		    Signo = "Peixes";
	    else if (nascimento.Day >=21 && nascimento.Month  == 3   || nascimento.Day <= 20 && nascimento.Month == 4)
		    Signo = "Áries";
	    else if (nascimento.Day >=21 && nascimento.Month  == 4   || nascimento.Day <= 20 && nascimento.Month == 5)
		    Signo = "Touro";
	    else if (nascimento.Day >=21 && nascimento.Month  == 5   || nascimento.Day <= 20 && nascimento.Month == 6)
		    Signo = "Gêmeos";
	    else if (nascimento.Day >=21 && nascimento.Month  == 6   || nascimento.Day <= 22 && nascimento.Month == 7)
		    Signo = "Câncer";
	    else if (nascimento.Day >=23 && nascimento.Month  == 7   || nascimento.Day <= 22 && nascimento.Month == 8)
		    Signo =  "Leão";
	    else if (nascimento.Day >=23 && nascimento.Month  == 8   || nascimento.Day <= 22 && nascimento.Month == 9)
		    Signo =  "Virgem";
	    else if (nascimento.Day >=23 && nascimento.Month  == 9   || nascimento.Day <= 22 && nascimento.Month == 10)
	        Signo = "Libra";
	    else if (nascimento.Day >=23 && nascimento.Month  == 10  || nascimento.Day <= 21 && nascimento.Month == 11)
		    Signo = "Escorpião";
	    else if (nascimento.Day >=22 && nascimento.Month  == 11  || nascimento.Day <= 21 && nascimento.Month == 12)
            Signo =  "Sagitário";
	    else if (nascimento.Day >=22 && nascimento.Month  == 12  || nascimento.Day <= 20 && nascimento.Month == 1)
		    Signo = "Capricórnio";
	    else 
		    Signo = "Se chegou aqui, seu signo é Alienígina";

        return Signo;
    }


	public List<string> Signos (List<DateTime> nascimento)
	{
		List<string> Sig = new List<string>();
		
		for(int i = 0; i < nascimento.Count; i++)
		{
			DateTime n = nascimento[i];
			string final  = QualSigno(n);
		Sig.Add(final);	
		}
	return Sig;
    } 
	


public string SepararLetras(string frase)
    {
        string separado = "";
        for (int i = 0; i < frase.Length; i++)
        {
            char letra = frase[i];
            separado += letra + "-";
        }   
        return separado;
    }
}

TreinoFocadoB treinoB = new TreinoFocadoB();

List<DateTime> l1 = treinoB.GerarSequencia(1);
Console.WriteLine(string.Join(",",l1));

DateTime x = new DateTime(2004,12,22);

List<DateTime> l2 = treinoB.GerarSequencia1(1,x);
Console.WriteLine(string.Join(",",l2));


List<DateTime> l3 = treinoB.GerarSequencia2(8);
Console.WriteLine(string.Join(",",l3));

DateTime x111 = new DateTime(2021,10,22);
DateTime x222 = new DateTime(2021,10,23);

List<DateTime> nasc = new List<DateTime>();
nasc.Add (x111);
nasc.Add(x222);



List<string> l4 = treinoB.Signos(nasc);
Console.WriteLine(string.Join("-",l4));



public class Pessoa
{
	public string Nome { get; set; }
	public DateTime Nascimento { get; set; }
	public string Cidade { get; set; }
}

public class TreinoFocadoC
{
	public string SepararLetras (string frase)
	{
		string Frase = string.Empty;
		for (int i = 0; i < frase.Length; i ++)
		{
			char posicao = frase[i];
			Frase += posicao + "-";
		}
		return Frase;
	}

	public string InverterLetras (string frase)
	{
		string Frase = string.Empty;
		for (int i = frase.Length -1; i >= 0; i --)
		{
			char posicao = frase[i];
			Frase += posicao;
		}
		return Frase;
	}

	 public bool TodasVogais(string frase)
    {
        frase = frase.ToLower();
        bool verdadeiro = false;

        if (frase.Contains("a") || frase.Contains("e") || frase.Contains("i") || frase.Contains("o") || frase.Contains("u"))
        {
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u')
                {
                    verdadeiro = true;
                }
                else
                {
                    verdadeiro = false;
                }
            }    
        }
        return verdadeiro;
    }

	 private string UltimoNome(string Nome)
    {
        int a = Nome.LastIndexOf(" ");
        string UltimoNome = Nome.Substring(a);
        string NomeFinal = UltimoNome.Trim();
        return NomeFinal;
    }

	public List<string> UltimosNomes(List<string> Nome)
    {
        List<string> Lista = new List<string> ();
        for (int i = 0; i < Nome.Count; i++)
        {
            Lista.Add(UltimoNome(Nome[i]));
        }
        return Lista;
    }

	public bool ApenasCoresPrimarias(List<string> cores)
    {
        bool a = false;
        List<string> Lista = new List<string> ();
        for (int i = 0; i < cores.Count; i++)
        {
            if (cores[i] == "Azul" || cores[i] == "Vermelho" || cores[i] == "Amarelo")
            {
               a = true;
            }
            else
            {
                a = false;
            }
        }
        return a;
    }

	 public bool SenhaForte(string senha)
    {
            bool teste = false;
            bool numero = false;
            bool caracter = false;
            bool digitos = false;
            int quantidade = 0;
            int quantidade2 = 0;

            if (senha.Length >= 8)
                digitos = true;
            else
                digitos = false;
            for (int i = 0; i < senha.Length; i++)
            {
                if (senha[i] == '0'|| senha[i] == '1' || senha[i] == '2' || senha[i] == '3' || senha[i] == '4' || senha[i] == '5' || senha[i] == '6' || senha[i] == '7' || senha[i] == '8' || senha[i] == '9')
                {
                    quantidade++;
                    numero = true;
                }    
                else if (senha[i] != '0'|| senha[i] != '1' || senha[i] != '2' || senha[i] != '3' || senha[i] != '4' || senha[i] != '5' || senha[i] != '6' || senha[i] != '7' || senha[i] != '8' || senha[i] != '9')
                {
                    numero = false;
                }
            }
                if (quantidade >= 2) 
                numero = true;
                else 
                    numero = false;

            for (int i = 0; i < senha.Length; i++)
            {
                if (senha[i] == '!'|| senha[i] == '@' || senha[i] == '#' || senha[i] == '$' || senha[i] == '%' || senha[i] == '¨' || senha[i] == '&' || senha[i] == '*' || senha[i] == '(' || senha[i] == ')')
                {
                    quantidade2++;
                } 
                else
                {
                    continue;
                }
            }

                if (quantidade2 >= 2) 
                caracter = true;
                else
                   caracter = false;
                
                if (digitos && caracter && numero)
                    teste = true;
                else
                    teste = false;

        return teste;            
    }
}

TreinoFocadoC treinoC = new TreinoFocadoC ();

string Funcao1TreinoC = treinoC.SepararLetras("Olá, tudo bem?");
Console.WriteLine(Funcao1TreinoC);


string Funcao2TreinoC = treinoC.InverterLetras("Olá, tudo bem?");
Console.WriteLine(Funcao2TreinoC);
 

bool Funcao3TreinoC = treinoC.TodasVogais("EAE");
Console.WriteLine(Funcao3TreinoC);


List<string> Nomes = new List<string> () {"Vinicius Otoni", "Sabrina Otoni"};



List<string> Funcao4TreinoC = treinoC.UltimosNomes(Nomes);
Console.WriteLine(String.Join(", ", Funcao4TreinoC));


List<string> cores = new List<string> () {"Azul", "Amarelo"};

bool Funcao5TreinoC = treinoC.ApenasCoresPrimarias (cores);
Console.WriteLine(Funcao5TreinoC);



bool Funcao6TreinoC = treinoC.SenhaForte("Eusóqueriaserfeliz");
Console.WriteLine(Funcao6TreinoC);


