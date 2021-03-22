using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    private Camera cam;
    public GameObject leftPrefab , rightPrefab;
    public GameData finInd, plaInd;
    RaycastHit hit;
    Ray ray;
    public AudioSource place;

    public static BlockSpawner instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }    
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        finInd.finishInd = 0;
        plaInd.playerInd = 1;
        cam = Camera.main;
        Time.timeScale = 1;

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           
            ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Floor") )
                {
                    Instantiate(leftPrefab, hit.point, leftPrefab.transform.rotation);
                    place.Play();
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Floor"))
                {
                    Instantiate(rightPrefab, hit.point, rightPrefab.transform.rotation);
                    place.Play();

                }
            }
        }
    }
}
