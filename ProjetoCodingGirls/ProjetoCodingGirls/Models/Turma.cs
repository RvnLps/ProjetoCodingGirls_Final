namespace ProjetoCodingGirls_Escola.Models
{
    public class Turma
    {   
        public int Id { get; set; }
        public string Nome { get; set; }    
        public bool Ativo { get; set; }


        
        #region Navigation Properties
        public virtual List<Aluno>? Aluno { get; set; }
        #endregion
        
    }
}


