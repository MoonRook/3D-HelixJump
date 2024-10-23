using UnityEngine;

public enum SegmentType
{
    Default,
    Trap,
    Empty,
    Finish
}

[RequireComponent(typeof (MeshRenderer))]
public class Segment : MonoBehaviour
{
    [SerializeField] private Material trapMaterial;
    [SerializeField] private Material finishtMaterial;

    [SerializeField] private SegmentType type;
    
    public SegmentType Type => type;

    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public void SetTrap()
    {
        meshRenderer.enabled = true;
        meshRenderer.material = trapMaterial;

        type = SegmentType.Trap;
    }

    public void SetEmty()
    {
        meshRenderer.enabled = false;
        
        type = SegmentType.Empty;
    }

    public void SetFinish()
    {
        meshRenderer.enabled = true;
        meshRenderer.material = finishtMaterial;

        type = SegmentType.Finish;
    }
}
