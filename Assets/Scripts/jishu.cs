using UnityEngine;
using TMPro;

public class jishu : MonoBehaviour
{
    int xms;

    private void Start()
    {

    }

    private void Update()
    {
        if (transform.position.y < 0)
        {
            xms = ++GameObject.Find("Main Camera").GetComponent<sheji1>().xms;
            GameObject.Find("Canvas/Test2").GetComponent<TextMeshProUGUI>().text = "消灭数：" + xms;
            Destroy(gameObject);
        }
    }
}