using TMPro;
using UnityEngine;



public class Player : MonoBehaviour
{
    public TextMeshProUGUI myText;


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "FinalBoard")
        {
            myText.text = "Congrats. You made it!";
        }
    }
}
