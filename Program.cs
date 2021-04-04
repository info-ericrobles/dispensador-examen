#region Inicio
using System;
namespace parcial
{
class producto
{
#endregion
#region menu

private string[] nombre = new string[5] 

{
"0- Takis $100", 
"1- Refresco Uva de Fanta $40", 
"2- Galleticas Dino $15", 
"3- Agua Dasani $25", 
"4- Galletas Chokis $45"
};
#endregion
#region arrays
private int[] productos = new int[5] {10, 13, 15, 20, 14};
private int[] precio = new int[5] {100, 40, 15, 25, 45};
#endregion
#region Imprimir_Resultado
public void imprimir ()
{
Console.Clear();
Console.WriteLine("Elija un producto"); 
Console.WriteLine("0. Takis $100"); 
Console.WriteLine("1. Refresco Uva de Fanta $40"); 
Console.WriteLine("2. Galleticas Dino $15"); 
Console.WriteLine("3. Agua Dasani $25"); 
Console.WriteLine("4. Galletas Chokis $45"); 
int a = int.Parse(Console.ReadLine());
productos[a]-=1; 
Console.Clear();
if (a==0 | a==1 |  a==2 |  a==3 |  a==4 |  a==5 |  a==6 |  a==7)
{
int x=1, b, ci=0, d=0, vc=0, c=0, cie=0, sobrante;
Console.WriteLine("Deposite {0} pesos",precio[a]);
Console.WriteLine("Ingrese una Moneda (5), (10), (25)");
Console.WriteLine("Ingrese un Billete (50), (100), (200)");
b = int.Parse(Console.ReadLine());
x=precio[a]-b;
do
{
if (b==5 | b==10 |  b==25 |  b==50 |  b==100 |  b==200)
{
if (x<0)
{
x*=-1;
cie=x/100;   
if (cie>0)
{
Console.WriteLine("Retire {0} billetes de cie",cie);
x%=100;
}
if (x>0)
{
c=x/50;
if (c>0)
{
Console.WriteLine("Retire {0} billetes de cincuenta",c);
x%=50;
}
}
if (x>0)
{
vc=x/25;
if (vc>0)
{
Console.WriteLine("Retire {0} monedas de veinte y cinco",vc);
x%=25;
}
}
if (x>0)
{
d=x/10;
if (d>0)
{
Console.WriteLine("Retire {0} monedas de d",d);
x%=10;
}
}
if (x>0)
{
ci=x/5;
if (ci>0)
{
Console.WriteLine("Retire {0} monedas de cinco",ci);
x%=5;
}
}
sobrante=
    (
    cie*100+ /* CIENPESO */
    c*50+    /* CINCUENTA */
    vc*25+   /* VENTICINCO */
    d*10+    /* DIEZPESO */
    ci*5     /* CINCO_PESO */  
    );

Console.WriteLine("Para un total de {0} pesos",sobrante);
Console.WriteLine("Disfrute su {0}",nombre[a]);
}
else
{
if (x==0)
{
Console.Clear();
Console.WriteLine("Disfrute su {0}",nombre[a]);
}
else
{
Console.WriteLine("Deposite {0} pesos",x);
Console.WriteLine("Ingrese una Moneda (5), (10), (25)");
Console.WriteLine("Ingrese un Billete (50), (100), (200)");
b = int.Parse(Console.ReadLine());
x-=b;
if (x==0)
{
Console.Clear();
Console.WriteLine("Disfrute su {0}",nombre[a]);
}
}
}
}
else
{
Console.WriteLine("Deposite una cantidad válida");
}      
Console.ReadLine();
}while(x!=0);
}
}
#endregion
#region Segunda_Parte
static void Main(string[] args)
{
int opcion = 0,i;
int[] productos = new int[5] {10, 13, 15, 20, 14};
string[] nombre = new string[5] 
{
"0. Takis $100", 
"1. Refresco Uva de Fanta $40", 
"2. Galleticas Dino $15", 
"3. Agua Dasani $25", 
"4. Galletas Chokis $45"
};
do
{
Console.Clear();
Console.WriteLine

("Opciones\n" +
"1.-Menu_Dispensadora\n" +
"2.-Reporte_Venta\n" +
"3.-Salir"
);

opcion = int.Parse(Console.ReadLine());
switch (opcion)
{
case 1:
producto prod = new producto();
prod.imprimir();
 
break;
case 2:
Console.Clear();
for(i=0; i<8; i++)
{
Console.WriteLine("Quedan {0} productos de {1}",productos[i], nombre[i]);                       
}
 
break;
case 3:
break;
}
}while(opcion!=3);
 
}
}  
}
#endregion