using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Pluggable AI/Actions/PlayerAction")]
public class PlayerAction : Action {

	[SerializeField] private float speed = 2f;
	private Vector3 touchPosition = new Vector3(100,0,100);
	private bool touch = true;

	public override void Act(StateController controller) {
		//touch = Input.GetMouseButton(0);
		if (touch) {
			Debug.Log("HEI1");
			touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			touchPosition.x = Input.mousePosition.x;
			touchPosition.z = Input.mousePosition.y;
			touchPosition.y = 0f;
			Vector3 direction = (touchPosition - controller.transform.position).normalized;
			controller.transform.position += direction * (speed * Time.deltaTime);
			return;
		}
		if (Vector3.Distance(controller.transform.position, touchPosition) < 0.5) {
			Debug.Log("HEI123");
			touch = false;
			return;
		}
		
		touchPosition = controller.transform.position;
	}
}