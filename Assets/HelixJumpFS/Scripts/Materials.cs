using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Materials : MonoBehaviour
{
    [SerializeField] private Material axis_mat;
    [SerializeField] private Material ball_mat;
    [SerializeField] private Material default_segment_mat;
    [SerializeField] private Material finish_segment_mat;
    [SerializeField] private Material trap_segment_mat;

    [SerializeField] private Color[] colorArray1;
    [SerializeField] private Color[] colorArray2;
    [SerializeField] private Color[] colorArray3;
    [SerializeField] private Color[] colorArray4;
    [SerializeField] private Color[] colorArray5;
    
    private void Start()
    {
        SetMaterialColor(axis_mat, colorArray1);
        SetMaterialColor(ball_mat, colorArray2);
        SetMaterialColor(default_segment_mat, colorArray3);
        SetMaterialColor(finish_segment_mat, colorArray4);
        SetMaterialColor(trap_segment_mat, colorArray5);
    }
    private void SetMaterialColor(Material material, Color[] colorArray)
    {
        int index = Random.Range(0, colorArray.Length);
        material.color = colorArray[index];
    }

}
