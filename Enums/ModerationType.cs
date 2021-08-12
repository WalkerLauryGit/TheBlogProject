using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TheBlogProject.Enums
{
    public enum ModerationType
    {
        [Description("Political Progaganda")]
        Political,
        [Description("Racism is bad")]
        Racism,
        [Description("Mean or threatening")]
        Bullying,
        [Description("Bad Language")]
        Language,
        [Description("Not for all audiences")]
        Inappropriate,
        [Description("Targeted harrasment")]
        Threatening
    }
}
