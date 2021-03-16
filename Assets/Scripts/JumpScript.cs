using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class JumpScript : MonoBehaviour
{
    public GameObject player;
    private ThirdPersonCharacter chara;

    void Start()
    {
        chara = player.GetComponent<ThirdPersonCharacter>();
    }

    public void OnClick()
    {
        Vector3 direction = new Vector3(0, 0, 0);
        chara.Move(direction, false, true);
    }
}
