using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theBoll : MonoBehaviour
{
    public float xPosition = Random.value;
    public float yPosition = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(xPosition, yPosition, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        xPosition = xPosition + 1f * Time.deltaTime;
        yPosition = xPosition + 1f * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0);
    }
}
