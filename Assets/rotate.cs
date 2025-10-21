using UnityEngine;

public class rotate : MonoBehaviour
{
    //speed of rotation 
    public Vector3 speed = new Vector3(1f, 0f, 0f);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotates the object
        transform.Rotate(speed * Time.deltaTime);

    }
}
