using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour {
	public int StartingHealth = 100;
	public int StartingMana = 100;

	public int CurrentHealth;
	public int CurrentMana;

	public Slider healthSlider;
	public Image damageImage;

	public Slider manaSlider;
	public AudioClip deathClip;

	public float flashSpeed = 5f;
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
