using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject clonePrefab;
    public BoxCollider bc; 
    private readonly string newTag = "Meteor";
    public float destroyTime = 10.0f;

    private void Start()
    {
        InvokeRepeating("SpawnClones", 0.0f, Random.Range(2.0f, 6.0f));
    }
    private void SpawnClones()
    {
        int numClones = Random.Range(1, 9);

        for (int i = 0; i < numClones; i++)
        {
            Vector3 spawnPosition = new Vector3(1.89f, Random.Range(50f, 80f), Random.Range(-130f, -100f));
            float scale = Random.Range(0.1f, 0.15f);

            GameObject clone = Instantiate(clonePrefab, spawnPosition, Quaternion.identity);
            clone.tag = newTag;
            clone.AddComponent<Meteor>();
            BoxCollider newCollider = clone.AddComponent<BoxCollider>();
            newCollider.center = bc.center;
            newCollider.size = bc.size;
            clone.transform.localScale = new Vector3(scale, scale, scale);
            Destroy(clone, destroyTime);
        }
    }
}