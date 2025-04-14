using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrrowController : MonoBehaviour
{
    public float ArrowSpeed = -0.1f;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,ArrowSpeed,0);
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float distance = dir.magnitude;
        float radius1 = 0.5f;
        float radius2 = 1.0f;

        if (distance < radius1 + radius2)
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseHP();

            Destroy(gameObject);
            
        }
    }
}
