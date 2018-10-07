﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misil : MonoBehaviour {

    public float speed; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Movimiento hacia adelante
        this.transform.Translate(Vector3.forward * speed);

    }// Fin update

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colision dectectada");

        //Buscamos un gameobject llamado Enemy
        GameObject enemy = collision.collider.gameObject;

        //Eliminamos el gameobject encontrado
        GameObject.Destroy(enemy);

        //Eliminamos tambin el misil
        GameObject missile = this.gameObject;
        GameObject.Destroy(missile);
    }
}
