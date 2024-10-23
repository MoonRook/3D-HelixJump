using UnityEngine;

public class SceneSetup : MonoBehaviour
{
    [SerializeField] private LevelGenerator levelGenerator;
    [SerializeField] private BallController ballController;
    [SerializeField] private LevelProgress LevelProgress;

    private void Start()
    {
        levelGenerator.Generate(LevelProgress.CurrentLevel);
        ballController.transform.position = new Vector3(ballController.transform.position.x, 
            levelGenerator.lastFloorY, ballController.transform.position.z);
    }
}
