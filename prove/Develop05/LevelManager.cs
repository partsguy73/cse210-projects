using System;

public class LevelManager // This entire class was added to provide a leveling component
{
    private int _currentLevel;
    private int _currentXP;
    private const int XP_PER_LEVEL = 1000;

    public LevelManager()
    {
        _currentLevel = 1;
        _currentXP = 0;
    }

    public int GetCurrentLevel()
    {
        return _currentLevel;
    }

    public int GetCurrentXP()
    {
        return _currentXP;
    }

    public int GetXPToNextLevel()
    {
        return XP_PER_LEVEL - (_currentXP % XP_PER_LEVEL);
    }

    public void AddXP(int amount)
    {
        _currentXP += amount;
        while (_currentXP >= _currentLevel * XP_PER_LEVEL)
        {
            _currentXP -= _currentLevel * XP_PER_LEVEL;
            _currentLevel++;
        }
    }
}
