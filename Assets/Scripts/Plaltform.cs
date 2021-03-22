using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plaltform : MonoBehaviour
{
    public GameObject pointA;
    public GameObject pointB;
    Vector3 pos1;
    Vector3 pos2;
    public float lerpSpeed;
    float lerpTime;
    bool toLerp;
    Vector3 currentPosition;
    bool position1;

    private void Start()
    {
        pos1 = pointA.transform.position;
        pos2 = pointB.transform.position;
        MoveToPosition(pos1);
    }

    private void Update()
    {
        if (toLerp)
        {
            transform.position = Vector3.Lerp(transform.position, currentPosition, lerpTime);
            lerpTime += Time.deltaTime / lerpSpeed;
            if (lerpTime > 1.0f)
            {
                lerpTime = 0;
                if (position1)
                {
                    MoveToPosition(pos2);
                }
                else
                {
                    MoveToPosition(pos1);
                }
            }
        }
    }

    void MoveToPosition(Vector3 pos)
    {
        currentPosition = pos;
        position1 = !position1;
        toLerp = true;
    }
}
