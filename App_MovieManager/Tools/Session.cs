using App_MovieManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_MovieManager.Tools
{
    public static class Session
    {
        public static Utilisateur CurrentUser { get; set; }
    }
}
