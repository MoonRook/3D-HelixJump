using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] private List<Segment> defaultSegments;

    public void AddEmptySegment(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            defaultSegments[i].SetEmty();
        }
        // Обратный цикл, т.к. при удалении массива сдвигается влево
        for (int i = amount; i >= 0; i--)
        {
            defaultSegments.RemoveAt(i);
        }
           
    }
    public void AddRandomTrapSegment(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            int index = UnityEngine.Random.Range(0, defaultSegments.Count);
            
            defaultSegments[index].SetTrap();
            defaultSegments.RemoveAt(index);
        }
    }
    public void SetRandomRotation()
    {
        transform.eulerAngles = new Vector3(0, UnityEngine.Random.Range(0, 360), 0);
    }
    public void SetFinishAllSegment()
    {
        for (int i = 0; i < defaultSegments.Count; i++)
        {
            defaultSegments[i].SetFinish();
        }
    }
}
