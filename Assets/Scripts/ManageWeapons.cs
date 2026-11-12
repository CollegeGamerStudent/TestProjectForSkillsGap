using UnityEngine;

public class ManageWeapons : MonoBehaviour
{
    [SerializeField]
    Camera playersCamera;
    Ray rayFromPlayer;
    //use this for initialisation
    void Start()
    {
        playersCamera = GameObject.Find ("PlayerCamera").GetComponent<Camera>();
    }
    //Update is called once per frame
    void Update()
    {
        rayFromPlayer = playersCamera.ScreenPointToRay (new Vector3 (Screen.width/2, Screen.height/2));
        Debug.DrawRay(rayFromPlayer.origin, rayFromPlayer.direction * 100, Color.red);
    }
}
