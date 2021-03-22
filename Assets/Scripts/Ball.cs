using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public GameObject whatToInst;
    public GameData gameData;
   
   
    void Start()
    {

      
    }

   
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Line"))
        {
            GameObject temp = Instantiate(whatToInst, transform.position , transform.rotation);
            gameData.playerInd++;
            temp.GetComponent<Rigidbody>().AddForce(Vector2.up * 70f, ForceMode.Impulse);
            gameObject.GetComponent<Rigidbody>().AddForce(Vector2.up * 70f, ForceMode.Impulse);
            collision.gameObject.GetComponent<BoxCollider>().enabled = false;
            Destroy(collision.gameObject,1f);
        }

        if(collision.gameObject.CompareTag("Spike"))
        {
            Time.timeScale = 0f;
            BlockSpawner.instance.enabled = false;
            UIManager.instance.losePanel.SetActive(true);
            Destroy(gameObject);
        }

        if(collision.gameObject.CompareTag("Finish"))
        {
            gameData.finishInd++;
            if (gameData.playerInd == gameData.finishInd)
            {
                Time.timeScale = 0f;
                BlockSpawner.instance.enabled = false;
                UIManager.instance.winPanel.SetActive(true);

            }
        }    


    }
}
