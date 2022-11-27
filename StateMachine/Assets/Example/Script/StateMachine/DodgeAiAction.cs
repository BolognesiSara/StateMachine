using UnityEngine;

	[CreateAssetMenu(menuName = "Pluggable AI/Actions/Dodge")]
	public class DodgeAiAction : Action
	{
		public override void Act(StateController controller)
		{
			var enemyController = controller as EnemyStateController;
			if (enemyController == null)
				return;
			int i = 0;
			DoAction(enemyController);
			Foo(ref i);
		}

		public void Foo(ref int i)
		{

		}

		private void DoAction(EnemyStateController controller)
		{
			var targetPosition = controller.target.transform.position;
			var myPosition = controller.transform.position;

			var direction = -(myPosition - targetPosition).normalized;

			controller.transform.position += direction * controller.dodgeSpeedMultiplier * Time.deltaTime;

			Debug.DrawRay(controller.transform.position, direction, Color.red);
		}
	}
