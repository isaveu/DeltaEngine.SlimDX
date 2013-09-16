﻿namespace CreepyTowers.Simple2D
{
	public class CalculateDamage2D
	{
		public float CalculateResistanceBasedOnStates(Tower.TowerType damageType, Creep2D creep)
		{
			var resistance = CheckResistanceBaseOnStateAndElementType(damageType, creep);
			return resistance;
		}

		private static float CheckResistanceBaseOnStateAndElementType(Tower.TowerType damageType,
			Creep2D creep)
		{
			if (creep.state.GetVulnerability(damageType) == CreepState.VulnerabilityType.Weak)
				return 2;
			if (creep.state.GetVulnerability(damageType) == CreepState.VulnerabilityType.Resistant)
				return 0.5f;
			if (creep.state.GetVulnerability(damageType) == CreepState.VulnerabilityType.HardBoiled)
				return 0.25f;
			if (creep.state.GetVulnerability(damageType) == CreepState.VulnerabilityType.Immune)
				return 0.1f;
			if (creep.state.GetVulnerability(damageType) == CreepState.VulnerabilityType.Vulnerable)
				return 3;
			return 1;
		}
	}
}