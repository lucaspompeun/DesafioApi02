using DesafioApi02.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioApi02.Service
{
    public static class ShowMeTheCodeService
    {
        static ShowMeTheCode UrlsGithub { get; set; }

        static ShowMeTheCodeService()
        {
            UrlsGithub = new ShowMeTheCode
            {
                UrlDesafio01 = "https://github.com/lucaspompeun/DesafioApi01",
                UrlDesafio02 = "https://github.com/lucaspompeun/DesafioApi02"
            };
        }

        public static ShowMeTheCode GetUrlsGithub()
        {
            return UrlsGithub;
        }
    }
}
