using UnityEngine;


namespace STUDY_Roll_a_Ball
{
    public class Test :
        MonoBehaviour
    {
        //[SerializeField] private float _speed = 3.0f;

        private void Start()
        {
            //PlayerTest player = new PlayerBallTest(_speed);

            /*
            InteractiveObjectTest interactiveObjectTest = new InteractiveObjectTest();
            print(interactiveObjectTest.DisplayFirstWay());
            print(interactiveObjectTest.DisplaySecondWay());
            print(interactiveObjectTest.DisplayThirdWay());

            print("+++++++++++++++++++++++++++++++++++++");

            InteractiveObjectTest interactiveObjectTest1 = new GoodBonusTest();
            print(interactiveObjectTest1.DisplayFirstWay());
            print(interactiveObjectTest1.DisplaySecondWay());
            print(interactiveObjectTest1.DisplayThirdWay());

            print("+++++++++++++++++++++++++++++++++++++");

            GoodBonusTest interactiveObjectTest2 = new GoodBonusTest();
            print(interactiveObjectTest2.DisplayFirstWay());
            print(interactiveObjectTest2.DisplaySecondWay());
            print(interactiveObjectTest2.DisplayThirdWay());
            */

            InteractiveObjectTest interactiveObjectTest = new GoodBonusTest();
            print(interactiveObjectTest is GoodBonusTest);
        }
    }
}
