using UnityEngine;

public class GroundSpawner : MonoBehaviour
{

    [SerializeField] GameObject groundTile;
    Vector3 nextSpawnPoint;
    static int countoffive=0;
    public void SpawnTile(bool spawnItems)
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

        //Debug.Log(countoffive);
        countoffive++;
        if (spawnItems)
        {
            temp.GetComponent<GroundTile>().SpawnObstacle();
            temp.GetComponent<GroundTile>().SpawnCoins();
        }
        if(countoffive%5==0)
        {
            temp.GetComponent<GroundTile>().SpawnJewel();
        }

    }

    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            if (i < 1)
            {
                SpawnTile(false);
            }
            else
            {
                SpawnTile(true);
            }
        }
    }
}
