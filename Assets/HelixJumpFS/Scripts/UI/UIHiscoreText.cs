using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHiscoreText : BallEvents
{
    [SerializeField] private ScoresCollector scoreCollector;
    [SerializeField] private Text HiscoreText;

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type == SegmentType.Finish)
        {
            HiscoreText.text = scoreCollector.Scores.ToString("Рекорд: ");
        }
    }
}
