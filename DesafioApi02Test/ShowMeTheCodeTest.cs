using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesafioApi02.Service;
using DesafioApi02.Model;

namespace DesafioApi02Test
{
    [TestClass]
    class ShowMeTheCodeTest
    {
        public string UrlDesafio01 { get; set; }
        public string UrlDesafio02 { get; set; }
        public ShowMeTheCode UrlsGitHub { get; set; }

        public ShowMeTheCodeTest()
        {
            UrlDesafio01 = "https://github.com/lucaspompeun/DesafioApi01";
            UrlDesafio02 = "https://github.com/lucaspompeun/DesafioApi02";

            UrlsGitHub = new ShowMeTheCode
            {
                UrlDesafio01 = this.UrlDesafio01,
                UrlDesafio02 = this.UrlDesafio02
            };
        }

        [TestMethod]
        public void IntegridadeUrl01()
        {
            var actual = ShowMeTheCodeService.GetUrlsGithub();
            var expected = UrlDesafio01;


            Assert.AreEqual(expected, actual.UrlDesafio01);
        }

        [TestMethod]
        public void IntegridadeUrl02()
        {
            var actual = ShowMeTheCodeService.GetUrlsGithub();
            var expected = UrlDesafio02;


            Assert.AreEqual(expected, actual.UrlDesafio02);
        }
    }
}
