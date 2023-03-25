using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Your_Score : MonoBehaviour
{
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = Score.score.ToString();
    }
}
