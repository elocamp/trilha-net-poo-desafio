using DesafioPOO.Models;

System.Console.WriteLine("Smartphone: Nokia");
Smartphone nokia = new Nokia("+55(81)99999-9999", "G60 5G", "XXXXXXXXXX", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Pinterest", 8);

nokia.InstalarAplicativo("Teste", 900);

System.Console.WriteLine("====================================================");

System.Console.WriteLine("Smartphone: iPhone");
Smartphone iPhone = new Iphone("+55(83)11111-1111", "13 PRO MAX", "XXXXXXXXXX", 248);
iPhone.Ligar();
iPhone.InstalarAplicativo("Instagram", 20);