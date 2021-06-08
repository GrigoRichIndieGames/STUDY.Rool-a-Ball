using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    public sealed class PCUserInput :
        BaseUserInput
    {
        private readonly string _horizontalAxisName;
        private readonly string _verticalAxisName;

        public PCUserInput(string horizontalAxisName, string verticalAxisName)
        {
            _horizontalAxisName = horizontalAxisName;
            _verticalAxisName = verticalAxisName;
        }

        public override float GetHorizontalAxis() => Input.GetAxis(_horizontalAxisName);
        public override float GetVerticalAxis() => Input.GetAxis(_verticalAxisName);
    }
}
