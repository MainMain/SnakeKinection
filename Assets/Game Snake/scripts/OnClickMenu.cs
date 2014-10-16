using UnityEngine;
using System.Collections;

// Clic sur un bouton du menu
public class OnClickMenu : MonoBehaviour {

	TextMesh[] texts;
	public AudioClip sound;

	//Define Enum
	public enum MenuOptions {Jouer, Options, Appliquer, Quitter};
	//This is what you need to show in the inspector.
	public MenuOptions OptionMenuSelected;


	void Start(){
		texts = GetComponentsInChildren<TextMesh>();
	}
	
	void OnMouseEnter(){
		foreach (TextMesh child in texts)
		{
			child.color = Color.red;
		}
	}
	
	void OnMouseExit(){
		foreach (TextMesh child in texts)
		{
			child.color = Color.white;
		}
	}
	
	void OnMouseDown() {
		if (OptionMenuSelected.Equals(MenuOptions.Jouer))
		{
			Application.LoadLevel("snakescene"); 
		}
		if (OptionMenuSelected.Equals(MenuOptions.Options))
		{
			Application.LoadLevel("OptionSnake"); 
		}
		if (OptionMenuSelected.Equals(MenuOptions.Appliquer))
		{
			Application.LoadLevel("MenuSnake"); 
		}
		if (OptionMenuSelected.Equals(MenuOptions.Quitter))
		{
			Application.LoadLevel(0); 
		}
		AudioSource.PlayClipAtPoint(sound, transform.position);
	}
}
