using UnityEngine;


public class ScoresCollector : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;

    [SerializeField] private int scores;
    [SerializeField] private int hiscores;
    public int Scores => scores;
    public int Hiscore => hiscores;
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Empty)
        {
            scores += levelProgress.CurrentLevel;
        }
        if (type == SegmentType.Finish)
        {
            if (scores > hiscores)
            {
                hiscores = scores;
            }
        }
    }
}
