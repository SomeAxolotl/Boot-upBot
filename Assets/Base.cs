using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class Base : MonoBehaviour
{
    public float changeTime = 1.2f;
    public int direction = 0;
    public float timer;
    public float failtimer;
    public float failTime = 0.5f;
    Animator animator;
    public ParticleSystem blast;
    public int points = 0;
    public GameObject scientist;
    Animator scienanimator;
    public GameObject scoreboard;
    Animator scoreanimator;
    AudioSource audioSource;
    public AudioClip correct;
    public AudioClip fail;
    public AudioClip explosion;
    public AudioClip boot;
    public AudioClip chime;
    

    
    // Start is called before the first frame update
    void Start()
    {
        timer = changeTime;
        failtimer = failTime;
        animator = GetComponent<Animator>();
        scienanimator = scientist.GetComponent<Animator> ();
        scoreanimator = scoreboard.GetComponent<Animator> ();
        audioSource= GetComponent<AudioSource>();

    }
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            Application.Quit();
        }
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        
        if (timer < 0)
        {
            direction = Random.Range(1,5);
            PlaySound(chime);
            if(direction == 1)
            {
                Debug.Log("Left");
                timer = changeTime;
                direction = 1;
                animator.SetInteger("direction", 1);
            }
            if(direction == 2)
            {
                Debug.Log("Right");
                timer = changeTime;
                direction = 2;
                animator.SetInteger("direction", 2);
            }
            if(direction == 3)
            {
                Debug.Log("Up");
                timer = changeTime;
                direction = 3;
                animator.SetInteger("direction", 3);
            }
            if(direction == 4)
            {
                Debug.Log("Down");
                timer = changeTime;
                direction = 4;
                animator.SetInteger("direction", 4);
            }
        }
        if(direction == 0)
        {
            timer -= Time.deltaTime;
        }
        if(direction == 1)
            {
               failtimer -= Time.deltaTime;
               if(horizontal < 0)
                {
                    Debug.Log("Correct");
                    direction = 0;
                    failtimer = failTime;
                    animator.SetInteger("direction", 0);
                    points += 1;
                    PlaySound(correct);
                    scoreanimator.SetInteger("score", scoreanimator.GetInteger("score") + 1);
                }

            }
        if(direction == 2)
            {
               failtimer -= Time.deltaTime;
               if(horizontal > 0)
                {
                    Debug.Log("Correct");
                    direction = 0;
                    failtimer = failTime;
                    animator.SetInteger("direction", 0);
                    points += 1;
                    PlaySound(correct);
                    scoreanimator.SetInteger("score", scoreanimator.GetInteger("score") + 1);
                }
            }
        if(direction == 3)
            {
               failtimer -= Time.deltaTime;
               if(vertical > 0)
                {
                    Debug.Log("Correct");
                    direction = 0;
                    failtimer = failTime;
                    animator.SetInteger("direction", 0);
                    PlaySound(correct);
                    points += 1;
                    scoreanimator.SetInteger("score", scoreanimator.GetInteger("score") + 1);
                }
            }
        if(direction == 4)
            {
              failtimer -= Time.deltaTime;
               if(vertical < 0)
                {
                    Debug.Log("Correct");
                    direction = 0;
                    failtimer = failTime;
                    animator.SetInteger("direction", 0);
                    points += 1;
                    PlaySound(correct);
                    scoreanimator.SetInteger("score", scoreanimator.GetInteger("score") + 1);
                }
            }
        if(failtimer < 0)
        {
            Lose();
            
        }
        if(points == 8)
        {
            Win();
        }
 
 
        
        
    }
    void Lose()
    {
        direction = 5;
        failtimer = failTime;
        PlaySound(fail);
        animator.SetInteger("direction", 5);
        Invoke("Reset", 2);
        Invoke("blastspawn", 0.65f);
        scienanimator.SetTrigger("loss");

    }
    void blastspawn()
    {
        blast.Play();
        PlaySound(explosion);
    }
    void Reset()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    void Win()
    {
        direction = 5;
        animator.SetInteger("direction", 6);
        Invoke("bootup", .5f);
        Invoke("Reset", 2);
        points = 0;

    }
    void bootup()
    {
        PlaySound(boot);
    }
    void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
