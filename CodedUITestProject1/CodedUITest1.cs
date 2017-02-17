using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
using Microsoft.VisualStudio.TestTools.UITesting.DirectUIControls;
using Microsoft.VisualStudio.TestTools.UITesting.WindowsRuntimeControls;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CodedUITestProject1
{
    /// <summary>
    /// CodedUITest1의 요약 설명
    /// </summary>
    [CodedUITest(CodedUITestType.WindowsStore)]
    public class CodedUITest1
    {
        public CodedUITest1()
        {

        }

        public string AddCalc(int a, int b)
        {
            return (a + b).ToString() ;
        }

        [TestMethod]
        public void CodedUITestMethod1()
        {
            string strTemp = string.Empty;

            strTemp = AddCalc(10, 10);
            

            // 이 테스트의 코드를 생성하려면 바로 가기 메뉴에서 "코딩된 UI 테스트에 대한 코드 생성"을 선택한 다음 메뉴 항목 중 하나를 선택하십시오.
        }

        #region 추가 테스트 특성

        // 테스트를 작성할 때 다음 추가 특성을 사용할 수 있습니다.

        ////TestInitialize를 사용하여 각 테스트를 실행하기 전에 코드를 실행합니다. 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{

        //    // 이 테스트의 코드를 생성하려면 바로 가기 메뉴에서 "코딩된 UI 테스트에 대한 코드 생성"을 선택한 다음 메뉴 항목 중 하나를 선택하십시오.
        //}

        ////TestCleanup을 사용하여 각 테스트를 실행한 후에 코드를 실행합니다.
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{

        //    // 이 테스트의 코드를 생성하려면 바로 가기 메뉴에서 "코딩된 UI 테스트에 대한 코드 생성"을 선택한 다음 메뉴 항목 중 하나를 선택하십시오.
        //}

        #endregion

        /// <summary>
        ///현재 테스트 실행에 대한 정보 및 기능을
        ///제공하는 테스트 컨텍스트를 가져오거나 설정합니다.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;
    }
}
