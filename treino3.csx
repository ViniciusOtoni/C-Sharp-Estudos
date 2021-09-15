using System;



public string RetangulosIguais (double b1, double a1, double b2, double a2 )
{
	return b1 * a1 == b2 * a2
	? "os retangulos são iguais"
    : "os retangulos não são iguais";
}

public string RetangulosIguais2 (double b1, double a1, double b2, double a2 )
{
	if  (AreaRetangulo(a1,b1) == AreaRetangulo(a2,b2))
	{
	return "Os Retangulos são iguais";
	}

	else if (AreaRetangulo(a1,b1) != AreaRetangulo(a2,b2))
	{
	return "Os Triangulos são diferentes";
	}

	else
	{
	return "O segundo Retangulo é maior que o primeiro";
	}
}

public double AreaRetangulo(double a1, double b1)
{
	return a1 * b1;
}


public class Retangulo
{
	public double altura {get;set;}
	public double basee {get;set;}
}


public string RetangulosIguais3 (Retangulo ret1, Retangulo ret2, Retangulo ret3)

{
 
  if (AreaRetangulo(ret1.altura, ret1.basee) == AreaRetangulo (ret2.altura, ret2.basee) && AreaRetangulo(ret3.altura, ret3.basee) ==
	AreaRetangulo(ret1.altura, ret1.basee))
 
	{
		return " Os Retangulos são iguais";
  	}

	else if (AreaRetangulo(ret1.altura, ret1.basee) > AreaRetangulo(ret2.altura, ret2.basee) && AreaRetangulo(ret3.altura, ret3.basee)
	< AreaRetangulo(ret1.altura, ret1.basee))
		{
		return "O primeiro retangulo é maior que o primeiro";
		}

	else if (AreaRetangulo(ret1.altura, ret1.basee) < AreaRetangulo(ret2.altura, ret2.basee) && AreaRetangulo(ret2.altura, ret2.basee)
> AreaRetangulo(ret3.altura, ret3.basee))
		{
		return "O segundo Retangulo é maior que o primeiro";
		}

	else
		{
		return "O terceiro Retangulo é maior";
		}

}






public class Ingresso
{
	public bool Meia {get; set;}
	public double Preco {get; set;}
	public string Filme {get; set;}
}


public class Cinemark
{
	public double CalcularTotal(Ingresso a)
	{
		if(a.Meia == true)
		{	
			return a.Preco/2;
		}

		else
		{
			return a.Preco;
		}
}

public string CalcularTotal1(Ingresso a)
{

	if (a.Meia == true)
	{
		return "Compra concluida! o ingresso para o filme" + a.Filme + "é de:" + a.Preco/2;
	}
	else
	{
	return "Compra concluida! o ingresso para o filme" + a.Filme + "é de:" + a.Preco;
	}
}

	
public double CalcularTotal3 (Ingresso ing1, Ingresso ing2)
{
	if (ing1.Meia == true)
	{
		return (ing1.Preco/2) + ing2.Preco ;
	}
	else if (ing2.Meia == true)
	{
		return (ing2.Preco/2) + ing1.Preco;
	}
	 else if (ing1.Meia == true && ing2.Meia)
	{
		return (ing1.Preco/2) + (ing2.Preco/2);
	}
	else  
	{
		return (ing1.Preco) + (ing2.Preco);
	}
}
}

public class Ingressos
{
	public bool Meia {get; set;}
	public double Preco {get; set;}
	public string Filme {get; set;}
	public int 	QtdIngressos {get; set;}
	public string Genero {get; set;}
}



