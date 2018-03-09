using UnityEngine;

namespace ScriptableObjectVariables
{
    [CreateAssetMenu(menuName = "Scriptable Object Variables/Float Variable")]
    public class FloatVariable : ScriptableObjectVariable<float>
    {
        public override bool ApplyChange(float amount)
        {
            if (!base.ApplyChange(amount)) return false;
            Value += amount;
            return true;
        }

        public override bool ApplyChange(ScriptableObjectVariable<float> amount)
        {
            if (!base.ApplyChange(amount)) return false;
            Value += amount.Value;
            return true;
        }
    }
}