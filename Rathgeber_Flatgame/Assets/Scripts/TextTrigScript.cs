using UnityEngine;
using TMPro;
using UnityEngine.Audio;

public class TextTrigScript : MonoBehaviour
{
    public TextMeshProUGUI text_to_trigger;
    public AudioMixer mixer;
    public Player player;

    public float type_rate = 5f;
    
    private float pitch_min = 10f;
    private float pitch_max = 12f;
    private float type_count = 0f;
    private bool is_active = false;
    private string full_string;
    private int letters = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        full_string = text_to_trigger.GetComponent<TMPro.TextMeshProUGUI>().text;
        text_to_trigger.GetComponent<TMPro.TextMeshProUGUI>().text = "";
    }

    // Update is called once per frame
    void Update()
    {

        if (is_active)
        {
            type_count += type_rate * Time.deltaTime;
            if (type_count >= 1 && letters < full_string.Length)
            {
                letters += 1;
                type_count = 0;
                mixer.SetFloat("type_pitch", Random.Range(pitch_min, pitch_max));
                GetComponent<AudioSource>().Play();
                //Debug.Log("Letter added!");
            }

            text_to_trigger.GetComponent<TMPro.TextMeshProUGUI>().text = full_string.Substring(0,letters);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (is_active == false)
        {
            is_active = true;
            bool player_can_move = player.GetComponent<Player>().is_active;
            if (!player_can_move)
            {
                player.GetComponent<Player>().is_active = true;
            }
            //Debug.Log("Activated!");
        }
    }
}
