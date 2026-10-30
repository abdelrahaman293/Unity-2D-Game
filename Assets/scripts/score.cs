using System.Collections;
using TMPro;
using UnityEngine;

public class score : MonoBehaviour
{
    private TextMeshProUGUI Score_txt;
    public static int score_val = 0;

    // Start is called before the first frame update
    void Start()
    {
        Score_txt = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Score_txt.text = "SCORE " + score_val;
    }
}

