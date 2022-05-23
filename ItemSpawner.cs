using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] itemsToDrop; // an array of gameobjects
    public float numberOfItems;

    public Vector2 minPositions;
    public Vector2 maxPositions;

    private Vector2 lastPositionTried;
    private Vector2 newPos;


    private void Start()
    {
        for (int i = 0; i < numberOfItems; i++)
        {
            // try to spawn an item

            //get a new position within our positions
            var newPos = new Vector2();
            newPos.x = Random.Range(minPositions.x, maxPositions.x); // get a random value between the left and right
            newPos.y = Random.Range(minPositions.y, maxPositions.y); // from top to bottom

            //eventually want a check in here so they dont spawn on each other...

            // grab a random number not going over the number of items we have in the list
            var theRandomItem = Random.Range(0, itemsToDrop.Length);

            //then we spawn that item at the random position
            Instantiate(itemsToDrop[theRandomItem], newPos, Quaternion.identity);
        }
    }
}
