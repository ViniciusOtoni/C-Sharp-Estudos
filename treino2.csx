using System;
					
public class Calculo 
{
	public double valor1;
	public double valor2;
	public string Operacao; 
}

public class Triangulo
{
	public	double LadoA;
	public double LadoB;
	public double Lado3;
}

public class Pessoa 
{
	public string Nome;
	public double Altura;
	public double Peso;
}


public class Notas 
{
	public double Nota1;
	public double Nota2;
	public double Nota3;
}
public class TreinoFocadoA
{

	public double  Calculadora (Calculo a)

	{
		double conta = 0;
	
		if (a.Operacao == "Soma")
	{
		conta = a.valor1 + a.valor2;
	}
	else if (a.Operacao == "Subtração")
	{
		conta = a.valor1 - a.valor2;
	}
	else if (a.Operacao == "Multiplicação")
	{
		conta = a.valor1 * a.valor2;
	}
	else if (a.Operacao == "Divisão")
	{
		conta =  a.valor1/ a.valor2;
	}
	return conta;
	}

	public string Termometro (double grau)
	{
	string temperatura = ""; 
	if (grau >=  36 && grau <= 37.2)
	{
		temperatura = $"Você está com a temperatura normal";
	}
	else if (grau >= 37.3 && grau <= 38)
	{
		temperatura = $"Você está com pouca febre";
	}
	else if (grau >= 38.1)
	{
		temperatura = $"Você está com febre alta!";
	}
	else if (grau <= 35.9)
	{
		temperatura = $"Você está com Hipotermia!";
	}
	
	return temperatura;
	}
	
	public string LucroOuPrejuizo (double Gastos, double Lucro)
	{
	string dinheiro = "";
	double conta = Lucro - Gastos;
	
		if (Gastos > Lucro)
		{
			dinheiro = $"Poxa você ficou {conta} Negativo ): ";
		}
		else if (Lucro > Gastos)
		{
			dinheiro = $"Ebaaaa você ficou {conta} Positivo!!! (: ";
		}
	
		else if (Lucro == Gastos)
		{
			dinheiro = $"Você ficou sem ganhos e sem gastos no final do mês!";
		}
		return dinheiro;
	}

	public double ArredondarMeioEmMeio (double nota)
	{
	double continha = Math.Floor(nota) - nota;
	double continhaa = Math.Abs(continha);

	double valor = 0;
	
	if (continhaa >= 0.00 && continhaa <= 0.25)
	{
		valor = 0;
	}
	else if (continhaa >= 0.26 && continhaa <= 0.74)
	{
		valor = 0.5;
	}
	else if (continhaa >= 0.75 && continhaa <= 0.99)
	{
		valor = Math.Ceiling(continhaa);
	}
	return valor;
	}
	
	public string PassouDeAno (Notas notinha)
	{
		string resu = "";
		double conta = (notinha.Nota1 + notinha.Nota2 + notinha.Nota3) /3;
		if (conta >= 5)
		{
			resu = $"Você Passou de Ano! Parabéns! (: ";
		}
		else if (conta <= 4.9)
		{
			resu = $"Você não Passou de ano! ): ";
		}
		return resu;
	}

 	public string PassouDeAno1 (Notas notinha, int faltas)
	{
		string resu = "";
		double conta = (notinha.Nota1 + notinha.Nota2 + notinha.Nota3) /3;
		if (conta >= 5 && faltas <= 25)
		{
			resu = $"Você Passou de Ano! Parabéns! (: ";
		}
		else if (conta <= 4.9 && faltas <= 25)
		{
			resu = $"Você está de Recuperação por causa de sua nota! ): ";
		}
		else if (conta >= 5 && faltas >= 25)
		{
			resu = $"Você está de Recuperação por causa da suas faltas! ai ai em mininu!";
		}
		else if (conta <= 4.9 && faltas >= 25)	
		{
			resu = $"Você está de recuperação pelos dois critérios!! vamo estudar mininu!!";
		} 
		return resu;
	}
	
	public string TipoTriangulo (Triangulo a)
	{
		string frase = " ";
		if (a.LadoA != a.LadoB && a.LadoA != a.Lado3 && a.LadoB != a.Lado3)
		{
			frase = $"O triangulo é Escaleno!";
		}
		else if (a.LadoA == a.LadoB && a.LadoA != a.Lado3 && a.LadoB != a.Lado3 || 
			 a.LadoB == a.Lado3 && a.LadoA != a.Lado3 && a.LadoB != a.LadoA ||
			 a.Lado3 == a.LadoA && a.LadoA != a.LadoB && a.Lado3 != a.LadoB)
		{
			frase = $"O triangulo é Isóceles!";
		}
		else if (a.LadoA == a.LadoB && a.LadoA == a.Lado3 && a.LadoB == a.Lado3)
		{
			frase = $"O triangulo é Equilátero!";
		}
		return frase;

	}

