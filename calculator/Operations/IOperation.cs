namespace calculator.Operations
{
    public interface IOperation
    {
        void Execute();

        int Resultat { get; }
    }
}
