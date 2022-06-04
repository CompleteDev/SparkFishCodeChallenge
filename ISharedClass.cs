namespace SparkFishChallenge
{
    public interface ISharedClass
    {
        int GetFirstNumber();
        int GetSecondNumber(int LowerNumber);
        void GetSelectedPosition(int TotalPositions, int LowNumber, int HighNumber);
        int GetTotalNumberOfPositions(int LowNumber, int HighNumber);
    }
}