	public string IMC(Pessoa a)
	{
		string frase = "";
		double conta = a.Peso/(a.Altura * a.Altura);
		
		if (conta < 18.5)
		{
			frase = $"{a.Nome} você está Abaixo do Peso!";
		}
		else if (conta >= 18.5 && conta <= 24.9)
		{
			frase = $"{a.Nome} você está com o Peso Normal!";
		}
		else if(conta >= 25.00 && conta <= 29.99)
		{
			frase = $"{a.Nome} você está com Sobrepeso!";
		}
		return frase;
	}
}

public class PecaDominio 
{
	public double LadoA;
	public double LadoB;
}

public class Semafaro 
{
	public bool LuzVermelhaAcesa;
	public bool LuzAmarelaAcesa;
	public bool LuzVerdeAcesa;
}

public class Recuperacao 
{
	public string Email;
	public string Telefone;
}

public class TreinoFocadoB
{
	public bool CorPrimaria (string cor)
		{		
		if (cor == "Azul" || cor == "Vermelho" || cor == "Amarelo")
		{
		return true;
		}
		else 
		{
		return false;
		}
	}

	public string CombinacaoCorPrimaria(string cor1, string cor2)
	{
		string resu = "";
		if (cor1 == "Azul" && cor2 == "Amarelo" ||
	    cor1 == "Amarelo" && cor2 == "Azul")
		{
			resu = $"A cor é Verde";
		}
		else if (cor1 == "Vermelho" && cor2 == "Azul" ||
			 cor1 == "Azul" && cor2 == "Vermelho")
		{
			resu = $"A cor é Roxa";
		}
		else if (cor1 == "Amarelo" && cor2 == "Vermelho" ||
			 cor1 == "Vermelho" && cor2 == "Amarelo")
		{
			resu = $"A cor é Laranja";
		}
		else
		{
			resu = $"A cor não é Primária Mongol!";
		}
	
		return resu;
	}

	public string PrimeiroNome (string nome)
	{
	
		if (nome.Contains(" "))
		{
			return nome.Substring(0, nome.IndexOf(" "));
		}
	
		else  
		{
			return nome;
		}
		
	}

	public bool DobreDominio (PecaDominio a)
	{
		if(a.LadoA == a.LadoB)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	public bool JogadaValida (PecaDominio peca1, PecaDominio peca2)
	{
		if(peca1.LadoA == peca2.LadoA ||
	   	peca1.LadoB == peca2.LadoB ||
       	peca1.LadoA == peca2.LadoB ||
       peca1.LadoB == peca2.LadoA)
		{
			return true;
		}
		else 
		{
			return false;
		}
	}

	public string RecuperacaoSenha (Recuperacao a)
	{
		if (a.Email.Contains("@"))
		{
		string corte = a.Email.Substring(a.Email.LastIndexOf("@"));
		string corte1 = corte.Substring(0,corte.IndexOf("."));
		string Corte2 = corte1.Replace("@","");
		string CorteNu = a.Telefone.Substring(5,a.Telefone.LastIndexOf("-"));
		return  $"Você receberá um Email de {Corte2} para resgatar a senha. Um código também foi enviado para o número {CorteNu}";
		}
		else 
		{
			return $"Algo deu errado não?";
		}
	}
}

public class Pessoa1 
{
	public string Nome;
	public DateTime Nascimento;
	public string Cidade;
}

public class TreinoFocadoC

{
	public int Trimestre(DateTime Data)
	{
	
		if (Data.Month == 1 || Data.Month == 2 || Data.Month == 3)
		{
			return 1;
		}
		else if (Data.Month == 4 || Data.Month == 5 || Data.Month == 6)
		{
			return 2;
		}
	
		else if (Data.Month == 7 || Data.Month == 8 || Data.Month == 9)
		{
			return 3;
		}
		else 
		{
			return 4;
		}
	}
	public string Mes(int mes)
	{
		if (mes == 1)
        {
            return "Janeiro";
        }
        else if (mes == 2)
        {
            return "Fevereiro";
        }
        else if (mes == 3)
        {
            return "Março";
        }
        else if (mes == 4)
        {
            return "Abril";
        }
        else if (mes == 5)
        {
            return "Maio";
        }
        else if (mes == 6)
        {
            return "Junho";
        }
        else if (mes == 7)
        {
            return "Julho";
        }
        else if (mes == 8)
        {
            return "Agosto";
        }
        else if (mes == 9)
        {
            return "Setembro";
        }
        else if (mes == 10)
        {
            return "Outubro";
        }
        else if (mes == 11)
        {
            return "Novembro";
        }
        else if (mes == 12) 
        {
            return "Dezembro";
        }
        else
        {
            return "Erro";
        }
	}
	public string PeriodoDoDia(DateTime Data)
	{
	
		if(Data.Hour >= 5 && Data.Hour <= 12)
		{
			return "Manhã";
		}
		else if (Data.Hour >= 12 && Data.Hour <= 18)
		{
			return "Tarde";
		}
		else if (Data.Hour >= 19 && Data.Hour <= 24)
		{
			return "Noite";
		}
		else
		{
			return "Madrugada";
		}
	}
	
