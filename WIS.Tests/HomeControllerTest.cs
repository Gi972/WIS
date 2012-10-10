using WIS.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.Mvc;

namespace WIS.Tests
{


    /// <summary>
    ///Classe de test pour HomeControllerTest, destinée à contenir tous
    ///les tests unitaires HomeControllerTest
    ///</summary>
    [TestClass()]
    public class HomeControllerTest
    {


        //private TestContext testContextInstance;

        ///// <summary>
        /////Obtient ou définit le contexte de test qui fournit
        /////des informations sur la série de tests active ainsi que ses fonctionnalités.
        /////</summary>
        //public TestContext TestContext
        //{
        //    get
        //    {
        //        return testContextInstance;
        //    }
        //    set
        //    {
        //        testContextInstance = value;
        //    }
        //}

        //#region Attributs de tests supplémentaires
        //// 
        ////Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        ////
        ////Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        ////[ClassInitialize()]
        ////public static void MyClassInitialize(TestContext testContext)
        ////{
        ////}
        ////
        ////Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        ////[ClassCleanup()]
        ////public static void MyClassCleanup()
        ////{
        ////}
        ////
        ////Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        ////[TestInitialize()]
        ////public void MyTestInitialize()
        ////{
        ////}
        ////
        ////Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        ////[TestCleanup()]
        ////public void MyTestCleanup()
        ////{
        ////}
        ////
        //#endregion


        ///// <summary>
        /////Test pour Constructeur HomeController
        /////</summary>
        //// TODO: vérifiez que l'attribut UrlToTest spécifie une URL vers une page ASP.NET (par exemple,
        //// http://.../Default.aspx). Cela est nécessaire pour que le test unitaire soit exécuté sur le serveur Web,
        //// que vous testiez une page, un service Web ou un service WCF.
        //[TestMethod()]
        //[HostType("ASP.NET")]
        //[AspNetDevelopmentServerHost("C:\\Users\\Gi\\Documents\\GitHub\\WIS\\WIS", "/")]
        //[UrlToTest("http://localhost:12400/")]
        //public void HomeControllerConstructorTest()
        //{
        //    HomeController target = new HomeController();
        //    Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        //}

        ///// <summary>
        /////Test pour Index
        /////</summary>
        //// TODO: vérifiez que l'attribut UrlToTest spécifie une URL vers une page ASP.NET (par exemple,
        //// http://.../Default.aspx). Cela est nécessaire pour que le test unitaire soit exécuté sur le serveur Web,
        //// que vous testiez une page, un service Web ou un service WCF.
        //[TestMethod()]
        //[HostType("ASP.NET")]
        //[AspNetDevelopmentServerHost("C:\\Users\\Gi\\Documents\\GitHub\\WIS\\WIS", "/")]
        //[UrlToTest("http://localhost:12400/")]
        //public void IndexTest()
        //{
        //    HomeController target = new HomeController(); // TODO: initialisez à une valeur appropriée
        //    ActionResult expected = null; // TODO: initialisez à une valeur appropriée
        //    ActionResult actual;
        //    actual = target.Index();
        //    Assert.AreEqual(expected, actual);
        //    Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        //}


        //TODO A verifier aprés si pertinent de garder et comment utiliser les données



        [TestMethod]
        public void Default_Action_Returns_Index_View()
        {
            // Arrange
            const string expectedViewName = "Index";
            var homeController = new HomeController();

            // Act
            var result = homeController.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result, "Should have returned a ViewResult");
            Assert.AreEqual(expectedViewName, result.ViewName, "View name should have been {0}", expectedViewName);
        }

        [TestMethod]
        public void affiche_view_bag()
        {
            const string expectedViewBag = "Accueil";
            var homeController = new HomeController();

            var result = homeController.Index() as ViewResult;

            Assert.IsNotNull(result.ViewBag.Page, "Cela devrait retourner un message dans le viewbag");
            Assert.AreEqual(expectedViewBag, result.ViewBag.Page, "Viewbag devrait retourner {0}", expectedViewBag);
        }







    }
}
