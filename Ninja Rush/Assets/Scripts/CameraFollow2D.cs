using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow2D : MonoBehaviour {

	public float boundsTop=0.0f;
	public float boundsBottom=0.0f;
	public float boundsLeft=0.0f;
	public float boundsRight=0.0f;

	public Vector2 movementFromBase = new Vector2 (0.0f, 0.0f);
	public Vector2 baseLocation = new Vector2 (0.0f, 0.0f);

	public float layerSpeed;
	public GameObject layer;


	private Transform target;
	// Use this for initialization
	void Start () {

		target = GameObject.FindWithTag("Player").transform;
		baseLocation = new Vector2 (transform.position.x,transform.position.y);

	}
	
	// Update is called once per frame
	void Update () {
		transform.position=new Vector3(Mathf.Clamp(target.position.x,boundsLeft,boundsRight),Mathf.Clamp(target.position.y,boundsBottom,boundsTop),transform.position.z);
		movementFromBase = new Vector2 (transform.position.x-baseLocation.x,transform.position.x-baseLocation.y);

		if (layer) {

			var material = layer.GetComponent<Renderer> ().material;
			material.SetTextureOffset ("_MainTex", new Vector2 ((movementFromBase.x * 0.015f) * layerSpeed, 0.0f));
		}

	
	}
}
