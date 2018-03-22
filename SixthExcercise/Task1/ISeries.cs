namespace Task1
{
    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }
}
