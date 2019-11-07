using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inicio : MonoBehaviour {
    public GameObject username;
    public GameObject password;
    private string Username;
    private string Password;
    public bool UN = false;
    public bool PW = false;

    //Funcion validar el ingreso de cuenta
    public void Ingreso () {
        Username = username.GetComponent<InputField>().text;
        Password = password.GetComponent<InputField>().text;
        if (Username != "") {
            if (Username == "new01") {
                UN = true;
            } else {
                Debug.LogWarning("Usuario invalido");
            }
        } else {
            Debug.LogWarning("Campo requerido");
        }
        if (Password != "") {
            if (Password == "lololololo") {
                PW = true;
            } else {
                Debug.LogWarning("Contrasena invalida");
            }
        } else {
            Debug.LogWarning("Campo requido");
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