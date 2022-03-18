using UnityEngine;



[CreateAssetMenu(fileName = "SpawnData", menuName = "Data/SpawnData", order =1)]
public class SpawnData : ScriptableObject
{
    [SerializeField] private CubeLogic cubePrefab;
    [SerializeField] private int count;
    [SerializeField] private bool autoExpand;

    public CubeLogic CubePrefab { get => cubePrefab; }
    public int Count { get => count; }
    public bool AutoExpand { get => autoExpand; }
    public float SpawnTime { get; set; }
}
