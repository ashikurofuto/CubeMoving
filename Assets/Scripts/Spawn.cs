using UnityEngine;
using System.Collections;



public class Spawn : MonoBehaviour
{
    [SerializeField] private SpawnData spawnData;
    [SerializeField] private Transform spawnPoint;
    private Pool<CubeLogic> cubePool;
    

    private void Awake()
    {
        cubePool = new Pool<CubeLogic>(spawnData.CubePrefab, spawnData.Count, spawnPoint)
        {
            autoExpand = spawnData.AutoExpand
        };
        
    }

    public void StartSpawnAndRepeat(bool canSpawn)
    {
        if (canSpawn)
        {
            StartCoroutine(SpawnCubesRoutine(spawnData.SpawnTime));
        }
        else
        {
            return;
        }
    }

    private IEnumerator SpawnCubesRoutine(float timeToSpawn)
    {
        var cube = cubePool.GetFreeElement();
        cube.transform.position = spawnPoint.position;
        yield return new WaitForSeconds(timeToSpawn);
        StartSpawnAndRepeat(true);
    }
}