public class Cinemark1 
{
public double 	CalcularTotal1(Ingressos ing)
	{
	if (ing.Meia == true)
		{
			return ing.Preco/2;
		}
	else 
		{
			return ing.Preco;
		}
	}
public string CalcularTotal2(Ingressos ing)
	{
	if (ing.Meia == true)
		{
			return "Compra Concluida! A compra de: " + ing.QtdIngressos + " Ingressos " + "meia" + " para o filme " + ing.Filme +
			" é de " + ing.Preco/2 + "$";
		}
	else 
	{
		return "Compra Concluida! A compra de: " + ing.QtdIngressos + " Ingressos " + "inteira" + " para o filme " + ing.Filme +
			" é de " + ing.Preco + "$" ;
	}
	}
}
public class Cinemark2
{
	public double CalcularTotal(Ingressos ing, double Cupom)
	{
	if (ing.Meia ==  true)	
		{
			return (ing.Preco/2) * ing.QtdIngressos - AplicarIngresso((ing.Preco/2) * ing.QtdIngressos, Cupom);
		}
	else
		{
			return (ing.Preco) * ing.QtdIngressos - AplicarIngresso(ing.Preco * ing.QtdIngressos, Cupom);
		}
}
private double AplicarIngresso (double total, double Cupom)
	{	
		return  (Cupom/100) * total ;
	}
}

public class Cinemark3
{
	public double CalcularTotal(Ingressos ing, double Cupom)
	{
	
	double conta = ing.Preco * ing.QtdIngressos;
	double x = 0;
		
	if (ing.Meia ==  true)	
		{
			 x = conta/2;
		
		}
	else {
	 x = conta;
	}
		double continha = conta - AplicarIngresso(conta, Cupom);
	if (continha > 100)
	{
		return x = continha - AplicarIngresso(ing.Preco * ing.QtdIngressos,10);	
	}
	
	else
	{
		 x = continha;
	}
return x;
}
private double AplicarIngresso (double total, double Cupom)
	{	
		return  (Cupom/100) * total ;
	}
}

public class Cinemark4
{
    private double AplicarIngresso (double total, double Cupom)
    {
        return  total - ((total * Cupom) /100);
    }
    public double CalcularTotal(Ingressos ing, double Cupom)
    {
        double conta = ing.Preco * ing.QtdIngressos;
        double x = 0;
        double quartafeira = 0;

        if (ing.Meia == true)
        {
            x = conta /2;
        }
        else
        {
            x = conta;
        }

        double continha = AplicarIngresso(x, Cupom);

        if (new DateTime(2021,05,19).DayOfWeek == DayOfWeek.Wednesday)
        {
            quartafeira = AplicarIngresso(continha, 50);

            if (quartafeira >= 100)
            {
                x = AplicarIngresso(quartafeira, 10);
            }
            else
            {
                x = continha;
            }
        }
        else
        {
            quartafeira = continha;
        }

        return quartafeira;
    }
}

public class Cinemark5
{
    private double AplicarIngresso (double total, double Cupom)
    {
        return  total - ((total * Cupom) /100);
    }
    public double CalcularTotal(Ingressos ing, double Cupom)
    {
        double conta = ing.Preco * ing.QtdIngressos;
        double x = 0;
        double quartafeira = 0;
 	 if (ing.Genero == "Nacional")
  	{
  	x = ing.QtdIngressos = 5;
	}
 	
	else {
	  
	if (ing.Meia == true)
        {
            x = conta /2;
        }
        else
        {
            x = conta;
        }

        double continha = AplicarIngresso(x, Cupom);

        if (new DateTime(2021,05,19).DayOfWeek == DayOfWeek.Wednesday)
        {
            quartafeira = AplicarIngresso(continha, 50);

            if (quartafeira >= 100)
            {
                x = AplicarIngresso(quartafeira, 10);
            }
            else
            {
                x = continha;
            }
        }
        else
        {
            quartafeira = continha;
        }
	 
	 }
	return x;
 }
}

	

	









Ingressos valores2 = new Ingressos();
valores2.Meia = false;
valores2.Filme = "Vingadores";
valores2.QtdIngressos = 10;
valores2.Preco = 20;

Cinemark4 vl = new Cinemark4();

double x = vl.CalcularTotal(valores2, 10);
Console.WriteLine(x);


Cinemark5 vl1 = new Cinemark5();
double finalll = vl1.CalcularTotal(valores20,5);
Console.WriteLine(finalll);



