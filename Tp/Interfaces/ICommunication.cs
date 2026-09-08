using System;
using System.Collections.Generic;
using System.Text;

namespace Modeles.Interfaces
{
    public interface ICommunication
    {
        public string Communiquer(string message = "Template de base");
    }
}
