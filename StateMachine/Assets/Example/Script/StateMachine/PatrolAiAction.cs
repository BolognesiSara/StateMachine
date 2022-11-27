using UnityEngine;
using Random = UnityEngine.Random;

	[CreateAssetMenu(menuName = "Pluggable AI/Actions/Patrol")]
	public class PatrolAiAction : Action
	{
		// No, perchè altrimenti è condivisa con tutti gli enemy
		// private Vector3 direction = Vector3.right;
		public float timeBeforeDirectionChange = 5f;

		public override void Act(StateController controller)
		{
			var enemyController = controller as EnemyStateController;
			if (enemyController == null)
				return;
			
			if (enemyController.currentStateTime / timeBeforeDirectionChange > enemyController.directionChangeCounter)
			{
				enemyController.direction = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
				enemyController.directionChangeCounter++;
			}

			controller.transform.position += enemyController.direction * Time.deltaTime * enemyController.speedMultiplier;

			Debug.DrawRay(controller.transform.position, enemyController.direction);
		}
	}
