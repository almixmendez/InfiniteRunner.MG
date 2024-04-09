using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 floorSpawnPoint;

    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            SpawnTile();
        }
    }
    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, floorSpawnPoint, Quaternion.identity);
        floorSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
}
