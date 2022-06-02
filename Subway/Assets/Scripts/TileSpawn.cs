using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawn : MonoBehaviour
{
    public List<GameObject> tracks;
    public GameObject tracksList;
    public GameObject Max;
    public Vector3 lastPos = new Vector3(0, 0, 500);
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        /*if (Mathf.Round(Max.transform.position.z) % 100 == 0)
        {
            spawnTile();
        }*/
        if (Time.frameCount % 750 == 0)
        {
            spawnTile();
        }
    }

    public void spawnTile()
    {
        Instantiate(tracks[Random.Range(0, tracks.Count)], lastPos, Max.transform.rotation, tracksList.transform);
        Destroy(tracksList.transform.GetChild(0).gameObject);
        lastPos.z += 100;
    }

}
