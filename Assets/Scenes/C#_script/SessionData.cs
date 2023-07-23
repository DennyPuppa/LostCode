public static class SessionData
{
    private static int score;
    private static int numbOfItem;
    private static int levelScore;
    private static int levelItem;
    private static int numbLevelItem;

    public static int GetScore()
    {
        return score;
    }

    public static void AddScore(int point)
    {
        score += point;
    }

    public static void AddItem()
    {
        numbOfItem ++;
    }

    public static void ResetData()
    {
        score = 0;
        numbOfItem = 0;
    }

    public static void ResetLevelData()
    {
        score = levelScore;
        numbOfItem = levelItem;
    }

    public static void SetLevelData()
    {
        levelScore = score;
        levelItem = numbOfItem;
    }

    public static int GetLevelNumbOfItem()
    {
        return numbOfItem;
    }

    public static void SetNumberLevelObject(int n)
    {
        numbLevelItem = n;
    }

    public static int GetNumberLevelObject()
    {
        return numbLevelItem;
    }


}
