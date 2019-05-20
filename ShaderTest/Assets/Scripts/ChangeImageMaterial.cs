using UnityEngine;
using UnityEngine.UI;

public class ChangeImageMaterial : MonoBehaviour
{
    public Image Image;
    public Material Material;

    void Start()
    {
        Image.material = Material;
    }
}
