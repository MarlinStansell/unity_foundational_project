using JetBrains.Annotations;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 1;
    public Vector3 move;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        float horizontal = Input.GetAxis("Horizontal");  // A/D or Left/Right
        float vertical = Input.GetAxis("Vertical");
        move = new Vector3(speed * horizontal, 0, speed * vertical);

        transform.Translate(move * Time.deltaTime);

  
    }

}
