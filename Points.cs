using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public GameManager gameManager;
    public Slider slider;

    private void Start()
    {
        //DontDestroyOnLoad(this.gameObject);
    }

    public void SetPoints(float point)
    {

        float count = gameManager.pointCount;
        if (count!=0)
         {
            slider.value = point / count;
         }
    }
}
