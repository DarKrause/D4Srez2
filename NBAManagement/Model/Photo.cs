using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBAManagement.Model
{
   
    
        partial class Team
        {
            public string DisplayedImage
            {
                get
                {
                    return Directory.GetCurrentDirectory() + $"/Teams/{Logo}";
                }
            }
        }
    }

