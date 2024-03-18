using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGenerator : MonoBehaviour
{
    public GameObject[] cubePrefabs; // Array to hold different cube prefabs
    public float spawnInterval = 2.5f;
    public float cubeSpeed = 5f;

    private void Start()
    {
        InvokeRepeating("SpawnCube", 0, spawnInterval);
    }

    void SpawnCube()
    {
        // Choose a random prefab from the array
        GameObject selectedPrefab = cubePrefabs[Random.Range(0, cubePrefabs.Length)];

        // Define a random spawn position
        Vector3 spawnPosition = new Vector3(Random.Range(-1, 1), Random.Range(1, 3), transform.localPosition.z);

        // Instantiate the randomly selected cube prefab
        GameObject cube = Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);

        // Assign speed to the cube's movement script
        cube.AddComponent<BlockMovement>().speed = cubeSpeed;
    }
}
