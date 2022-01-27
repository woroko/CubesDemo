using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject grabbableCube; // prefab for the grabbable cube
    public float spawningInterval = 2f; // seconds to wait before spawning the next cube
    public int numberToSpawn = 7; // maximum number of cubes to spawn

    private WaitForSeconds spawningDelay;

    // Start is called before the first frame update
    void Start()
    {
        spawningDelay = new WaitForSeconds(spawningInterval); // reusable objects should be created only once to minimize garbage collection
        // advanced users sometimes create object pools to avoid GC

        // start the coroutine
        StartCoroutine(SpawnCubes());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator SpawnCubes()
    {
        for(int i=0; i<numberToSpawn; i++)
        {
            // instantiate a new copy of the cube prefab at this scripts position plus a random offset, using the default rotation
            Instantiate(grabbableCube, transform.position + Random.onUnitSphere*1.4f, Quaternion.identity);
            yield return spawningDelay;
        }

        yield return null;
    }
}
