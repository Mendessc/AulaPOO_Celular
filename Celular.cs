namespace POO_Celular
{
    public class Celular
    {
        public string cor; 
        public string modelo; 
        public string tamanho; 
        public bool ligar(){
            bool ligar = true;
            return ligar;
        }
        public string ligacao(){
            return "discando";
        }
        public string mensagem(){
            string mensagem = "enviando";
            return mensagem;
        }

       
    }
}