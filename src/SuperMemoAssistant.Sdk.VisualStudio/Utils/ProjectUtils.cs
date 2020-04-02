using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperMemoAssistant.Sdk.VisualStudio.Models;

namespace SuperMemoAssistant.Sdk.VisualStudio.Utils
{
  public static class ProjectUtils
  {
    public static void InstallTemplate(this SMAProjectInstall proj)
    {

    }
    
    public static void DeleteOriginalFolder(this SMAProjectInstall proj)
    {
      void DoDeleteOriginalFolder(SMAProjectInstall proj)
      {

      }
    }
    
    public static string GetPluginName(string projectName)
    {
      var idx = projectName.LastIndexOf('.') + 1;

      return idx < projectName.Length && idx > 0
        ? projectName.Substring(idx)
        : projectName;
    }

    public static string EnforcePluginName(string name)
    {
      if (name.StartsWith("SuperMemoAssistant.Plugins.") == false)
        name = "SuperMemoAssistant.Plugins." + name;

      return name;
    }
  }
}
