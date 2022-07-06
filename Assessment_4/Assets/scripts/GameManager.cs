using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

/// <summary>
/// Real
/// </summary>
public class GameManager : MonoBehaviour
{

    int Score;  // Score
    public TMP_Text score;
    public static GameManager instance;

    // Audio
    //public AudioSource FallingDownSound;
    //public AudioSource DiamondCollect;
    public AudioClip FallingDownSound;
    public AudioClip DiamondCollect;

    private AudioSource audioSource;

    bool GameOver = false;

    private void Awake()
    {
        instance = this;
        audioSource = gameObject.AddComponent<AudioSource>();
    }




    public void IncrementScore()
    {
        Score++;
        score.text = Score.ToString();
    }

    public void PointsCollect()
    {
        
        audioSource.PlayOneShot(DiamondCollect);
        //DiamondCollect.Play();  // play diamond collect audio
    }

    public void FallingDownSounds()
    {
        //FallingDownSound.Play();
        audioSource.PlayOneShot(FallingDownSound);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //public void stopthegame()
    //{
    //    GameOver = true;
    //}
}
