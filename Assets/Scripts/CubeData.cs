using UnityEngine;
using System;

[CreateAssetMenu(fileName = "CubeData", menuName = "Data/CubeData", order = 2)]
public class CubeData : ScriptableObject
{
    public float Speed { get; set; }
    public float Distance { get; set; }



}
