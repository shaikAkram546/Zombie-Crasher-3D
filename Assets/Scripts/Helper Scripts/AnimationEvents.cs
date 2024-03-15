using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationEvents : MonoBehaviour {

	private PlayerController playerController;
	private Animator anim;
    [SerializeField]
    private GameObject Congrates_Panel;


    void Start () {
		playerController = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ();
		anim = GetComponent<Animator> ();
	}
	
	public void ResetShooting() {
		playerController.canShoot = true;
		anim.Play ("Idle");
	}

	void CameraStartGame() {
		SceneManager.LoadScene ("Gameplay");
	}
    public void CongratesDisable()
    {
        Congrates_Panel.SetActive(false);
    }

} // class



































