using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private Rigidbody rb;
    private MeshRenderer meshRend;


    public Text scoreText;

    public AudioSource audioSource;
    public AudioClip audioBoost;
    //public List<AudioClip> audioBoost = new List<AudioClip>();
    

    //public TMP_Text scoreText;

    public List<Material> colorMaterials = new List<Material>();
    private int currentColorIndex = 0;


    public int points = 0;

    public float boostSpeed = 5f;

    public float playerSpeed = 2f;

    public float slowSpeed = 1.0f;

    public float playerSize;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        meshRend = GetComponent<MeshRenderer>();
        audioSource = GetComponent<AudioSource>();
        Random.Range(0,3);
    }

    // Update is called once per frame
    void Update()
    {
        //color swaps
        if(Input.GetKeyUp(KeyCode.RightBracket))
        {
            currentColorIndex++;
            if(currentColorIndex >= colorMaterials.Count)
            {
                currentColorIndex = 0;
            }
            meshRend.sharedMaterial = colorMaterials[currentColorIndex];
        }
        else if(Input.GetKeyDown(KeyCode.LeftBracket))
        {
            currentColorIndex--;
            if (currentColorIndex < 0)
            {
                currentColorIndex = colorMaterials.Count - 1;
            }
            meshRend.sharedMaterial = colorMaterials[currentColorIndex];
        }


        //allows the 'WASD' and 'arrow keys' to be able to move left to right and back and forth
        float horizontal = Input.GetAxisRaw("Horizontal") * playerSpeed;
        float vertical = Input.GetAxisRaw("Vertical") * playerSpeed;
        

        rb.AddForce(horizontal, 0.0f, vertical);
        //Converting the text to the amount if points youve gotten
        scoreText.text = "Score " + points.ToString();




        //boostTimer -= Time.deltaTime;
        //if(bosstTimer <= 0.0f && Input.GetButtonDown("Boost"))
        //{
        //    rb.AddForce(horizontal * boostpower, 0.0f, forward * boostPower, ForceMode.Inpulse);
        //    boostTimer = BoostCoolDown;

        //    AudioClip selectedBoost = boostSounds[Random.Range()];
        //    audioSource.PlayOneShot(audioBoost);
        //}
    }

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }
        SceneManager.LoadScene(nextSceneIndex);


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boost")

        {
            
            playerSpeed = boostSpeed;

            return;

            Debug.Log("Boost");
        }
        if (other.tag == "EndPlate"/* && points == 0*/)
            {
                Debug.Log("End Plate");
                LoadNextScene();
                //SceneManager.LoadScene(nextSceneIndex);
            }

        
    }

}
