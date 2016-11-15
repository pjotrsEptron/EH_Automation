using EveryHairTestsScripts;
using System;
using TechTalk.SpecFlow;
using EveryHairTestScripts.pages;

namespace EveryHairTestScripts
{
    [Binding]
    public class DeleteFeatureYes
    {
        deleteFeaturesYes deleteAction = new deleteFeaturesYes();

        [Then(@"i can delete feature")]
        public void ThenICanDeleteFeature()
        {

            deleteAction.pressDeleteFeatureAgain();
            deleteAction.pressYesButtonInFeatures();
        }

        [Then(@"check deleted feature")]
        public void ThenCheckDeletedFeature()
        {

            deleteAction.checkFeatureIsDeleted();
        }
    }
}