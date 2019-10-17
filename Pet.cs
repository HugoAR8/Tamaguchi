using System;

class Pet{
  private string nome;
  private int fome;
  private int saude;
  private int idade;
 
  public int churrasco;
  public int raçao;
  public int raçaoComum;
  
  public int curaGrande;
  public int curaMedia;
  public int curaPequena;
  

  public bool vivo(){
    if(saude > 0){
      return true;
    }
    else{
      return false;
    }
  }
  public string getNome(){
    return nome;
  }
  public int getFome(){
    return fome;
  }
  public int getSaude(){
    return saude;
  }
  public int getIdade(){
    return idade;
  }
  public void alterarNome(string n){
    nome = n;
  }

  public void alimentar(int f){
    fome+=f;
  }

  public void curar(int c){
    saude += c;
  }

  public void setFome(int f){
    fome=f;
  }

  public void setSaude(int s){
    saude = s;
  }
  public void setIdade(int i){
    idade= i;
  }

  public void envelhecer(){
    idade++;
  }

  public int getHumor(){
    int humor = (saude+fome)/2;
    return humor;
  }

  public void faminto(){
    if(fome > 0){
      fome-=1;
    }
  }
  public void adoecido(){
    saude-=3;
  }


}