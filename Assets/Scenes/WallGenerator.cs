using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    public GameObject wallPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject wall = Instantiate (wallPrefab) as GameObject;
        wall.transform.position = new Vector3 (-5,2, 20); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
