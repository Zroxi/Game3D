using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PickItem : MonoBehaviour
{
    public static int score = 0;
    public Text scoreText;
    public Text scoreText2;
    private AudioSource audioSource;
    public AudioClip itemSound;
    public AudioClip itemPoison;
    Animator animator;
    bool Poison;
    CharacterMovement characterMovement;
    public GameObject EndUI;
    public Text BestScore;
    public static int bscore;


    private void Start()
    {
        animator = GetComponent<Animator>();
        characterMovement = GetComponent<CharacterMovement>();
        audioSource = GetComponent<AudioSource>();
        scoreText.text = "Score = " + score.ToString();
        scoreText2.text = "Score = " + score.ToString();
    }

    private void Update()
    {
         if (score > bscore)
        {
             bscore = score;
        }
    }
    private void OnCollisionEnter(Collision target)
    {
        if(target.gameObject.tag.Equals("Item"))
        {
            Destroy(target.gameObject);
            score += 1;

            scoreText.text = "Score = " + score.ToString();
            audioSource.PlayOneShot(itemSound);
        }
        if (target.gameObject.tag.Equals("Poison"))
        {
            Destroy(target.gameObject);
            animator.SetBool("Die", true);
            characterMovement.speed = 0;
            characterMovement.roatationSpeed = 0;
            audioSource.PlayOneShot(itemPoison);
            EndUI.SetActive(true);
            scoreText2.text = "Score = " + score.ToString();
        
            BestScore.text = "Best Score = " + bscore.ToString();
        }
    }
}
