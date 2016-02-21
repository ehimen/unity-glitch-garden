using UnityEngine;
using UnityEngine.UI;

public class UiFade : MonoBehaviour {

    public float startDelay = 0f;

    public float duration = 2f;

    private Image panel;

    private Color currentColor = Color.black;

	void Start()
    {
        panel = GetComponent<Image>();
	}

    void Update()
    {
        FadeTick();
    }

    void FadeTick()
    {
        if (panel)
        {
            if (Time.timeSinceLevelLoad < duration)
            {
                currentColor.a = 1 - (Time.timeSinceLevelLoad / duration);
                panel.color = currentColor;
            }
            else
            {
                gameObject.SetActive(false);
            }
        }
    }

}
