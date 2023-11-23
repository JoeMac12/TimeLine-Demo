using UnityEngine;
using System.Collections; 

public class Trigger : MonoBehaviour
{   
    public GameObject TimeLine;
    public GameObject MainCamera;

    void OnTriggerEnter(Collider other)
    {
        TimeLine.SetActive(true);
        MainCamera.SetActive(false);

        StartCoroutine(FinishTimeLine());
    }

    IEnumerator FinishTimeLine() // The main camera reenables by the timeline so no need to setactive
    {
        yield return new WaitForSeconds(10);
        TimeLine.SetActive(false);
    }
}
