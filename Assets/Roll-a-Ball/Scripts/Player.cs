using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{

    private Rigidbody rb;

    public Text scoreText;

    public int points = 0;

    public float boostSpeed = 3;

    public float playerSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        //allows the 'WASD' and 'arrow keys' to be able to move left to right and back and forth
        float horizontal = Input.GetAxisRaw("Horizontal") * playerSpeed;
        float vertical = Input.GetAxisRaw("Vertical") * playerSpeed;
        

        rb.AddForce(horizontal, 0.0f, vertical);
        //Converting the text to the amount if points youve gotten
        scoreText.text = "Score " + points.ToString();
    }

    void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }

        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "EndPlate" && points == 18)
            {
            SceneManager.LoadScene(nextSceneIndex);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boost")
        {
            playerSpeed = boostSpeed;
            Debug.Log("Boost");
        }
        
    }
}
