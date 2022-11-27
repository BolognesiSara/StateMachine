using UnityEngine;

	[CreateAssetMenu(menuName = "Pluggable AI/Decisions/In Range")]
	public class InRangeDecision : Decision
	{
		[SerializeField] private float range = 1;
		[SerializeField] private bool inRangeDebug;
		public override bool Decide(StateController controller)
		{
			if (inRangeDebug) {
				return true;
			}
			var enemyController = controller as EnemyStateController;
			if (enemyController == null)
				return false;

			if (enemyController.target==null) {
			Debug.Log("Errrrooooor");
				return false;
			}
			
			var targetDistance = (enemyController.target.transform.position - enemyController.transform.position).magnitude;
			return targetDistance < range;
		}
	}

