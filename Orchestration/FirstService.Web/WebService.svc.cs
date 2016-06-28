using FirstService.Web.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace FirstService.Web
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class WebService
    {
        [OperationContract]
        public List<Eleve> GetEtudiants()
        {
            return new List<Eleve>()
                {
                    new Eleve() {Nom = "Elève 1", Academie="Académie 1"},
                    new Eleve() {Nom = "Elève 2", Academie="Académie 1"},
                    new Eleve() {Nom = "Elève 3", Academie="Académie 1"}
                };
        }
    }
}
