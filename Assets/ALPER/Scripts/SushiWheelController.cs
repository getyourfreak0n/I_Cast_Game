using UnityEngine;
using System.Collections;

public class SushiWheelController : MonoBehaviour
{
    public Transform[] points;
    public Transform[] sushis;
    public float transitionDuration = 1.0f;
    public float delayBetweenRotations = 0f;

    private int[] currentIndices;

    void Start()
    {
        currentIndices = new int[sushis.Length];
        for (int i = 0; i < sushis.Length; i++)
        {
            currentIndices[i] = i;
            sushis[i].position = points[i].position;
        }

        StartCoroutine(RotatingWheel());
    }

    IEnumerator RotatingWheel()
    {
        while (true)
        {
            float elapsedTime = 0f;

            Vector3[] startPositions = new Vector3[sushis.Length];
            Vector3[] targetPositions = new Vector3[sushis.Length];

            for (int i = 0; i < sushis.Length; i++)
            {
                startPositions[i] = sushis[i].position;
                int nextIndex = (currentIndices[i] - 1 + points.Length) % points.Length;
                targetPositions[i] = points[nextIndex].position;
                currentIndices[i] = nextIndex;
            }

            while (elapsedTime < transitionDuration)
            {
                elapsedTime += Time.deltaTime;
                float t = elapsedTime / transitionDuration;
                t = Mathf.SmoothStep(0f, 1f, t);

                for (int i = 0; i < sushis.Length; i++)
                {
                    sushis[i].position = Vector3.Lerp(startPositions[i], targetPositions[i], t);
                }

                yield return null;
            }

            for (int i = 0; i < sushis.Length; i++)
            {
                sushis[i].position = targetPositions[i];
            }

            if (delayBetweenRotations > 0f)
            {
                yield return new WaitForSeconds(delayBetweenRotations);
            }
        }
    }
}