using System;
using System.Threading;

class MainClass {
  public static void Main (string[] args) {
    int cont = 0;
    string tipoDeAlimento ="";
    string tipoDeCura = "";
    bool darChocolate = false;
    bool digitouErrado = true;
    Random rand = new Random();
    Pet pet = new Pet();
    Console.WriteLine("Digite o nome do seu pet!");
    pet.alterarNome(Console.ReadLine());
    pet.setIdade(rand.Next(6));
    pet.setFome(rand.Next(20-2)+2);
    pet.setSaude(rand.Next(50));
    Console.WriteLine("Nome do pet: {0} \nIdade do pet: {1}\nFome : {2}\nSaude: {3}\n Humor: {4}",pet.getNome(),pet.getIdade(),pet.getFome(),pet.getSaude(),pet.getHumor());
    
    while(pet.vivo() == true){
      Thread.Sleep(6);
      cont++;
      if(cont == rand.Next(1200-500)+500){
        Console.WriteLine("Deseja brincar com seu pet?");
        int random = rand.Next(1200);
        if(random >=0 && random <= 300){
          pet.curaPequena ++;
          Console.WriteLine("Uau o(a) {0} achou uma cura pequena!!",pet.getNome());
        }else if(random > 300 && random <600){
          pet.raçaoComum ++;
          Console.WriteLine("Uau o(a) {0} achou uma raçao comum!!",pet.getNome());
        }else if(random > 600 && random <= 800){
          pet.raçao++;
          Console.WriteLine("Uau o(a) {0} achou uma raçao !!",pet.getNome());
        }else if(random > 800 && random <= 1000){
          pet.curaMedia++;
          Console.WriteLine("Uau o(a) {0} achou uma cura media!!",pet.getNome());

        }else if(random > 1000 && random <= 1100){
          pet.curaGrande++;
          Console.WriteLine("Uau o(a) {0} achou uma cura grande!!",pet.getNome());
        }else if(random > 1100 && random <= 1200){
          pet.churrasco++;
          Console.WriteLine("Uau o(a) {0} achou uma churrasco !!",pet.getNome());
        }
      }
      if(cont == 200 || cont == 400 || cont == 600 || cont == 800 || cont == 1000 || cont == 1200){
        Console.Clear();
        pet.faminto();
        Console.WriteLine("Nome do pet: {0} \nIdade do pet: {1}\nFome : {2}\nSaude: {3}\n Humor: {4}",pet.getNome(),pet.getIdade(),pet.getFome(),pet.getSaude(),pet.getHumor());
        if(darChocolate == true){
          Console.WriteLine("Irmão não dá chocolate pra cachorro não >:( é venenoso!!");
        }
      }
      if(cont == rand.Next(1000-200)+200 && pet.getFome() < 20){
        digitouErrado = true;
        Console.WriteLine("Seu pet está com fome ! Qual alimento deseja dar a ele ? Basta escrever 'churrasco'(50 de fome),'raçao'(25 de fome) ou 'raçaoComum'(10 de fome) para alimenta-lo (digite 'nao' para não alimentar o seu pet!) ");
        tipoDeAlimento = Console.ReadLine();
        while(digitouErrado == true){
          if(tipoDeAlimento == "churrasco"){
            tipoDeAlimento = "";
            pet.alimentar(50);
            digitouErrado = false;
          }else if(tipoDeAlimento == "raçao"){
            tipoDeAlimento = "";
            pet.alimentar(25);
            digitouErrado = false;
          }else if(tipoDeAlimento == "raçaoComum"){
            tipoDeAlimento = "";
            pet.alimentar(10);
            digitouErrado = false;
          }else if(tipoDeAlimento == "chocolate"){
            darChocolate = true;
            digitouErrado = false;
          }else if(tipoDeAlimento == "nao"){
            tipoDeAlimento = "";
            digitouErrado = false;
          }else{
            tipoDeAlimento = "";
            Console.WriteLine("Digitou errado, tente novamente!");
            tipoDeAlimento = Console.ReadLine();digitouErrado = true;
          }
        }

      }
      if(cont == rand.Next(1200-400)+400 && pet.getSaude() < 25){
        Console.WriteLine("Deseja curar seu pet ? Basta escrever 'curaGrande'(50 de vida), 'curaMedia(25 de vida) ou 'curaPequena'(10 de vida) e clicar em confirmar(digite 'nao' para não curar seu pet");
        tipoDeCura = Console.ReadLine();
        if(tipoDeCura == "curaGrande"){
          tipoDeCura = "";
          pet.curar(50);
        }else if(tipoDeCura == "curaMedia"){
          tipoDeCura = "";
          pet.curar(25);
        }else if(tipoDeCura == "curaPequena"){
          tipoDeCura = "";
          pet.curar(10);
        }else if(tipoDeCura == "nao"){
          tipoDeCura = "";
        }else{
          tipoDeCura = "";
          Console.WriteLine("Digitou errado, tente novamente!");
          tipoDeCura = Console.ReadLine();
        }
      }
      if(pet.getFome() <= 0){
        if(cont == 200 || cont == 400 || cont == 600 || cont == 800 || cont == 1000 || cont == 1200){
          pet.adoecido();
        }
      }
      if(cont == 1200){
        cont = 0;
        pet.envelhecer();
      }
      
              
    }
    string espaço = "                       ";
    int contAnim = 0;
    while(pet.vivo() == false){
      Thread.Sleep(3);
      contAnim++;
      if(contAnim == 100){
        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n{0}<(‘o'<)",espaço);
        Console.WriteLine("    {0}      V",espaço);
      }else if(contAnim == 200){
        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n{0}^( ‘-‘ )^",espaço);
        Console.WriteLine("     {0}   Vo",espaço);
      }else if(contAnim == 300){
        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n{0}(>‘o’)>",espaço);
        Console.WriteLine("     {0}  Voc",espaço);
      }else if(contAnim == 400){
        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n{0}v( ‘.’ )v",espaço);
        Console.WriteLine("    {0}  Você",espaço);
      }else if(contAnim == 500){
        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n{0}<(‘ .’ )>",espaço);
        Console.WriteLine("    {0} Você p",espaço);
      }else if(contAnim == 600){
        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n{0}<(‘.'<)",espaço);
        Console.WriteLine("    {0}Você pe",espaço);
      }else if(contAnim == 700){
        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n{0}^( ‘.’ )^",espaço);
        Console.WriteLine("   {0}Você per",espaço);
      }else if(contAnim == 800){
        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n{0}(>‘.’)>",espaço);
        Console.WriteLine("  {0}Você perd",espaço);
      }else if(contAnim == 900){
        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n{0}v( ‘.’ )v",espaço);
        Console.WriteLine(" {0}Você perde",espaço);
      }else if(contAnim == 1000){
        Console.Clear();
        Console.WriteLine("\n\n\n\n\n\n\n\n\n\n{0}<(‘ .’ )>",espaço);
        Console.WriteLine("{0}Você perdeu",espaço);
        contAnim = 0;
      }
    }
  }
}