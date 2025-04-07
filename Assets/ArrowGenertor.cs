using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenertor : MonoBehaviour
{
    public GameObject arrowPrefab; // Prefab of the arrow to be instantiated
    private float span = 1.0f; // Time interval between arrow generations
    private float delta = 0; // Time elapsed since the last arrow generation

    // Start is called before the first frame update
    void Start()
    {
        // Initialization logic can go here if needed
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime; // Increment the elapsed time by the time since the last frame
        if (this.delta > this.span) // Check if the time interval has passed
        {
            this.delta = 0; // Reset the elapsed time
            GameObject go = Instantiate(this.arrowPrefab); // Instantiate a new arrow
            int px = Random.Range(-6, 7); // Generate a random x position for the arrow
            go.transform.position = new Vector3(px, 7, 0); // Set the position of the arrow
        }
    }
}