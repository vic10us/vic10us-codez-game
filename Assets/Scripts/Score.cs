using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text Scoreboard;

    // Update is called once per frame
    void Update()
    {
        Scoreboard.text = $"{Player.position.z:0}";
    }
}
