using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
        }
        /*
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, moveSpeed, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -moveSpeed, 0) * Time.deltaTime;
        }
        */
    }
}
