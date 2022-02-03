using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public Transform player;
    public Text distanceText;
    private int distance;


    // Update is called once per frame
    void Update()
    {
        distance = 50 + (int) player.transform.position.z ;
        distanceText.text = distance.ToString();
    }
}