Retangulo ret = new Retangulo();
ret.altura = 2;
ret.basee = 4;

Retangulo ret2 = new Retangulo();
ret2.altura = 2;
ret2.basee = 4;

Retangulo ret3 = new Retangulo();
ret3.altura = 0;
ret3.basee = 4;

Ingresso valores = new Ingresso();
valores.Filme = "Vingadores";
valores.Meia = false;
valores.Preco = 40;

Cinemark valores1 = new Cinemark();
double u = valores1.CalcularTotal(valores);
Console.WriteLine(u);

Ingressos valores20 = new Ingressos();
valores20.Meia = false;
valores20.Filme = "Vingadores";
valores20.QtdIngressos = 2;
valores20.Preco = 100;
valores20.Genero= "Nacional";

Cinemark1  valores3 = new Cinemark1();
string final1 = valores3.CalcularTotal2(valores20);
Console.WriteLine(final1);

Cinemark2 valores4 =  new Cinemark2();
double qq = valores4.CalcularTotal(valores20, 5);
Console.WriteLine(qq);

Cinemark3 valores5 = new Cinemark3();
double qq1 = valores5.CalcularTotal(valores20,5);
Console.WriteLine(qq1);








					
public class Jogador
{
	public string Nome;
	public bool Par;
	public int Numero;
}

public string ParOuImpar (Jogador j1, Jogador j2)
{
	int soma = j1.Numero + j2.Numero;
	string vencedor = "";
	if (soma % 2 == 0 && j1.Par == true)
	{
		vencedor = $"Deu Par! O Jogador{j1.Nome} venceu!";
	}
	else if (soma % 2 ==1 && j1.Par == false)
	{
		vencedor = $"Deu Impar! O Jogador{j1.Nome} Venceu!";
	}
	else if (soma % 2 == 0 && j2.Par == true)
	{
		vencedor = $"Deu Par! O Jogador {j2.Nome} Venceu!";
	}

	else if (soma % 2 == 1 && j2.Par == false)
	{
		vencedor = $"Deu Impar! O Jogador {j2.Nome} Venceu!";
	}
	return vencedor;
}


Jogador j1 = new Jogador();
j1.Nome = "Vinícius";
j1.Numero = 2;
j1.Par  = true;

Jogador j2 = new Jogador();
j2.Numero = 1;
j2.Nome = "Bruno";
j2.Par = false;





					
public class Jogadas 
{
	public string 	Nome;
	public string Jogada;
}


public string JokemPo (Jogadas j1, Jogadas j2)
{
	string venceu = "";
	
	if (j1.Jogada == "Tesoura" && j2.Jogada == "Papel")
	{
		venceu = $"Parabens! {j1.Nome} você Venceu!";
	}
	else if (j1.Jogada == "Pedra" && j2.Jogada == "Tesoura")
	{
		venceu = $"Parabens! {j1.Nome} você Venceu!";
	}
	else if (j1.Jogada == "Papel" && j2.Jogada == "Pedra")
	{
		venceu = $"Parabens! {j1.Nome} você Venceu!";
	}
	
	if (j2.Jogada == "Tesoura" && j1.Jogada == "Papel")
	{
		venceu = $"Parabens! {j2.Nome} você Venceu!";
	}
	else if (j2.Jogada == "Pedra" && j1.Jogada == "Tesoura")
	{
		venceu = $"Parabens! {j2.Nome} você Venceu!";
	}
	else if (j2.Jogada == "Papel" && j1.Jogada == "Pedra")
	{
		venceu = $"Parabens! {j2.Nome} você Venceu!";
	}
	else if (j1.Jogada == "Tesoura" && j2.Jogada == "Tesoura" || j1.Jogada == "Pedra" && j2.Jogada == "Pedra" 
			 || j1.Jogada == "Papel" && j2.Jogada == "Papel")
	{
		venceu = $"Nenhum Jogador Ganhou!";
	}
	return venceu;
}



