namespace Orientação_obj___02_12
{
    public class Aluno
    {
        public string nome;
        public int idade;
        public string curso;
        public string rg;
        public bool  bolsista;
        public float mediaFinal;
        public float valorMensalidade;

        public float VerMediaAluno(){
            return this.mediaFinal;
        }
        float valor;
        public float VerMensalidade(){
        
        if(this.bolsista == true && this.mediaFinal >=8){
            valor = this.valorMensalidade * 0.5f; //50% da mensalidade 

        }else{
            valor = this.valorMensalidade;
        }
        
        return valor;
        
        }
        
    }
}