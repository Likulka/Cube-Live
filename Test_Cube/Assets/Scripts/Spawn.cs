using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Spawn : MonoBehaviour
{
    [SerializeField] public InputField inputSpeed;
    [SerializeField] public InputField inputDistance;
    [SerializeField] public InputField inputSpawnTime;

    [SerializeField] private GameObject cube;

    private int spawnPlaceZ;
    Vector3Int spawnPlace;

    public void StartSpawn()
    { 
        StartCoroutine(SpawnCube());
        
    }
       
    IEnumerator SpawnCube()
    {
        yield return new WaitForSeconds(float.Parse(inputSpawnTime.text));
        spawnPlaceZ = UnityEngine.Random.Range(-7, 10);
        spawnPlace = new Vector3Int(40, 1, spawnPlaceZ);
        GameObject cubesItem =  Instantiate(cube, spawnPlace, Quaternion.identity);
        cubesItem.GetComponent<Moving>().cubeDistance = float.Parse(inputDistance.text);
        cubesItem.GetComponent<Moving>().cubeSpeed = float.Parse(inputSpeed.text);
                       
    }
}
