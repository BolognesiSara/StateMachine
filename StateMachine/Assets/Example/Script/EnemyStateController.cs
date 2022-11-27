using UnityEngine;
using UnityEngine.AI;

public enum PlayerState{
	player,
	enemy
}
	public class EnemyStateController : StateController
	{
		//Rinominare in EntityStateController
		[SerializeField] private float life = 100;
		[SerializeField] private Material playerMaterial;
		[SerializeField] private Material enemyMaterial;
		//[SerializeField] private PlayerState myState;
		private MeshRenderer mesh;
		//private NavMeshAgent agent;
		
		
		public EnemyStateController target;
		public float speedMultiplier = 2;
		public float dodgeSpeedMultiplier = 3;

		public Vector3 direction;
		public int directionChangeCounter;
		
		public void Start()
		{
			//target = GameManager.Instance.Player;
			if (!target) {
				Debug.Log("Missing Target");
			}
			
			}

	

		public void GetDamage(float damage) {
			life -= damage;
		}
		

		public void Pushed(float distance, GameObject enemy) {
			Vector3 dist = (transform.position-enemy.transform.position).normalized;
			transform.position += dist*Mathf.Sqrt(distance);
		}

	}
