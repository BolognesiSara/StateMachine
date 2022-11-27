using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

	[CreateAssetMenu(menuName = "Pluggable AI/Decisions/Out of Range")]
	public class OutOfRangeDecision : Decision
	{
		[SerializeField] private float range = 1;

		public override bool Decide(StateController controller)
		{
			var enemyController = controller as EnemyStateController;
			if (enemyController == null)
				return false;

			var targetDistance = (enemyController.target.transform.position - enemyController.transform.position).magnitude;

			return targetDistance > range;
		}
	}