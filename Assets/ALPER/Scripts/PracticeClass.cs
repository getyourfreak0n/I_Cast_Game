using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeClass : MonoBehaviour
{
    [SerializeField] float waitingTime = 3f;
    string[][] practiceArray = new string[5][];
    string[] suriyeliString = { "amcik", "kancik", "dalyarrak" };

    [SerializeField] List<GameObject>suriyeli = new List<GameObject>();

    private void Start()
    { 
        foreach (GameObject item in suriyeli)
        {
            Debug.Log(item);
        }


        practiceArray[0] = suriyeliString;

        IEnumerator CoroutinePractice()
        {
            foreach (string[] item in practiceArray)
            { 
                Debug.Log("Vay anam vay.");

                yield return new WaitForSeconds(waitingTime);

                Debug.Log("merhaba televole!");
                yield return new WaitForSeconds(waitingTime);

                Debug.Log("Kolesiyim canina yandigimin.");

                yield return new WaitForSeconds(waitingTime);
            }
        }

        IEnumerator CoroutinePractice2()
        {
            Debug.Log("DUR DAHA YENI BASLADIK!");
            yield return CoroutinePractice();
        }

        //StartCoroutine(CoroutinePractice());
        //StartCoroutine(CoroutinePractice2());
    }

}
