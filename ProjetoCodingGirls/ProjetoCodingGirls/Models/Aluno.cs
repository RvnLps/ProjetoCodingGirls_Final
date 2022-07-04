namespace ProjetoCodingGirls_Escola.Models
{
    public class Aluno
    {
		public int Id { get; set; }
		public  string? Nome { get; set; }
		public DateTime DataNascimento { get; set; }
		public char Genero { get; set; }
		public int TotalFaltas { get; set; }
		public int Id_Turma { get; set; }

		
		#region Navigation Properties
		public virtual Turma? Turma { get; set; }
		#endregion
		
	}
}



