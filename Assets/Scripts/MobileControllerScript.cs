using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class MobileControllerScript : MonoBehaviour
{
    public FixedJoystick joystick;
    public GameObject player;
    private ThirdPersonCharacter chara;

    void Start()
    {
        chara = player.GetComponent<ThirdPersonCharacter>();
    }

    void Update()
    {
        Vector3 direction = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
        chara.Move(direction, false, false);
    }
}
