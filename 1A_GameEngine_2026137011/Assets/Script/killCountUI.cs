using TMPro;
using UnityEngine;

public class killCountUI : MonoBehaviour
{
    public TMP_Text label_k;
    public TMP_Text label_s;

    void Start()
    {
        Health.killCount = 0;
        Health.score = 0;
    }


    void Update()
    {
        label_k.text = "Kill " + Health.killCount;
        label_s.text = "Score " + Health.score;
    }
}