	public double DiasVida(DateTime nascimento)
	{
		TimeSpan x = DateTime.Now - nascimento; 
		double DiasDeVida = x.TotalDays;
		double arredondar = Math.Truncate(DiasDeVida);
		return arredondar;
	}

	public string QualSigno(DateTime nascimento)
    {
        string Signo = string.Empty;
	
	    if (nascimento.Day >= 21 && nascimento.Month      == 1   || nascimento.Day <= 18 && nascimento.Month == 2)
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



	public string DataPorExtenso (Pessoa1 info)
    	{
        	double diastotais = DiasVida(info.Nascimento);
        	string Periodo = PeriodoDoDia(info.Nascimento);
        	string mes = Mes(info.Nascimento.Month);
        	int trimestre = Trimestre(info.Nascimento);
        	string signo = QualSigno(info.Nascimento);
        
        	return $"{info.Nome} você nasceu a {diastotais} dias no {Periodo} do dia {info.Nascimento.Day} de {mes} ({trimestre}° trimestre) de {info.Nascimento.Year}. Seu sígno é {signo}";
    	}
}


Calculo valores = new Calculo();
valores.valor1 = 2;
valores.valor2 = 7;
valores.Operacao = "Soma";


Notas valores1 = new Notas();
valores1.Nota1 = 10;
valores1.Nota2 = 10;
valores1.Nota3 = 10;


Pessoa valores2 = new Pessoa();
valores2.Altura = 1.70;
valores2.Nome = "Vinícius";
valores2.Peso = 58.00;

Triangulo valores3 = new Triangulo();
valores3.LadoA = 20.00;
valores3.LadoB = 20.01;
valores3.Lado3 = 21.00;

PecaDominio valores4 = new PecaDominio();
valores4.LadoA = 6;
valores4.LadoB = 6;

PecaDominio peca1 = new PecaDominio();
peca1.LadoA = 4;
peca1.LadoB = 1;

PecaDominio peca2 = new PecaDominio();
peca2.LadoA = 6;
peca2.LadoB = 2;

Semafaro valores5 = new Semafaro();
valores5.LuzAmarelaAcesa = true;
valores5.LuzVerdeAcesa = false;
valores5.LuzVermelhaAcesa = false;

TreinoFocadoA a = new TreinoFocadoA();

double final111 = a.Calculadora(valores);
Console.WriteLine(final111);

double final = a.ArredondarMeioEmMeio(0.28);
Console.WriteLine(final);

Recuperacao recu = new Recuperacao();
recu.Email = "Viniciusotonimsv@Outulook.com.br";
recu.Telefone = "5939-6202";




string final1 = a.Termometro(36);
Console.WriteLine(final1);

string final2 = a.LucroOuPrejuizo(40, 40);
Console.WriteLine(final2);

string final3 = a.PassouDeAno(valores1);
Console.WriteLine(final3);

string final4 = a.PassouDeAno1(valores1, 27);
Console.WriteLine(final4);

string final5 = a.IMC(valores2);
Console.WriteLine(final5);

string final6 = a.TipoTriangulo(valores3);
Console.WriteLine(final6);

TreinoFocadoB b = new TreinoFocadoB();

bool final7 = b.CorPrimaria("Azul");
Console.WriteLine(final7);

string final8 = b.CombinacaoCorPrimaria("Azul","Vermelhoo");
Console.WriteLine(final8);

string final9 = b.PrimeiroNome("Vinicius");
Console.WriteLine(final9);

bool final10 = b.DobreDominio(valores4);
Console.WriteLine(final10);

bool final11 = b.JogadaValida(peca1, peca2);
Console.WriteLine(final11);

string final12 = b.RecuperacaoSenha(recu);
Console.WriteLine(final12);


TreinoFocadoC c = new TreinoFocadoC();

DateTime Dataa = new DateTime(2021,12,10);
int final13 = c.Trimestre(Dataa);
Console.WriteLine(final13);

string final14 = c.Mes(12);
Console.WriteLine(final14);




string final15 = c.PeriodoDoDia(DateTime.Now);
Console.WriteLine(final15);


DateTime qq = new DateTime(2005,02,04);

double final16 = c.DiasVida(qq);
Console.WriteLine($"Tempo de vida  {final16}");

DateTime Q1 = new DateTime(2005,02,04);

string final17 = c.QualSigno(Q1);
Console.WriteLine($"O Seu Signo é {final17}");

Pessoa1 aaaa = new Pessoa1();
aaaa.Cidade = "São Paulo";
aaaa.Nome = "Vinícius Otoni Da Silva";
aaaa.Nascimento = new DateTime(2005,12,18);

string final18 = c.DataPorExtenso(aaaa);
Console.WriteLine(final18);