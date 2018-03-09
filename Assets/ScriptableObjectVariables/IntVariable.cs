using UnityEngine;

namespace ScriptableObjectVariables
{
    [CreateAssetMenu(menuName = "Scriptable Object Variables/Int Variable")]
    public class IntVariable : ScriptableObjectVariable<int>
    {
		public override bool ApplyChange(int amount)
        {
            if (!base.ApplyChange(amount)) return false;
            Value += amount;
            return true;
        }

        public override bool ApplyChange(ScriptableObjectVariable<int> amount)
        {
            if (!base.ApplyChange(amount)) return false;
            Value += amount.Value;
            return true;
        }
    }
}