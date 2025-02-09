using UnityEngine;
using UnityEngine.Audio;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public bool is_active = false;
    public AudioMixer mixer;
    public GameObject cam;

    AudioSource[] AudioSources;

    private bool is_moving = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AudioSources = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (is_active)
        {
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.position += new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
                is_moving = true;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                this.transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
                is_moving = true;
            }
            else
            {
                is_moving = false;
            }

            if (is_moving)
            {
                mixer.SetFloat("player_volume",  -15);
            }
            else
            {
                mixer.SetFloat("player_volume", -80);
            }
            
            for (int i = 0; i < AudioSources.Length; i++)
            {
                AudioSource a_s = AudioSources[i];
                if (!a_s.isPlaying)
                {
                    if (Random.Range(0, 100) > 85)
                    {
                        a_s.Play();
                    }
                }
            }
        }
    }
}
