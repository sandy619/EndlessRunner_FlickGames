using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    bool isAlive=true;
    [SerializeField]
    public float forwardSpeed = 8f;
    float horizontalSpeed = 10f;
    Rigidbody rb;
    float HorizontalInput;
    //[SerializeField] GameObject achievment;
    [SerializeField] public Text Distance;
    [SerializeField] public Text FinalDistance;
    [SerializeField] GameObject GameOver;

    public int distance=0;

    public float speedIncreasePerPoint = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb=gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!isAlive)
            return;
        Vector3 forwardMove = transform.forward * forwardSpeed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * HorizontalInput * horizontalSpeed * Time.fixedDeltaTime;
        rb.MovePosition(transform.position + forwardMove + horizontalMove);
        
    }

    private void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.y < -5)
        {
            Die();
        }

        distance = Mathf.RoundToInt((this.transform.position.z) + 7);
        PlayerPrefs.SetInt("distancePlayerPrefs", distance);
        Distance.text = "Distance : " + Mathf.RoundToInt((this.transform.position.z)+7).ToString()+"m";
       
        //if(GameManager.inst.score >=10 && GameManager.inst.score <= 12)
        //{
        //    achievment.SetActive(true);
        //}
        //else
        //{
        //    achievment.SetActive(false);
        //}
    }

    public void Die()
    {
        
        isAlive = false;
        //if (PlayerPrefs.GetInt("score") < GameManager.inst.score)
        //{
        //    PlayerPrefs.SetInt("score", GameManager.inst.score);
        //}
        PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score") + GameManager.inst.score);
        PlayerPrefs.SetInt("jewel", PlayerPrefs.GetInt("jewel") + GameManager.inst.jewel);

        FinalDistance.text = "Distance Travelled: " + Mathf.RoundToInt((this.transform.position.z) + 7).ToString() + "m"; 
        // Restart the game
        //Invoke("Restart", 1);
        //SceneManager.LoadScene(0);
        GameOver.SetActive(true);

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
