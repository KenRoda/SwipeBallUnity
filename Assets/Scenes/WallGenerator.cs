using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    public GameObject wallPrefab;

    private int startPosition = 0;

    private int goalPosition = 12000;

    // Start is called before the first frame update
    private void Start()
    {
        for (int i = startPosition; i < goalPosition; i += 100)
        {
            var wall = Instantiate(wallPrefab);
            int num = Random.Range(-10, 10);
            wall.transform.position = new Vector3(num, wall.transform.position.y, i);
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}