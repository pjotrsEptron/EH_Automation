using EveryHairTestsScripts;
using System;
using TechTalk.SpecFlow;
using EveryHairTestScripts.pages;

namespace EveryHairTestScripts
{
    [Binding]
    public class DeleteFeatureNo
    {
        deleteFeaturesNo cancelDeleteFeature = new deleteFeaturesNo();
        [Then(@"i can cancel delete action")]
        public void ThenICanCancelDeleteAction()
        {

            cancelDeleteFeature.pressDeleteFeature();
            cancelDeleteFeature.pressNoButtonInFeatures();
        }
    }
}