using System;
using System.Collections.Generic;

class Aula57{
  static void Main(){

  List<string> transp = new List<string>(); 

  transp.Add("Carro");
  transp.Add("Avião");
  transp.Add("Navio");
  transp.Add("Motocicleta");

  //if(transp.Find("Carro")==null){
  //  Console.WriteLine("Não encontrado");
  //}else{
  //  Console.WriteLine("Elemento encontrado\n");
  //}

  foreach(string t in transp){
    Console.WriteLine("Transporte......: {0}",t);
  } 
    
  }
}