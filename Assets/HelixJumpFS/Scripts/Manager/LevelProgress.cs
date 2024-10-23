using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelProgress : BallEvents
{
    private int currentLevel = 1;
    public int CurrentLevel => currentLevel;
    
    private int hiscores;
    public int Hiscores => hiscores;

    protected override void Awake()
    {
        base.Awake();

        Load();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1) == true)
        {
            Reset();
        }
        if (Input.GetKeyDown(KeyCode.F2) == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Finish)
        {
            currentLevel++;
            hiscores++;
            Save();
        }
    }
    private void Save()
    {
        PlayerPrefs.SetInt("LevelProgress:CurrentLevel", currentLevel);
        PlayerPrefs.SetInt("Hiscores", hiscores);
    }
    private void Load()
    {
        currentLevel = PlayerPrefs.GetInt("LevelProgress:CurrentLevel", 1);
        hiscores = PlayerPrefs.GetInt("Hiscores", 0);
    }

    private void Reset()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
