using WIS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace WIS.Tests
{
    
    
    /// <summary>
    ///Classe de test pour MvcApplicationTest, destinée à contenir tous
    ///les tests unitaires MvcApplicationTest
    ///</summary>
    [TestClass()]
    public class MvcApplicationTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
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

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test pour Constructeur MvcApplication
        ///</summary>
        // TODO: vérifiez que l'attribut UrlToTest spécifie une URL vers une page ASP.NET (par exemple,
        // http://.../Default.aspx). Cela est nécessaire pour que le test unitaire soit exécuté sur le serveur Web,
        // que vous testiez une page, un service Web ou un service WCF.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gi\\Documents\\GitHub\\WIS\\WIS", "/")]
        [UrlToTest("http://localhost:12400/")]
        public void MvcApplicationConstructorTest()
        {
            MvcApplication target = new MvcApplication();
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Application_Start
        ///</summary>
        // TODO: vérifiez que l'attribut UrlToTest spécifie une URL vers une page ASP.NET (par exemple,
        // http://.../Default.aspx). Cela est nécessaire pour que le test unitaire soit exécuté sur le serveur Web,
        // que vous testiez une page, un service Web ou un service WCF.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gi\\Documents\\GitHub\\WIS\\WIS", "/")]
        [UrlToTest("http://localhost:12400/")]
        [DeploymentItem("WIS.dll")]
        public void Application_StartTest()
        {
            MvcApplication_Accessor target = new MvcApplication_Accessor(); // TODO: initialisez à une valeur appropriée
            target.Application_Start();
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour Constructeur MvcApplication
        ///</summary>
        // TODO: vérifiez que l'attribut UrlToTest spécifie une URL vers une page ASP.NET (par exemple,
        // http://.../Default.aspx). Cela est nécessaire pour que le test unitaire soit exécuté sur le serveur Web,
        // que vous testiez une page, un service Web ou un service WCF.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gi\\Documents\\GitHub\\WIS\\WIS", "/")]
        [UrlToTest("http://localhost:12400/")]
        public void MvcApplicationConstructorTest1()
        {
            MvcApplication target = new MvcApplication();
            Assert.Inconclusive("TODO: implémentez le code pour vérifier la cible");
        }

        /// <summary>
        ///Test pour Application_Start
        ///</summary>
        // TODO: vérifiez que l'attribut UrlToTest spécifie une URL vers une page ASP.NET (par exemple,
        // http://.../Default.aspx). Cela est nécessaire pour que le test unitaire soit exécuté sur le serveur Web,
        // que vous testiez une page, un service Web ou un service WCF.
        [TestMethod()]
        [HostType("ASP.NET")]
        [AspNetDevelopmentServerHost("C:\\Users\\Gi\\Documents\\GitHub\\WIS\\WIS", "/")]
        [UrlToTest("http://localhost:12400/")]
        [DeploymentItem("WIS.dll")]
        public void Application_StartTest1()
        {
            MvcApplication_Accessor target = new MvcApplication_Accessor(); // TODO: initialisez à une valeur appropriée
            target.Application_Start();
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }
    }
}
