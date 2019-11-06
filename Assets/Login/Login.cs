using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour {
    public Gameobject username;
    public Gameobject password;
    private string Username;
    private string Password;

    //Funcion validar el ingreso de cuenta
    public void Ingreso () {
        bool UN = false;
        bool PW = false;
        if (username != "") {
            if (username == "new01") {
                UN == true;
            } else {
                Debug.LogWarning("Usuario invalido");
            }
        } else {
            Debug.LogWarning("Campo requerido");
        }
        if (password != "") {
            if (password == "lololololo") {
                PW = true;
            } else {
                Debug.LogWarning("Contrasena invalida");
            }
        } else {
            Debug.LogWarning("Compo requido");
        }
        if (UN == true && PW == true)
        {
            print("Ingreso satisfactorio");
            username.GetComponent<InputField>().text = "";
            password.GetComponent<InputField>().text = "";
        }
    }
    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.Tab)) {
            if (username.GetComponent<InputField>().isFocused) {
                password.GetComponent<InputField>().Select();
            }
        }
        if (Input.GetKeyDown (KeyCode.Return)) {
            if (Password != "" && Password != "") {
                Ingreso();
            }
        }
    }
}