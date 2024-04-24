class Vetor
{
    private int[] vetor;
    public Vetor(int tamanho){
        vetor = new int[tamanho];
    }
    public void PreencherVetor(){
        for(int i=0; i<vetor.Length; i++){
            Console.WriteLine("Informe o n° para preenchimento: " + i);
            vetor[i] = int.Parse(Console.ReadLine());
        }
    }
    public void ExibirVetor() {
        Console.WriteLine("Números preenchidos: " + string.Join(", ", vetor));
        
    }
}

