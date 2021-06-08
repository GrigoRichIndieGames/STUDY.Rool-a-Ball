using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    public class GoodBonusTest :
        InteractiveObjectTest
    {
        public override string DisplaySecondWay() => $"I am a {nameof(GoodBonusTest)} class method";
        public new string DisplayThirdWay() => $"I am a {nameof(GoodBonusTest)} class method";
    }
}
