using UnityEngine;
using System.Collections;

public class Debugging : MonoBehaviour {

	// Use this for initializatio

    private void QAwake()
    {
        int from = 0;
        int to = 1000000000;

        for (float factor = 0.0f; factor <= 1.0f; factor += 0.1f)
        {
            int result = (int)(from * (1f - factor) + to * factor);

            Debug.Log(result);
        }
    }
}
