using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    public GameObject wallPrefab;

    private int startPosition = 0;

    private int goalPosition = 8000;

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = startPosition + 1000; i < goalPosition; i += 200)
        {
            var wall = Instantiate(wallPrefab);
            int num = Random.Range(-8, 8);
            wall.transform.position = new Vector3(num, wall.transform.position.y, i);
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}