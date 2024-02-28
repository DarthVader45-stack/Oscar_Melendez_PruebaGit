using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Launcher : MonoBehaviour
{
    [SerializeField] TMP_InputField roomNameInputField;
    [SerializeField] TMP_Text roomName;

    public object PhotonNetwork { get; private set; }

    // Start is called before the first frame update
    public void CreateRoom()
    {
        //Si presionamos el boton y este esta vacio no procedera.
        if(string.IsNullOrEmpty(roomNameInputField.text))
        {
            return;
        }

        PhotonNetwork.CreateRoom(roomNameInputField.text);

        ContextualMenuManager.Instance.OpenMenuName("Loading");
    }
}

