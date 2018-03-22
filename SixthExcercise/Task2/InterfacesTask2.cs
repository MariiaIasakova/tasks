namespace Task2
{
    public interface IIndexable
    {
        double this[int index] { get; }
    }

    public interface ISeries
    {
        double GetCurrent();
        bool MoveNext();
        void Reset();
    }

    interface IIndexableSeries : ISeries, IIndexable
    {
    }
}
