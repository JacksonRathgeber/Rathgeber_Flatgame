using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public bool is_active = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (is_active)
        {
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.position += new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                this.transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
            }
        }
    }
}
