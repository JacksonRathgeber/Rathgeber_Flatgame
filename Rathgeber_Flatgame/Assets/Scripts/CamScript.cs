using UnityEngine;

public class Camera : MonoBehaviour
{
    public Player player;
    public float followDist;
    public float lerpVal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        float p_x = player.transform.position.x;
        float p_y = player.transform.position.y;
        */
        this.transform.position = new Vector3(0, -20, -10);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 followVect = new Vector3(player.transform.position.x, 0, -10);

        if (Vector3.Distance(this.transform.position, player.transform.position) > followDist)
        {
            this.transform.position = Vector3.Lerp(this.transform.position, followVect, lerpVal * Time.deltaTime);
        }
    }
}
