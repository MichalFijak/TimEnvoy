using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public GameManager gameManager;
    public Slider slider;
    


    public void SetPoints(float point)
    {
        
        float count = gameManager.pointCount;
        
        slider.value = (point / count);

    }
}
