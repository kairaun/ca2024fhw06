using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab; 
    public Transform[] pillars; 
    public float spawnInterval = 1f; 
    public float fallSpeed = 2f;  
    public float cubeScaleOffset = 0.1f;  

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnCube();
            timer = 0;
        }
    }
    void SpawnCube()
    {
        Transform selectedPillar = pillars[Random.Range(0, pillars.Length)];
        Vector3 spawnPosition = selectedPillar.position + new Vector3(0, selectedPillar.localScale.y / 2, 0);
        GameObject newCube = Instantiate(cubePrefab, spawnPosition, Quaternion.identity);
        newCube.AddComponent<FallingCube>().fallSpeed = fallSpeed;
        newCube.GetComponent<FallingCube>().pillarHeight = selectedPillar.localScale.y;
        newCube.GetComponent<FallingCube>().pillarBaseY = selectedPillar.position.y - selectedPillar.localScale.y / 2;
    }
}
